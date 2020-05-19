﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            String Username = username.Text;
            String Password = password.Text;
            Singleton instanceOfSingleton = Singleton.getInstance();
            instanceOfSingleton.processData(Username,Password);
        }
    }
}
