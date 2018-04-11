namespace GUI
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCentruTransfuzii = new System.Windows.Forms.TabPage();
            this.tabPageMedici = new System.Windows.Forms.TabPage();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabPageSpitale = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCentruTransfuzii);
            this.tabControl1.Controls.Add(this.tabPageMedici);
            this.tabControl1.Controls.Add(this.tabPageSpitale);
            this.tabControl1.Location = new System.Drawing.Point(1, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCentruTransfuzii
            // 
            this.tabPageCentruTransfuzii.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCentruTransfuzii.Location = new System.Drawing.Point(4, 22);
            this.tabPageCentruTransfuzii.Name = "tabPageCentruTransfuzii";
            this.tabPageCentruTransfuzii.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCentruTransfuzii.Size = new System.Drawing.Size(790, 377);
            this.tabPageCentruTransfuzii.TabIndex = 0;
            this.tabPageCentruTransfuzii.Text = "CentreDeTransfuzii";
            this.tabPageCentruTransfuzii.UseVisualStyleBackColor = true;
            // 
            // tabPageMedici
            // 
            this.tabPageMedici.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMedici.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedici.Name = "tabPageMedici";
            this.tabPageMedici.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedici.Size = new System.Drawing.Size(790, 377);
            this.tabPageMedici.TabIndex = 1;
            this.tabPageMedici.Text = "Medici";
            this.tabPageMedici.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(745, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLogout.Size = new System.Drawing.Size(47, 49);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabPageSpitale
            // 
            this.tabPageSpitale.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSpitale.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpitale.Name = "tabPageSpitale";
            this.tabPageSpitale.Size = new System.Drawing.Size(790, 377);
            this.tabPageSpitale.TabIndex = 2;
            this.tabPageSpitale.Text = "Spitale";
            this.tabPageSpitale.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCentruTransfuzii;
        private System.Windows.Forms.TabPage tabPageMedici;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TabPage tabPageSpitale;
    }
}