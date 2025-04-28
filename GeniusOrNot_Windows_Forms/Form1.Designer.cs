using System.Windows.Forms;

namespace GeniusOrNot_Windows_Forms
{
    partial class Form1
    {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResults = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelResults = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.panelName = new System.Windows.Forms.Panel();
            this.panelQuestionsManagement = new System.Windows.Forms.Panel();
            this.dataGridViewQuestions = new System.Windows.Forms.DataGridView();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.txtNewQuestion = new System.Windows.Forms.TextBox();
            this.txtNewAnswer = new System.Windows.Forms.TextBox();
            this.lblManageQuestions = new System.Windows.Forms.Label();
            this.menuQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelQuestions.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelQuestionsManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRestart,
            this.menuResults,
            this.menuQuestions,
            this.menuExit});
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(53, 20);
            this.mainMenuStrip.Text = "Меню";
            // 
            // menuRestart
            // 
            this.menuRestart.Name = "menuRestart";
            this.menuRestart.Size = new System.Drawing.Size(205, 22);
            this.menuRestart.Text = "Перезапустить";
            // 
            // menuResults
            // 
            this.menuResults.Name = "menuResults";
            this.menuResults.Size = new System.Drawing.Size(205, 22);
            this.menuResults.Text = "Результаты";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(205, 22);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // panelResults
            // 
            this.panelResults.Controls.Add(this.dataGridView1);
            this.panelResults.Location = new System.Drawing.Point(0, 24);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(401, 576);
            this.panelResults.TabIndex = 2;
            this.panelResults.Visible = false;
            this.panelResults.Click += new System.EventHandler(this.menuRestart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(401, 576);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelQuestions
            // 
            this.panelQuestions.Controls.Add(this.btnSubmitAnswer);
            this.panelQuestions.Controls.Add(this.txtAnswer);
            this.panelQuestions.Controls.Add(this.lblQuestion);
            this.panelQuestions.Location = new System.Drawing.Point(0, 0);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(401, 600);
            this.panelQuestions.TabIndex = 1;
            this.panelQuestions.Visible = false;
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Location = new System.Drawing.Point(159, 251);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAnswer.TabIndex = 2;
            this.btnSubmitAnswer.Text = "Ответить";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(144, 203);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(3, 109);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(400, 60);
            this.lblQuestion.MinimumSize = new System.Drawing.Size(0, 60);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(389, 60);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Вопрос будет здесь";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите ваше ФИО:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 258);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(159, 332);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(98, 37);
            this.btnStartTest.TabIndex = 5;
            this.btnStartTest.Text = "Начать тестирование";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.btnStartTest);
            this.panelName.Controls.Add(this.txtName);
            this.panelName.Controls.Add(this.label1);
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(401, 600);
            this.panelName.TabIndex = 0;
            // 
            // panelQuestionsManagement
            // 
            this.panelQuestionsManagement.Controls.Add(this.dataGridViewQuestions);
            this.panelQuestionsManagement.Controls.Add(this.btnAddQuestion);
            this.panelQuestionsManagement.Controls.Add(this.btnRemoveQuestion);
            this.panelQuestionsManagement.Controls.Add(this.txtNewQuestion);
            this.panelQuestionsManagement.Controls.Add(this.txtNewAnswer);
            this.panelQuestionsManagement.Controls.Add(this.lblManageQuestions);
            this.panelQuestionsManagement.Location = new System.Drawing.Point(0, 24);
            this.panelQuestionsManagement.Name = "panelQuestionsManagement";
            this.panelQuestionsManagement.Size = new System.Drawing.Size(401, 576);
            this.panelQuestionsManagement.TabIndex = 3;
            this.panelQuestionsManagement.Visible = false;
            // 
            // dataGridViewQuestions
            // 
            this.dataGridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestions.Location = new System.Drawing.Point(10, 40);
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuestions.Size = new System.Drawing.Size(380, 400);
            this.dataGridViewQuestions.TabIndex = 0;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(10, 500);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(120, 30);
            this.btnAddQuestion.TabIndex = 1;
            this.btnAddQuestion.Text = "Добавить вопрос";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.Location = new System.Drawing.Point(270, 500);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveQuestion.TabIndex = 2;
            this.btnRemoveQuestion.Text = "Удалить вопрос";
            this.btnRemoveQuestion.UseVisualStyleBackColor = true;
            // 
            // txtNewQuestion
            // 
            this.txtNewQuestion.Location = new System.Drawing.Point(10, 450);
            this.txtNewQuestion.Name = "txtNewQuestion";
            this.txtNewQuestion.Size = new System.Drawing.Size(250, 20);
            this.txtNewQuestion.TabIndex = 3;
            // 
            // txtNewAnswer
            // 
            this.txtNewAnswer.Location = new System.Drawing.Point(270, 450);
            this.txtNewAnswer.Name = "txtNewAnswer";
            this.txtNewAnswer.Size = new System.Drawing.Size(120, 20);
            this.txtNewAnswer.TabIndex = 4;
            // 
            // lblManageQuestions
            // 
            this.lblManageQuestions.AutoSize = true;
            this.lblManageQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblManageQuestions.Location = new System.Drawing.Point(10, 10);
            this.lblManageQuestions.Name = "lblManageQuestions";
            this.lblManageQuestions.Size = new System.Drawing.Size(207, 20);
            this.lblManageQuestions.TabIndex = 5;
            this.lblManageQuestions.Text = "Управление вопросами";
            // 
            // menuQuestions
            // 
            this.menuQuestions.Name = "menuQuestions";
            this.menuQuestions.Size = new System.Drawing.Size(205, 22);
            this.menuQuestions.Text = "Управление вопросами";
            this.menuQuestions.Click += new System.EventHandler(this.menuQuestions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 600);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.panelQuestions);
            this.Controls.Add(this.panelResults);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Тест на гениальность";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelQuestions.ResumeLayout(false);
            this.panelQuestions.PerformLayout();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelQuestionsManagement.ResumeLayout(false);
            this.panelQuestionsManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuStrip;
        private ToolStripMenuItem menuRestart;
        private ToolStripMenuItem menuResults;
        private ToolStripMenuItem menuExit;
        private Label label1;
        private TextBox txtName;
        private Button btnStartTest;
        private Panel panelName;
        private Panel panelQuestionsManagement;
        private DataGridView dataGridViewQuestions;
        private Button btnAddQuestion;
        private Button btnRemoveQuestion;
        private TextBox txtNewQuestion;
        private TextBox txtNewAnswer;
        private Label lblManageQuestions;
        private ToolStripMenuItem menuQuestions;
    }
}

