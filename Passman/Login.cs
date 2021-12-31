using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passman
{
    public partial class Login : Form
    {
        public string? Password { get; set; } = null;
        private string ConfigLocation = Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, "");
        public Login()
        {
            InitializeComponent();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Length == 0)
                {
                    MessageBox.Show("Password cannot be blank.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ValidatePassword();
                }              
            }
        }     
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ValidatePassword()
        {

            Password = textBox1.Text;
            Close();
        }
    }
}
