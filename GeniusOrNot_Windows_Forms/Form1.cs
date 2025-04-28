using GeniusOrNot_Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GeniusOrNot_Windows_Forms
{
    public partial class Form1 : Form
    {
        private readonly QuestionService _questionService = new QuestionService();
        private QuestionsForm _questionsForm;
        private readonly ResultService _resultService = new ResultService();

        private int _correctAnswers;
        private List<int> _usedQuestions = new List<int>();

        public Form1()
        {
            InitializeComponent();
            InitializeApplicationState();
            InitializeMenu();
        }
        private void InitializeMenu()
        {
            menuRestart.Click += (s, e) => RestartApplication();
            menuResults.Click += menuResults_Click;
            menuExit.Click += menuExit_Click;
        }
        private void InitializeApplicationState()
        {
            panelQuestions.Visible = false;
            panelResults.Visible = false;
            panelName.Visible = true;
        }
        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите ФИО!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StartTest();
        }
        private void StartTest()
        {
            _questionService.ReloadQuestions();
            _correctAnswers = 0;
            _usedQuestions.Clear();

            panelName.Visible = false;
            panelQuestions.Visible = true;

            ShowNextQuestion();
        }
        private void RestartApplication()
        {
            Application.Restart();
            Environment.Exit(0);
        }
        private void LoadResults()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Настройка столбцов
            dataGridView1.Columns.Add("Name", "ФИО");
            dataGridView1.Columns.Add("CorrectAnswers", "Правильные ответы");
            dataGridView1.Columns.Add("Diagnosis", "Диагноз");

            // Автоматическое растягивание столбцов
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            try
            {
                var results = _resultService.LoadResults();
                foreach (var item in results)
                {
                    dataGridView1.Rows.Add(item.Name, item.CorrectAnswers, item.Diagnosis);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки результатов: {ex.Message}");
            }
        }
        private void ShowResults()
        {
            panelName.Visible = false;
            panelQuestions.Visible = false;
            panelResults.Visible = true;
            LoadResults();
        }
        private void ShowNextQuestion()
        {
            if (_usedQuestions.Count >= _questionService.QuestionsCount)
            {
                FinishTest();
                return;
            }

            var questionIndex = _questionService.GetRandomQuestionIndex(_usedQuestions);
            _usedQuestions.Add(questionIndex);

            lblQuestion.Text = $"Вопрос {_usedQuestions.Count}:\n{_questionService.GetQuestion(questionIndex)}";
            txtAnswer.Clear();
        }
        private void FinishTest()
        {
            double score = (double)_correctAnswers / _questionService.QuestionsCount * 100;
            string diagnosis = _questionService.GetDiagnosis(score);

            _resultService.SaveResult(txtName.Text, _correctAnswers, diagnosis);

            panelQuestions.Visible = false;
            panelResults.Visible = true;
            LoadResults();

            MessageBox.Show($"Тест завершен! Ваш диагноз: {diagnosis}");
        }
        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAnswer.Text, out int userAnswer))
            {
                MessageBox.Show("Введите число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var currentQuestionIndex = _usedQuestions.Last(); // попробуй если не заработает - var currentQuestionIndex = _usedQuestions[_usedQuestions.Count - 1];
            if (userAnswer == _questionService.GetAnswer(currentQuestionIndex))
            {
                _correctAnswers++;
            }

            ShowNextQuestion();
        }
        private void menuRestart_Click(object sender, EventArgs e) => Application.Restart();
        private void menuResults_Click(object sender, EventArgs e)
        {
            ShowResults();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuQuestions_Click(object sender, EventArgs e)
        {
            var questionsForm = new QuestionsForm();
            questionsForm.ShowDialog();
            _questionService.ReloadQuestions();
        }
    }
}
