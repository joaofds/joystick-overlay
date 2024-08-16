using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyPressSimulator
{
    public partial class Form1 : Form
    {
        // Dicionario para guardar teclas.
        private Dictionary<Keys, Control> keyButtonMap;
        public Form1()
        {
            InitializeComponent();
            InitializeKeyButtonMap();
        }

        // Metodo que faz o mapeamento das teclas
        private void InitializeKeyButtonMap() 
        {
            keyButtonMap = new Dictionary<Keys, Control>
            {
                {Keys.Q, qButton },
                {Keys.W, wButton },
                {Keys.E, eButton },
                {Keys.R, rButton },
                {Keys.T, tButton },
                {Keys.A, aButton },
                {Keys.S, sButton },
                {Keys.D, dButton },
                {Keys.F, fButton },
                {Keys.Space, spaceButton },
                {Keys.NumPad1, numpad1 },
                {Keys.NumPad2, numpad2 },
                {Keys.NumPad3, numpad3 },
                {Keys.NumPad4, numpad4 },
                {Keys.NumPad5, numpad5},
                {Keys.NumPad6, numpad6 },
                {Keys.NumPad7, numpad7 },
                {Keys.NumPad8, numpad8 },
                {Keys.NumPad9, numpad9 },
            };
        }

        // Evento para detectar quando uma tecla é pressionada
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyButtonMap.ContainsKey(e.KeyCode))
            {
                keyButtonMap[e.KeyCode].BackColor = Color.White;
                keyButtonMap[e.KeyCode].ForeColor = Color.Black;
                
            }
        }

        // Evento para detectar quando uma tecla é solta
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyButtonMap.ContainsKey(e.KeyCode))
            {
                keyButtonMap[e.KeyCode].BackColor = Color.Black;
                keyButtonMap[e.KeyCode].ForeColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
