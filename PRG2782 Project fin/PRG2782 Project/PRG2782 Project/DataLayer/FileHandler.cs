using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2782_Project.DataLayer
{
    internal class FileHandler
    {

        public FileHandler() { }


        // This is the path where Superheroes.txt  is stored we made it 
        public string filePath = @"C:\Users\mthi6\Downloads\PRG2782 Project fin\PRG2782 Project\PRG2782 Project\Superheroes.txt";


        // This method use streamwriter to writes a superhero's details to the text file.It does not overwrite if the code already exists on the textfile
        public void write(Superheroes hero)
        {

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(hero.ToString());

            }
            
        }

        // This method reads all superheroes from the text file
        public List<string> read()
        {
            List<string> receivedData = new List<string>();
            // Check if the file exists before reading
            if (File.Exists(filePath))
            {
                
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string txt;

                    // Read each line until the end of the file
                    while ((txt = reader.ReadLine()) != null)
                    {

                        receivedData.Add(txt);

                    }

                }
                return receivedData;

            }
            else
            {
                return receivedData;
            }

            Console.ReadLine();

        }

        // This method converts a list of text lines into a list of Superheroes objects
        public List<Superheroes> format(List<string> lines)
        {
            List<Superheroes> heroes = new List<Superheroes>();

            foreach (string rawLine in lines)
            {
                try
                {
                    string line = rawLine.Trim();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Split by '|'
                    string[] parts = line.Split('|');
                    if (parts.Length < 5) continue;

                    // Helper function to get the value after the first ':' if it exists
                    string GetValue(string input)
                    {
                        if (input.Contains(":"))
                        {
                            return input.Split(':')[1].Trim();
                        }
                        else
                        {
                            // Remove label text like "Hero ID" or "Name"
                            string[] tokens = input.Split(' ');
                            return tokens.Length > 1 ? tokens.Last().Trim() : input.Trim();
                        }
                    }

                    int heroId = int.Parse(GetValue(parts[0]));
                    int age = int.Parse(GetValue(parts[1]));
                    string name = GetValue(parts[2]);
                    string superpower = GetValue(parts[3]);
                    double heroExamScore = double.Parse(GetValue(parts[4]));

                    string rank = parts.Length > 5 ? GetValue(parts[5]) : "";
                    string threatLevel = parts.Length > 6 ? GetValue(parts[6]) : "";

                    heroes.Add(new Superheroes(heroId, age, name, superpower, threatLevel, rank, heroExamScore));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error parsing line:\n{rawLine}\n\nDetails: {ex.Message}");
                }
            }

            return heroes;
        }

        internal object write()
        {
            throw new NotImplementedException();
        }

        // This method is used to update the Superheroes.txt with a new list of superheroes
        public void UpdateFile(List<Superheroes> heroesList)
        {
            using (StreamWriter writer = new StreamWriter(filePath)) 
            {
                foreach (Superheroes hero in heroesList)
                {
                    writer.WriteLine(hero.ToString());

                }
            }
        }

    }
}

