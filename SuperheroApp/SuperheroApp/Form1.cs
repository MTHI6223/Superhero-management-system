using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperheroApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClearForm();
            RefreshSuperheroList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Check fields filled
            if (string.IsNullOrWhiteSpace(txtHeroId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtSuperpower.Text) ||
                string.IsNullOrWhiteSpace(txtExamScore.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Missing Information",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Is Age and Exam number?
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid number for Age!", "Invalid Age",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtExamScore.Text, out int examScore))
            {
                MessageBox.Show("Please enter a valid number for Exam Score!", "Invalid Score",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Is Exam 0-100
            if (examScore < 0 || examScore > 100)
            {
                MessageBox.Show("Exam Score must be between 0 and 100!", "Invalid Score",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Rank and Threat Level
            string rank = "";
            string threatLevel = "";

            if (examScore >= 81 && examScore <= 100)
            {
                rank = "S-Rank";
                threatLevel = "Finals Week";
            }
            else if (examScore >= 61 && examScore <= 80)
            {
                rank = "A-Rank";
                threatLevel = "Midterm Madness";
            }
            else if (examScore >= 41 && examScore <= 60)
            {
                rank = "B-Rank";
                threatLevel = "Group Project Gone Wrong";
            }
            else
            {
                rank = "C-Rank";
                threatLevel = "Pop Quiz";
            }


            //Show the calculated rank and threat on the form
            lblRank.Text = rank;
            lblThreatLevel.Text = threatLevel;

            //Save the superhero to file
            string heroData = $"{txtHeroId.Text},{txtName.Text},{age},{txtSuperpower.Text},{examScore},{rank},{threatLevel}";

            try
            {
                System.IO.File.AppendAllText("superheroes.txt", heroData + Environment.NewLine);

                
                MessageBox.Show("Superhero added successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                ClearForm();

               
                RefreshSuperheroList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving superhero: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



        private void ClearForm()
        {
            // Clear all textboxes
            txtHeroId.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtSuperpower.Text = "";
            txtExamScore.Text = "";

            // Clear the rank and threat labels
            lblRank.Text = "(Auto Calculate)";
            lblThreatLevel.Text = "(Auto Calculate)";
        }

        private void RefreshSuperheroList()
        {
            try
            {
                
                dataGridViewHeroes.Rows.Clear();

                // Check if file exists
                if (!System.IO.File.Exists("superheroes.txt"))
                    return;

                
                string[] allHeroes = System.IO.File.ReadAllLines("superheroes.txt");

              
                foreach (string heroLine in allHeroes)
                {
                    string[] heroData = heroLine.Split(',');
                    if (heroData.Length >= 7)
                    {
                        
                        dataGridViewHeroes.Rows.Add(
                            heroData[0], // Hero ID
                            heroData[1], // Name
                            heroData[2], // Age
                            heroData[3], // Superpower
                            heroData[4], // Exam Score
                            heroData[5], // Rank
                            heroData[6]  // Threat Level
                        );
                    }
                }

                
                dataGridViewHeroes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading heroes: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if a hero is selected in the grid
            if (dataGridViewHeroes.CurrentRow == null)
            {
                MessageBox.Show("Please select a hero to update from the list!", "No Selection",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtHeroId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtSuperpower.Text) ||
                string.IsNullOrWhiteSpace(txtExamScore.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Missing Information",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || !int.TryParse(txtExamScore.Text, out int examScore))
            {
                MessageBox.Show("Please enter valid numbers for Age and Exam Score!", "Invalid Numbers",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (examScore < 0 || examScore > 100)
            {
                MessageBox.Show("Exam Score must be between 0 and 100!", "Invalid Score",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate new rank and threat
            string rank = "";
            string threatLevel = "";

            if (examScore >= 81 && examScore <= 100)
            {
                rank = "S-Rank";
                threatLevel = "Finals Week";
            }
            else if (examScore >= 61 && examScore <= 80)
            {
                rank = "A-Rank";
                threatLevel = "Midterm Madness";
            }
            else if (examScore >= 41 && examScore <= 60)
            {
                rank = "B-Rank";
                threatLevel = "Group Project Gone Wrong";
            }
            else
            {
                rank = "C-Rank";
                threatLevel = "Pop Quiz";
            }

            
            lblRank.Text = rank;
            lblThreatLevel.Text = threatLevel;

            // Update the data in file
            try
            {
                string[] allHeroes = System.IO.File.ReadAllLines("superheroes.txt");
                int selectedIndex = dataGridViewHeroes.CurrentRow.Index;

                
                string updatedHero = $"{txtHeroId.Text},{txtName.Text},{age},{txtSuperpower.Text},{examScore},{rank},{threatLevel}";
                allHeroes[selectedIndex] = updatedHero;

                
                System.IO.File.WriteAllLines("superheroes.txt", allHeroes);

                MessageBox.Show("Superhero updated successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshSuperheroList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating superhero: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewHeroes.CurrentRow == null)
            {
                MessageBox.Show("Please select a hero to delete from the list!", "No Selection",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this superhero?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string[] allHeroes = System.IO.File.ReadAllLines("superheroes.txt");
                    int selectedIndex = dataGridViewHeroes.CurrentRow.Index;

                    // Create new list without the deleted hero
                    List<string> updatedHeroes = new List<string>();
                    for (int i = 0; i < allHeroes.Length; i++)
                    {
                        if (i != selectedIndex)
                            updatedHeroes.Add(allHeroes[i]);
                    }

                   
                    System.IO.File.WriteAllLines("superheroes.txt", updatedHeroes);

                    MessageBox.Show("Superhero deleted successfully!", "Success",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                    RefreshSuperheroList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting superhero: {ex.Message}", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!System.IO.File.Exists("superheroes.txt"))
                {
                    MessageBox.Show("No superheroes found! Please add some heroes first.",
                                   "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string[] allHeroes = System.IO.File.ReadAllLines("superheroes.txt");

                if (allHeroes.Length == 0)
                {
                    MessageBox.Show("No superheroes found! Please add some heroes first.",
                                   "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

               
                int totalHeroes = allHeroes.Length;
                int totalAge = 0;
                int totalScore = 0;
                int sRankCount = 0, aRankCount = 0, bRankCount = 0, cRankCount = 0;

                
                foreach (string heroLine in allHeroes)
                {
                    string[] heroData = heroLine.Split(',');
                    if (heroData.Length >= 7)
                    {
                       
                        if (int.TryParse(heroData[2], out int age))
                            totalAge += age;
                        if (int.TryParse(heroData[4], out int score))
                            totalScore += score;

                       
                        switch (heroData[5])
                        {
                            case "S-Rank": sRankCount++; break;
                            case "A-Rank": aRankCount++; break;
                            case "B-Rank": bRankCount++; break;
                            case "C-Rank": cRankCount++; break;
                        }
                    }
                }

                
                double avgAge = totalAge / (double)totalHeroes;
                double avgScore = totalScore / (double)totalHeroes;

                // Update the form labels
                lblTotalHeroes.Text = totalHeroes.ToString();
                lblAvgAge.Text = avgAge.ToString("0.00");
                lblAvgScore.Text = avgScore.ToString("0.00");
                lblSRank.Text = sRankCount.ToString();
                lblARank.Text = aRankCount.ToString();
                lblBRank.Text = bRankCount.ToString();
                lblCRank.Text = cRankCount.ToString();

                // Save summary to file
                string summary = $"SUPERHERO SUMMARY REPORT\n" +
                                $"Generated on: {DateTime.Now}\n" +
                                $"Total Heroes: {totalHeroes}\n" +
                                $"Average Age: {avgAge:0.00}\n" +
                                $"Average Exam Score: {avgScore:0.00}\n" +
                                $"Rank Distribution:\n" +
                                $"  S-Rank: {sRankCount} heroes\n" +
                                $"  A-Rank: {aRankCount} heroes\n" +
                                $"  B-Rank: {bRankCount} heroes\n" +
                                $"  C-Rank: {cRankCount} heroes";

                System.IO.File.WriteAllText("summary.txt", summary);

                MessageBox.Show("Report generated successfully!\nSaved to 'summary.txt'",
                               "Report Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewHeroes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridViewHeroes.Rows[e.RowIndex];

                // Fill the form with selected hero's data
                txtHeroId.Text = row.Cells["colHeroId"].Value?.ToString() ?? "";
                txtName.Text = row.Cells["colName"].Value?.ToString() ?? "";
                txtAge.Text = row.Cells["colAge"].Value?.ToString() ?? "";
                txtSuperpower.Text = row.Cells["colSuperpower"].Value?.ToString() ?? "";
                txtExamScore.Text = row.Cells["colExamScore"].Value?.ToString() ?? "";
                lblRank.Text = row.Cells["colRank"].Value?.ToString() ?? "(Auto Calculate)";
                lblThreatLevel.Text = row.Cells["colThreatLevel"].Value?.ToString() ?? "(Auto Calculate)";
            }
        }
    }

    public class Hero
    {
        public string HeroId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Superpower { get; set; }
        public string ExamScore { get; set; }
        public string Rank { get; set; }
        public string ThreatLevel { get; set; }
    }
}


