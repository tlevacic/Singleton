using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Singleton
{
    public partial class LoginForm : Form
    {
        Singleton instanceOfSingleton;

        private void set_background(Object sender, PaintEventArgs e)
        {
            var size = this.Size;
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, size.Width, size.Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(64, 224, 208), Color.FromArgb(238, 130, 238), 59f);      
            graphics.FillRectangle(b, gradient_rectangle);
        }

        public LoginForm()
        {
            InitializeComponent();


            //Background
            this.Paint += new PaintEventHandler(set_background);
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

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
