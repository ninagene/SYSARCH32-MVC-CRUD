namespace CollegeApplication
{
    partial class Form1
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
            this.COLLEGENAMEtxt = new System.Windows.Forms.TextBox();
            this.COLLEGECODEtxt = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.COLLEGEdgv = new System.Windows.Forms.DataGridView();
            this.COLLEGEAddbtn = new System.Windows.Forms.Button();
            this.COLLEGEEditbtn = new System.Windows.Forms.Button();
            this.COLLEGEDeletebtn = new System.Windows.Forms.Button();
            this.DEPARTMENTNAMEtxt = new System.Windows.Forms.TextBox();
            this.DEPARTMENTCODEtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DEPARTMENTdgv = new System.Windows.Forms.DataGridView();
            this.DEPARTMENTADDbtn = new System.Windows.Forms.Button();
            this.DEPARTMENTEDITbtn = new System.Windows.Forms.Button();
            this.DEPARTMENTDELETEbtn = new System.Windows.Forms.Button();
            this.COLLEGEisActivecb = new System.Windows.Forms.CheckBox();
            this.DEPARTEMNTisActivecb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DEPEARTMENTIDtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.COLLEGEIDtxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.COLLEGEdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEPARTMENTdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // COLLEGENAMEtxt
            // 
            this.COLLEGENAMEtxt.Location = new System.Drawing.Point(54, 112);
            this.COLLEGENAMEtxt.Multiline = true;
            this.COLLEGENAMEtxt.Name = "COLLEGENAMEtxt";
            this.COLLEGENAMEtxt.Size = new System.Drawing.Size(356, 52);
            this.COLLEGENAMEtxt.TabIndex = 0;
            // 
            // COLLEGECODEtxt
            // 
            this.COLLEGECODEtxt.Location = new System.Drawing.Point(54, 198);
            this.COLLEGECODEtxt.Multiline = true;
            this.COLLEGECODEtxt.Name = "COLLEGECODEtxt";
            this.COLLEGECODEtxt.Size = new System.Drawing.Size(356, 52);
            this.COLLEGECODEtxt.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(49, 80);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(212, 29);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "COLLEGE NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "COLLEGE CODE";
            // 
            // COLLEGEdgv
            // 
            this.COLLEGEdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.COLLEGEdgv.Location = new System.Drawing.Point(473, 12);
            this.COLLEGEdgv.Name = "COLLEGEdgv";
            this.COLLEGEdgv.RowHeadersWidth = 62;
            this.COLLEGEdgv.RowTemplate.Height = 28;
            this.COLLEGEdgv.Size = new System.Drawing.Size(766, 384);
            this.COLLEGEdgv.TabIndex = 2;
            this.COLLEGEdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.COLLEGEdgv_CellContentClick);
            // 
            // COLLEGEAddbtn
            // 
            this.COLLEGEAddbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COLLEGEAddbtn.Location = new System.Drawing.Point(138, 431);
            this.COLLEGEAddbtn.Name = "COLLEGEAddbtn";
            this.COLLEGEAddbtn.Size = new System.Drawing.Size(306, 70);
            this.COLLEGEAddbtn.TabIndex = 4;
            this.COLLEGEAddbtn.Text = "ADD";
            this.COLLEGEAddbtn.UseVisualStyleBackColor = true;
            this.COLLEGEAddbtn.Click += new System.EventHandler(this.COLLEGEAddbtn_Click);
            // 
            // COLLEGEEditbtn
            // 
            this.COLLEGEEditbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COLLEGEEditbtn.Location = new System.Drawing.Point(474, 431);
            this.COLLEGEEditbtn.Name = "COLLEGEEditbtn";
            this.COLLEGEEditbtn.Size = new System.Drawing.Size(306, 70);
            this.COLLEGEEditbtn.TabIndex = 4;
            this.COLLEGEEditbtn.Text = "EDIT";
            this.COLLEGEEditbtn.UseVisualStyleBackColor = true;
            this.COLLEGEEditbtn.Click += new System.EventHandler(this.COLLEGEEditbtn_Click);
            // 
            // COLLEGEDeletebtn
            // 
            this.COLLEGEDeletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COLLEGEDeletebtn.Location = new System.Drawing.Point(809, 431);
            this.COLLEGEDeletebtn.Name = "COLLEGEDeletebtn";
            this.COLLEGEDeletebtn.Size = new System.Drawing.Size(306, 70);
            this.COLLEGEDeletebtn.TabIndex = 4;
            this.COLLEGEDeletebtn.Text = "DELETE";
            this.COLLEGEDeletebtn.UseVisualStyleBackColor = true;
            this.COLLEGEDeletebtn.Click += new System.EventHandler(this.COLLEGEDeletebtn_Click);
            // 
            // DEPARTMENTNAMEtxt
            // 
            this.DEPARTMENTNAMEtxt.Location = new System.Drawing.Point(54, 662);
            this.DEPARTMENTNAMEtxt.Multiline = true;
            this.DEPARTMENTNAMEtxt.Name = "DEPARTMENTNAMEtxt";
            this.DEPARTMENTNAMEtxt.Size = new System.Drawing.Size(356, 52);
            this.DEPARTMENTNAMEtxt.TabIndex = 0;
            this.DEPARTMENTNAMEtxt.TextChanged += new System.EventHandler(this.DEPARTMENTNAMEtxt_TextChanged);
            // 
            // DEPARTMENTCODEtxt
            // 
            this.DEPARTMENTCODEtxt.Location = new System.Drawing.Point(54, 748);
            this.DEPARTMENTCODEtxt.Multiline = true;
            this.DEPARTMENTCODEtxt.Name = "DEPARTMENTCODEtxt";
            this.DEPARTMENTCODEtxt.Size = new System.Drawing.Size(356, 52);
            this.DEPARTMENTCODEtxt.TabIndex = 0;
            this.DEPARTMENTCODEtxt.TextChanged += new System.EventHandler(this.DEPARTMENTCODEtxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "DEPARTMENT NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 717);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "DEPARTMENT CODE";
            // 
            // DEPARTMENTdgv
            // 
            this.DEPARTMENTdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DEPARTMENTdgv.Location = new System.Drawing.Point(473, 544);
            this.DEPARTMENTdgv.Name = "DEPARTMENTdgv";
            this.DEPARTMENTdgv.RowHeadersWidth = 62;
            this.DEPARTMENTdgv.RowTemplate.Height = 28;
            this.DEPARTMENTdgv.Size = new System.Drawing.Size(766, 384);
            this.DEPARTMENTdgv.TabIndex = 2;
            this.DEPARTMENTdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DEPARTMENTdgv_CellContentClick);
            // 
            // DEPARTMENTADDbtn
            // 
            this.DEPARTMENTADDbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEPARTMENTADDbtn.Location = new System.Drawing.Point(138, 963);
            this.DEPARTMENTADDbtn.Name = "DEPARTMENTADDbtn";
            this.DEPARTMENTADDbtn.Size = new System.Drawing.Size(306, 70);
            this.DEPARTMENTADDbtn.TabIndex = 4;
            this.DEPARTMENTADDbtn.Text = "ADD";
            this.DEPARTMENTADDbtn.UseVisualStyleBackColor = true;
            this.DEPARTMENTADDbtn.Click += new System.EventHandler(this.DEPARTMENTADDbtn_Click);
            // 
            // DEPARTMENTEDITbtn
            // 
            this.DEPARTMENTEDITbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEPARTMENTEDITbtn.Location = new System.Drawing.Point(474, 963);
            this.DEPARTMENTEDITbtn.Name = "DEPARTMENTEDITbtn";
            this.DEPARTMENTEDITbtn.Size = new System.Drawing.Size(306, 70);
            this.DEPARTMENTEDITbtn.TabIndex = 4;
            this.DEPARTMENTEDITbtn.Text = "EDIT";
            this.DEPARTMENTEDITbtn.UseVisualStyleBackColor = true;
            this.DEPARTMENTEDITbtn.Click += new System.EventHandler(this.DEPARTMENTEDITbtn_Click);
            // 
            // DEPARTMENTDELETEbtn
            // 
            this.DEPARTMENTDELETEbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEPARTMENTDELETEbtn.Location = new System.Drawing.Point(809, 963);
            this.DEPARTMENTDELETEbtn.Name = "DEPARTMENTDELETEbtn";
            this.DEPARTMENTDELETEbtn.Size = new System.Drawing.Size(306, 70);
            this.DEPARTMENTDELETEbtn.TabIndex = 4;
            this.DEPARTMENTDELETEbtn.Text = "DELETE";
            this.DEPARTMENTDELETEbtn.UseVisualStyleBackColor = true;
            this.DEPARTMENTDELETEbtn.Click += new System.EventHandler(this.DEPARTMENTDELETEbtn_Click);
            // 
            // COLLEGEisActivecb
            // 
            this.COLLEGEisActivecb.AutoSize = true;
            this.COLLEGEisActivecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COLLEGEisActivecb.Location = new System.Drawing.Point(54, 367);
            this.COLLEGEisActivecb.Name = "COLLEGEisActivecb";
            this.COLLEGEisActivecb.Size = new System.Drawing.Size(133, 29);
            this.COLLEGEisActivecb.TabIndex = 5;
            this.COLLEGEisActivecb.Text = "Is Active?";
            this.COLLEGEisActivecb.UseVisualStyleBackColor = true;
            this.COLLEGEisActivecb.CheckedChanged += new System.EventHandler(this.COLLEGEisActivecb_CheckedChanged);
            // 
            // DEPARTEMNTisActivecb
            // 
            this.DEPARTEMNTisActivecb.AutoSize = true;
            this.DEPARTEMNTisActivecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEPARTEMNTisActivecb.Location = new System.Drawing.Point(54, 917);
            this.DEPARTEMNTisActivecb.Name = "DEPARTEMNTisActivecb";
            this.DEPARTEMNTisActivecb.Size = new System.Drawing.Size(133, 29);
            this.DEPARTEMNTisActivecb.TabIndex = 5;
            this.DEPARTEMNTisActivecb.Text = "Is Active?";
            this.DEPARTEMNTisActivecb.UseVisualStyleBackColor = true;
            this.DEPARTEMNTisActivecb.CheckedChanged += new System.EventHandler(this.DEPARTEMNTisActivecb_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 808);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "DEPARTMENT ID";
            // 
            // DEPEARTMENTIDtxt
            // 
            this.DEPEARTMENTIDtxt.Location = new System.Drawing.Point(54, 840);
            this.DEPEARTMENTIDtxt.Multiline = true;
            this.DEPEARTMENTIDtxt.Name = "DEPEARTMENTIDtxt";
            this.DEPEARTMENTIDtxt.Size = new System.Drawing.Size(356, 52);
            this.DEPEARTMENTIDtxt.TabIndex = 0;
            this.DEPEARTMENTIDtxt.TextChanged += new System.EventHandler(this.DEPEARTMENTIDtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "COLLEGE ID";
            // 
            // COLLEGEIDtxt
            // 
            this.COLLEGEIDtxt.Location = new System.Drawing.Point(54, 290);
            this.COLLEGEIDtxt.Multiline = true;
            this.COLLEGEIDtxt.Name = "COLLEGEIDtxt";
            this.COLLEGEIDtxt.Size = new System.Drawing.Size(356, 52);
            this.COLLEGEIDtxt.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 562);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 52);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "COLLEGE ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1308, 1050);
            this.Controls.Add(this.DEPARTEMNTisActivecb);
            this.Controls.Add(this.COLLEGEisActivecb);
            this.Controls.Add(this.DEPARTMENTDELETEbtn);
            this.Controls.Add(this.COLLEGEDeletebtn);
            this.Controls.Add(this.DEPARTMENTEDITbtn);
            this.Controls.Add(this.COLLEGEEditbtn);
            this.Controls.Add(this.DEPARTMENTADDbtn);
            this.Controls.Add(this.COLLEGEAddbtn);
            this.Controls.Add(this.DEPARTMENTdgv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.COLLEGEdgv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DEPEARTMENTIDtxt);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.DEPARTMENTCODEtxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.COLLEGEIDtxt);
            this.Controls.Add(this.DEPARTMENTNAMEtxt);
            this.Controls.Add(this.COLLEGECODEtxt);
            this.Controls.Add(this.COLLEGENAMEtxt);
            this.Name = "Form1";
            this.Text = "COLLEGE APPLICATION FORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.COLLEGEdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEPARTMENTdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox COLLEGENAMEtxt;
        private System.Windows.Forms.TextBox COLLEGECODEtxt;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView COLLEGEdgv;
        private System.Windows.Forms.Button COLLEGEAddbtn;
        private System.Windows.Forms.Button COLLEGEEditbtn;
        private System.Windows.Forms.Button COLLEGEDeletebtn;
        private System.Windows.Forms.TextBox DEPARTMENTNAMEtxt;
        private System.Windows.Forms.TextBox DEPARTMENTCODEtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DEPARTMENTdgv;
        private System.Windows.Forms.Button DEPARTMENTADDbtn;
        private System.Windows.Forms.Button DEPARTMENTEDITbtn;
        private System.Windows.Forms.Button DEPARTMENTDELETEbtn;
        private System.Windows.Forms.CheckBox COLLEGEisActivecb;
        private System.Windows.Forms.CheckBox DEPARTEMNTisActivecb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DEPEARTMENTIDtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox COLLEGEIDtxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

