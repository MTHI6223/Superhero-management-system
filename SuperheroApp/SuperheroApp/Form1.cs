using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperheroApp.BusinessLayer;

namespace SuperheroApp
{
    /// <summary>
    /// Application Layer - Main form for the Superhero Management System
    /// This class handles user interface interactions and delegates business logic to the Business Layer
    /// </summary>
    public partial class Form1 : Form
    {
        private SuperheroBusinessLogic _businessLogic;

        public Form1()
        {
            InitializeComponent();
            _businessLogic = new SuperheroBusinessLogic();
            ClearForm();
            RefreshSuperheroList();
        }

        /// <summary>
        /// Handles the Add Hero button click event
        /// Delegates validation and business logic to the Business Layer
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Delegate to business layer for validation and processing
                OperationResult result = _businessLogic.AddSuperhero(
                    txtHeroId.Text,
                    txtName.Text,
                    txtAge.Text,
                    txtSuperpower.Text,
                    txtExamScore.Text
                );

                if (result.Success)
                {
                    // Calculate and display rank and threat level for user feedback
                    if (int.TryParse(txtExamScore.Text, out int examScore))
                    {
                        lblRank.Text = _businessLogic.CalculateRank(examScore);
                        lblThreatLevel.Text = _businessLogic.CalculateThreatLevel(examScore);
                    }

                    MessageBox.Show(result.Message, "Success",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                    RefreshSuperheroList();
                }
                else
                {
                    MessageBox.Show(result.Message, "Validation Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding superhero: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Clears all form fields and resets labels to default values
        /// </summary>
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

        /// <summary>
        /// Refreshes the DataGridView with current superhero data from the Business Layer
        /// </summary>
        private void RefreshSuperheroList()
        {
            try
            {
                // Clear existing rows
                dataGridViewHeroes.Rows.Clear();

                // Get all superheroes from business layer
                List<string[]> allHeroes = _businessLogic.GetAllSuperheroes();

                // Populate DataGridView with superhero data
                foreach (string[] heroData in allHeroes)
                {
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

                // Auto-resize columns for better display
                dataGridViewHeroes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading heroes: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Update Hero button click event
        /// Delegates validation and business logic to the Business Layer
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a hero is selected in the grid
                if (dataGridViewHeroes.CurrentRow == null)
                {
                    MessageBox.Show("Please select a hero to update from the list!", "No Selection",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected row index
                int selectedIndex = dataGridViewHeroes.CurrentRow.Index;

                // Delegate to business layer for validation and processing
                OperationResult result = _businessLogic.UpdateSuperhero(
                    selectedIndex,
                    txtHeroId.Text,
                    txtName.Text,
                    txtAge.Text,
                    txtSuperpower.Text,
                    txtExamScore.Text
                );

                if (result.Success)
                {
                    // Calculate and display rank and threat level for user feedback
                    if (int.TryParse(txtExamScore.Text, out int examScore))
                    {
                        lblRank.Text = _businessLogic.CalculateRank(examScore);
                        lblThreatLevel.Text = _businessLogic.CalculateThreatLevel(examScore);
                    }

                    MessageBox.Show(result.Message, "Success",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshSuperheroList();
                }
                else
                {
                    MessageBox.Show(result.Message, "Validation Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating superhero: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Delete Hero button click event
        /// Delegates deletion logic to the Business Layer
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a hero is selected in the grid
                if (dataGridViewHeroes.CurrentRow == null)
                {
                    MessageBox.Show("Please select a hero to delete from the list!", "No Selection",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this superhero?",
                                                            "Confirm Delete",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Get the selected row index
                    int selectedIndex = dataGridViewHeroes.CurrentRow.Index;

                    // Delegate to business layer for deletion
                    OperationResult result = _businessLogic.DeleteSuperhero(selectedIndex);

                    if (result.Success)
                    {
                        MessageBox.Show(result.Message, "Success",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                        RefreshSuperheroList();
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Error",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting superhero: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Generate Report button click event
        /// Delegates summary calculation and file operations to the Business Layer
        /// </summary>
        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there are any superheroes
                List<string[]> allHeroes = _businessLogic.GetAllSuperheroes();
                if (allHeroes.Count == 0)
                {
                    MessageBox.Show("No superheroes found! Please add some heroes first.",
                                   "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Generate summary statistics using business layer
                SummaryStatistics summary = _businessLogic.GenerateSummary();

                // Update the form labels with calculated statistics
                lblTotalHeroes.Text = summary.TotalHeroes.ToString();
                lblAvgAge.Text = summary.AverageAge.ToString("0.00");
                lblAvgScore.Text = summary.AverageScore.ToString("0.00");
                lblSRank.Text = summary.SRankCount.ToString();
                lblARank.Text = summary.ARankCount.ToString();
                lblBRank.Text = summary.BRankCount.ToString();
                lblCRank.Text = summary.CRankCount.ToString();

                // Save summary to file using business layer
                _businessLogic.SaveSummaryToFile(summary);

                MessageBox.Show("Report generated successfully!\nSaved to 'summary.txt'",
                               "Report Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Handles the DataGridView cell click event to populate form fields for editing
        /// </summary>
        private void dataGridViewHeroes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridViewHeroes.Rows[e.RowIndex];

                // Fill the form with selected hero's data for editing
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
}


