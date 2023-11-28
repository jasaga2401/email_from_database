namespace email_from_database
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
            this.btn_email = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_connect_db = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_email
            // 
            this.btn_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email.Location = new System.Drawing.Point(259, 165);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(274, 100);
            this.btn_email.TabIndex = 0;
            this.btn_email.Text = "Send Email";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(255, 329);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(179, 20);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Waiting to send emails";
            // 
            // lbl_connect_db
            // 
            this.lbl_connect_db.AutoSize = true;
            this.lbl_connect_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connect_db.Location = new System.Drawing.Point(259, 290);
            this.lbl_connect_db.Name = "lbl_connect_db";
            this.lbl_connect_db.Size = new System.Drawing.Size(190, 20);
            this.lbl_connect_db.TabIndex = 2;
            this.lbl_connect_db.Text = "Waiting to connect to db";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 475);
            this.Controls.Add(this.lbl_connect_db);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_email);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_connect_db;
    }
}

