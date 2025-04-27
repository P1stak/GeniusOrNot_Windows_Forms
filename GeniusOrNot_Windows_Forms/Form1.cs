using GeniusOrNot_Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GeniusOrNot_Windows_Forms
{
    public partial class Form1 : Form
    {
        private readonly QuestionService _questionService = new QuestionService();
        private readonly ResultService _resultService = new ResultService();

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
            InitializeMenu();
            InitializeFile();
            questions = GetQuestions();
            answers = GetAnswers();
            SetInitialState();
            panelQuestions.Visible = false;
            panelResults.Visible = false;
            panelName.Visible = true;
        }
        // инициализация меню
        private void InitializeMenu()
        {
            // Обработчики событий
            menuRestart.Click += (s, e) => RestartApplication();
            menuResults.Click += (s, e) => ShowResults();
            menuExit.Click += (s, e) => Application.Exit();
        }
        
        private void RestartApplication()
        {
            Application.Restart();
            Environment.Exit(0);
        }
        private void ShowResults()
        {
            panelName.Visible = false;
            panelQuestions.Visible = false;
            panelResults.Visible = true;
            LoadResults();
        }
        private void SetInitialState()
        {
            panelQuestions.Visible = false;
            panelResults.Visible = false;
            panelName.Visible = true;
            mainMenuStrip.Visible = true;

        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти?",
                            "Подтверждение",
                            MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No) return;
        }

        // работа с меню
        //--------------------------------------------------------//
        private void InitializeFile()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "ФИО;Правильные ответы;Диагноз\n");
            }
        }
        private string[] GetQuestions() => _questionService.GetQuestions();
        private int[] GetAnswers() => _questionService.GetAnswers();

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите ФИО!");
                return;
            }
            // Используем QuestionService
            int index = _questionService.GetRandomQuestionIndex(totalQuestions, usedQuestions);
            usedQuestions.Add(index);
            lblQuestion.Text = $"Вопрос {currentQuestion + 1}:\n{_questionService.GetQuestions()[index]}";


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
            string diagnosis = _questionService.GetDiagnosis(score);

            _resultService.SaveResult(txtName.Text, correctAnswers, diagnosis);

            File.AppendAllText(filePath,
                $"{txtName.Text};{correctAnswers};{diagnosis}\n");

            panelQuestions.Visible = false;
            panelResults.Visible = true;
            LoadResults();
            MessageBox.Show($"Тест завершен! Ваш диагноз: {diagnosis}");
        }
        private void LoadResults()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Создаем колонки вручную
            dataGridView1.Columns.Add("ФИО", "ФИО");
            dataGridView1.Columns.Add("ПравильныеОтветы", "Правильные ответы");
            dataGridView1.Columns.Add("Диагноз", "Диагноз");

            var results = _resultService.LoadResults();
            for (int i = 0; i < results.Length; i++)
            {
                var parts = results[i].Split(';');
                dataGridView1.Rows.Add(parts[0], parts[1], parts[2]);
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
