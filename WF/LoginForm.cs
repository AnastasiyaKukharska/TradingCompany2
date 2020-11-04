using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace WF
{
     static class Global
    {
        public static int ID;
        public static int CID;
        public static int BID;
    }
    public partial class LoginForm : Form
    {
        protected readonly IAuthManager _manager;
        public LoginForm(IAuthManager manager)
        {
            InitializeComponent();
            _manager = manager;
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Width, 40);
            Global.ID = _manager.UID(loginFielsd.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doLogin();
        }

        private void doLogin()
        {
            if (_manager.Login(loginFielsd.Text, passField.Text))
            {
                
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

    }
}
