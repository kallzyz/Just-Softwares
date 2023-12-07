using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDsoftwares
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DesligarComputador();
        }

        private void DesligarComputador()
        {
            Process processoDesligar = new Process();

            try
            {
                processoDesligar.StartInfo.FileName = "shutdown";
                processoDesligar.StartInfo.Arguments = "/s /t 10";
                processoDesligar.StartInfo.CreateNoWindow = true;
                processoDesligar.StartInfo.UseShellExecute = false;
                processoDesligar.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desligar o computador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            Hide();
        }
    }
}
