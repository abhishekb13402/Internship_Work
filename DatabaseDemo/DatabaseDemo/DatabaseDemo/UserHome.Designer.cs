namespace DatabaseDemo
{
    partial class UserHome
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
            this.lblusertext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblusertext
            // 
            this.lblusertext.AutoSize = true;
            this.lblusertext.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusertext.Location = new System.Drawing.Point(12, 9);
            this.lblusertext.Name = "lblusertext";
            this.lblusertext.Size = new System.Drawing.Size(45, 21);
            this.lblusertext.TabIndex = 2;
            this.lblusertext.Text = "text";
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblusertext);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserHome_FormClosed);
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusertext;
    }
}