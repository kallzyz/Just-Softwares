using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDsoftwares
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            AddFormShadow();
        }

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://www.discord.com/invite/nnmuSnX3xc";

            Process.Start(url);
        }

        

             private void guna2Button1_Click(object sender, EventArgs e)
        {
          
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (Autenticar(usuario, senha))
            {

                Form3 ml = new Form3();
                ml.ShowDialog();

                Form2 ML = new Form2();
                ML.Show();
                Hide();
            }
            else
            {
                Form4 F4 = new Form4();
                F4.ShowDialog();
            }
        }

        private bool Autenticar(string usuario, string senha)
        {
           
            return usuario == "" && senha == "";
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Adiciona uma sombra vermelha ao formulário
        private void AddFormShadow()
        {
            int CS_DROPSHADOW = 0x20000;

            // Habilita o estilo de sombra para o formulário
            this.FormBorderStyle = FormBorderStyle.None;

            // Ativa o estilo de sombra CS_DROPSHADOW
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DROPSHADOW);
        }

        #region P/Invoke Declarations

        private const int CS_DROPSHADOW = 0x20000;
        private const int GCL_STYLE = -26;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetClassLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetClassLong(IntPtr hWnd, int nIndex, int dwNewLong);

        #endregion
    }
}
    

