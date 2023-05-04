using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("12345")) //poderá ser associado a uma variável, ou fazer a leitura de um ficheiro
                {
                    //entrar na aplicação
                    var menu = new MenuRegisto();
                    menu.Show();

                    //esconde a janela de login
                    this.Visible = false;

                } else
                {
                    MessageBox.Show("O username e a password não coincidem.",
                                    "ERRO!", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                    txtUsername.Focus();
                    txtPassword.Text = "";
                }
            } catch(Exception ex)
            {
                MessageBox.Show("ERRO!",
                                ex.Message,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
