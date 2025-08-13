using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTApp
{
    public partial class FormLogin : Form
    {
        string User = "Admin"; string Password = "1234";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == User && txtPassword.Text == Password)
            {

            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void lklRecuperarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Hagamos como que hiciste un proceso de recuperación\n Usuario:{User}\n Contraseña:{Password}","",MessageBoxButtons.OK);
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
