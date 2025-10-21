using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SuperheroApp.DataLayer
{
    /// <summary>
    /// Database Layer - Handles all file operations for superhero data persistence
    /// This class is responsible for reading from and writing to superheroes.txt and summary.txt files
    /// </summary>
    public class SuperheroDataAccess
    {
        private const string SUPERHEROES_FILE = "superheroes.txt";
        private const string SUMMARY_FILE = "summary.txt";

        /// <summary>
        /// Reads all superhero records from the superheroes.txt file
        /// </summary>
        /// <returns>List of superhero data as string arrays</returns>
        public List<string[]> GetAllSuperheroes()
        {
            try
            {
                // Check if file exists, return empty list if not
                if (!File.Exists(SUPERHEROES_FILE))
                {
                    return new List<string[]>();
                }

                // Read all lines from file and split each line into array
                string[] allLines = File.ReadAllLines(SUPERHEROES_FILE);
                List<string[]> superheroes = new List<string[]>();

                foreach (string line in allLines)
                {
                    // Skip empty lines
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] heroData = line.Split(',');
                        if (heroData.Length >= 7) // Ensure we have all required fields
                        {
                            superheroes.Add(heroData);
                        }
                    }
                }

                return superheroes;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading superhero data: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Appends a new superhero record to the superheroes.txt file
        /// </summary>
        /// <param name="heroData">Comma-separated string of hero data</param>
        public void AddSuperhero(string heroData)
        {
            try
            {
                // Append the new hero data to the file
                File.AppendAllText(SUPERHEROES_FILE, heroData + Environment.NewLine);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding superhero: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Updates a superhero record at the specified index in the superheroes.txt file
        /// </summary>
        /// <param name="index">Index of the record to update</param>
        /// <param name="updatedHeroData">Updated hero data</param>
        public void UpdateSuperhero(int index, string updatedHeroData)
        {
            try
            {
                // Read all current records
                List<string[]> allHeroes = GetAllSuperheroes();
                
                // Check if index is valid
                if (index < 0 || index >= allHeroes.Count)
                {
                    throw new ArgumentException("Invalid superhero index for update");
                }

                // Update the specific record
                string[] heroArray = updatedHeroData.Split(',');
                allHeroes[index] = heroArray;

                // Write all records back to file
                WriteAllSuperheroes(allHeroes);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating superhero: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Deletes a superhero record at the specified index from the superheroes.txt file
        /// </summary>
        /// <param name="index">Index of the record to delete</param>
        public void DeleteSuperhero(int index)
        {
            try
            {
                // Read all current records
                List<string[]> allHeroes = GetAllSuperheroes();
                
                // Check if index is valid
                if (index < 0 || index >= allHeroes.Count)
                {
                    throw new ArgumentException("Invalid superhero index for deletion");
                }

                // Remove the record at the specified index
                allHeroes.RemoveAt(index);

                // Write remaining records back to file
                WriteAllSuperheroes(allHeroes);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting superhero: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Writes all superhero records to the superheroes.txt file
        /// </summary>
        /// <param name="superheroes">List of superhero data arrays</param>
        private void WriteAllSuperheroes(List<string[]> superheroes)
        {
            try
            {
                // Convert arrays back to comma-separated strings
                List<string> lines = new List<string>();
                foreach (string[] heroData in superheroes)
                {
                    lines.Add(string.Join(",", heroData));
                }

                // Write all lines to file
                File.WriteAllLines(SUPERHEROES_FILE, lines);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error writing superhero data: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Saves summary report to the summary.txt file
        /// </summary>
        /// <param name="summaryContent">Formatted summary content to save</param>
        public void SaveSummary(string summaryContent)
        {
            try
            {
                File.WriteAllText(SUMMARY_FILE, summaryContent);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving summary: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Checks if the superheroes file exists
        /// </summary>
        /// <returns>True if file exists, false otherwise</returns>
        public bool SuperheroesFileExists()
        {
            return File.Exists(SUPERHEROES_FILE);
        }

        /// <summary>
        /// Gets the count of superhero records in the file
        /// </summary>
        /// <returns>Number of superhero records</returns>
        public int GetSuperheroCount()
        {
            try
            {
                List<string[]> superheroes = GetAllSuperheroes();
                return superheroes.Count;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting superhero count: {ex.Message}", ex);
            }
        }
    }
}
