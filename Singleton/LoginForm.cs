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
using System.Runtime.InteropServices;


namespace Singleton
{
    public partial class LoginForm : Form
    {
        Singleton instanceOfSingleton;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
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

            //Border radius
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

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
