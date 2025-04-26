using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniusOrNot_Windows_Forms
{
    public partial class Form1 : Form
    {
        private string filePath = "results.csv";
        private int totalQuestions = 5;
        private string[] questions;
        private int[] answers;
        private int correctAnswers = 0;
        private int currentQuestion = 0;
        private List<int> usedQuestions = new List<int>();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeFile();
            questions = GetQuestions();
            answers = GetAnswers();
            SetInitialState();
            panelQuestions.Visible = false;
            panelResults.Visible = false;
            panelName.Visible = true;
        }
        private void SetInitialState()
        {
            panelQuestions.Visible = false;
            panelResults.Visible = false;
        }
        private void InitializeFile()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "ФИО;Правильные ответы;Диагноз\n");
            }
        }
        private string[] GetQuestions() => new string[]
{
            "Сколько будет два плюс два умноженное на два?",
            "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?",
            "На двух руках 10 пальцев. Сколько пальцев на 5 руках?",
            "Укол делают каждые полчаса. Сколько нужно минут для трех уколов?",
            "Пять свечей горело, две потухли. Сколько свечей осталось?"
        };

        private int[] GetAnswers() => new int[] { 6, 9, 25, 60, 2 };

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите ФИО!");
                return;
            }

            panelName.Visible = false;
            panelQuestions.Visible = true;
            correctAnswers = 0;
            currentQuestion = 0;
            usedQuestions.Clear();
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {


            if (currentQuestion >= totalQuestions)
            {
                FinishTest();
                return;
            }

            int index;
            do { index = random.Next(totalQuestions); }
            while (usedQuestions.Contains(index));

            usedQuestions.Add(index);
            lblQuestion.Text = $"Вопрос {currentQuestion + 1}:\n{questions[index]}";
            txtAnswer.Clear();
            currentQuestion++;
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAnswer.Text, out int userAnswer))
            {
                MessageBox.Show("Введите число!");
                return;
            }

            int correct = answers[usedQuestions[usedQuestions.Count - 1]];
            if (userAnswer == correct) correctAnswers++;

            ShowNextQuestion();
        }
        private void FinishTest()
        {
            double score = (double)correctAnswers / totalQuestions * 100;
            string diagnosis = GetDiagnosis(score);

            File.AppendAllText(filePath,
                $"{txtName.Text};{correctAnswers};{diagnosis}\n");

            panelQuestions.Visible = false;
            panelResults.Visible = true;
            LoadResults();
            MessageBox.Show($"Тест завершен! Ваш диагноз: {diagnosis}");
        }
        private string GetDiagnosis(double score)
        {
            if (score >= 90) return "гений";
            if (score >= 80) return "талант";
            if (score >= 60) return "нормальный";
            if (score >= 40) return "дурак";
            if (score >= 20) return "идиот";
            return "кретин";
        }
        private void LoadResults()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Создаем колонки вручную
            dataGridView1.Columns.Add("ФИО", "ФИО");
            dataGridView1.Columns.Add("ПравильныеОтветы", "Правильные ответы");
            dataGridView1.Columns.Add("Диагноз", "Диагноз");

            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);
                    for (int i = 1; i < lines.Length; i++) // Пропускаем заголовок
                    {
                        var parts = lines[i].Split(';');
                        dataGridView1.Rows.Add(parts[0], parts[1], parts[2]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке результатов: {ex.Message}");
            }
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {
            panelName.Visible = false;
            panelQuestions.Visible = false;
            panelResults.Visible = true;
            LoadResults();
        }

    }
}
