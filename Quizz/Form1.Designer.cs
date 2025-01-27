namespace Quizz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_add_deck = new Button();
            comboBox1 = new ComboBox();
            button_start_quizz = new Button();
            button_modify_deck = new Button();
            button_delete_deck = new Button();
            panel1 = new Panel();
            startQuizzUserControl1 = new StartQuizzUserControl();
            addDeckUserControl1 = new AddDeckUserControl();
            addQuestionUserControl1 = new AddQuestionUserControl();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7142859F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.28571F));
            tableLayoutPanel1.Size = new Size(1044, 525);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0000038F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0000038F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btn_add_deck, 0, 0);
            tableLayoutPanel2.Controls.Add(comboBox1, 2, 0);
            tableLayoutPanel2.Controls.Add(button_start_quizz, 1, 0);
            tableLayoutPanel2.Controls.Add(button_modify_deck, 3, 0);
            tableLayoutPanel2.Controls.Add(button_delete_deck, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1038, 66);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_add_deck
            // 
            btn_add_deck.Location = new Point(3, 3);
            btn_add_deck.Name = "btn_add_deck";
            btn_add_deck.Size = new Size(167, 29);
            btn_add_deck.TabIndex = 0;
            btn_add_deck.Text = "Añadir Deck";
            btn_add_deck.UseVisualStyleBackColor = true;
            btn_add_deck.Click += btn_add_deck_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(417, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 28);
            comboBox1.TabIndex = 3;
            // 
            // button_start_quizz
            // 
            button_start_quizz.Location = new Point(210, 3);
            button_start_quizz.Name = "button_start_quizz";
            button_start_quizz.Size = new Size(167, 29);
            button_start_quizz.TabIndex = 4;
            button_start_quizz.Text = "Empezar Quizz";
            button_start_quizz.UseVisualStyleBackColor = true;
            button_start_quizz.Click += button_start_quizz_Click;
            // 
            // button_modify_deck
            // 
            button_modify_deck.Location = new Point(624, 3);
            button_modify_deck.Name = "button_modify_deck";
            button_modify_deck.Size = new Size(167, 29);
            button_modify_deck.TabIndex = 1;
            button_modify_deck.Text = "Modificar Deck";
            button_modify_deck.UseVisualStyleBackColor = true;
            button_modify_deck.Click += button_modify_deck_Click;
            // 
            // button_delete_deck
            // 
            button_delete_deck.Location = new Point(831, 3);
            button_delete_deck.Name = "button_delete_deck";
            button_delete_deck.Size = new Size(167, 29);
            button_delete_deck.TabIndex = 2;
            button_delete_deck.Text = "Eliminar Deck";
            button_delete_deck.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(startQuizzUserControl1);
            panel1.Controls.Add(addDeckUserControl1);
            panel1.Controls.Add(addQuestionUserControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 447);
            panel1.TabIndex = 1;
            // 
            // startQuizzUserControl1
            // 
            startQuizzUserControl1.Dock = DockStyle.Fill;
            startQuizzUserControl1.Location = new Point(0, 0);
            startQuizzUserControl1.Name = "startQuizzUserControl1";
            startQuizzUserControl1.Size = new Size(1038, 447);
            startQuizzUserControl1.TabIndex = 2;
            // 
            // addDeckUserControl1
            // 
            addDeckUserControl1.Dock = DockStyle.Fill;
            addDeckUserControl1.Location = new Point(0, 0);
            addDeckUserControl1.Name = "addDeckUserControl1";
            addDeckUserControl1.Size = new Size(1038, 447);
            addDeckUserControl1.TabIndex = 1;
            // 
            // addQuestionUserControl1
            // 
            addQuestionUserControl1.Dock = DockStyle.Fill;
            addQuestionUserControl1.Location = new Point(0, 0);
            addQuestionUserControl1.Name = "addQuestionUserControl1";
            addQuestionUserControl1.Size = new Size(1038, 447);
            addQuestionUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 525);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_add_deck;
        private Button button_modify_deck;
        private Button button_delete_deck;
        private ComboBox comboBox1;
        private Button button_start_quizz;
        private Panel panel1;
        private AddDeckUserControl deckUserControl1;
        private AddQuestionUserControl addQuestionUserControl1;
        private AddDeckUserControl addDeckUserControl1;
        private StartQuizzUserControl startQuizzUserControl1;
    }
}
