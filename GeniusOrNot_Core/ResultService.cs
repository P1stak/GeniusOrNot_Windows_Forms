using System;
using System.IO;
using System.Linq;

namespace GeniusOrNot_Core
{
    public class ResultService
    {
        private readonly string _filePath;
        public ResultService(string filePath = "results.csv")
        {
            _filePath = filePath;
            InitializeFile();
        }

        private void InitializeFile()
        {
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "ФИО;Правильные ответы;Диагноз\n");
            }
        }
        public void SaveResult(string name, int correctAnswers, string diagnosis)
        {
            File.AppendAllText(_filePath, $"{name};{correctAnswers};{diagnosis}\n");
        }
        public string[] LoadResults()
        {
            return File.Exists(_filePath) ? File.ReadAllLines(_filePath).Skip(1).ToArray() : Array.Empty<string>();
        }
    }
}
