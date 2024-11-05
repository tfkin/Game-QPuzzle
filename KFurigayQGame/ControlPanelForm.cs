// ControlPanelForm.cs
// Assignment 2 that is a Q-Puzzle game.
// Revision History: $Kin Furigay, 2023.10.03: Created. -- >
// $Kin FUrigay, 2023.10.05: Edited.-- >

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFurigayQGame
{
    public partial class ControlPanelForm : Form
    {
        public ControlPanelForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the 'Design' button click.
        /// Opens the DesignerForm for editing or creating puzzles.
        /// </summary>
        private void btnCtrlDesign_Click(object sender, EventArgs e)
        {
            DesignerForm designerForm = new DesignerForm(); // Creates a new instance of the DesignerForm.
            designerForm.Show(); // Displays the DesignerForm to the user.
        }

        /// <summary>
        /// Event handler for the 'Exit' button click.
        /// Closes the application.
        /// </summary>
        private void btnCtrlExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exit the application
        }

        /// <summary>
        /// Event handler for the 'Play' button click.
        /// Opens the PlayForm for playing the game by loading the created puzzles in the DesignerForm.
        /// </summary>
        private void btnCtrlPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm(); // Creates a new instance of the PlayForm.
            playForm.Show();
        }
    }
}
