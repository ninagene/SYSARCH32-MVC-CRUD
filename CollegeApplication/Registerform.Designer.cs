namespace CollegeApplication
{
    partial class Registerform
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
            this.rgstrnametxt = new System.Windows.Forms.TextBox();
            this.rgstrpasstxt = new System.Windows.Forms.TextBox();
            this.rgstrconfirmtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registerbtn = new System.Windows.Forms.Button();
            this.haveanaccountbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rgstrnametxt
            // 
            this.rgstrnametxt.Location = new System.Drawing.Point(637, 78);
            this.rgstrnametxt.Name = "rgstrnametxt";
            this.rgstrnametxt.Size = new System.Drawing.Size(210, 26);
            this.rgstrnametxt.TabIndex = 0;
            this.rgstrnametxt.TextChanged += new System.EventHandler(this.rgstrnametxt_TextChanged);
            // 
            // rgstrpasstxt
            // 
            this.rgstrpasstxt.Location = new System.Drawing.Point(637, 145);
            this.rgstrpasstxt.Name = "rgstrpasstxt";
            this.rgstrpasstxt.Size = new System.Drawing.Size(210, 26);
            this.rgstrpasstxt.TabIndex = 1;
            this.rgstrpasstxt.TextChanged += new System.EventHandler(this.rgstrpasstxt_TextChanged);
            // 
            // rgstrconfirmtxt
            // 
            this.rgstrconfirmtxt.Location = new System.Drawing.Point(637, 194);
            this.rgstrconfirmtxt.Name = "rgstrconfirmtxt";
            this.rgstrconfirmtxt.Size = new System.Drawing.Size(210, 26);
            this.rgstrconfirmtxt.TabIndex = 2;
            this.rgstrconfirmtxt.TextChanged += new System.EventHandler(this.rgstrconfirmtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "confirm password";
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(565, 271);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(130, 49);
            this.registerbtn.TabIndex = 7;
            this.registerbtn.Text = "register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // haveanaccountbtn
            // 
            this.haveanaccountbtn.Location = new System.Drawing.Point(737, 271);
            this.haveanaccountbtn.Name = "haveanaccountbtn";
            this.haveanaccountbtn.Size = new System.Drawing.Size(187, 49);
            this.haveanaccountbtn.TabIndex = 8;
            this.haveanaccountbtn.Text = "already have an account?";
            this.haveanaccountbtn.UseVisualStyleBackColor = true;
            this.haveanaccountbtn.Click += new System.EventHandler(this.haveanaccountbtn_Click);
            // 
            // Registerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 450);
            this.Controls.Add(this.haveanaccountbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rgstrconfirmtxt);
            this.Controls.Add(this.rgstrpasstxt);
            this.Controls.Add(this.rgstrnametxt);
            this.Name = "Registerform";
            this.Text = "Registerform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rgstrnametxt;
        private System.Windows.Forms.TextBox rgstrpasstxt;
        private System.Windows.Forms.TextBox rgstrconfirmtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button haveanaccountbtn;
    }
}