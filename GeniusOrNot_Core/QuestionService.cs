using System;
using System.Collections.Generic;

namespace GeniusOrNot_Core
{
    public class QuestionService
    {
        private readonly Random _random = new Random();
        private readonly Dictionary<int, (string Question, int Answer)> _questions;


        public QuestionService()
        {
            _questions = new Dictionary<int, (string, int)>
            {
                {0, ("Сколько будет два плюс два умноженное на два?", 6)},
                {1, ("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9)},
                {2, ("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25)},
                {3, ("Укол делают каждые полчаса. Сколько нужно минут для трех уколов?", 60)},
                {4, ("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)}
            };
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
