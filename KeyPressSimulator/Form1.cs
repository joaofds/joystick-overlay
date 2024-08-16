using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyPressSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para detectar quando uma tecla é pressionada
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aButton.ForeColor = Color.Black;
                    aButton.BackColor = Color.White;
                    break;
                case Keys.S:
                    sButton.ForeColor = Color.Black;
                    sButton.BackColor = Color.White;
                    break;
                case Keys.D:
                    dButton.ForeColor = Color.Black;
                    dButton.BackColor = Color.White;
                    break;
                case Keys.Space:
                    spaceButton.ForeColor = Color.Black;
                    spaceButton.BackColor = Color.White;
                    break;
            }
        }

        // Evento para detectar quando uma tecla é solta
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aButton.ForeColor = Color.White;
                    aButton.BackColor = Color.Black;
                    break;
                case Keys.S:
                    sButton.ForeColor = Color.White;
                    sButton.BackColor = Color.Black;
                    break;
                case Keys.D:
                    dButton.ForeColor = Color.White;
                    dButton.BackColor = Color.Black;
                    break;
                case Keys.Space:
                    spaceButton.ForeColor = Color.White;
                    spaceButton.BackColor = Color.Black;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
