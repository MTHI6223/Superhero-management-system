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
                // Clear the current data grid
                dataGridViewHeroes.Rows.Clear();

                // Check if file exists
                if (!System.IO.File.Exists("superheroes.txt"))
                    return;

                // Read all heroes from file
                string[] allHeroes = System.IO.File.ReadAllLines("superheroes.txt");

                // Add each hero to the data grid
                foreach (string heroLine in allHeroes)
                {
                    string[] heroData = heroLine.Split(',');
                    if (heroData.Length >= 7)
                    {
                        dataGridViewHeroes.Rows.Add(heroData[0], heroData[1], heroData[2],
                                                  heroData[3], heroData[4], heroData[5], heroData[6]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading heroes: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
