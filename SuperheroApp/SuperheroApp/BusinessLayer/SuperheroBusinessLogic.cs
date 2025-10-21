using System;
using System.Collections.Generic;
using System.Linq;
using SuperheroApp.DataLayer;

namespace SuperheroApp.BusinessLayer
{
    /// <summary>
    /// Business Layer - Contains all business logic, validation rules, and calculations
    /// This class handles data validation, rank calculations, and summary statistics
    /// </summary>
    public class SuperheroBusinessLogic
    {
        private readonly SuperheroDataAccess _dataAccess;

        public SuperheroBusinessLogic()
        {
            _dataAccess = new SuperheroDataAccess();
        }

        /// <summary>
        /// Validates superhero input data according to business rules
        /// </summary>
        /// <param name="heroId">Hero ID to validate</param>
        /// <param name="name">Hero name to validate</param>
        /// <param name="age">Hero age to validate</param>
        /// <param name="superpower">Hero superpower to validate</param>
        /// <param name="examScore">Hero exam score to validate</param>
        /// <returns>Validation result with error message if invalid</returns>
        public ValidationResult ValidateSuperheroData(string heroId, string name, string age, string superpower, string examScore)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(heroId))
                return new ValidationResult(false, "Hero ID cannot be empty");
            
            if (string.IsNullOrWhiteSpace(name))
                return new ValidationResult(false, "Name cannot be empty");
            
            if (string.IsNullOrWhiteSpace(age))
                return new ValidationResult(false, "Age cannot be empty");
            
            if (string.IsNullOrWhiteSpace(superpower))
                return new ValidationResult(false, "Superpower cannot be empty");
            
            if (string.IsNullOrWhiteSpace(examScore))
                return new ValidationResult(false, "Exam Score cannot be empty");

            // Validate age is a number
            if (!int.TryParse(age, out int ageValue))
                return new ValidationResult(false, "Age must be a valid number");

            // Validate exam score is a number
            if (!int.TryParse(examScore, out int scoreValue))
                return new ValidationResult(false, "Exam Score must be a valid number");

            // Validate exam score range (0-100)
            if (scoreValue < 0 || scoreValue > 100)
                return new ValidationResult(false, "Exam Score must be between 0 and 100");

            return new ValidationResult(true, "Validation successful");
        }

        /// <summary>
        /// Calculates superhero rank based on exam score
        /// </summary>
        /// <param name="examScore">Exam score to calculate rank for</param>
        /// <returns>Calculated rank</returns>
        public string CalculateRank(int examScore)
        {
            if (examScore >= 81 && examScore <= 100)
                return "S-Rank";
            else if (examScore >= 61 && examScore <= 80)
                return "A-Rank";
            else if (examScore >= 41 && examScore <= 60)
                return "B-Rank";
            else
                return "C-Rank";
        }

        /// <summary>
        /// Calculates threat level based on exam score
        /// </summary>
        /// <param name="examScore">Exam score to calculate threat level for</param>
        /// <returns>Calculated threat level</returns>
        public string CalculateThreatLevel(int examScore)
        {
            if (examScore >= 81 && examScore <= 100)
                return "Finals Week";
            else if (examScore >= 61 && examScore <= 80)
                return "Midterm Madness";
            else if (examScore >= 41 && examScore <= 60)
                return "Group Project Gone Wrong";
            else
                return "Pop Quiz";
        }

        /// <summary>
        /// Adds a new superhero with validation and rank calculation
        /// </summary>
        /// <param name="heroId">Hero ID</param>
        /// <param name="name">Hero name</param>
        /// <param name="age">Hero age</param>
        /// <param name="superpower">Hero superpower</param>
        /// <param name="examScore">Hero exam score</param>
        /// <returns>Result of the add operation</returns>
        public OperationResult AddSuperhero(string heroId, string name, string age, string superpower, string examScore)
        {
            try
            {
                // Validate input data
                ValidationResult validation = ValidateSuperheroData(heroId, name, age, superpower, examScore);
                if (!validation.IsValid)
                {
                    return new OperationResult(false, validation.ErrorMessage);
                }

                // Parse validated data
                int ageValue = int.Parse(age);
                int scoreValue = int.Parse(examScore);

                // Calculate rank and threat level
                string rank = CalculateRank(scoreValue);
                string threatLevel = CalculateThreatLevel(scoreValue);

                // Create hero data string
                string heroData = $"{heroId},{name},{ageValue},{superpower},{scoreValue},{rank},{threatLevel}";

                // Save to database layer
                _dataAccess.AddSuperhero(heroData);

                return new OperationResult(true, "Superhero added successfully");
            }
            catch (Exception ex)
            {
                return new OperationResult(false, $"Error adding superhero: {ex.Message}");
            }
        }

        /// <summary>
        /// Updates an existing superhero with validation and rank recalculation
        /// </summary>
        /// <param name="index">Index of the superhero to update</param>
        /// <param name="heroId">Updated hero ID</param>
        /// <param name="name">Updated hero name</param>
        /// <param name="age">Updated hero age</param>
        /// <param name="superpower">Updated hero superpower</param>
        /// <param name="examScore">Updated hero exam score</param>
        /// <returns>Result of the update operation</returns>
        public OperationResult UpdateSuperhero(int index, string heroId, string name, string age, string superpower, string examScore)
        {
            try
            {
                // Validate input data
                ValidationResult validation = ValidateSuperheroData(heroId, name, age, superpower, examScore);
                if (!validation.IsValid)
                {
                    return new OperationResult(false, validation.ErrorMessage);
                }

                // Parse validated data
                int ageValue = int.Parse(age);
                int scoreValue = int.Parse(examScore);

                // Calculate rank and threat level
                string rank = CalculateRank(scoreValue);
                string threatLevel = CalculateThreatLevel(scoreValue);

                // Create updated hero data string
                string updatedHeroData = $"{heroId},{name},{ageValue},{superpower},{scoreValue},{rank},{threatLevel}";

                // Update in database layer
                _dataAccess.UpdateSuperhero(index, updatedHeroData);

                return new OperationResult(true, "Superhero updated successfully");
            }
            catch (Exception ex)
            {
                return new OperationResult(false, $"Error updating superhero: {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes a superhero at the specified index
        /// </summary>
        /// <param name="index">Index of the superhero to delete</param>
        /// <returns>Result of the delete operation</returns>
        public OperationResult DeleteSuperhero(int index)
        {
            try
            {
                _dataAccess.DeleteSuperhero(index);
                return new OperationResult(true, "Superhero deleted successfully");
            }
            catch (Exception ex)
            {
                return new OperationResult(false, $"Error deleting superhero: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets all superheroes from the database
        /// </summary>
        /// <returns>List of superhero data arrays</returns>
        public List<string[]> GetAllSuperheroes()
        {
            try
            {
                return _dataAccess.GetAllSuperheroes();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving superheroes: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Generates summary statistics for all superheroes
        /// </summary>
        /// <returns>Summary statistics object</returns>
        public SummaryStatistics GenerateSummary()
        {
            try
            {
                List<string[]> allHeroes = GetAllSuperheroes();

                if (allHeroes.Count == 0)
                {
                    return new SummaryStatistics
                    {
                        TotalHeroes = 0,
                        AverageAge = 0,
                        AverageScore = 0,
                        SRankCount = 0,
                        ARankCount = 0,
                        BRankCount = 0,
                        CRankCount = 0
                    };
                }

                // Calculate statistics
                int totalHeroes = allHeroes.Count;
                int totalAge = 0;
                int totalScore = 0;
                int sRankCount = 0, aRankCount = 0, bRankCount = 0, cRankCount = 0;

                foreach (string[] heroData in allHeroes)
                {
                    if (heroData.Length >= 7)
                    {
                        // Parse age and score
                        if (int.TryParse(heroData[2], out int age))
                            totalAge += age;
                        if (int.TryParse(heroData[4], out int score))
                            totalScore += score;

                        // Count ranks
                        switch (heroData[5])
                        {
                            case "S-Rank": sRankCount++; break;
                            case "A-Rank": aRankCount++; break;
                            case "B-Rank": bRankCount++; break;
                            case "C-Rank": cRankCount++; break;
                        }
                    }
                }

                // Calculate averages
                double avgAge = totalAge / (double)totalHeroes;
                double avgScore = totalScore / (double)totalHeroes;

                return new SummaryStatistics
                {
                    TotalHeroes = totalHeroes,
                    AverageAge = avgAge,
                    AverageScore = avgScore,
                    SRankCount = sRankCount,
                    ARankCount = aRankCount,
                    BRankCount = bRankCount,
                    CRankCount = cRankCount
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error generating summary: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Saves summary report to file
        /// </summary>
        /// <param name="summary">Summary statistics to save</param>
        public void SaveSummaryToFile(SummaryStatistics summary)
        {
            try
            {
                string summaryContent = $"SUPERHERO SUMMARY REPORT\n" +
                                      $"Generated on: {DateTime.Now}\n" +
                                      $"Total Heroes: {summary.TotalHeroes}\n" +
                                      $"Average Age: {summary.AverageAge:0.00}\n" +
                                      $"Average Exam Score: {summary.AverageScore:0.00}\n" +
                                      $"Rank Distribution:\n" +
                                      $"  S-Rank: {summary.SRankCount} heroes\n" +
                                      $"  A-Rank: {summary.ARankCount} heroes\n" +
                                      $"  B-Rank: {summary.BRankCount} heroes\n" +
                                      $"  C-Rank: {summary.CRankCount} heroes";

                _dataAccess.SaveSummary(summaryContent);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving summary to file: {ex.Message}", ex);
            }
        }
    }

    /// <summary>
    /// Represents the result of a validation operation
    /// </summary>
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }

        public ValidationResult(bool isValid, string errorMessage)
        {
            IsValid = isValid;
            ErrorMessage = errorMessage;
        }
    }

    /// <summary>
    /// Represents the result of an operation (add, update, delete)
    /// </summary>
    public class OperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public OperationResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }

    /// <summary>
    /// Contains summary statistics for all superheroes
    /// </summary>
    public class SummaryStatistics
    {
        public int TotalHeroes { get; set; }
        public double AverageAge { get; set; }
        public double AverageScore { get; set; }
        public int SRankCount { get; set; }
        public int ARankCount { get; set; }
        public int BRankCount { get; set; }
        public int CRankCount { get; set; }
    }
}
