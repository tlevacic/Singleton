using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();

            //Background
            this.Paint += new PaintEventHandler(set_background);

        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            var size = this.Size;
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, size.Width, size.Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(64, 224, 208), Color.FromArgb(238, 130, 238), 59f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void openLoginForm(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
