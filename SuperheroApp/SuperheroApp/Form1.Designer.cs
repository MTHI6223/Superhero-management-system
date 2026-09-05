namespace SuperheroApp
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBurst = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeaderInner = new System.Windows.Forms.Panel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.pnlInputInner = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblThreatLevel = new System.Windows.Forms.Label();
            this.labelThreatLevel = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.labelRank = new System.Windows.Forms.Label();
            this.txtExamScore = new System.Windows.Forms.TextBox();
            this.labelExamScore = new System.Windows.Forms.Label();
            this.txtSuperpower = new System.Windows.Forms.TextBox();
            this.labelSuperpower = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtHeroId = new System.Windows.Forms.TextBox();
            this.labelHeroId = new System.Windows.Forms.Label();
            this.pnlInputTitle = new System.Windows.Forms.Panel();
            this.lblInputTitle = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dataGridViewHeroes = new System.Windows.Forms.DataGridView();
            this.colHeroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuperpower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExamScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThreatLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.pnlSummaryInner = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalHeroes = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAvgAge = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAvgScore = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSRank = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblARank = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBRank = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCRank = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderInner.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlInputInner.SuspendLayout();
            this.pnlInputTitle.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeroes)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.pnlSummaryInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlHeader.Controls.Add(this.pnlHeaderInner);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(940, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlHeaderInner
            // 
            this.pnlHeaderInner.BackColor = SuperheroApp.UITheme.Red;
            this.pnlHeaderInner.Controls.Add(this.pnlBurst);
            this.pnlHeaderInner.Controls.Add(this.lblSubtitle);
            this.pnlHeaderInner.Controls.Add(this.lblTitle);
            this.pnlHeaderInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderInner.ForeColor = System.Drawing.Color.White;
            this.pnlHeaderInner.Location = new System.Drawing.Point(4, 4);
            this.pnlHeaderInner.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeaderInner.Name = "pnlHeaderInner";
            this.pnlHeaderInner.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeaderInner.Size = new System.Drawing.Size(932, 92);
            this.pnlHeaderInner.TabIndex = 0;
            // 
            // pnlBurst
            // 
            this.pnlBurst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBurst.BackColor = SuperheroApp.UITheme.Red;
            this.pnlBurst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBurst.Location = new System.Drawing.Point(844, 7);
            this.pnlBurst.Name = "pnlBurst";
            this.pnlBurst.Size = new System.Drawing.Size(78, 78);
            this.pnlBurst.TabIndex = 2;
            this.pnlBurst.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBurst_Paint);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = SuperheroApp.UITheme.Red;
            this.lblSubtitle.Font = SuperheroApp.UITheme.SubHeaderFont;
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(28, 62);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(285, 16);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "THE ULTIMATE HERO DATABASE - RECRUIT, RANK & REPORT";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = SuperheroApp.UITheme.Red;
            this.lblTitle.Font = SuperheroApp.UITheme.HeaderFont;
            this.lblTitle.ForeColor = SuperheroApp.UITheme.Gold;
            this.lblTitle.Location = new System.Drawing.Point(24, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SUPERHERO HQ";
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlInput.Controls.Add(this.pnlInputInner);
            this.pnlInput.Location = new System.Drawing.Point(20, 112);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(900, 258);
            this.pnlInput.TabIndex = 1;
            // 
            // pnlInputInner
            // 
            this.pnlInputInner.BackColor = SuperheroApp.UITheme.White;
            this.pnlInputInner.Controls.Add(this.btnReport);
            this.pnlInputInner.Controls.Add(this.btnDelete);
            this.pnlInputInner.Controls.Add(this.btnUpdate);
            this.pnlInputInner.Controls.Add(this.btnAdd);
            this.pnlInputInner.Controls.Add(this.lblThreatLevel);
            this.pnlInputInner.Controls.Add(this.labelThreatLevel);
            this.pnlInputInner.Controls.Add(this.lblRank);
            this.pnlInputInner.Controls.Add(this.labelRank);
            this.pnlInputInner.Controls.Add(this.txtExamScore);
            this.pnlInputInner.Controls.Add(this.labelExamScore);
            this.pnlInputInner.Controls.Add(this.txtSuperpower);
            this.pnlInputInner.Controls.Add(this.labelSuperpower);
            this.pnlInputInner.Controls.Add(this.txtAge);
            this.pnlInputInner.Controls.Add(this.labelAge);
            this.pnlInputInner.Controls.Add(this.txtName);
            this.pnlInputInner.Controls.Add(this.labelName);
            this.pnlInputInner.Controls.Add(this.txtHeroId);
            this.pnlInputInner.Controls.Add(this.labelHeroId);
            this.pnlInputInner.Controls.Add(this.pnlInputTitle);
            this.pnlInputInner.Location = new System.Drawing.Point(3, 3);
            this.pnlInputInner.Name = "pnlInputInner";
            this.pnlInputInner.Size = new System.Drawing.Size(894, 252);
            this.pnlInputInner.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = SuperheroApp.UITheme.Green;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReport.FlatAppearance.BorderSize = 2;
            this.btnReport.FlatAppearance.MouseDownBackColor = SuperheroApp.UITheme.GreenDark;
            this.btnReport.FlatAppearance.MouseOverBackColor = SuperheroApp.UITheme.GreenDark;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = SuperheroApp.UITheme.ComicFont;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(506, 196);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(180, 42);
            this.btnReport.TabIndex = 18;
            this.btnReport.Text = "GENERATE REPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = SuperheroApp.UITheme.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseDownBackColor = SuperheroApp.UITheme.RedDark;
            this.btnDelete.FlatAppearance.MouseOverBackColor = SuperheroApp.UITheme.RedDark;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = SuperheroApp.UITheme.ComicFont;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(344, 196);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = SuperheroApp.UITheme.Blue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = SuperheroApp.UITheme.BlueDark;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = SuperheroApp.UITheme.BlueDark;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = SuperheroApp.UITheme.ComicFont;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(182, 196);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 42);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = SuperheroApp.UITheme.Gold;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseDownBackColor = SuperheroApp.UITheme.GoldDark;
            this.btnAdd.FlatAppearance.MouseOverBackColor = SuperheroApp.UITheme.GoldDark;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = SuperheroApp.UITheme.ComicFont;
            this.btnAdd.ForeColor = SuperheroApp.UITheme.Ink;
            this.btnAdd.Location = new System.Drawing.Point(20, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 42);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "ADD HERO";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblThreatLevel
            // 
            this.lblThreatLevel.BackColor = SuperheroApp.UITheme.AltRow;
            this.lblThreatLevel.Font = SuperheroApp.UITheme.LabelFont;
            this.lblThreatLevel.ForeColor = SuperheroApp.UITheme.Ink;
            this.lblThreatLevel.Location = new System.Drawing.Point(690, 139);
            this.lblThreatLevel.Name = "lblThreatLevel";
            this.lblThreatLevel.Size = new System.Drawing.Size(170, 26);
            this.lblThreatLevel.TabIndex = 14;
            this.lblThreatLevel.Text = "(Auto Calculate)";
            this.lblThreatLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThreatLevel
            // 
            this.labelThreatLevel.AutoSize = true;
            this.labelThreatLevel.BackColor = SuperheroApp.UITheme.White;
            this.labelThreatLevel.Font = SuperheroApp.UITheme.LabelFont;
            this.labelThreatLevel.ForeColor = SuperheroApp.UITheme.Ink;
            this.labelThreatLevel.Location = new System.Drawing.Point(590, 145);
            this.labelThreatLevel.Name = "labelThreatLevel";
            this.labelThreatLevel.Size = new System.Drawing.Size(91, 15);
            this.labelThreatLevel.TabIndex = 13;
            this.labelThreatLevel.Text = "Threat Level:";
            // 
            // lblRank
            // 
            this.lblRank.BackColor = SuperheroApp.UITheme.Gold;
            this.lblRank.Font = SuperheroApp.UITheme.LabelFont;
            this.lblRank.ForeColor = SuperheroApp.UITheme.Ink;
            this.lblRank.Location = new System.Drawing.Point(470, 139);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(110, 26);
            this.lblRank.TabIndex = 12;
            this.lblRank.Text = "(Auto Calculate)";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.BackColor = SuperheroApp.UITheme.White;
            this.labelRank.Font = SuperheroApp.UITheme.LabelFont;
            this.labelRank.ForeColor = SuperheroApp.UITheme.Ink;
            this.labelRank.Location = new System.Drawing.Point(400, 145);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(43, 15);
            this.labelRank.TabIndex = 11;
            this.labelRank.Text = "Rank:";
            // 
            // txtExamScore
            // 
            this.txtExamScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExamScore.Font = SuperheroApp.UITheme.GridFont;
            this.txtExamScore.Location = new System.Drawing.Point(115, 140);
            this.txtExamScore.Name = "txtExamScore";
            this.txtExamScore.Size = new System.Drawing.Size(200, 23);
            this.txtExamScore.TabIndex = 10;
            // 
            // labelExamScore
            // 
            this.labelExamScore.AutoSize = true;
            this.labelExamScore.BackColor = SuperheroApp.UITheme.White;
            this.labelExamScore.Font = SuperheroApp.UITheme.LabelFont;
            this.labelExamScore.ForeColor = SuperheroApp.UITheme.Ink;
            this.labelExamScore.Location = new System.Drawing.Point(20, 144);
            this.labelExamScore.Name = "labelExamScore";
            this.labelExamScore.Size = new System.Drawing.Size(78, 15);
            this.labelExamScore.TabIndex = 9;
            this.labelExamScore.Text = "Exam Score:";
            // 
            // txtSuperpower
            // 
            this.txtSuperpower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuperpower.Font = SuperheroApp.UITheme.GridFont;
            this.txtSuperpower.Location = new System.Drawing.Point(495, 96);
            this.txtSuperpower.Name = "txtSuperpower";
            this.txtSuperpower.Size = new System.Drawing.Size(210, 23);
            this.txtSuperpower.TabIndex = 8;
            // 
            // labelSuperpower
            // 
            this.labelSuperpower.AutoSize = true;
            this.labelSuperpower.BackColor = SuperheroApp.UITheme.White;
            this.labelSuperpower.Font = SuperheroApp.UITheme.LabelFont;
            this.labelSuperpower.ForeColor = SuperheroApp.UITheme.Ink;
            this.labelSuperpower.Location = new System.Drawing.Point(400, 100);
            this.labelSuperpower.Name = "labelSuperpower";
            this.labelSuperpower.Size = new System.Drawing.Size(86, 15);
            this.labelSuperpower.TabIndex = 7;
            this.labelSuperpower.Text = "Superpower:";
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = SuperheroApp.UITheme.GridFont;
            this.txtAge.Location = new System.Drawing.Point(115, 96);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 23);
            this.txtAge.TabIndex = 6;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = SuperheroApp.UITheme.White;
            this.labelAge.Font = SuperheroApp.UITheme.LabelFont;
            this.labelAge.ForeColor = SuperheroApp.UITheme.Ink;
            this.labelAge.Location = new System.Drawing.Point(20, 100);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 15);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Age:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = SuperheroApp.UITheme.GridFont;
            this.txtName.Location = new System.Drawing.Point(495, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 23);
            this.txtName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = SuperheroApp.UITheme.White;
            this.labelName.Font = SuperheroApp.UITheme.LabelFont;
            this.labelName.ForeColor = SuperheroApp.UITheme.Ink;
            this.labelName.Location = new System.Drawing.Point(400, 56);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 15);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";
            // 
            // txtHeroId
            // 
            this.txtHeroId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeroId.Font = SuperheroApp.UITheme.GridFont;
            this.txtHeroId.Location = new System.Drawing.Point(115, 52);
            this.txtHeroId.Name = "txtHeroId";
            this.txtHeroId.Size = new System.Drawing.Size(200, 23);
            this.txtHeroId.TabIndex = 2;
            // 
            // labelHeroId
            // 
            this.labelHeroId.AutoSize = true;
            this.labelHeroId.BackColor = SuperheroApp.UITheme.White;
            this.labelHeroId.Font = SuperheroApp.UITheme.LabelFont;
            this.labelHeroId.ForeColor = SuperheroApp.UITheme.Ink;
            this.labelHeroId.Location = new System.Drawing.Point(20, 56);
            this.labelHeroId.Name = "labelHeroId";
            this.labelHeroId.Size = new System.Drawing.Size(56, 15);
            this.labelHeroId.TabIndex = 1;
            this.labelHeroId.Text = "Hero ID:";
            // 
            // pnlInputTitle
            // 
            this.pnlInputTitle.BackColor = SuperheroApp.UITheme.Blue;
            this.pnlInputTitle.Controls.Add(this.lblInputTitle);
            this.pnlInputTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInputTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlInputTitle.Name = "pnlInputTitle";
            this.pnlInputTitle.Size = new System.Drawing.Size(894, 34);
            this.pnlInputTitle.TabIndex = 0;
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.AutoSize = true;
            this.lblInputTitle.BackColor = SuperheroApp.UITheme.Blue;
            this.lblInputTitle.Font = SuperheroApp.UITheme.ComicFont;
            this.lblInputTitle.ForeColor = System.Drawing.Color.White;
            this.lblInputTitle.Location = new System.Drawing.Point(14, 8);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(150, 17);
            this.lblInputTitle.TabIndex = 0;
            this.lblInputTitle.Text = "RECRUIT A HERO";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlGrid.Controls.Add(this.dataGridViewHeroes);
            this.pnlGrid.Location = new System.Drawing.Point(20, 382);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(900, 236);
            this.pnlGrid.TabIndex = 2;
            // 
            // dataGridViewHeroes
            // 
            this.dataGridViewHeroes.AllowUserToAddRows = false;
            this.dataGridViewHeroes.AllowUserToDeleteRows = false;
            this.dataGridViewHeroes.AlternatingRowsDefaultCellStyle.BackColor = SuperheroApp.UITheme.AltRow;
            this.dataGridViewHeroes.BackgroundColor = SuperheroApp.UITheme.White;
            this.dataGridViewHeroes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHeroes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewHeroes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewHeroes.ColumnHeadersDefaultCellStyle.BackColor = SuperheroApp.UITheme.Red;
            this.dataGridViewHeroes.ColumnHeadersDefaultCellStyle.Font = SuperheroApp.UITheme.ComicFont;
            this.dataGridViewHeroes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewHeroes.ColumnHeadersDefaultCellStyle.SelectionBackColor = SuperheroApp.UITheme.Red;
            this.dataGridViewHeroes.ColumnHeadersHeight = 34;
            this.dataGridViewHeroes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHeroId,
            this.colName,
            this.colAge,
            this.colSuperpower,
            this.colExamScore,
            this.colRank,
            this.colThreatLevel});
            this.dataGridViewHeroes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHeroes.EnableHeadersVisualStyles = false;
            this.dataGridViewHeroes.GridColor = SuperheroApp.UITheme.GridLine;
            this.dataGridViewHeroes.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewHeroes.MultiSelect = false;
            this.dataGridViewHeroes.Name = "dataGridViewHeroes";
            this.dataGridViewHeroes.ReadOnly = true;
            this.dataGridViewHeroes.RowHeadersVisible = false;
            this.dataGridViewHeroes.RowTemplate.DefaultCellStyle.Font = SuperheroApp.UITheme.GridFont;
            this.dataGridViewHeroes.RowTemplate.DefaultCellStyle.SelectionBackColor = SuperheroApp.UITheme.SelectionGold;
            this.dataGridViewHeroes.RowTemplate.DefaultCellStyle.SelectionForeColor = SuperheroApp.UITheme.Ink;
            this.dataGridViewHeroes.RowTemplate.Height = 30;
            this.dataGridViewHeroes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHeroes.Size = new System.Drawing.Size(894, 230);
            this.dataGridViewHeroes.TabIndex = 0;
            this.dataGridViewHeroes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHeroes_CellClick);
            this.dataGridViewHeroes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewHeroes_CellFormatting);
            // 
            // colHeroId
            // 
            this.colHeroId.HeaderText = "Hero ID";
            this.colHeroId.Name = "colHeroId";
            this.colHeroId.Width = 120;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 160;
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Width = 60;
            // 
            // colSuperpower
            // 
            this.colSuperpower.HeaderText = "Superpower";
            this.colSuperpower.Name = "colSuperpower";
            this.colSuperpower.Width = 180;
            // 
            // colExamScore
            // 
            this.colExamScore.HeaderText = "Exam Score";
            this.colExamScore.Name = "colExamScore";
            this.colExamScore.Width = 100;
            // 
            // colRank
            // 
            this.colRank.HeaderText = "Rank";
            this.colRank.Name = "colRank";
            this.colRank.Width = 110;
            // 
            // colThreatLevel
            // 
            this.colThreatLevel.HeaderText = "Threat Level";
            this.colThreatLevel.Name = "colThreatLevel";
            this.colThreatLevel.Width = 160;
            // 
            // pnlSummary
            // 
            this.pnlSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlSummary.Controls.Add(this.pnlSummaryInner);
            this.pnlSummary.Location = new System.Drawing.Point(20, 630);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(900, 56);
            this.pnlSummary.TabIndex = 3;
            // 
            // pnlSummaryInner
            // 
            this.pnlSummaryInner.BackColor = SuperheroApp.UITheme.White;
            this.pnlSummaryInner.Controls.Add(this.label9);
            this.pnlSummaryInner.Controls.Add(this.label10);
            this.pnlSummaryInner.Controls.Add(this.lblTotalHeroes);
            this.pnlSummaryInner.Controls.Add(this.label11);
            this.pnlSummaryInner.Controls.Add(this.lblAvgAge);
            this.pnlSummaryInner.Controls.Add(this.label12);
            this.pnlSummaryInner.Controls.Add(this.lblAvgScore);
            this.pnlSummaryInner.Controls.Add(this.label14);
            this.pnlSummaryInner.Controls.Add(this.lblSRank);
            this.pnlSummaryInner.Controls.Add(this.label15);
            this.pnlSummaryInner.Controls.Add(this.lblARank);
            this.pnlSummaryInner.Controls.Add(this.label16);
            this.pnlSummaryInner.Controls.Add(this.lblBRank);
            this.pnlSummaryInner.Controls.Add(this.label17);
            this.pnlSummaryInner.Controls.Add(this.lblCRank);
            this.pnlSummaryInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSummaryInner.Location = new System.Drawing.Point(3, 3);
            this.pnlSummaryInner.Name = "pnlSummaryInner";
            this.pnlSummaryInner.Size = new System.Drawing.Size(894, 50);
            this.pnlSummaryInner.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = SuperheroApp.UITheme.White;
            this.label9.Font = SuperheroApp.UITheme.ComicFont;
            this.label9.ForeColor = SuperheroApp.UITheme.Blue;
            this.label9.Location = new System.Drawing.Point(16, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "ROSTER SUMMARY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = SuperheroApp.UITheme.White;
            this.label10.Font = SuperheroApp.UITheme.LabelFont;
            this.label10.ForeColor = SuperheroApp.UITheme.BlueDark;
            this.label10.Location = new System.Drawing.Point(200, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Heroes:";
            // 
            // lblTotalHeroes
            // 
            this.lblTotalHeroes.AutoSize = true;
            this.lblTotalHeroes.BackColor = SuperheroApp.UITheme.White;
            this.lblTotalHeroes.Font = SuperheroApp.UITheme.ComicFont;
            this.lblTotalHeroes.ForeColor = SuperheroApp.UITheme.Blue;
            this.lblTotalHeroes.Location = new System.Drawing.Point(258, 16);
            this.lblTotalHeroes.Name = "lblTotalHeroes";
            this.lblTotalHeroes.Size = new System.Drawing.Size(16, 17);
            this.lblTotalHeroes.TabIndex = 2;
            this.lblTotalHeroes.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = SuperheroApp.UITheme.White;
            this.label11.Font = SuperheroApp.UITheme.LabelFont;
            this.label11.ForeColor = SuperheroApp.UITheme.BlueDark;
            this.label11.Location = new System.Drawing.Point(320, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Avg Age:";
            // 
            // lblAvgAge
            // 
            this.lblAvgAge.AutoSize = true;
            this.lblAvgAge.BackColor = SuperheroApp.UITheme.White;
            this.lblAvgAge.Font = SuperheroApp.UITheme.ComicFont;
            this.lblAvgAge.ForeColor = SuperheroApp.UITheme.Blue;
            this.lblAvgAge.Location = new System.Drawing.Point(392, 16);
            this.lblAvgAge.Name = "lblAvgAge";
            this.lblAvgAge.Size = new System.Drawing.Size(16, 17);
            this.lblAvgAge.TabIndex = 4;
            this.lblAvgAge.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = SuperheroApp.UITheme.White;
            this.label12.Font = SuperheroApp.UITheme.LabelFont;
            this.label12.ForeColor = SuperheroApp.UITheme.BlueDark;
            this.label12.Location = new System.Drawing.Point(470, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Avg Score:";
            // 
            // lblAvgScore
            // 
            this.lblAvgScore.AutoSize = true;
            this.lblAvgScore.BackColor = SuperheroApp.UITheme.White;
            this.lblAvgScore.Font = SuperheroApp.UITheme.ComicFont;
            this.lblAvgScore.ForeColor = SuperheroApp.UITheme.Blue;
            this.lblAvgScore.Location = new System.Drawing.Point(551, 16);
            this.lblAvgScore.Name = "lblAvgScore";
            this.lblAvgScore.Size = new System.Drawing.Size(16, 17);
            this.lblAvgScore.TabIndex = 6;
            this.lblAvgScore.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = SuperheroApp.UITheme.White;
            this.label14.Font = SuperheroApp.UITheme.LabelFont;
            this.label14.ForeColor = SuperheroApp.UITheme.Red;
            this.label14.Location = new System.Drawing.Point(610, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "S:";
            // 
            // lblSRank
            // 
            this.lblSRank.AutoSize = true;
            this.lblSRank.BackColor = SuperheroApp.UITheme.White;
            this.lblSRank.Font = SuperheroApp.UITheme.ComicFont;
            this.lblSRank.ForeColor = SuperheroApp.UITheme.Red;
            this.lblSRank.Location = new System.Drawing.Point(636, 16);
            this.lblSRank.Name = "lblSRank";
            this.lblSRank.Size = new System.Drawing.Size(16, 17);
            this.lblSRank.TabIndex = 8;
            this.lblSRank.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = SuperheroApp.UITheme.White;
            this.label15.Font = SuperheroApp.UITheme.LabelFont;
            this.label15.ForeColor = SuperheroApp.UITheme.Orange;
            this.label15.Location = new System.Drawing.Point(680, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "A:";
            // 
            // lblARank
            // 
            this.lblARank.AutoSize = true;
            this.lblARank.BackColor = SuperheroApp.UITheme.White;
            this.lblARank.Font = SuperheroApp.UITheme.ComicFont;
            this.lblARank.ForeColor = SuperheroApp.UITheme.Orange;
            this.lblARank.Location = new System.Drawing.Point(706, 16);
            this.lblARank.Name = "lblARank";
            this.lblARank.Size = new System.Drawing.Size(16, 17);
            this.lblARank.TabIndex = 10;
            this.lblARank.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = SuperheroApp.UITheme.White;
            this.label16.Font = SuperheroApp.UITheme.LabelFont;
            this.label16.ForeColor = SuperheroApp.UITheme.GreenDark;
            this.label16.Location = new System.Drawing.Point(750, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "B:";
            // 
            // lblBRank
            // 
            this.lblBRank.AutoSize = true;
            this.lblBRank.BackColor = SuperheroApp.UITheme.White;
            this.lblBRank.Font = SuperheroApp.UITheme.ComicFont;
            this.lblBRank.ForeColor = SuperheroApp.UITheme.GreenDark;
            this.lblBRank.Location = new System.Drawing.Point(776, 16);
            this.lblBRank.Name = "lblBRank";
            this.lblBRank.Size = new System.Drawing.Size(16, 17);
            this.lblBRank.TabIndex = 12;
            this.lblBRank.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = SuperheroApp.UITheme.White;
            this.label17.Font = SuperheroApp.UITheme.LabelFont;
            this.label17.ForeColor = SuperheroApp.UITheme.Blue;
            this.label17.Location = new System.Drawing.Point(820, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 15);
            this.label17.TabIndex = 13;
            this.label17.Text = "C:";
            // 
            // lblCRank
            // 
            this.lblCRank.AutoSize = true;
            this.lblCRank.BackColor = SuperheroApp.UITheme.White;
            this.lblCRank.Font = SuperheroApp.UITheme.ComicFont;
            this.lblCRank.ForeColor = SuperheroApp.UITheme.Blue;
            this.lblCRank.Location = new System.Drawing.Point(846, 16);
            this.lblCRank.Name = "lblCRank";
            this.lblCRank.Size = new System.Drawing.Size(16, 17);
            this.lblCRank.TabIndex = 14;
            this.lblCRank.Text = "0";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = SuperheroApp.UITheme.Paper;
            this.ClientSize = new System.Drawing.Size(940, 694);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(940, 694);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Superhero HQ - Management System";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeaderInner.ResumeLayout(false);
            this.pnlHeaderInner.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInputInner.ResumeLayout(false);
            this.pnlInputInner.PerformLayout();
            this.pnlInputTitle.ResumeLayout(false);
            this.pnlInputTitle.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeroes)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummaryInner.ResumeLayout(false);
            this.pnlSummaryInner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderInner;
        private System.Windows.Forms.Panel pnlBurst;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlInputInner;
        private System.Windows.Forms.Panel pnlInputTitle;
        private System.Windows.Forms.Label lblInputTitle;
        private System.Windows.Forms.Label labelHeroId;
        private System.Windows.Forms.TextBox txtHeroId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label labelSuperpower;
        private System.Windows.Forms.TextBox txtSuperpower;
        private System.Windows.Forms.Label labelExamScore;
        private System.Windows.Forms.TextBox txtExamScore;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label labelThreatLevel;
        private System.Windows.Forms.Label lblThreatLevel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dataGridViewHeroes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuperpower;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThreatLevel;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel pnlSummaryInner;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalHeroes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAvgAge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAvgScore;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSRank;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblARank;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBRank;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCRank;
    }
}