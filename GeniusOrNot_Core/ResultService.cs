using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace GeniusOrNot_Core
{
    public class ResultService
    {
        private readonly string _filePath;
        private List<UserResult> _results;

        public ResultService(string filePath = "results.json")
        {
            _filePath = filePath;
            _results = new List<UserResult>();
            InitializeFile();
        }

        private void InitializeFile()
        {
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "[]"); // Пустой JSON массив
            }
            else
            {
                LoadResults(); // Загружаем существующие результаты
            }
        }

        public void SaveResult(string name, int correctAnswers, string diagnosis)
        {
            _results.Add(new UserResult
            {
                Name = name,
                CorrectAnswers = correctAnswers,
                Diagnosis = diagnosis
            });

            SaveToFile();
        }

        public List<UserResult> LoadResults()
        {
            try
            {
                string json = File.ReadAllText(_filePath);
                _results = JsonConvert.DeserializeObject<List<UserResult>>(json) ?? new List<UserResult>();
                return _results;
            }
            catch 
            {
                return new List<UserResult>();
            }
        }

        public string[] LoadResultsAsStrings()
        {
            return LoadResults()
                .Select(r => $"{r.Name};{r.CorrectAnswers};{r.Diagnosis}")
                .ToArray();
        }

        private void SaveToFile()
        {
            string json = JsonConvert.SerializeObject(_results, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
