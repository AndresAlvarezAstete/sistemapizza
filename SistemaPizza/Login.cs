using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPizza
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (textBox1.Text == "" || textBox2.Text == "!")
            {
                MessageBox.Show("Ingrese su cuenta y contraseña");
                return;
            }
            else
            {
                if (textBox1.Text == "CajeroAdm" || textBox2.Text == "HnmX2020!")
                {
                    Login loginfrm = new Login();
                    loginfrm.Close();

                    MessageBox.Show("Bienvenido" + textBox1.Text.ToString());
                    principal chForm = new principal();
                    chForm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                    return;
                }
            }

            /*try
            {
                principal chForm = new principal();
                chForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    
    }
}
