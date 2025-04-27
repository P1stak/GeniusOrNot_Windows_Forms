using System;
using System.Collections.Generic;

namespace GeniusOrNot_Core
{
    public class QuestionService
    {
        private readonly Random _random = new Random();

        public string[] GetQuestions() => new string[]
        {
                "Сколько будет два плюс два умноженное на два?",
                "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?",
                "На двух руках 10 пальцев. Сколько пальцев на 5 руках?",
                "Укол делают каждые полчаса. Сколько нужно минут для трех уколов?",
                "Пять свечей горело, две потухли. Сколько свечей осталось?"
        };
        public int[] GetAnswers() => new int[] { 6, 9, 25, 60, 2 };
        public string GetDiagnosis(double percentRightAnswers)
        {
            if (percentRightAnswers >= 90) return "гений";
            if (percentRightAnswers >= 80) return "талант";
            if (percentRightAnswers >= 60) return "нормальный";
            if (percentRightAnswers >= 40) return "дурак";
            if (percentRightAnswers >= 20) return "идиот";
            return "кретин";
        }
        public int GetRandomQuestionIndex(int totalQuestions, List<int> usedQuestions)
        {
            var index = 0;
            do
            {
                index = _random.Next(totalQuestions);
            }
            while (usedQuestions.Contains(index));

            return index;
        }
    }
}
