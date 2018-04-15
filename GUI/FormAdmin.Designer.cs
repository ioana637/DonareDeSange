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
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.labelParola = new System.Windows.Forms.Label();
            this.buttonAddCentruT = new System.Windows.Forms.Button();
            this.checkedListBoxSpitale = new System.Windows.Forms.CheckedListBox();
            this.labelSpitale = new System.Windows.Forms.Label();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.comboBoxLocalitate = new System.Windows.Forms.ComboBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.dataGridViewCentre = new System.Windows.Forms.DataGridView();
            this.comboBoxJudet = new System.Windows.Forms.ComboBox();
            this.labelJudet = new System.Windows.Forms.Label();
            this.labelZona = new System.Windows.Forms.Label();
            this.labelLocalitate = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.tabPageMedici = new System.Windows.Forms.TabPage();
            this.tabPageSpitale = new System.Windows.Forms.TabPage();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonDeleteCentru = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCentruTransfuzii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCentre)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(911, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCentruTransfuzii
            // 
            this.tabPageCentruTransfuzii.Controls.Add(this.buttonDeleteCentru);
            this.tabPageCentruTransfuzii.Controls.Add(this.textBoxParola);
            this.tabPageCentruTransfuzii.Controls.Add(this.labelParola);
            this.tabPageCentruTransfuzii.Controls.Add(this.buttonAddCentruT);
            this.tabPageCentruTransfuzii.Controls.Add(this.checkedListBoxSpitale);
            this.tabPageCentruTransfuzii.Controls.Add(this.labelSpitale);
            this.tabPageCentruTransfuzii.Controls.Add(this.textBoxAdresa);
            this.tabPageCentruTransfuzii.Controls.Add(this.comboBoxLocalitate);
            this.tabPageCentruTransfuzii.Controls.Add(this.textBoxNume);
            this.tabPageCentruTransfuzii.Controls.Add(this.dataGridViewCentre);
            this.tabPageCentruTransfuzii.Controls.Add(this.comboBoxJudet);
            this.tabPageCentruTransfuzii.Controls.Add(this.labelJudet);
            this.tabPageCentruTransfuzii.Controls.Add(this.labelZona);
            this.tabPageCentruTransfuzii.Controls.Add(this.labelLocalitate);
            this.tabPageCentruTransfuzii.Controls.Add(this.labelNume);
            this.tabPageCentruTransfuzii.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCentruTransfuzii.Location = new System.Drawing.Point(4, 22);
            this.tabPageCentruTransfuzii.Name = "tabPageCentruTransfuzii";
            this.tabPageCentruTransfuzii.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCentruTransfuzii.Size = new System.Drawing.Size(903, 451);
            this.tabPageCentruTransfuzii.TabIndex = 0;
            this.tabPageCentruTransfuzii.Text = "CentreDeTransfuzii";
            this.tabPageCentruTransfuzii.UseVisualStyleBackColor = true;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(761, 148);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(131, 27);
            this.textBoxParola.TabIndex = 16;
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Location = new System.Drawing.Point(675, 151);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(58, 20);
            this.labelParola.TabIndex = 15;
            this.labelParola.Text = "Parola";
            // 
            // buttonAddCentruT
            // 
            this.buttonAddCentruT.Location = new System.Drawing.Point(678, 419);
            this.buttonAddCentruT.Name = "buttonAddCentruT";
            this.buttonAddCentruT.Size = new System.Drawing.Size(55, 24);
            this.buttonAddCentruT.TabIndex = 14;
            this.buttonAddCentruT.Text = "Add";
            this.buttonAddCentruT.UseVisualStyleBackColor = true;
            this.buttonAddCentruT.Click += new System.EventHandler(this.buttonAddCentruT_Click);
            // 
            // checkedListBoxSpitale
            // 
            this.checkedListBoxSpitale.FormattingEnabled = true;
            this.checkedListBoxSpitale.Location = new System.Drawing.Point(677, 228);
            this.checkedListBoxSpitale.Name = "checkedListBoxSpitale";
            this.checkedListBoxSpitale.Size = new System.Drawing.Size(215, 180);
            this.checkedListBoxSpitale.TabIndex = 7;
            // 
            // labelSpitale
            // 
            this.labelSpitale.AutoSize = true;
            this.labelSpitale.Location = new System.Drawing.Point(675, 194);
            this.labelSpitale.Name = "labelSpitale";
            this.labelSpitale.Size = new System.Drawing.Size(127, 20);
            this.labelSpitale.TabIndex = 8;
            this.labelSpitale.Text = "SpitaleAsignate";
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(761, 42);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(131, 27);
            this.textBoxAdresa.TabIndex = 11;
            // 
            // comboBoxLocalitate
            // 
            this.comboBoxLocalitate.FormattingEnabled = true;
            this.comboBoxLocalitate.Location = new System.Drawing.Point(761, 109);
            this.comboBoxLocalitate.Name = "comboBoxLocalitate";
            this.comboBoxLocalitate.Size = new System.Drawing.Size(131, 28);
            this.comboBoxLocalitate.TabIndex = 13;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(761, 8);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(131, 27);
            this.textBoxNume.TabIndex = 9;
            // 
            // dataGridViewCentre
            // 
            this.dataGridViewCentre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCentre.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCentre.Name = "dataGridViewCentre";
            this.dataGridViewCentre.Size = new System.Drawing.Size(620, 437);
            this.dataGridViewCentre.TabIndex = 0;
            this.dataGridViewCentre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBoxJudet
            // 
            this.comboBoxJudet.FormattingEnabled = true;
            this.comboBoxJudet.Location = new System.Drawing.Point(761, 75);
            this.comboBoxJudet.Name = "comboBoxJudet";
            this.comboBoxJudet.Size = new System.Drawing.Size(131, 28);
            this.comboBoxJudet.TabIndex = 12;
            this.comboBoxJudet.SelectedIndexChanged += new System.EventHandler(this.comboBoxJudet_SelectedIndexChanged);
            // 
            // labelJudet
            // 
            this.labelJudet.AutoSize = true;
            this.labelJudet.Location = new System.Drawing.Point(678, 83);
            this.labelJudet.Name = "labelJudet";
            this.labelJudet.Size = new System.Drawing.Size(51, 20);
            this.labelJudet.TabIndex = 5;
            this.labelJudet.Text = "Judet";
            // 
            // labelZona
            // 
            this.labelZona.AutoSize = true;
            this.labelZona.Location = new System.Drawing.Point(673, 49);
            this.labelZona.Name = "labelZona";
            this.labelZona.Size = new System.Drawing.Size(61, 20);
            this.labelZona.TabIndex = 4;
            this.labelZona.Text = "Adresa";
            // 
            // labelLocalitate
            // 
            this.labelLocalitate.AutoSize = true;
            this.labelLocalitate.Location = new System.Drawing.Point(674, 117);
            this.labelLocalitate.Name = "labelLocalitate";
            this.labelLocalitate.Size = new System.Drawing.Size(83, 20);
            this.labelLocalitate.TabIndex = 6;
            this.labelLocalitate.Text = "Localitate";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(675, 15);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(54, 20);
            this.labelNume.TabIndex = 3;
            this.labelNume.Text = "Nume";
            // 
            // tabPageMedici
            // 
            this.tabPageMedici.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMedici.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedici.Name = "tabPageMedici";
            this.tabPageMedici.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedici.Size = new System.Drawing.Size(903, 451);
            this.tabPageMedici.TabIndex = 1;
            this.tabPageMedici.Text = "Medici";
            this.tabPageMedici.UseVisualStyleBackColor = true;
            // 
            // tabPageSpitale
            // 
            this.tabPageSpitale.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSpitale.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpitale.Name = "tabPageSpitale";
            this.tabPageSpitale.Size = new System.Drawing.Size(903, 451);
            this.tabPageSpitale.TabIndex = 2;
            this.tabPageSpitale.Text = "Spitale";
            this.tabPageSpitale.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(865, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLogout.Size = new System.Drawing.Size(47, 49);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonDeleteCentru
            // 
            this.buttonDeleteCentru.Location = new System.Drawing.Point(817, 419);
            this.buttonDeleteCentru.Name = "buttonDeleteCentru";
            this.buttonDeleteCentru.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCentru.TabIndex = 17;
            this.buttonDeleteCentru.Text = "Delete";
            this.buttonDeleteCentru.UseVisualStyleBackColor = true;
            this.buttonDeleteCentru.Click += new System.EventHandler(this.buttonDeleteCentru_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 512);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCentruTransfuzii.ResumeLayout(false);
            this.tabPageCentruTransfuzii.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCentre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCentruTransfuzii;
        private System.Windows.Forms.TabPage tabPageMedici;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TabPage tabPageSpitale;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelZona;
        private System.Windows.Forms.Label labelJudet;
        private System.Windows.Forms.Label labelLocalitate;
        private System.Windows.Forms.CheckedListBox checkedListBoxSpitale;
        private System.Windows.Forms.Label labelSpitale;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.ComboBox comboBoxJudet;
        private System.Windows.Forms.ComboBox comboBoxLocalitate;
        private System.Windows.Forms.DataGridView dataGridViewCentre;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Button buttonAddCentruT;
        private System.Windows.Forms.Button buttonDeleteCentru;
    }
}