namespace GUI
{
    partial class FormLogareCentru
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
            this.comboBoxNumeCentru = new System.Windows.Forms.ComboBox();
            this.textBoxParolaCentru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxNumeCentru
            // 
            this.comboBoxNumeCentru.FormattingEnabled = true;
            this.comboBoxNumeCentru.Location = new System.Drawing.Point(150, 121);
            this.comboBoxNumeCentru.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNumeCentru.Name = "comboBoxNumeCentru";
            this.comboBoxNumeCentru.Size = new System.Drawing.Size(188, 26);
            this.comboBoxNumeCentru.TabIndex = 0;
            this.comboBoxNumeCentru.Text = "Nume Centru";
            // 
            // textBoxParolaCentru
            // 
            this.textBoxParolaCentru.Location = new System.Drawing.Point(150, 212);
            this.textBoxParolaCentru.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxParolaCentru.Name = "textBoxParolaCentru";
            this.textBoxParolaCentru.PasswordChar = '*';
            this.textBoxParolaCentru.Size = new System.Drawing.Size(188, 24);
            this.textBoxParolaCentru.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parolă";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(222, 291);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(75, 29);
            this.buttonLogIn.TabIndex = 3;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // FormLogareCentru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 445);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxParolaCentru);
            this.Controls.Add(this.comboBoxNumeCentru);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogareCentru";
            this.Text = "LOG IN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNumeCentru;
        private System.Windows.Forms.TextBox textBoxParolaCentru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogIn;
    }
}