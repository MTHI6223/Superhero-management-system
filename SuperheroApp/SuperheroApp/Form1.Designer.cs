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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeroId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuperpower = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExamScore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblThreatLevel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.dataGridViewHeroes = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalHeroes = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAvgAge = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAvgScore = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSRank = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblARank = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBRank = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCRank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeroes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUPERHERO MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hero ID:";
            // 
            // txtHeroId
            // 
            this.txtHeroId.Location = new System.Drawing.Point(120, 67);
            this.txtHeroId.Name = "txtHeroId";
            this.txtHeroId.Size = new System.Drawing.Size(150, 20);
            this.txtHeroId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(350, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(120, 107);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(150, 20);
            this.txtAge.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Superpower:";
            // 
            // txtSuperpower
            // 
            this.txtSuperpower.Location = new System.Drawing.Point(380, 107);
            this.txtSuperpower.Name = "txtSuperpower";
            this.txtSuperpower.Size = new System.Drawing.Size(200, 20);
            this.txtSuperpower.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Exam Score:";
            // 
            // txtExamScore
            // 
            this.txtExamScore.Location = new System.Drawing.Point(123, 143);
            this.txtExamScore.Name = "txtExamScore";
            this.txtExamScore.Size = new System.Drawing.Size(78, 20);
            this.txtExamScore.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rank :";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.BackColor = System.Drawing.Color.LightYellow;
            this.lblRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRank.Location = new System.Drawing.Point(340, 147);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(84, 15);
            this.lblRank.TabIndex = 12;
            this.lblRank.Text = "(Auto Calculate)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Threat Level:";
            // 
            // lblThreatLevel
            // 
            this.lblThreatLevel.AutoSize = true;
            this.lblThreatLevel.BackColor = System.Drawing.Color.LightCyan;
            this.lblThreatLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThreatLevel.Location = new System.Drawing.Point(560, 147);
            this.lblThreatLevel.Name = "lblThreatLevel";
            this.lblThreatLevel.Size = new System.Drawing.Size(84, 15);
            this.lblThreatLevel.TabIndex = 14;
            this.lblThreatLevel.Text = "(Auto Calculate)";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Location = new System.Drawing.Point(50, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Hero";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.Location = new System.Drawing.Point(140, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update Hero";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(240, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete Hero";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnReport.Location = new System.Drawing.Point(340, 190);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(120, 30);
            this.btnReport.TabIndex = 18;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dataGridViewHeroes
            // 
            this.dataGridViewHeroes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHeroes.Location = new System.Drawing.Point(50, 240);
            this.dataGridViewHeroes.Name = "dataGridViewHeroes";
            this.dataGridViewHeroes.Size = new System.Drawing.Size(800, 300);
            this.dataGridViewHeroes.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 560);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Summary Report:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 590);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total Heroes:";
            // 
            // lblTotalHeroes
            // 
            this.lblTotalHeroes.AutoSize = true;
            this.lblTotalHeroes.Location = new System.Drawing.Point(130, 590);
            this.lblTotalHeroes.Name = "lblTotalHeroes";
            this.lblTotalHeroes.Size = new System.Drawing.Size(13, 13);
            this.lblTotalHeroes.TabIndex = 22;
            this.lblTotalHeroes.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 590);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Average Age:";
            // 
            // lblAvgAge
            // 
            this.lblAvgAge.AutoSize = true;
            this.lblAvgAge.Location = new System.Drawing.Point(280, 590);
            this.lblAvgAge.Name = "lblAvgAge";
            this.lblAvgAge.Size = new System.Drawing.Size(13, 13);
            this.lblAvgAge.TabIndex = 24;
            this.lblAvgAge.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 590);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Average Score:";
            // 
            // lblAvgScore
            // 
            this.lblAvgScore.AutoSize = true;
            this.lblAvgScore.Location = new System.Drawing.Point(440, 590);
            this.lblAvgScore.Name = "lblAvgScore";
            this.lblAvgScore.Size = new System.Drawing.Size(13, 13);
            this.lblAvgScore.TabIndex = 26;
            this.lblAvgScore.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(541, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 620);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "S-Rank:";
            // 
            // lblSRank
            // 
            this.lblSRank.AutoSize = true;
            this.lblSRank.ForeColor = System.Drawing.Color.Red;
            this.lblSRank.Location = new System.Drawing.Point(100, 620);
            this.lblSRank.Name = "lblSRank";
            this.lblSRank.Size = new System.Drawing.Size(13, 13);
            this.lblSRank.TabIndex = 29;
            this.lblSRank.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(180, 620);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "A-Rank:";
            // 
            // lblARank
            // 
            this.lblARank.AutoSize = true;
            this.lblARank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARank.ForeColor = System.Drawing.Color.Orange;
            this.lblARank.Location = new System.Drawing.Point(230, 620);
            this.lblARank.Name = "lblARank";
            this.lblARank.Size = new System.Drawing.Size(15, 15);
            this.lblARank.TabIndex = 31;
            this.lblARank.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(260, 620);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "B-Rank:";
            // 
            // lblBRank
            // 
            this.lblBRank.AutoSize = true;
            this.lblBRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBRank.ForeColor = System.Drawing.Color.Green;
            this.lblBRank.Location = new System.Drawing.Point(312, 620);
            this.lblBRank.Name = "lblBRank";
            this.lblBRank.Size = new System.Drawing.Size(15, 15);
            this.lblBRank.TabIndex = 33;
            this.lblBRank.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(340, 620);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "C-Rank:";
            // 
            // lblCRank
            // 
            this.lblCRank.AutoSize = true;
            this.lblCRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRank.ForeColor = System.Drawing.Color.Blue;
            this.lblCRank.Location = new System.Drawing.Point(390, 620);
            this.lblCRank.Name = "lblCRank";
            this.lblCRank.Size = new System.Drawing.Size(15, 15);
            this.lblCRank.TabIndex = 35;
            this.lblCRank.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.lblCRank);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblBRank);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblARank);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblSRank);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblAvgScore);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblAvgAge);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotalHeroes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewHeroes);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblThreatLevel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExamScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSuperpower);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeroId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Superhero Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeroes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeroId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSuperpower;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExamScore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblThreatLevel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dataGridViewHeroes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalHeroes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAvgAge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAvgScore;
        private System.Windows.Forms.Label label13;
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

