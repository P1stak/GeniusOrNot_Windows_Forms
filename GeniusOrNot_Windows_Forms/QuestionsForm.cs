using GeniusOrNot_Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniusOrNot_Windows_Forms
{
    public partial class QuestionsForm : Form
    {
        private readonly QuestionService _questionService;

        public QuestionsForm()
        {
            InitializeComponent();
            _questionService = new QuestionService();
            SetupDataGridView();
            LoadQuestion();

            btnAddQuestion.Click += (s, e) => { this.DialogResult = DialogResult.OK; this.Close(); };

        }

        private void SetupDataGridView()
        { 
            dataGridViewQuestions.Columns.Clear();
            dataGridViewQuestions.Columns.Add("Number", "№");
            dataGridViewQuestions.Columns.Add("Question", "Вопрос");
            dataGridViewQuestions.Columns.Add("Answer", "Ответ");

            dataGridViewQuestions.Columns["Number"].Width = 40;
            dataGridViewQuestions.Columns["Answer"].Width = 60;
        }

        private void LoadQuestion()
        {

                dataGridViewQuestions.Rows.Clear();
                var questions = _questionService.GetAllQuestion();

                for (int i = 0; i < questions.Count; i++)
                {
                    dataGridViewQuestions.Rows.Add
                        (
                            i + 1,
                            questions[i].Question,
                            questions[i].Answer
                        );
                }
        }
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNewQuestion.Text))
                {
                    MessageBox.Show("Введите текст вопроса!");
                    return;
                }

                if (!int.TryParse(txtNewAnswer.Text, out int answer))
                {
                    MessageBox.Show("Ответ должен быть числом!");
                    return;
                }

                // Добавляем вопрос
                _questionService.AddQuestion(txtNewQuestion.Text, answer);

                txtNewQuestion.Text = "";
                txtNewAnswer.Text = "";

                LoadQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ошибка {ex.Message}");         
            }


        }
        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            if (dataGridViewQuestions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите вопрос для удаления!");
                return;
            }

            try
            {
                int selectedIndex = dataGridViewQuestions.SelectedRows[0].Index;
                MessageBox.Show($"Удаляем вопрос с индексом: {selectedIndex}");
                _questionService.RemoveQuestion(selectedIndex);
                LoadQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления {ex.Message}");
            }

        }
    }
}
