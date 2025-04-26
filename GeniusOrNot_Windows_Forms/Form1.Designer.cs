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
            this.panelName = new System.Windows.Forms.Panel();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelResults = new System.Windows.Forms.Panel();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.panelName.SuspendLayout();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelQuestions.SuspendLayout();
            this.SuspendLayout();
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 258);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 4;
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
            // panelResults
            // 
            this.panelResults.Controls.Add(this.btnShowResults);
            this.panelResults.Controls.Add(this.dataGridView1);
            this.panelResults.Location = new System.Drawing.Point(0, 0);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(401, 600);
            this.panelResults.TabIndex = 2;
            this.panelResults.Visible = false;
            // 
            // btnShowResults
            // 
            this.btnShowResults.Location = new System.Drawing.Point(144, 185);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(133, 23);
            this.btnShowResults.TabIndex = 1;
            this.btnShowResults.Text = "Показать результаты";
            this.btnShowResults.UseVisualStyleBackColor = true;
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 600);
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
            this.btnSubmitAnswer.Location = new System.Drawing.Point(159, 144);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAnswer.TabIndex = 2;
            this.btnSubmitAnswer.Text = "Ответить";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(144, 74);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(0, 0);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(400, 60);
            this.lblQuestion.MinimumSize = new System.Drawing.Size(0, 60);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(389, 60);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Вопрос будет здесь";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 600);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.panelQuestions);
            this.Controls.Add(this.panelResults);
            this.Name = "Form1";
            this.Text = "Тест на гениальность";
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelQuestions.ResumeLayout(false);
            this.panelQuestions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        // Панели
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartTest;

        // Элементы panelName
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubmitAnswer;
    }
}

