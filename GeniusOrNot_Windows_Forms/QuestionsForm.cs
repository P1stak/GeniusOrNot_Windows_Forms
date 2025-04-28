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
                    MessageBox.Show("Введите текст вопроса!", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtNewAnswer.Text, out int answer))
                {
                    MessageBox.Show("Ответ должен быть числом!", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Добавляем вопрос
                _questionService.AddQuestion(txtNewQuestion.Text, answer);

                // Очищаем поля для нового ввода
                txtNewQuestion.Text = "";
                txtNewAnswer.Text = "";

                // Обновляем таблицу (но НЕ закрываем форму)
                LoadQuestion();
                txtNewQuestion.Focus();

                // Фокус на поле вопроса для удобства
                txtNewQuestion.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            if (dataGridViewQuestions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите вопрос для удаления!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedIndex = dataGridViewQuestions.SelectedRows[0].Index;
                _questionService.RemoveQuestion(selectedIndex);
                LoadQuestion(); // Просто обновляем список (форма НЕ закрывается)

                if (dataGridViewQuestions.Rows.Count > 0)
                    dataGridViewQuestions.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
