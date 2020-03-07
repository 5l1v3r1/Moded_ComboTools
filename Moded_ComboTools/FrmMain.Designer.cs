namespace Moded_ComboTools
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_filterPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_unpass = new System.Windows.Forms.NumericUpDown();
            this.txt_topass = new System.Windows.Forms.NumericUpDown();
            this.txt_spliter = new System.Windows.Forms.TextBox();
            this.btn_splitRight = new System.Windows.Forms.Button();
            this.btn_splitLeft = new System.Windows.Forms.Button();
            this.btn_clearDuplicates = new System.Windows.Forms.Button();
            this.btn_loadComboThingsDefault = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.af = new System.Windows.Forms.Button();
            this.btn_usernamesToCombine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_topass)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btn_loadComboThingsDefault);
            this.groupBox1.Location = new System.Drawing.Point(97, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Combo Things";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_filterPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_unpass);
            this.panel1.Controls.Add(this.txt_topass);
            this.panel1.Controls.Add(this.txt_spliter);
            this.panel1.Controls.Add(this.btn_splitRight);
            this.panel1.Controls.Add(this.btn_splitLeft);
            this.panel1.Controls.Add(this.btn_clearDuplicates);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(6, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 159);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "-----------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "-----------------------------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "-----------------------------------------------------------------";
            // 
            // btn_filterPassword
            // 
            this.btn_filterPassword.Location = new System.Drawing.Point(22, 119);
            this.btn_filterPassword.Name = "btn_filterPassword";
            this.btn_filterPassword.Size = new System.Drawing.Size(173, 23);
            this.btn_filterPassword.TabIndex = 22;
            this.btn_filterPassword.Text = "Filter Password";
            this.btn_filterPassword.UseVisualStyleBackColor = true;
            this.btn_filterPassword.Click += new System.EventHandler(this.Btn_filterPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(99, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "-";
            // 
            // txt_unpass
            // 
            this.txt_unpass.Location = new System.Drawing.Point(117, 93);
            this.txt_unpass.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txt_unpass.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txt_unpass.Name = "txt_unpass";
            this.txt_unpass.Size = new System.Drawing.Size(49, 20);
            this.txt_unpass.TabIndex = 20;
            this.txt_unpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_unpass.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // txt_topass
            // 
            this.txt_topass.Location = new System.Drawing.Point(44, 93);
            this.txt_topass.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txt_topass.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txt_topass.Name = "txt_topass";
            this.txt_topass.Size = new System.Drawing.Size(49, 20);
            this.txt_topass.TabIndex = 19;
            this.txt_topass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_topass.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // txt_spliter
            // 
            this.txt_spliter.Location = new System.Drawing.Point(97, 47);
            this.txt_spliter.Name = "txt_spliter";
            this.txt_spliter.Size = new System.Drawing.Size(25, 20);
            this.txt_spliter.TabIndex = 12;
            this.txt_spliter.Text = ":";
            this.txt_spliter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_splitRight
            // 
            this.btn_splitRight.Location = new System.Drawing.Point(128, 46);
            this.btn_splitRight.Name = "btn_splitRight";
            this.btn_splitRight.Size = new System.Drawing.Size(80, 23);
            this.btn_splitRight.TabIndex = 11;
            this.btn_splitRight.Text = "Split Right";
            this.btn_splitRight.UseVisualStyleBackColor = true;
            this.btn_splitRight.Click += new System.EventHandler(this.Btn_splitRight_Click);
            // 
            // btn_splitLeft
            // 
            this.btn_splitLeft.Location = new System.Drawing.Point(11, 46);
            this.btn_splitLeft.Name = "btn_splitLeft";
            this.btn_splitLeft.Size = new System.Drawing.Size(80, 23);
            this.btn_splitLeft.TabIndex = 10;
            this.btn_splitLeft.Text = "Split Left";
            this.btn_splitLeft.UseVisualStyleBackColor = true;
            this.btn_splitLeft.Click += new System.EventHandler(this.Btn_splitLeft_Click);
            // 
            // btn_clearDuplicates
            // 
            this.btn_clearDuplicates.Location = new System.Drawing.Point(11, 17);
            this.btn_clearDuplicates.Name = "btn_clearDuplicates";
            this.btn_clearDuplicates.Size = new System.Drawing.Size(197, 23);
            this.btn_clearDuplicates.TabIndex = 9;
            this.btn_clearDuplicates.Text = "Clear Duplicates";
            this.btn_clearDuplicates.UseVisualStyleBackColor = true;
            this.btn_clearDuplicates.Click += new System.EventHandler(this.Btn_clearDuplicates_Click);
            // 
            // btn_loadComboThingsDefault
            // 
            this.btn_loadComboThingsDefault.Location = new System.Drawing.Point(17, 26);
            this.btn_loadComboThingsDefault.Name = "btn_loadComboThingsDefault";
            this.btn_loadComboThingsDefault.Size = new System.Drawing.Size(197, 34);
            this.btn_loadComboThingsDefault.TabIndex = 4;
            this.btn_loadComboThingsDefault.Text = "Load Default Combo";
            this.btn_loadComboThingsDefault.UseVisualStyleBackColor = true;
            this.btn_loadComboThingsDefault.Click += new System.EventHandler(this.Btn_loadComboThingsDefault_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.af);
            this.groupBox2.Controls.Add(this.btn_usernamesToCombine);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(97, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Combo Maker";
            // 
            // af
            // 
            this.af.Location = new System.Drawing.Point(99, 25);
            this.af.Name = "af";
            this.af.Size = new System.Drawing.Size(115, 24);
            this.af.TabIndex = 29;
            this.af.Text = "RND Passwords";
            this.af.UseVisualStyleBackColor = true;
            this.af.Click += new System.EventHandler(this.Af_Click);
            // 
            // btn_usernamesToCombine
            // 
            this.btn_usernamesToCombine.Location = new System.Drawing.Point(6, 25);
            this.btn_usernamesToCombine.Name = "btn_usernamesToCombine";
            this.btn_usernamesToCombine.Size = new System.Drawing.Size(87, 24);
            this.btn_usernamesToCombine.TabIndex = 28;
            this.btn_usernamesToCombine.Text = "Usernames";
            this.btn_usernamesToCombine.UseVisualStyleBackColor = true;
            this.btn_usernamesToCombine.Click += new System.EventHandler(this.Btn_usernamesToCombine_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 24);
            this.button1.TabIndex = 27;
            this.button1.Text = "Combine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(101, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 59);
            this.label6.TabIndex = 2;
            this.label6.Text = "Combo Tools V1.0.0\r\nDeveloper : @MrModed\r\nChannel : @SuperNaturalCoding\r\nPlease J" +
    "oin us!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 437);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo Tools By MrModed | SuperNaturalCoding -> V1.0.0";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_topass)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_loadComboThingsDefault;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_filterPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_unpass;
        private System.Windows.Forms.NumericUpDown txt_topass;
        private System.Windows.Forms.TextBox txt_spliter;
        private System.Windows.Forms.Button btn_splitRight;
        private System.Windows.Forms.Button btn_splitLeft;
        private System.Windows.Forms.Button btn_clearDuplicates;
        private System.Windows.Forms.Button btn_usernamesToCombine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button af;
        private System.Windows.Forms.Label label6;
    }
}

