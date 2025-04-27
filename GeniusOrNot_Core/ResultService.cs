using System;
using System.IO;

namespace GeniusOrNot_Core
{
    public class ResultService
    {
        private readonly string _filePath;

        public ResultService(string filePath = "rusults.csv")
        {
            _filePath = filePath;
            InitializeFile();
        }

        private void InitializeFile()
        {
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, $"ФИО;Правильные ответы;Диагноз\n");
            }
        }
        public void SaveResult(string name, int correctRightAnswers, string diagnosis)
        {
            File.AppendAllText(_filePath, $"{name};{correctRightAnswers};{diagnosis}\n");
        }
        public string[] LoadResults()
        {
            return File.Exists(_filePath) ? File.ReadAllLines(_filePath) : Array.Empty<string>();
        }
        }
    }
