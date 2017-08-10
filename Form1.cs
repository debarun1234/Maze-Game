//This code is only used for apps which are meant to be done in C# language.
// Made in Visual Studio 2017 RC.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        // This SoundPlayer plays a sound whenever the player hits a wall.
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");

        // This SoundPlayer plays a sound when the player finishes the game.
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void FinishLabel_MouseEnter(object sender, EventArgs e)
        {
            // Play a sound, show a congratulatory MessageBox, then close the form.
            finishSoundPlayer.Play();
            MessageBox.Show("Congratulations!");
            MoveToStart();
        }

        /// <summary>
        /// Play a sound then move the pointer to a point 10 pixels down and to the right 
        /// of the starting point in the upper-left corner of the maze.
        /// </summary>

        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);

        }

        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer hits a wall or enters the panel,
            // call the MoveToStart() method.
            MoveToStart();
        }

        private void S(object sender, PaintEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to close the Game?");
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello There! Welcome to Maze. This is a very fun game. The instruction is that you have to move the mouse freely through the passsage." +
                " Be Careful if you go near the walls then you have to restart game. Hence All the Best!!");
        }
    }
}
