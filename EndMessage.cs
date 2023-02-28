using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaQuiz.Properties;

namespace TriviaQuiz
{
    public partial class EndMessage : Form
    {
        public int Points { get; set; }
        public EndMessage()
        {
            InitializeComponent();
            Icon = Icon.FromHandle(Resources.trivia_quiz_logo.GetHicon());
            Points = TriviaNewGame.Points;
            lblPoints.Text = Points.ToString();
            if (Points == 0) lblMessage.Text = "Ты ведь специльно, да?";
            else if (Points < 10) lblMessage.Text = "Неплохой результат! Но можно лучше.";
            else if (Points < 20) lblMessage.Text = "Отличный результат!";
            else lblMessage.Text = "Поздравляем! Ты настоящий эрудит!";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPoints_Click(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
