namespace Practice0302
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            textBoxPatronymic = new TextBox();
            textBoxAge = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 41);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 97);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 161);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 224);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "Возраст";
            // 
            // button1
            // 
            button1.Location = new Point(52, 278);
            button1.Name = "button1";
            button1.Size = new Size(232, 29);
            button1.TabIndex = 4;
            button1.Text = "Сохранить в txt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(52, 335);
            button2.Name = "button2";
            button2.Size = new Size(232, 29);
            button2.TabIndex = 5;
            button2.Text = "Сохранить в csv";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(128, 41);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(156, 27);
            textBoxSurname.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(128, 97);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(156, 27);
            textBoxName.TabIndex = 7;
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Location = new Point(128, 161);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(156, 27);
            textBoxPatronymic.TabIndex = 8;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(128, 224);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(156, 27);
            textBoxAge.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxPatronymic);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSurname);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private TextBox textBoxPatronymic;
        private TextBox textBoxAge;
    }
}