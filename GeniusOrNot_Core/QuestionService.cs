using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GeniusOrNot_Core
{
    public class QuestionService
    {
        private readonly string _questionpath = "questions.json";
        private List<QuestionItem> _questions;
        private readonly Random _random = new Random();


        public QuestionService()
        {
            LoadQuestion();
            InitializeDefaultQuestions();
        }

        // создание json файла с вопросами
        private void LoadQuestion()
        {
            // проверка на наличие json файла и его создание
            try
            {
                if (File.Exists(_questionpath))
                {
                    string json = File.ReadAllText(_questionpath);
                    _questions = JsonConvert.DeserializeObject<List<QuestionItem>>(json) ?? new List<QuestionItem>();
                }
                else
                {
                    _questions = new List<QuestionItem>();
                }
            }
            catch
            {
                _questions = new List<QuestionItem>();
            }
        }

        // внедрение стандартных вопросов при запуске
        private void InitializeDefaultQuestions()
        {
            if (_questions.Any()) return; //если уже есть дефолтные вопросы, не добавляем их же повторно

            _questions = new List<QuestionItem>
            {
                new QuestionItem { Question = "Сколько будет два плюс два умноженное на два?", Answer = 6 },
                new QuestionItem { Question = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", Answer = 9},
                new QuestionItem { Question = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?", Answer = 25 },
                new QuestionItem { Question = "Укол делают каждые полчаса. Сколько нужно минут для трех уколов?", Answer = 60 },
                new QuestionItem { Question = "Пять свечей горело, две потухли. Сколько свечей осталось?", Answer = 5 }
            };
            SaveQuestion();

        }

        // добавление вопросов
        public void AddQuestion(string question, int answer)
        { 
            _questions.Add(new QuestionItem { Question = question, Answer = answer });
            SaveQuestion();
        }

        // Удаление вопроса по индексу
        public void RemoveQuestion(int index)
        {
            if (index >= 0 && index < _questions.Count)
            {
                _questions.RemoveAt(index);
                SaveQuestion();
            }
        }
        public void ReloadQuestions() // метод принудительного сохранения правок вопросов после перезагрузки приложения
        {
            _questions.Clear();
            LoadQuestion(); 
        }


        public List<QuestionItem> GetAllQuestion() => _questions;


        // сохранение вопросов при добавлении
        public void SaveQuestion()
        {              
            string json = JsonConvert.SerializeObject(_questions, Formatting.Indented);
            File.WriteAllText(_questionpath, json);
            MessageBox.Show($"файл сохранен в {_questionpath}");
        }






        public string GetQuestion(int index) => _questions[index].Question;
        public int GetAnswer(int index) => _questions[index].Answer;
        public int QuestionsCount => _questions.Count;

        public string GetDiagnosis(double percentRightAnswers)
        {
            if (percentRightAnswers >= 90) return "гений";
            if (percentRightAnswers >= 80) return "талант";
            if (percentRightAnswers >= 60) return "нормальный";
            if (percentRightAnswers >= 40) return "дурак";
            if (percentRightAnswers >= 20) return "идиот";
            return "кретин";
        }
        public int GetRandomQuestionIndex(List<int> usedQuestions)
        {
            int index;
            do
            {
                index = _random.Next(_questions.Count);
            } while (usedQuestions.Contains(index));

            return index;
        }

    }
}
