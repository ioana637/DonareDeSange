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
            this.buttonDeleteCentru = new System.Windows.Forms.Button();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.labelParola = new System.Windows.Forms.Label();
            this.buttonAddCentruT = new System.Windows.Forms.Button();
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
            this.buttonDeleteMedic = new System.Windows.Forms.Button();
            this.buttonAddMedic = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.checkedListBoxListSpitale = new System.Windows.Forms.CheckedListBox();
            this.textBoxNumeMedic = new System.Windows.Forms.TextBox();
            this.textBoxPrenumeMedic = new System.Windows.Forms.TextBox();
            this.textBoxEmailMedic = new System.Windows.Forms.TextBox();
            this.textBoxTelefonMedic = new System.Windows.Forms.TextBox();
            this.textBoxUsernameMedic = new System.Windows.Forms.TextBox();
            this.textBoxPasswordMedic = new System.Windows.Forms.TextBox();
            this.textBoxCNPMedic = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewMedici = new System.Windows.Forms.DataGridView();
            this.tabPageSpitale = new System.Windows.Forms.TabPage();
            this.buttonDeleteSpital = new System.Windows.Forms.Button();
            this.comboBoxCentruT = new System.Windows.Forms.ComboBox();
            this.labelCentruTransfuzie = new System.Windows.Forms.Label();
            this.buttonAddSpital = new System.Windows.Forms.Button();
            this.textBoxAdresaSpital = new System.Windows.Forms.TextBox();
            this.comboBoxLocalitateSpital = new System.Windows.Forms.ComboBox();
            this.comboBoxJudetSpital = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewSpitale = new System.Windows.Forms.DataGridView();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCentruTransfuzii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCentre)).BeginInit();
            this.tabPageMedici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedici)).BeginInit();
            this.tabPageSpitale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpitale)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageCentruTransfuzii);
            this.tabControl1.Controls.Add(this.tabPageMedici);
            this.tabControl1.Controls.Add(this.tabPageSpitale);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCentruTransfuzii
            // 
            this.tabPageCentruTransfuzii.BackColor = System.Drawing.Color.Firebrick;
            this.tabPageCentruTransfuzii.Controls.Add(this.buttonDeleteCentru);
            this.tabPageCentruTransfuzii.Controls.Add(this.textBoxParola);
            this.tabPageCentruTransfuzii.Controls.Add(this.labelParola);
            this.tabPageCentruTransfuzii.Controls.Add(this.buttonAddCentruT);
            this.tabPageCentruTransfuzii.Controls.Add(this.textBoxAdresa);
            this.tabPageCentruTransfuzii.Controls.Add(this.comboBoxLocalitate);
            this.tabPageCentruTransfuzii.Controls.Add(this.textBoxNume);
            this.tabPageCentruTransfuzii.Controls.Add(this.dataGridViewCentre);
            this.tabPageCentruTransfuzii.Controls.Add(this.comboBoxJudet);
            this.tabPageCentruTransfuzii.Controls.Add(this.labelJudet);
            this.tabPageCentruTransfuzii.Controls.Add(this.labelZona);
            this.tabPageCentruTransfuzii.Controls.Add(this.labelLocalitate);
            this.tabPageCentruTransfuzii.Controls.Add(this.labelNume);
            this.tabPageCentruTransfuzii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCentruTransfuzii.Location = new System.Drawing.Point(4, 29);
            this.tabPageCentruTransfuzii.Name = "tabPageCentruTransfuzii";
            this.tabPageCentruTransfuzii.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCentruTransfuzii.Size = new System.Drawing.Size(1152, 475);
            this.tabPageCentruTransfuzii.TabIndex = 0;
            this.tabPageCentruTransfuzii.Text = "Centre de transfuzii";
            // 
            // buttonDeleteCentru
            // 
            this.buttonDeleteCentru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteCentru.BackColor = System.Drawing.Color.White;
            this.buttonDeleteCentru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteCentru.FlatAppearance.BorderSize = 0;
            this.buttonDeleteCentru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteCentru.ForeColor = System.Drawing.Color.Brown;
            this.buttonDeleteCentru.Location = new System.Drawing.Point(986, 427);
            this.buttonDeleteCentru.Name = "buttonDeleteCentru";
            this.buttonDeleteCentru.Size = new System.Drawing.Size(138, 35);
            this.buttonDeleteCentru.TabIndex = 17;
            this.buttonDeleteCentru.Text = "Șterge";
            this.buttonDeleteCentru.UseVisualStyleBackColor = false;
            this.buttonDeleteCentru.Click += new System.EventHandler(this.buttonDeleteCentru_Click);
            // 
            // textBoxParola
            // 
            this.textBoxParola.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxParola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxParola.Location = new System.Drawing.Point(916, 271);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(208, 26);
            this.textBoxParola.TabIndex = 16;
            // 
            // labelParola
            // 
            this.labelParola.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParola.AutoSize = true;
            this.labelParola.ForeColor = System.Drawing.Color.White;
            this.labelParola.Location = new System.Drawing.Point(831, 277);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(54, 20);
            this.labelParola.TabIndex = 15;
            this.labelParola.Text = "Parolă";
            // 
            // buttonAddCentruT
            // 
            this.buttonAddCentruT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddCentruT.BackColor = System.Drawing.Color.White;
            this.buttonAddCentruT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddCentruT.FlatAppearance.BorderSize = 0;
            this.buttonAddCentruT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCentruT.ForeColor = System.Drawing.Color.Brown;
            this.buttonAddCentruT.Location = new System.Drawing.Point(854, 427);
            this.buttonAddCentruT.Name = "buttonAddCentruT";
            this.buttonAddCentruT.Size = new System.Drawing.Size(126, 35);
            this.buttonAddCentruT.TabIndex = 14;
            this.buttonAddCentruT.Text = "Adaugă";
            this.buttonAddCentruT.UseVisualStyleBackColor = false;
            this.buttonAddCentruT.Click += new System.EventHandler(this.buttonAddCentruT_Click);
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAdresa.Location = new System.Drawing.Point(916, 120);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(208, 26);
            this.textBoxAdresa.TabIndex = 11;
            // 
            // comboBoxLocalitate
            // 
            this.comboBoxLocalitate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLocalitate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLocalitate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocalitate.FormattingEnabled = true;
            this.comboBoxLocalitate.Location = new System.Drawing.Point(916, 223);
            this.comboBoxLocalitate.Name = "comboBoxLocalitate";
            this.comboBoxLocalitate.Size = new System.Drawing.Size(208, 28);
            this.comboBoxLocalitate.TabIndex = 13;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNume.Location = new System.Drawing.Point(916, 72);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(208, 26);
            this.textBoxNume.TabIndex = 9;
            // 
            // dataGridViewCentre
            // 
            this.dataGridViewCentre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewCentre.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewCentre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCentre.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewCentre.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCentre.Name = "dataGridViewCentre";
            this.dataGridViewCentre.Size = new System.Drawing.Size(812, 461);
            this.dataGridViewCentre.TabIndex = 0;
            this.dataGridViewCentre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBoxJudet
            // 
            this.comboBoxJudet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxJudet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxJudet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJudet.FormattingEnabled = true;
            this.comboBoxJudet.Location = new System.Drawing.Point(916, 167);
            this.comboBoxJudet.Name = "comboBoxJudet";
            this.comboBoxJudet.Size = new System.Drawing.Size(208, 28);
            this.comboBoxJudet.TabIndex = 12;
            this.comboBoxJudet.SelectedIndexChanged += new System.EventHandler(this.comboBoxJudet_SelectedIndexChanged);
            // 
            // labelJudet
            // 
            this.labelJudet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJudet.AutoSize = true;
            this.labelJudet.ForeColor = System.Drawing.Color.White;
            this.labelJudet.Location = new System.Drawing.Point(831, 175);
            this.labelJudet.Name = "labelJudet";
            this.labelJudet.Size = new System.Drawing.Size(49, 20);
            this.labelJudet.TabIndex = 5;
            this.labelJudet.Text = "Județ";
            // 
            // labelZona
            // 
            this.labelZona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZona.AutoSize = true;
            this.labelZona.ForeColor = System.Drawing.Color.White;
            this.labelZona.Location = new System.Drawing.Point(831, 126);
            this.labelZona.Name = "labelZona";
            this.labelZona.Size = new System.Drawing.Size(60, 20);
            this.labelZona.TabIndex = 4;
            this.labelZona.Text = "Adresă";
            // 
            // labelLocalitate
            // 
            this.labelLocalitate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLocalitate.AutoSize = true;
            this.labelLocalitate.ForeColor = System.Drawing.Color.White;
            this.labelLocalitate.Location = new System.Drawing.Point(831, 231);
            this.labelLocalitate.Name = "labelLocalitate";
            this.labelLocalitate.Size = new System.Drawing.Size(78, 20);
            this.labelLocalitate.TabIndex = 6;
            this.labelLocalitate.Text = "Localitate";
            // 
            // labelNume
            // 
            this.labelNume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNume.AutoSize = true;
            this.labelNume.ForeColor = System.Drawing.Color.White;
            this.labelNume.Location = new System.Drawing.Point(831, 75);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(51, 20);
            this.labelNume.TabIndex = 3;
            this.labelNume.Text = "Nume";
            // 
            // tabPageMedici
            // 
            this.tabPageMedici.BackColor = System.Drawing.Color.Firebrick;
            this.tabPageMedici.Controls.Add(this.buttonDeleteMedic);
            this.tabPageMedici.Controls.Add(this.buttonAddMedic);
            this.tabPageMedici.Controls.Add(this.label11);
            this.tabPageMedici.Controls.Add(this.checkedListBoxListSpitale);
            this.tabPageMedici.Controls.Add(this.textBoxNumeMedic);
            this.tabPageMedici.Controls.Add(this.textBoxPrenumeMedic);
            this.tabPageMedici.Controls.Add(this.textBoxEmailMedic);
            this.tabPageMedici.Controls.Add(this.textBoxTelefonMedic);
            this.tabPageMedici.Controls.Add(this.textBoxUsernameMedic);
            this.tabPageMedici.Controls.Add(this.textBoxPasswordMedic);
            this.tabPageMedici.Controls.Add(this.textBoxCNPMedic);
            this.tabPageMedici.Controls.Add(this.label10);
            this.tabPageMedici.Controls.Add(this.label9);
            this.tabPageMedici.Controls.Add(this.label8);
            this.tabPageMedici.Controls.Add(this.label7);
            this.tabPageMedici.Controls.Add(this.label6);
            this.tabPageMedici.Controls.Add(this.label5);
            this.tabPageMedici.Controls.Add(this.label4);
            this.tabPageMedici.Controls.Add(this.dataGridViewMedici);
            this.tabPageMedici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMedici.ForeColor = System.Drawing.Color.Black;
            this.tabPageMedici.Location = new System.Drawing.Point(4, 29);
            this.tabPageMedici.Name = "tabPageMedici";
            this.tabPageMedici.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedici.Size = new System.Drawing.Size(1152, 475);
            this.tabPageMedici.TabIndex = 1;
            this.tabPageMedici.Text = "Medici";
            // 
            // buttonDeleteMedic
            // 
            this.buttonDeleteMedic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteMedic.BackColor = System.Drawing.Color.White;
            this.buttonDeleteMedic.FlatAppearance.BorderSize = 0;
            this.buttonDeleteMedic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteMedic.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonDeleteMedic.Location = new System.Drawing.Point(919, 427);
            this.buttonDeleteMedic.Name = "buttonDeleteMedic";
            this.buttonDeleteMedic.Size = new System.Drawing.Size(126, 35);
            this.buttonDeleteMedic.TabIndex = 18;
            this.buttonDeleteMedic.Text = "Șterge";
            this.buttonDeleteMedic.UseVisualStyleBackColor = false;
            this.buttonDeleteMedic.Click += new System.EventHandler(this.buttonDeleteMedic_Click);
            // 
            // buttonAddMedic
            // 
            this.buttonAddMedic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddMedic.BackColor = System.Drawing.Color.White;
            this.buttonAddMedic.FlatAppearance.BorderSize = 0;
            this.buttonAddMedic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMedic.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonAddMedic.Location = new System.Drawing.Point(796, 427);
            this.buttonAddMedic.Name = "buttonAddMedic";
            this.buttonAddMedic.Size = new System.Drawing.Size(126, 35);
            this.buttonAddMedic.TabIndex = 17;
            this.buttonAddMedic.Text = "Adaugă";
            this.buttonAddMedic.UseVisualStyleBackColor = false;
            this.buttonAddMedic.Click += new System.EventHandler(this.buttonAddMedic_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(792, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Spitale unde lucrează";
            // 
            // checkedListBoxListSpitale
            // 
            this.checkedListBoxListSpitale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxListSpitale.CheckOnClick = true;
            this.checkedListBoxListSpitale.FormattingEnabled = true;
            this.checkedListBoxListSpitale.Location = new System.Drawing.Point(795, 328);
            this.checkedListBoxListSpitale.Name = "checkedListBoxListSpitale";
            this.checkedListBoxListSpitale.Size = new System.Drawing.Size(250, 46);
            this.checkedListBoxListSpitale.TabIndex = 15;
            // 
            // textBoxNumeMedic
            // 
            this.textBoxNumeMedic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumeMedic.Location = new System.Drawing.Point(891, 55);
            this.textBoxNumeMedic.Name = "textBoxNumeMedic";
            this.textBoxNumeMedic.Size = new System.Drawing.Size(154, 26);
            this.textBoxNumeMedic.TabIndex = 14;
            // 
            // textBoxPrenumeMedic
            // 
            this.textBoxPrenumeMedic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrenumeMedic.Location = new System.Drawing.Point(891, 93);
            this.textBoxPrenumeMedic.Name = "textBoxPrenumeMedic";
            this.textBoxPrenumeMedic.Size = new System.Drawing.Size(154, 26);
            this.textBoxPrenumeMedic.TabIndex = 13;
            // 
            // textBoxEmailMedic
            // 
            this.textBoxEmailMedic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailMedic.Location = new System.Drawing.Point(891, 132);
            this.textBoxEmailMedic.Name = "textBoxEmailMedic";
            this.textBoxEmailMedic.Size = new System.Drawing.Size(154, 26);
            this.textBoxEmailMedic.TabIndex = 12;
            // 
            // textBoxTelefonMedic
            // 
            this.textBoxTelefonMedic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTelefonMedic.Location = new System.Drawing.Point(891, 171);
            this.textBoxTelefonMedic.Name = "textBoxTelefonMedic";
            this.textBoxTelefonMedic.Size = new System.Drawing.Size(154, 26);
            this.textBoxTelefonMedic.TabIndex = 11;
            // 
            // textBoxUsernameMedic
            // 
            this.textBoxUsernameMedic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsernameMedic.Location = new System.Drawing.Point(891, 210);
            this.textBoxUsernameMedic.Name = "textBoxUsernameMedic";
            this.textBoxUsernameMedic.Size = new System.Drawing.Size(154, 26);
            this.textBoxUsernameMedic.TabIndex = 10;
            // 
            // textBoxPasswordMedic
            // 
            this.textBoxPasswordMedic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPasswordMedic.Location = new System.Drawing.Point(891, 249);
            this.textBoxPasswordMedic.Name = "textBoxPasswordMedic";
            this.textBoxPasswordMedic.Size = new System.Drawing.Size(154, 26);
            this.textBoxPasswordMedic.TabIndex = 9;
            // 
            // textBoxCNPMedic
            // 
            this.textBoxCNPMedic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCNPMedic.Location = new System.Drawing.Point(891, 17);
            this.textBoxCNPMedic.Name = "textBoxCNPMedic";
            this.textBoxCNPMedic.Size = new System.Drawing.Size(154, 26);
            this.textBoxCNPMedic.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(791, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(791, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Username";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(791, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(791, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Prenume";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(791, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(791, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nume";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(791, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "CNP";
            // 
            // dataGridViewMedici
            // 
            this.dataGridViewMedici.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewMedici.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedici.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewMedici.Name = "dataGridViewMedici";
            this.dataGridViewMedici.ReadOnly = true;
            this.dataGridViewMedici.Size = new System.Drawing.Size(643, 463);
            this.dataGridViewMedici.TabIndex = 0;
            this.dataGridViewMedici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedici_CellClick);
            this.dataGridViewMedici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedici_CellContentClick);
            // 
            // tabPageSpitale
            // 
            this.tabPageSpitale.BackColor = System.Drawing.Color.Firebrick;
            this.tabPageSpitale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageSpitale.Controls.Add(this.buttonDeleteSpital);
            this.tabPageSpitale.Controls.Add(this.comboBoxCentruT);
            this.tabPageSpitale.Controls.Add(this.labelCentruTransfuzie);
            this.tabPageSpitale.Controls.Add(this.buttonAddSpital);
            this.tabPageSpitale.Controls.Add(this.textBoxAdresaSpital);
            this.tabPageSpitale.Controls.Add(this.comboBoxLocalitateSpital);
            this.tabPageSpitale.Controls.Add(this.comboBoxJudetSpital);
            this.tabPageSpitale.Controls.Add(this.label1);
            this.tabPageSpitale.Controls.Add(this.label2);
            this.tabPageSpitale.Controls.Add(this.label3);
            this.tabPageSpitale.Controls.Add(this.dataGridViewSpitale);
            this.tabPageSpitale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSpitale.Location = new System.Drawing.Point(4, 29);
            this.tabPageSpitale.Name = "tabPageSpitale";
            this.tabPageSpitale.Size = new System.Drawing.Size(1152, 475);
            this.tabPageSpitale.TabIndex = 2;
            this.tabPageSpitale.Text = "Spitale";
            // 
            // buttonDeleteSpital
            // 
            this.buttonDeleteSpital.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteSpital.BackColor = System.Drawing.Color.White;
            this.buttonDeleteSpital.FlatAppearance.BorderSize = 0;
            this.buttonDeleteSpital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSpital.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonDeleteSpital.Location = new System.Drawing.Point(897, 429);
            this.buttonDeleteSpital.Name = "buttonDeleteSpital";
            this.buttonDeleteSpital.Size = new System.Drawing.Size(126, 35);
            this.buttonDeleteSpital.TabIndex = 26;
            this.buttonDeleteSpital.Text = "Șterge";
            this.buttonDeleteSpital.UseVisualStyleBackColor = false;
            this.buttonDeleteSpital.Click += new System.EventHandler(this.buttonDeleteSpital_Click);
            // 
            // comboBoxCentruT
            // 
            this.comboBoxCentruT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCentruT.FormattingEnabled = true;
            this.comboBoxCentruT.Location = new System.Drawing.Point(892, 253);
            this.comboBoxCentruT.Name = "comboBoxCentruT";
            this.comboBoxCentruT.Size = new System.Drawing.Size(197, 28);
            this.comboBoxCentruT.TabIndex = 24;
            // 
            // labelCentruTransfuzie
            // 
            this.labelCentruTransfuzie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCentruTransfuzie.AutoSize = true;
            this.labelCentruTransfuzie.ForeColor = System.Drawing.Color.White;
            this.labelCentruTransfuzie.Location = new System.Drawing.Point(804, 256);
            this.labelCentruTransfuzie.Name = "labelCentruTransfuzie";
            this.labelCentruTransfuzie.Size = new System.Drawing.Size(57, 20);
            this.labelCentruTransfuzie.TabIndex = 23;
            this.labelCentruTransfuzie.Text = "Centru";
            // 
            // buttonAddSpital
            // 
            this.buttonAddSpital.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddSpital.BackColor = System.Drawing.Color.White;
            this.buttonAddSpital.FlatAppearance.BorderSize = 0;
            this.buttonAddSpital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSpital.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonAddSpital.Location = new System.Drawing.Point(813, 429);
            this.buttonAddSpital.Name = "buttonAddSpital";
            this.buttonAddSpital.Size = new System.Drawing.Size(126, 35);
            this.buttonAddSpital.TabIndex = 22;
            this.buttonAddSpital.Text = "Adaugă";
            this.buttonAddSpital.UseVisualStyleBackColor = false;
            this.buttonAddSpital.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAdresaSpital
            // 
            this.textBoxAdresaSpital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdresaSpital.Location = new System.Drawing.Point(892, 85);
            this.textBoxAdresaSpital.Name = "textBoxAdresaSpital";
            this.textBoxAdresaSpital.Size = new System.Drawing.Size(197, 26);
            this.textBoxAdresaSpital.TabIndex = 19;
            // 
            // comboBoxLocalitateSpital
            // 
            this.comboBoxLocalitateSpital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLocalitateSpital.FormattingEnabled = true;
            this.comboBoxLocalitateSpital.Location = new System.Drawing.Point(892, 194);
            this.comboBoxLocalitateSpital.Name = "comboBoxLocalitateSpital";
            this.comboBoxLocalitateSpital.Size = new System.Drawing.Size(197, 28);
            this.comboBoxLocalitateSpital.TabIndex = 21;
            // 
            // comboBoxJudetSpital
            // 
            this.comboBoxJudetSpital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxJudetSpital.FormattingEnabled = true;
            this.comboBoxJudetSpital.Location = new System.Drawing.Point(892, 140);
            this.comboBoxJudetSpital.Name = "comboBoxJudetSpital";
            this.comboBoxJudetSpital.Size = new System.Drawing.Size(197, 28);
            this.comboBoxJudetSpital.TabIndex = 20;
            this.comboBoxJudetSpital.SelectedIndexChanged += new System.EventHandler(this.comboBoxJudetSpital_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(804, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Județ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(804, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Adresă";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(804, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Localitate";
            // 
            // dataGridViewSpitale
            // 
            this.dataGridViewSpitale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewSpitale.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSpitale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpitale.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSpitale.Name = "dataGridViewSpitale";
            this.dataGridViewSpitale.ReadOnly = true;
            this.dataGridViewSpitale.Size = new System.Drawing.Size(640, 465);
            this.dataGridViewSpitale.TabIndex = 0;
            this.dataGridViewSpitale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpitale_CellClick);
            this.dataGridViewSpitale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpitale_CellContentClick);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(1084, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLogout.Size = new System.Drawing.Size(56, 27);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1152, 538);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FormAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPageCentruTransfuzii.ResumeLayout(false);
            this.tabPageCentruTransfuzii.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCentre)).EndInit();
            this.tabPageMedici.ResumeLayout(false);
            this.tabPageMedici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedici)).EndInit();
            this.tabPageSpitale.ResumeLayout(false);
            this.tabPageSpitale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpitale)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.ComboBox comboBoxJudet;
        private System.Windows.Forms.ComboBox comboBoxLocalitate;
        private System.Windows.Forms.DataGridView dataGridViewCentre;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Button buttonAddCentruT;
        private System.Windows.Forms.Button buttonDeleteCentru;
        private System.Windows.Forms.DataGridView dataGridViewSpitale;
        private System.Windows.Forms.ComboBox comboBoxCentruT;
        private System.Windows.Forms.Label labelCentruTransfuzie;
        private System.Windows.Forms.Button buttonAddSpital;
        private System.Windows.Forms.TextBox textBoxAdresaSpital;
        private System.Windows.Forms.ComboBox comboBoxLocalitateSpital;
        private System.Windows.Forms.ComboBox comboBoxJudetSpital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDeleteSpital;
        private System.Windows.Forms.TextBox textBoxNumeMedic;
        private System.Windows.Forms.TextBox textBoxPrenumeMedic;
        private System.Windows.Forms.TextBox textBoxEmailMedic;
        private System.Windows.Forms.TextBox textBoxTelefonMedic;
        private System.Windows.Forms.TextBox textBoxUsernameMedic;
        private System.Windows.Forms.TextBox textBoxPasswordMedic;
        private System.Windows.Forms.TextBox textBoxCNPMedic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewMedici;
        private System.Windows.Forms.Button buttonAddMedic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox checkedListBoxListSpitale;
        private System.Windows.Forms.Button buttonDeleteMedic;
    }
}