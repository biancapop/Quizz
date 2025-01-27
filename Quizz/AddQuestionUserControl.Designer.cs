namespace Quizz
{
    partial class AddQuestionUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_question_statement = new TextBox();
            button_question_statement = new Button();
            button_question_response = new Button();
            textBox_question_response = new TextBox();
            label2 = new Label();
            button_add = new Button();
            comboBox_tag = new ComboBox();
            label3 = new Label();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel_question_details = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel_question_details.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 1;
            label1.Text = "Pregunta";
            // 
            // textBox_question_statement
            // 
            textBox_question_statement.Location = new Point(3, 62);
            textBox_question_statement.Name = "textBox_question_statement";
            textBox_question_statement.Size = new Size(598, 27);
            textBox_question_statement.TabIndex = 2;
            // 
            // button_question_statement
            // 
            button_question_statement.Location = new Point(3, 121);
            button_question_statement.Name = "button_question_statement";
            button_question_statement.Size = new Size(94, 29);
            button_question_statement.TabIndex = 3;
            button_question_statement.Text = "Imagen";
            button_question_statement.UseVisualStyleBackColor = true;
            button_question_statement.Click += button1_Click;
            // 
            // button_question_response
            // 
            button_question_response.Location = new Point(3, 298);
            button_question_response.Name = "button_question_response";
            button_question_response.Size = new Size(94, 29);
            button_question_response.TabIndex = 6;
            button_question_response.Text = "Imagen";
            button_question_response.UseVisualStyleBackColor = true;
            // 
            // textBox_question_response
            // 
            textBox_question_response.Location = new Point(3, 239);
            textBox_question_response.Name = "textBox_question_response";
            textBox_question_response.Size = new Size(598, 27);
            textBox_question_response.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 177);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Respuesta";
            // 
            // button_add
            // 
            button_add.Location = new Point(3, 3);
            button_add.Name = "button_add";
            button_add.Size = new Size(164, 29);
            button_add.TabIndex = 7;
            button_add.Text = "Añadir/Editar";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // comboBox_tag
            // 
            comboBox_tag.FormattingEnabled = true;
            comboBox_tag.Location = new Point(3, 416);
            comboBox_tag.Name = "comboBox_tag";
            comboBox_tag.Size = new Size(151, 28);
            comboBox_tag.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 354);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 9;
            label3.Text = "Tag";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel_question_details);
            splitContainer1.Size = new Size(871, 539);
            splitContainer1.SplitterDistance = 263;
            splitContainer1.TabIndex = 10;
            // 
            // tableLayoutPanel_question_details
            // 
            tableLayoutPanel_question_details.ColumnCount = 1;
            tableLayoutPanel_question_details.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_question_details.Controls.Add(label1, 0, 0);
            tableLayoutPanel_question_details.Controls.Add(textBox_question_statement, 0, 1);
            tableLayoutPanel_question_details.Controls.Add(comboBox_tag, 0, 7);
            tableLayoutPanel_question_details.Controls.Add(label3, 0, 6);
            tableLayoutPanel_question_details.Controls.Add(button_question_statement, 0, 2);
            tableLayoutPanel_question_details.Controls.Add(label2, 0, 3);
            tableLayoutPanel_question_details.Controls.Add(textBox_question_response, 0, 4);
            tableLayoutPanel_question_details.Controls.Add(button_question_response, 0, 5);
            tableLayoutPanel_question_details.Controls.Add(tableLayoutPanel2, 0, 8);
            tableLayoutPanel_question_details.Dock = DockStyle.Fill;
            tableLayoutPanel_question_details.Location = new Point(0, 0);
            tableLayoutPanel_question_details.Name = "tableLayoutPanel_question_details";
            tableLayoutPanel_question_details.RowCount = 9;
            tableLayoutPanel_question_details.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel_question_details.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel_question_details.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel_question_details.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel_question_details.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel_question_details.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel_question_details.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel_question_details.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel_question_details.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel_question_details.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_question_details.Size = new Size(604, 539);
            tableLayoutPanel_question_details.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(listView1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(263, 539);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 0;
            label4.Text = "Listado de preguntas";
            // 
            // button1
            // 
            button1.Location = new Point(3, 32);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 1;
            button1.Text = "Añadir/Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(button_add, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 475);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(598, 61);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(302, 3);
            button2.Name = "button2";
            button2.Size = new Size(164, 29);
            button2.TabIndex = 8;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(3, 67);
            listView1.Name = "listView1";
            listView1.Size = new Size(257, 469);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // AddQuestionUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "AddQuestionUserControl";
            Size = new Size(871, 539);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel_question_details.ResumeLayout(false);
            tableLayoutPanel_question_details.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox_question_statement;
        private Button button_question_statement;
        private Button button_question_response;
        private TextBox textBox_question_response;
        private Label label2;
        private Button button_add;
        private ComboBox comboBox_tag;
        private Label label3;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel_question_details;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button2;
        private ListView listView1;
    }
}
