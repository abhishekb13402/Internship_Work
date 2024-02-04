namespace DatabaseDemo
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
            this.lblloginid = new System.Windows.Forms.Label();
            this.lblloginpassword = new System.Windows.Forms.Label();
            this.tbloginid = new System.Windows.Forms.TextBox();
            this.tbloginpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblloginid
            // 
            this.lblloginid.AutoSize = true;
            this.lblloginid.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginid.Location = new System.Drawing.Point(78, 120);
            this.lblloginid.Name = "lblloginid";
            this.lblloginid.Size = new System.Drawing.Size(89, 21);
            this.lblloginid.TabIndex = 0;
            this.lblloginid.Text = "Login ID";
            // 
            // lblloginpassword
            // 
            this.lblloginpassword.AutoSize = true;
            this.lblloginpassword.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginpassword.Location = new System.Drawing.Point(78, 181);
            this.lblloginpassword.Name = "lblloginpassword";
            this.lblloginpassword.Size = new System.Drawing.Size(156, 21);
            this.lblloginpassword.TabIndex = 1;
            this.lblloginpassword.Text = "Login Password";
            // 
            // tbloginid
            // 
            this.tbloginid.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbloginid.Location = new System.Drawing.Point(294, 111);
            this.tbloginid.Name = "tbloginid";
            this.tbloginid.Size = new System.Drawing.Size(147, 30);
            this.tbloginid.TabIndex = 2;
            // 
            // tbloginpassword
            // 
            this.tbloginpassword.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbloginpassword.Location = new System.Drawing.Point(294, 170);
            this.tbloginpassword.Name = "tbloginpassword";
            this.tbloginpassword.Size = new System.Drawing.Size(147, 30);
            this.tbloginpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(294, 242);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(106, 38);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(128, 242);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(106, 38);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 399);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.tbloginpassword);
            this.Controls.Add(this.tbloginid);
            this.Controls.Add(this.lblloginpassword);
            this.Controls.Add(this.lblloginid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblloginid;
        private System.Windows.Forms.Label lblloginpassword;
        private System.Windows.Forms.TextBox tbloginid;
        private System.Windows.Forms.TextBox tbloginpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnclear;
    }
}

