namespace DatabaseDemo
{
    partial class AdminHome
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
            this.lbladmintext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbladmintext
            // 
            this.lbladmintext.AutoSize = true;
            this.lbladmintext.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmintext.Location = new System.Drawing.Point(12, 9);
            this.lbladmintext.Name = "lbladmintext";
            this.lbladmintext.Size = new System.Drawing.Size(72, 21);
            this.lbladmintext.TabIndex = 1;
            this.lbladmintext.Text = "Admin";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbladmintext);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminHome_FormClosed);
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladmintext;
    }
}