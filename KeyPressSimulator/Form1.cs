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
                case Keys.F:
                    fButton.ForeColor = Color.Black;
                    fButton.BackColor = Color.White;
                    break;
                case Keys.Space:
                    spaceButton.ForeColor = Color.Black;
                    spaceButton.BackColor = Color.White;
                    break;
                case Keys.Q:
                    qButton.ForeColor = Color.Black;
                    qButton.BackColor = Color.White;
                    break;
                case Keys.W:
                    wButton.ForeColor = Color.Black;
                    wButton.BackColor = Color.White;
                    break;
                case Keys.E:
                    eButton.ForeColor = Color.Black;
                    eButton.BackColor = Color.White;
                    break;
                case Keys.R:
                    rButton.ForeColor = Color.Black;
                    rButton.BackColor = Color.White;
                    break;
                case Keys.T:
                    tButton.ForeColor = Color.Black;
                    tButton.BackColor = Color.White;
                    break;
                case Keys.NumPad1:
                    numpad1.ForeColor = Color.Black;
                    numpad1.BackColor = Color.White;
                    break;
                case Keys.NumPad2:
                    numpad2.ForeColor = Color.Black;
                    numpad2.BackColor = Color.White;
                    break;
                case Keys.NumPad3:
                    numpad3.ForeColor = Color.Black;
                    numpad3.BackColor = Color.White;
                    break;
                case Keys.NumPad4:
                    numpad4.ForeColor = Color.Black;
                    numpad4.BackColor = Color.White;
                    break;
                case Keys.NumPad5:
                    numpad5.ForeColor = Color.Black;
                    numpad5.BackColor = Color.White;
                    break;
                case Keys.NumPad6:
                    numpad6.ForeColor = Color.Black;
                    numpad6.BackColor = Color.White;
                    break;
                case Keys.NumPad7:
                    numpad7.ForeColor = Color.Black;
                    numpad7.BackColor = Color.White;
                    break;
                case Keys.NumPad8:
                    numpad8.ForeColor = Color.Black;
                    numpad8.BackColor = Color.White;
                    break;
                case Keys.NumPad9:
                    numpad9.ForeColor = Color.Black;
                    numpad9.BackColor = Color.White;
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
                case Keys.F:
                    fButton.ForeColor = Color.White;
                    fButton.BackColor = Color.Black;
                    break;
                case Keys.Space:
                    spaceButton.ForeColor = Color.White;
                    spaceButton.BackColor = Color.Black;
                    break;
                case Keys.Q:
                    qButton.ForeColor = Color.White;
                    qButton.BackColor = Color.Black;
                    break;
                case Keys.W:
                    wButton.ForeColor = Color.White;
                    wButton.BackColor = Color.Black;
                    break;
                case Keys.E:
                    eButton.ForeColor = Color.White;
                    eButton.BackColor = Color.Black;
                    break;
                case Keys.R:
                    rButton.ForeColor = Color.White;
                    rButton.BackColor = Color.Black;
                    break;
                case Keys.T:
                    tButton.ForeColor = Color.White;
                    tButton.BackColor = Color.Black;
                    break;
                case Keys.NumPad1:
                    numpad1.ForeColor = Color.White;
                    numpad1.BackColor = Color.Black;
                    break;
                case Keys.NumPad2:
                    numpad2.ForeColor = Color.White;
                    numpad2.BackColor = Color.Black;
                    break;
                case Keys.NumPad3:
                    numpad3.ForeColor = Color.White;
                    numpad3.BackColor = Color.Black;
                    break;
                case Keys.NumPad4:
                    numpad4.ForeColor = Color.White;
                    numpad4.BackColor = Color.Black;
                    break;
                case Keys.NumPad5:
                    numpad5.ForeColor = Color.White;
                    numpad5.BackColor = Color.Black;
                    break;
                case Keys.NumPad6:
                    numpad6.ForeColor = Color.White;
                    numpad6.BackColor = Color.Black;
                    break;
                case Keys.NumPad7:
                    numpad7.ForeColor = Color.White;
                    numpad7.BackColor = Color.Black;
                    break;
                case Keys.NumPad8:
                    numpad8.ForeColor = Color.White;
                    numpad8.BackColor = Color.Black;
                    break;
                case Keys.NumPad9:
                    numpad9.ForeColor = Color.White;
                    numpad9.BackColor = Color.Black;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
