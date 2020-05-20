namespace Singleton
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.username = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.errorInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(33, 119);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(364, 20);
            this.username.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(744, 200);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(364, 20);
            this.password.TabIndex = 2;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(15, 438);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 3;
            this.login.Text = "Ok";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(819, 378);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // errorInfo
            // 
            this.errorInfo.AutoSize = true;
            this.errorInfo.Location = new System.Drawing.Point(12, 388);
            this.errorInfo.Name = "errorInfo";
            this.errorInfo.Size = new System.Drawing.Size(35, 13);
            this.errorInfo.TabIndex = 5;
            this.errorInfo.Text = "label1";
            this.errorInfo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.username);
            this.panel1.Location = new System.Drawing.Point(313, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 471);
            this.panel1.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1065, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.errorInfo);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label errorInfo;
        private System.Windows.Forms.Panel panel1;
    }
}

