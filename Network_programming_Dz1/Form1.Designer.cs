namespace Network_programming_Dz1
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
            this.components = new System.ComponentModel.Container();
            this.PrintTextBox = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TextBoxTag = new System.Windows.Forms.TextBox();
            this.buttonTag = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Procent = new System.Windows.Forms.Button();
            this.Uniqueness = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrintTextBox
            // 
            this.PrintTextBox.Location = new System.Drawing.Point(679, 12);
            this.PrintTextBox.Multiline = true;
            this.PrintTextBox.Name = "PrintTextBox";
            this.PrintTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrintTextBox.Size = new System.Drawing.Size(477, 335);
            this.PrintTextBox.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(933, 373);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(149, 43);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.toolTip1.SetToolTip(this.Start, "Начало");
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "https://www.mail.ru",
            "https://google.com",
            "https://yandex.ru"});
            this.listBox1.Location = new System.Drawing.Point(679, 373);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 104);
            this.listBox1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.listBox1, "Выберите сайт");
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(933, 420);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(149, 46);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save File";
            this.toolTip1.SetToolTip(this.Save, "Сохранить");
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // TextBoxTag
            // 
            this.TextBoxTag.Location = new System.Drawing.Point(12, 12);
            this.TextBoxTag.Multiline = true;
            this.TextBoxTag.Name = "TextBoxTag";
            this.TextBoxTag.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxTag.Size = new System.Drawing.Size(314, 353);
            this.TextBoxTag.TabIndex = 5;
            // 
            // buttonTag
            // 
            this.buttonTag.Location = new System.Drawing.Point(16, 373);
            this.buttonTag.Name = "buttonTag";
            this.buttonTag.Size = new System.Drawing.Size(159, 45);
            this.buttonTag.TabIndex = 6;
            this.buttonTag.Text = "Tag Count";
            this.toolTip1.SetToolTip(this.buttonTag, "посчет тэгов");
            this.buttonTag.UseVisualStyleBackColor = true;
            this.buttonTag.Click += new System.EventHandler(this.buttonTag_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 27);
            this.textBox1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBox1, "Например html  ");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите тег";
            // 
            // Procent
            // 
            this.Procent.Location = new System.Drawing.Point(332, 113);
            this.Procent.Name = "Procent";
            this.Procent.Size = new System.Drawing.Size(164, 45);
            this.Procent.TabIndex = 9;
            this.Procent.Text = "Percentage of use";
            this.toolTip1.SetToolTip(this.Procent, "Процент инспользования тэга");
            this.Procent.UseVisualStyleBackColor = true;
            this.Procent.Click += new System.EventHandler(this.Procent_Click);
            // 
            // Uniqueness
            // 
            this.Uniqueness.Location = new System.Drawing.Point(509, 113);
            this.Uniqueness.Name = "Uniqueness";
            this.Uniqueness.Size = new System.Drawing.Size(164, 45);
            this.Uniqueness.TabIndex = 10;
            this.Uniqueness.Text = "Uniqueness";
            this.toolTip1.SetToolTip(this.Uniqueness, "Проверка на уникальность тэга");
            this.Uniqueness.UseVisualStyleBackColor = true;
            this.Uniqueness.Click += new System.EventHandler(this.Uniqueness_Click);
            // 
            // labelInput
            // 
            this.labelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelInput.Location = new System.Drawing.Point(408, 183);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(166, 43);
            this.labelInput.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 478);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.Uniqueness);
            this.Controls.Add(this.Procent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonTag);
            this.Controls.Add(this.TextBoxTag);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.PrintTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PrintTextBox;
        private Button Start;
        private ListBox listBox1;
        private Button Save;
        private SaveFileDialog saveFileDialog1;
        private TextBox TextBoxTag;
        private Button buttonTag;
        private TextBox textBox1;
        private Label label1;
        private Button Procent;
        private ToolTip toolTip1;
        private Button Uniqueness;
        private Label labelInput;
    }
}