namespace LSPU_ADVENTURE
{
    partial class Artapp
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
            A1 = new Button();
            A3 = new Button();
            A5 = new Button();
            A4 = new Button();
            A2 = new Button();
            SequenceAnswer = new Label();
            SUBMIT = new Button();
            STARTBTN = new Button();
            SCORE = new Label();
            HIGHSCORE = new Label();
            ATTEMPlbl = new Label();
            Correct1 = new Label();
            Correct2 = new Label();
            Correct3 = new Label();
            Correct4 = new Label();
            Correct5 = new Label();
            SuspendLayout();
            // 
            // A1
            // 
            A1.BackColor = SystemColors.ControlDark;
            A1.Location = new Point(250, 200);
            A1.Name = "A1";
            A1.Size = new Size(100, 100);
            A1.TabIndex = 0;
            A1.Text = "\"\"";
            A1.UseVisualStyleBackColor = false;
            A1.Click += A1_Click;
            // 
            // A3
            // 
            A3.BackColor = SystemColors.ControlDark;
            A3.Location = new Point(650, 200);
            A3.Name = "A3";
            A3.Size = new Size(100, 100);
            A3.TabIndex = 1;
            A3.Text = "\"\"";
            A3.UseVisualStyleBackColor = false;
            A3.Click += A3_Click;
            // 
            // A5
            // 
            A5.BackColor = SystemColors.ControlDark;
            A5.Location = new Point(1050, 200);
            A5.Name = "A5";
            A5.Size = new Size(100, 100);
            A5.TabIndex = 2;
            A5.Text = "\"\"";
            A5.UseVisualStyleBackColor = false;
            A5.Click += A5_Click;
            // 
            // A4
            // 
            A4.BackColor = SystemColors.ControlDark;
            A4.Location = new Point(850, 200);
            A4.Name = "A4";
            A4.Size = new Size(100, 100);
            A4.TabIndex = 3;
            A4.Text = "\"\"";
            A4.UseVisualStyleBackColor = false;
            A4.Click += A4_Click;
            // 
            // A2
            // 
            A2.BackColor = SystemColors.ControlDark;
            A2.Location = new Point(450, 200);
            A2.Name = "A2";
            A2.Size = new Size(100, 100);
            A2.TabIndex = 4;
            A2.Text = "\"\"";
            A2.UseVisualStyleBackColor = false;
            A2.Click += A2_Click;
            // 
            // SequenceAnswer
            // 
            SequenceAnswer.BackColor = SystemColors.Info;
            SequenceAnswer.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SequenceAnswer.ForeColor = Color.DarkRed;
            SequenceAnswer.Location = new Point(250, 349);
            SequenceAnswer.Name = "SequenceAnswer";
            SequenceAnswer.Size = new Size(900, 30);
            SequenceAnswer.TabIndex = 5;
            SequenceAnswer.Text = "Sequnce Answer:";
            // 
            // SUBMIT
            // 
            SUBMIT.BackColor = Color.DarkCyan;
            SUBMIT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SUBMIT.Location = new Point(656, 469);
            SUBMIT.Name = "SUBMIT";
            SUBMIT.Size = new Size(100, 50);
            SUBMIT.TabIndex = 6;
            SUBMIT.Text = "SUBMIT";
            SUBMIT.UseVisualStyleBackColor = false;
            // 
            // STARTBTN
            // 
            STARTBTN.BackColor = Color.DarkCyan;
            STARTBTN.Location = new Point(656, 396);
            STARTBTN.Name = "STARTBTN";
            STARTBTN.Size = new Size(94, 29);
            STARTBTN.TabIndex = 7;
            STARTBTN.Text = "START";
            STARTBTN.UseVisualStyleBackColor = false;
            // 
            // SCORE
            // 
            SCORE.BackColor = Color.DarkCyan;
            SCORE.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SCORE.Location = new Point(12, 627);
            SCORE.Name = "SCORE";
            SCORE.Size = new Size(100, 30);
            SCORE.TabIndex = 8;
            SCORE.Text = "SCORE:";
            SCORE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HIGHSCORE
            // 
            HIGHSCORE.BackColor = Color.DarkCyan;
            HIGHSCORE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HIGHSCORE.Location = new Point(1158, 639);
            HIGHSCORE.Name = "HIGHSCORE";
            HIGHSCORE.Size = new Size(130, 30);
            HIGHSCORE.TabIndex = 9;
            HIGHSCORE.Text = "HIGHSCORE:";
            HIGHSCORE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ATTEMPlbl
            // 
            ATTEMPlbl.BackColor = SystemColors.Info;
            ATTEMPlbl.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ATTEMPlbl.ForeColor = Color.DarkRed;
            ATTEMPlbl.Location = new Point(250, 396);
            ATTEMPlbl.Name = "ATTEMPlbl";
            ATTEMPlbl.Size = new Size(144, 30);
            ATTEMPlbl.TabIndex = 10;
            ATTEMPlbl.Text = "ATTEMPT:";
            // 
            // Correct1
            // 
            Correct1.AutoSize = true;
            Correct1.BackColor = SystemColors.ControlDark;
            Correct1.Location = new Point(290, 168);
            Correct1.Name = "Correct1";
            Correct1.Size = new Size(25, 20);
            Correct1.TabIndex = 11;
            Correct1.Text = "\" \"";
            // 
            // Correct2
            // 
            Correct2.AutoSize = true;
            Correct2.BackColor = SystemColors.ControlDark;
            Correct2.Location = new Point(487, 168);
            Correct2.Name = "Correct2";
            Correct2.Size = new Size(25, 20);
            Correct2.TabIndex = 12;
            Correct2.Text = "\" \"";
            // 
            // Correct3
            // 
            Correct3.AutoSize = true;
            Correct3.BackColor = SystemColors.ControlDark;
            Correct3.Location = new Point(690, 168);
            Correct3.Name = "Correct3";
            Correct3.Size = new Size(25, 20);
            Correct3.TabIndex = 13;
            Correct3.Text = "\" \"";
            // 
            // Correct4
            // 
            Correct4.AutoSize = true;
            Correct4.BackColor = SystemColors.ControlDark;
            Correct4.Location = new Point(885, 168);
            Correct4.Name = "Correct4";
            Correct4.Size = new Size(25, 20);
            Correct4.TabIndex = 14;
            Correct4.Text = "\" \"";
            // 
            // Correct5
            // 
            Correct5.AutoSize = true;
            Correct5.BackColor = SystemColors.ControlDark;
            Correct5.Location = new Point(1087, 168);
            Correct5.Name = "Correct5";
            Correct5.Size = new Size(25, 20);
            Correct5.TabIndex = 15;
            Correct5.Text = "\" \"";
            // 
            // Artapp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            BackgroundImage = Properties.Resources.Artapp_TempDesign;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1300, 700);
            Controls.Add(Correct5);
            Controls.Add(Correct4);
            Controls.Add(Correct3);
            Controls.Add(Correct2);
            Controls.Add(Correct1);
            Controls.Add(ATTEMPlbl);
            Controls.Add(HIGHSCORE);
            Controls.Add(SCORE);
            Controls.Add(STARTBTN);
            Controls.Add(SUBMIT);
            Controls.Add(SequenceAnswer);
            Controls.Add(A2);
            Controls.Add(A4);
            Controls.Add(A5);
            Controls.Add(A3);
            Controls.Add(A1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Artapp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Artapp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button A1;
        private Button A3;
        private Button A5;
        private Button A4;
        private Button A2;
        private Label SequenceAnswer;
        private Button SUBMIT;
        private Button STARTBTN;
        private Label SCORE;
        private Label HIGHSCORE;
        private Label ATTEMPlbl;
        private Label Correct1;
        private Label Correct2;
        private Label Correct3;
        private Label Correct4;
        private Label Correct5;
    }
}