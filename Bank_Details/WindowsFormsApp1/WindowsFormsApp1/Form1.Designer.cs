namespace WindowsFormsApp1
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
            this.btnfileopen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblbank = new System.Windows.Forms.Label();
            this.comboBox_Bankname = new System.Windows.Forms.ComboBox();
            this.tbcontactno = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.lbcontactno = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnfileopen
            // 
            this.btnfileopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfileopen.Location = new System.Drawing.Point(604, 314);
            this.btnfileopen.Name = "btnfileopen";
            this.btnfileopen.Size = new System.Drawing.Size(118, 34);
            this.btnfileopen.TabIndex = 22;
            this.btnfileopen.Text = "Open File";
            this.btnfileopen.UseVisualStyleBackColor = true;
            this.btnfileopen.Click += new System.EventHandler(this.btnfileopen_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(442, 388);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 34);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(604, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 34);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblbank
            // 
            this.lblbank.AutoSize = true;
            this.lblbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbank.Location = new System.Drawing.Point(78, 155);
            this.lblbank.Name = "lblbank";
            this.lblbank.Size = new System.Drawing.Size(94, 17);
            this.lblbank.TabIndex = 19;
            this.lblbank.Text = "Select Bank";
            // 
            // comboBox_Bankname
            // 
            this.comboBox_Bankname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Bankname.FormattingEnabled = true;
            this.comboBox_Bankname.Items.AddRange(new object[] {
            "None",
            "ICICI Bank",
            "SBI Bank",
            "BOB Bank",
            "Axis Bank"});
            this.comboBox_Bankname.Location = new System.Drawing.Point(203, 151);
            this.comboBox_Bankname.Name = "comboBox_Bankname";
            this.comboBox_Bankname.Size = new System.Drawing.Size(234, 24);
            this.comboBox_Bankname.TabIndex = 18;
            // 
            // tbcontactno
            // 
            this.tbcontactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontactno.Location = new System.Drawing.Point(203, 107);
            this.tbcontactno.MaxLength = 10;
            this.tbcontactno.Multiline = true;
            this.tbcontactno.Name = "tbcontactno";
            this.tbcontactno.Size = new System.Drawing.Size(234, 27);
            this.tbcontactno.TabIndex = 17;
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(203, 68);
            this.tbname.MaxLength = 12;
            this.tbname.Multiline = true;
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(234, 27);
            this.tbname.TabIndex = 16;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(203, 28);
            this.tbid.Multiline = true;
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(234, 27);
            this.tbid.TabIndex = 15;
            // 
            // lbcontactno
            // 
            this.lbcontactno.AutoSize = true;
            this.lbcontactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontactno.Location = new System.Drawing.Point(78, 108);
            this.lbcontactno.Name = "lbcontactno";
            this.lbcontactno.Size = new System.Drawing.Size(93, 17);
            this.lbcontactno.TabIndex = 14;
            this.lbcontactno.Text = "Contact No.";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(78, 69);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(49, 17);
            this.lblname.TabIndex = 13;
            this.lblname.Text = "Name";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(78, 29);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(23, 17);
            this.lblid.TabIndex = 12;
            this.lblid.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfileopen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblbank);
            this.Controls.Add(this.comboBox_Bankname);
            this.Controls.Add(this.tbcontactno);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.lbcontactno);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfileopen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblbank;
        private System.Windows.Forms.ComboBox comboBox_Bankname;
        private System.Windows.Forms.TextBox tbcontactno;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label lbcontactno;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblid;
    }
}

