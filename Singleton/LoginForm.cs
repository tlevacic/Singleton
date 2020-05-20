using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    public partial class LoginForm : Form
    {
        Singleton instanceOfSingleton;
        public LoginForm()
        {
            InitializeComponent();
            instanceOfSingleton = Singleton.getInstance();
            username.Text = instanceOfSingleton.Username;
            password.Text = instanceOfSingleton.Password;
        }

        private void login_Click(object sender, EventArgs e)
        {
            var validation= instanceOfSingleton.ProcessData(username.Text, password.Text);
            if (validation.Equals(ValidationState.True))
            {
                this.Close();
            }
            else if(validation.Equals(ValidationState.False))
            {
                errorInfo.Text = "Wrong Credentials!";
                errorInfo.Visible = true;
            }
            else
            {
                errorInfo.Text = "Something went wrong";
                errorInfo.Visible = true;
            }
        }
    }
}
