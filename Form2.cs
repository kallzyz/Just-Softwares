using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToggleSwitch;

namespace UDsoftwares
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
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
            Form1 F1 = new Form1();
            F1.Show();
            Hide();
        }

       private void guna2Button1_Click(object sender, EventArgs e)
        {
            {
                LimparRegistro();
            }

            void LimparRegistro()
            {

                try { 
                Registry.CurrentUser.DeleteValue("NomeDoValor", false);

                Registry.CurrentUser.DeleteSubKeyTree(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", false);

                MessageBox.Show("Registro limpo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                catch (Exception ex)
                {
                MessageBox.Show("Erro ao limpar o Registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
                {
                    LimparCache();
                }

            void LimparCache()
                {
                    try
                    {
                        string tempFolderPath = Path.GetTempPath();

                        string[] files = Directory.GetFiles(tempFolderPath);

                        foreach (string file in files)
                        {
                            File.Delete(file);
                        }

                        MessageBox.Show("Cache limpo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao limpar o cache: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
 
        } 
    }
}
    


    
