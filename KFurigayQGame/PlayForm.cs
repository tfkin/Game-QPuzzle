// PlayForm.cs
// Assignment 3 that is a Q-Puzzle game update based from Assignment 2.
// Revision History: $Kin Furigay, 2023.11.20: Created.
// $Kin Furigay, 2023.11.21: Edited.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFurigayQGame
{
    public partial class PlayForm : Form
    {
        private Tile[,] gameGrid;
        private Tile selectedTile;
        private int moves, remainingBoxes;
        private const int WALL = 1, RED_DOOR = 2, GREEN_DOOR = 3, RED_BOX = 4, GREEN_BOX = 5;

        public PlayForm()
        {
            InitializeComponent();
            ResetMoveAndBoxCount();
            this.KeyPreview = true; // For the Process CMD Key
        }

        /// <summary>
        /// Opens a dialog to load a game from a file.
        /// </summary>
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "QGame Files (*.qgame)|*.qgame|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadLevel(openFileDialog.FileName);
            }
        }

        /// <summary>
        /// Closes the PlayForm.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Loads the level from the specified file.
        /// </summary>
        /// NOTE: The loop to read the data for the design levels is different from the given qgame file meaning it cannot load the attached qgame file in the attachment because I
        /// aligned the loop based from my DesignerForm. Mine didn't include the column and row positions which would generate a different data structure on the qgame notepad.
        private void LoadLevel(string fileName)
        {
            try
            {
                ResetGame();

                string[] lines = File.ReadAllLines(fileName);
                int numRows = int.Parse(lines[0]);
                int numCols = int.Parse(lines[1]);
                gameGrid = new Tile[numRows, numCols];
                moves = 0;
                remainingBoxes = 0;
                
                // Reading the tile data and creating the grid
                for (int i = 2; i < lines.Length; i++)
                {
                    int tileType = int.Parse(lines[i]);
                    int row = (i - 2) / numCols;
                    int col = (i - 2) % numCols;
                    Tile tile = CreateTile(row, col, tileType);

                    if (tile != null)
                    {
                        gameGrid[row, col] = tile;
                        gridPanel.Controls.Add(tile);

                        // Increment box counter if a box is found
                        if (tileType == RED_BOX || tileType == GREEN_BOX)
                            remainingBoxes++;
                    }
                }
                UpdateMoveAndBoxCount();
                SetControlPadEnabled(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading level: {ex.Message}");
                SetControlPadEnabled(false);
            }
        }

        /// <summary>
        /// Creates a Tile object based on the specified parameters.
        /// </summary>
        /// /// <returns>A Tile object or null if the tileType is 0 (empty).</returns>
        private Tile CreateTile(int row, int col, int tileType)
        {
            if (tileType == 0) return null;

            Tile tile = new Tile
            {
                Row = row,
                Col = col,
                TileType = tileType,
                Size = new Size(60, 60),
                Location = new Point(col * 60, row * 60),
                BorderStyle = BorderStyle.FixedSingle,
                BackgroundImageLayout = ImageLayout.Stretch,
                BackgroundImage = GetTileImage(tileType)
            };
            tile.Click += Tile_Click;
            return tile;
        }

        /// <summary>
        /// Event handler for clicking on a tile.
        /// </summary>
        private void Tile_Click(object sender, EventArgs e)
        {
            if (sender is Tile tile && (tile.TileType == RED_BOX || tile.TileType == GREEN_BOX))
            {
                if (selectedTile != null)
                {
                    selectedTile.BorderStyle = BorderStyle.FixedSingle;
                }
                selectedTile = tile;
                selectedTile.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        // Event handlers for moving the selected tile
        // Event handler for the 'btnUp' button.
        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveSelectedTile(0, -1);
        }

        // Event handler for the 'btnDown' button.
        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveSelectedTile(0, 1);
        }

        // Event handler for the 'btnLeft' button.
        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveSelectedTile(-1, 0);
        }

        // Event handler for the 'btnRight' button.
        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveSelectedTile(1, 0);
        }

        /// <summary>
        /// Attempts to move the selected tile in the specified direction.
        /// </summary>
        private void MoveSelectedTile(int dx, int dy)
        {
            if (selectedTile == null)
            {
                MessageBox.Show("Click to select", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TryMoveTile(selectedTile, dx, dy))
            {
                UpdateMoveAndBoxCount();
                CheckGameCompletion();
            }
        }

        /// <summary>
        /// Tries to move the specified tile by the given deltas in row and column.
        /// </summary>
        private bool TryMoveTile(Tile tile, int dx, int dy)
        {
            int newRow = tile.Row;
            int newCol = tile.Col;

            // Attempt to move the tile until an obstacle is reached
            while (CanMove(newRow + dy, newCol + dx))
            {
                newRow += dy;
                newCol += dx;

                // Check if the tile has reached a matching door
                if (IsMatchingDoorBox(gameGrid[newRow, newCol], tile))
                {
                    RemoveTile(tile);
                    return false;
                }
            }

            // Update the tile position if it has changed
            if (newRow != tile.Row || newCol != tile.Col)
            {
                UpdateTilePosition(tile, newRow, newCol);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determines if the tile can move to the specified row and column.
        /// </summary>
        private bool CanMove(int row, int col)
        {
            return row >= 0 && row < gameGrid.GetLength(0) && col >= 0 && col < gameGrid.GetLength(1) &&
                   (gameGrid[row, col] == null || IsMatchingDoorBox(gameGrid[row, col], selectedTile));
        }

        /// <summary>
        /// Removes the tile from the grid and updates game state accordingly.
        /// </summary>
        private void RemoveTile(Tile tile)
        {
            gridPanel.Controls.Remove(tile);
            gameGrid[tile.Row, tile.Col] = null;
            remainingBoxes--;
            selectedTile = null;
            moves++;
            UpdateMoveAndBoxCount();
            CheckGameCompletion();
        }

        /// <summary>
        /// Updates the position of the tile in the grid and on the screen.
        /// </summary>
        private void UpdateTilePosition(Tile tile, int newRow, int newCol)
        {
            gameGrid[tile.Row, tile.Col] = null;
            gameGrid[newRow, newCol] = tile;
            tile.Location = new Point(newCol * 60, newRow * 60);
            tile.Row = newRow;
            tile.Col = newCol;
            moves++;
        }

        /// <summary>
        /// Determines if a tile is a box that matches the color of a door.
        /// </summary>
        private bool IsMatchingDoorBox(Tile door, Tile box)
        {
            return door != null && ((door.TileType == RED_DOOR && box.TileType == RED_BOX) || (door.TileType == GREEN_DOOR && box.TileType == GREEN_BOX));
        }

        /// <summary>
        /// Checks if the game is complete and executes end-of-game logic.
        /// </summary>
        private void CheckGameCompletion()
        {
            if (remainingBoxes == 0)
            {
                MessageBox.Show($"Congratulations\nGame End", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetGame();
            }
        }

        /// <summary>
        /// Resets the game to a clean state.
        /// </summary>
        private void ResetGame()
        {
            if (gameGrid != null)
            {
                foreach (Tile tile in gameGrid)
                {
                    if (tile != null)
                    {
                        gridPanel.Controls.Remove(tile);
                    }
                }
            }
            gameGrid = null;
            selectedTile = null;
            moves = 0;
            remainingBoxes = 0;
            ResetMoveAndBoxCount();
            SetControlPadEnabled(false);
        }

        /// <summary>
        /// Resets the move and box count displays.
        /// </summary>
        private void ResetMoveAndBoxCount()
        {
            txtMoves.Text = "0";
            txtBoxes.Text = "0";
        }

        /// <summary>
        /// Updates the move and box count displays to reflect the current state.
        /// </summary>
        private void UpdateMoveAndBoxCount()
        {
            txtMoves.Text = moves.ToString();
            txtBoxes.Text = remainingBoxes.ToString();
        }

        /// <summary>
        /// Sets the enabled state of the control pad buttons.
        /// </summary>
        private void SetControlPadEnabled(bool enabled)
        {
            btnUp.Enabled = enabled;
            btnDown.Enabled = enabled;
            btnLeft.Enabled = enabled;
            btnRight.Enabled = enabled;
        }

        /// <summary>
        /// Retrieves the image from the resources with a specific tile type.
        /// </summary>
        private Image GetTileImage(int tileType)
        {
            switch (tileType)
            {
                case WALL:
                    return Properties.Resources.imgWall;
                case RED_DOOR:
                    return Properties.Resources.imgRedDoor;
                case GREEN_DOOR:
                    return Properties.Resources.imgGreenDoor;
                case RED_BOX:
                    return Properties.Resources.imgRedBox;
                case GREEN_BOX:
                    return Properties.Resources.imgGreenBox;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Processes a command on the arrow keys for moving tiles.
        /// </summary>
        /// NOTE: This is not part of the instructions but I had time and thought this was a good implementation for the game.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    btnUp_Click(this, EventArgs.Empty);
                    return true;
                case Keys.Down:
                    btnDown_Click(this, EventArgs.Empty);
                    return true;
                case Keys.Left:
                    btnLeft_Click(this, EventArgs.Empty);
                    return true;
                case Keys.Right:
                    btnRight_Click(this, EventArgs.Empty);
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }

    /// <summary>
    /// Represents a tile in the game grid.
    /// </summary>
    public class Tile : PictureBox
    {
        public int Row { get; set; } // Gets or sets the row of the tile in the game grid.
        public int Col { get; set; } // Gets or sets the column of the tile in the game grid.
        public int TileType { get; set; }  // Gets or sets the type of the tile.
    }
}