// DesignerForm.cs
// Assignment 2 that is a Q-Puzzle game.
// Revision History: $Kin Furigay, 2023.10.03: Created.
// $Kin Furigay, 2023.10.05: Edited.-- >

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
using static System.Windows.Forms.LinkLabel;

namespace KFurigayQGame
{
    public partial class DesignerForm : Form
    {
        private ToolPictureBox[,] gridPictureBoxes;
        private int selectedTool = 0;

        public DesignerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the 'Save' menu item click.
        /// Saves the current state of the maze to a file.
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] maze = GetMaze(); // Retrieves the current maze configuration.

            int walls = 0, doors = 0, boxes = 0;

            StringBuilder sb = new StringBuilder();

            int numRows = maze.GetLength(0);
            int numCols = maze.GetLength(1);

            sb.AppendLine(numRows.ToString()); // Number of rows
            sb.AppendLine(numCols.ToString()); // Number of columns

            // Iterates through the maze and appends each element to the StringBuilder. Also counts walls, doors, and boxes.
            // NOTE: I didn't follow the format in the hints. The displayed output shows the number of rows, columns and just the cell's content from left to right starting on top.
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    sb.AppendLine(maze[i, j].ToString());

                    switch (maze[i, j])
                    {
                        case 1:
                            walls++;
                            break;
                        case 2: // red door
                        case 3: // green door
                            doors++; // Red and Green Doors are added together for the MessageBox value.
                            break;
                        case 4: // red box
                        case 5: // green box
                            boxes++; // Red and Green Boxes are added together for the MessageBox value.
                            break;
                    }
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "QGame Files (*.qgame)|*.qgame|All files (*.*)|*.*"; // Save as type filter
            saveFileDialog.FileName = GetDefaultFileName(); // Retrieves a default filename for the save file.

            // If the user clicks 'Save' in the dialog, writes the contents to the file and displays a message.
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, sb.ToString());
                MessageBox.Show($"File saved successfully:\nTotal number of walls: {walls}\nTotal number of doors: {doors}\nTotal number of boxes: {boxes}");
            }
        }

        /// <summary>
        /// Retrieves the current maze configuration from the gridPictureBoxes.
        /// </summary>
        /// <returns>A two-dimensional array representing the maze.</returns>
        private int[,] GetMaze()
        {
            // Returns an empty maze if gridPictureBoxes is not initialized.
            if (gridPictureBoxes == null)
            {
                return new int[0, 0];
            }

            int rows = gridPictureBoxes.GetLength(0);
            int cols = gridPictureBoxes.GetLength(1);
            int[,] maze = new int[rows, cols];

            // Copies the ToolValue from each ToolPictureBox to the maze array.
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    maze[row, col] = gridPictureBoxes[row, col].ToolValue;
                }
            }

            return maze;
        }

        /// <summary>
        /// Generates a default filename for saving the maze.
        /// Ensures that the filename is unique by incrementing an index.
        /// </summary>
        /// <returns>A unique filename for the save file.</returns>
        private string GetDefaultFileName()
        {
            int index = 1;
            // Loops until a non-existing filename is found.
            while (File.Exists($"savegame{index}.qgame"))
            {
                index++;
            }
            return $"savegame{index}.qgame";
        }

        /// <summary>
        /// Event handler for the 'Close' menu item click.
        /// Closes the application form.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler for the 'Generate' button click.
        /// Generates a new grid for the puzzle based on user input for rows and columns.
        /// </summary>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Asks user to confirm if they want to create a new grid if the current one has content.
            if (gridPictureBoxes != null && GridHasContent())
            {
                DialogResult result = MessageBox.Show("Do you want to create a new level? If you do, the current level will be lost", "QGame", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return; // Exits if the user selects 'No'.
                }
            }

            int rows, cols;
            // Parses the user input for rows and columns and generates the grid.
            if (int.TryParse(txtRows.Text, out rows) && int.TryParse(txtColumns.Text, out cols))
            {
                if (rows > 0 && cols > 0)
                {
                    GenerateGrid(rows, cols); // Calls the method to create the grid.
                }
                else
                {
                    // Show error message if numbers are not positive
                    MessageBox.Show("Please provide valid data for rows and columns (Both must be integers) Number of rows must be positive", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show error message if input is not in the correct format
                MessageBox.Show("Please provide valid data for rows and columns (Both must be positive integers) Input string was not in a correct format", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Checks if the current grid has any content.
        /// </summary>
        /// /// <returns>A boolean indicating whether any cell in the grid has been modified.</returns>
        private bool GridHasContent()
        {
            // Iterates over the grid to check if any cell has a non-zero value.
            for (int row = 0; row < gridPictureBoxes.GetLength(0); row++)
            {
                for (int col = 0; col < gridPictureBoxes.GetLength(1); col++)
                {
                    if (gridPictureBoxes[row, col].ToolValue != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Creates a new grid of ToolPictureBoxes with the specified dimensions.
        /// </summary>
        /// NOTE: The grid can only contain a maximum of 8x8 tiles as the panel and designer can only fit that much. 
        private void GenerateGrid(int rows, int cols)
        {
            ClearGrid(); // Clears the existing grid if any.

            gridPictureBoxes = new ToolPictureBox[rows, cols];
            int pictureBoxSize = 60; // Declares the size of the pictureBoxes

            // Prepares the gridPanel for new controls.
            gridPanel.Controls.Clear();
            gridPanel.SuspendLayout();

            // Creates and configures new ToolPictureBoxes for the grid.
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    ToolPictureBox pictureBox = new ToolPictureBox();
                    pictureBox.Height = pictureBoxSize;
                    pictureBox.Width = pictureBoxSize;
                    pictureBox.Click += GridPictureBox_Click; // Attaches click event handler.
                    pictureBox.Location = new Point(col * pictureBoxSize, row * pictureBoxSize);
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.ToolValue = 0; // Default tool value
                    gridPictureBoxes[row, col] = pictureBox;
                    gridPanel.Controls.Add(pictureBox);
                }
            }

            gridPanel.ResumeLayout(); // Resumes layout logic.
        }

        /// <summary>
        /// Clears the existing grid, removing all controls.
        /// </summary>
        private void ClearGrid()
        {
            // Iterates through the grid and removes each ToolPictureBox from the panel.
            if (gridPictureBoxes != null)
                if (gridPictureBoxes != null)
            {
                for (int row = 0; row < gridPictureBoxes.GetLength(0); row++)
                {
                    for (int col = 0; col < gridPictureBoxes.GetLength(1); col++)
                    {
                        gridPanel.Controls.Remove(gridPictureBoxes[row, col]);
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for the click event of any ToolPictureBox in the grid.
        /// Sets the selected tool image and value to the clicked ToolPictureBox.
        /// </summary>
        private void GridPictureBox_Click(object sender, EventArgs e)
        {
            // Casts sender to ToolPictureBox and applies the selected tool's settings.
            ToolPictureBox clickedPictureBox = sender as ToolPictureBox;
            if (clickedPictureBox != null)
            {
                if (selectedTool == 0)
                {
                    clickedPictureBox.Image = null;
                    clickedPictureBox.ToolValue = 0;
                }
                else
                {
                    clickedPictureBox.Image = GetToolImage(selectedTool);
                    clickedPictureBox.ToolValue = selectedTool;
                }
            }
        }

        /// <summary>
        /// Retrieves the corresponding image for a given tool type.
        /// </summary>
        private Image GetToolImage(int toolType)
        {
            switch (toolType)
            {
                // Returns the image resource based on the tool type.
                case 1: // wall
                    return Properties.Resources.imgWall;
                case 2: // red door
                    return Properties.Resources.imgRedDoor;
                case 3: // green door
                    return Properties.Resources.imgGreenDoor;
                case 4: // red box
                    return Properties.Resources.imgRedBox;
                case 5: // green box
                    return Properties.Resources.imgGreenBox;
                default:
                    return null;
            }
        }


        // Tool selection buttons' event handlers. These methods set the selectedTool variable based on the button clicked.

        // Event handler for the 'None' button. It sets the selected tool to 0.
        private void btnNone_Click(object sender, EventArgs e)
        {
            selectedTool = 0;
        }

        // Event handler for the 'Wall' button. It sets the selected tool to 1.
        private void btnWall_Click(object sender, EventArgs e)
        {
            selectedTool = 1;
        }

        // Event handler for the 'Red Door' button. It sets the selected tool to 2.
        private void btnRedDoor_Click(object sender, EventArgs e)
        {
            selectedTool = 2;
        }

        // Event handler for the 'Green Door' button. It sets the selected tool to 3.
        private void btnGreenDoor_Click(object sender, EventArgs e)
        {
            selectedTool = 3;
        }

        // Event handler for the 'Red Box' button. It sets the selected tool to 4.
        private void btnRedBox_Click(object sender, EventArgs e)
        {
            selectedTool = 4;
        }

        // Event handler for the 'Green Box' button. It sets the selected tool to 5.
        private void btnGreenBox_Click(object sender, EventArgs e)
        {
            selectedTool = 5;
        }
    }

    /// <summary>
    /// A PictureBox derivative that includes a ToolValue property to identify the tool it represents.
    /// </summary>
    public class ToolPictureBox : PictureBox
    {
        /// Gets or sets the tool value which corresponds to the type of tool this picture box represents.
        public int ToolValue { get; set; }
    }
}
