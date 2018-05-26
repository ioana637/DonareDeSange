namespace GUI
{
    partial class CerereForm
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
            this.btnNotifica = new System.Windows.Forms.Button();
            this.btnTrimiteSange = new System.Windows.Forms.Button();
            this.lblmesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNotifica
            // 
            this.btnNotifica.BackColor = System.Drawing.Color.Firebrick;
            this.btnNotifica.FlatAppearance.BorderSize = 0;
            this.btnNotifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifica.ForeColor = System.Drawing.Color.White;
            this.btnNotifica.Location = new System.Drawing.Point(7, 61);
            this.btnNotifica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNotifica.Name = "btnNotifica";
            this.btnNotifica.Size = new System.Drawing.Size(201, 86);
            this.btnNotifica.TabIndex = 0;
            this.btnNotifica.Text = "Notifică donatori";
            this.btnNotifica.UseVisualStyleBackColor = false;
            this.btnNotifica.Click += new System.EventHandler(this.btnNotifica_Click);
            // 
            // btnTrimiteSange
            // 
            this.btnTrimiteSange.BackColor = System.Drawing.Color.Firebrick;
            this.btnTrimiteSange.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTrimiteSange.FlatAppearance.BorderSize = 0;
            this.btnTrimiteSange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrimiteSange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrimiteSange.ForeColor = System.Drawing.Color.White;
            this.btnTrimiteSange.Location = new System.Drawing.Point(212, 61);
            this.btnTrimiteSange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrimiteSange.Name = "btnTrimiteSange";
            this.btnTrimiteSange.Size = new System.Drawing.Size(217, 86);
            this.btnTrimiteSange.TabIndex = 1;
            this.btnTrimiteSange.Text = "Trimite sânge";
            this.btnTrimiteSange.UseVisualStyleBackColor = false;
            this.btnTrimiteSange.Click += new System.EventHandler(this.btnTrimiteSange_Click);
            // 
            // lblmesaj
            // 
            this.lblmesaj.AutoSize = true;
            this.lblmesaj.Location = new System.Drawing.Point(38, 39);
            this.lblmesaj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmesaj.Name = "lblmesaj";
            this.lblmesaj.Size = new System.Drawing.Size(0, 13);
            this.lblmesaj.TabIndex = 2;
            // 
            // CerereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(440, 198);
            this.Controls.Add(this.lblmesaj);
            this.Controls.Add(this.btnTrimiteSange);
            this.Controls.Add(this.btnNotifica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CerereForm";
            this.Load += new System.EventHandler(this.CerereForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotifica;
        private System.Windows.Forms.Button btnTrimiteSange;
        private System.Windows.Forms.Label lblmesaj;
    }
}