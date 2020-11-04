namespace WF
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
            this.authorization = new System.Windows.Forms.Label();
            this.loginFielsd = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorization
            // 
            this.authorization.AllowDrop = true;
            this.authorization.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.authorization.Font = new System.Drawing.Font("Stencil", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorization.Location = new System.Drawing.Point(59, 29);
            this.authorization.Name = "authorization";
            this.authorization.Size = new System.Drawing.Size(210, 38);
            this.authorization.TabIndex = 0;
            this.authorization.Text = "authorization";
            // 
            // loginFielsd
            // 
            this.loginFielsd.Location = new System.Drawing.Point(34, 121);
            this.loginFielsd.Multiline = true;
            this.loginFielsd.Name = "loginFielsd";
            this.loginFielsd.Size = new System.Drawing.Size(264, 40);
            this.loginFielsd.TabIndex = 1;
            //this.loginFielsd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(34, 218);
            this.passField.Multiline = true;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(277, 37);
            this.passField.TabIndex = 2;
            this.passField.UseSystemPasswordChar = true;
           // this.passField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
          //  this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(120, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(338, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginFielsd);
            this.Controls.Add(this.authorization);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
          //  this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorization;
        private System.Windows.Forms.TextBox loginFielsd;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}