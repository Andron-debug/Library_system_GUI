
namespace Library_system_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BooklistBox = new System.Windows.Forms.ListBox();
            this.BookReaderlistBox = new System.Windows.Forms.ListBox();
            this.AddBk = new System.Windows.Forms.Button();
            this.AddBookReader = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReaderNameTextBox = new System.Windows.Forms.TextBox();
            this.ReaderYearTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReaderBooksListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TakeBook = new System.Windows.Forms.Button();
            this.BookBack = new System.Windows.Forms.Button();
            this.BackAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BooklistBox
            // 
            this.BooklistBox.FormattingEnabled = true;
            this.BooklistBox.ItemHeight = 16;
            this.BooklistBox.Location = new System.Drawing.Point(12, 54);
            this.BooklistBox.Name = "BooklistBox";
            this.BooklistBox.ScrollAlwaysVisible = true;
            this.BooklistBox.Size = new System.Drawing.Size(207, 276);
            this.BooklistBox.TabIndex = 0;
            // 
            // BookReaderlistBox
            // 
            this.BookReaderlistBox.FormattingEnabled = true;
            this.BookReaderlistBox.ItemHeight = 16;
            this.BookReaderlistBox.Location = new System.Drawing.Point(276, 54);
            this.BookReaderlistBox.Name = "BookReaderlistBox";
            this.BookReaderlistBox.ScrollAlwaysVisible = true;
            this.BookReaderlistBox.Size = new System.Drawing.Size(207, 276);
            this.BookReaderlistBox.TabIndex = 1;
            this.BookReaderlistBox.SelectedIndexChanged += new System.EventHandler(this.BookReaderlistBox_SelectedIndexChanged);
            // 
            // AddBk
            // 
            this.AddBk.Location = new System.Drawing.Point(12, 336);
            this.AddBk.Name = "AddBk";
            this.AddBk.Size = new System.Drawing.Size(207, 50);
            this.AddBk.TabIndex = 2;
            this.AddBk.Text = "Добавить книгу";
            this.AddBk.UseVisualStyleBackColor = true;
            this.AddBk.Click += new System.EventHandler(this.AddBk_Click);
            // 
            // AddBookReader
            // 
            this.AddBookReader.Location = new System.Drawing.Point(276, 336);
            this.AddBookReader.Name = "AddBookReader";
            this.AddBookReader.Size = new System.Drawing.Size(207, 50);
            this.AddBookReader.TabIndex = 3;
            this.AddBookReader.Text = "Добавить читателя";
            this.AddBookReader.UseVisualStyleBackColor = true;
            this.AddBookReader.Click += new System.EventHandler(this.AddBookReader_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Хронилище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(276, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список читателей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(577, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Читатель";
            // 
            // ReaderNameTextBox
            // 
            this.ReaderNameTextBox.Enabled = false;
            this.ReaderNameTextBox.Location = new System.Drawing.Point(582, 74);
            this.ReaderNameTextBox.Name = "ReaderNameTextBox";
            this.ReaderNameTextBox.Size = new System.Drawing.Size(173, 22);
            this.ReaderNameTextBox.TabIndex = 8;
            // 
            // ReaderYearTextBox
            // 
            this.ReaderYearTextBox.Enabled = false;
            this.ReaderYearTextBox.Location = new System.Drawing.Point(582, 117);
            this.ReaderYearTextBox.Name = "ReaderYearTextBox";
            this.ReaderYearTextBox.Size = new System.Drawing.Size(173, 22);
            this.ReaderYearTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Год рождения";
            // 
            // ReaderBooksListBox
            // 
            this.ReaderBooksListBox.FormattingEnabled = true;
            this.ReaderBooksListBox.ItemHeight = 16;
            this.ReaderBooksListBox.Location = new System.Drawing.Point(582, 166);
            this.ReaderBooksListBox.Name = "ReaderBooksListBox";
            this.ReaderBooksListBox.ScrollAlwaysVisible = true;
            this.ReaderBooksListBox.Size = new System.Drawing.Size(193, 164);
            this.ReaderBooksListBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Список книг";
            // 
            // TakeBook
            // 
            this.TakeBook.Location = new System.Drawing.Point(582, 336);
            this.TakeBook.Name = "TakeBook";
            this.TakeBook.Size = new System.Drawing.Size(193, 28);
            this.TakeBook.TabIndex = 13;
            this.TakeBook.Text = "Взять книгу";
            this.TakeBook.UseVisualStyleBackColor = true;
            this.TakeBook.Click += new System.EventHandler(this.TakeBook_Click);
            // 
            // BookBack
            // 
            this.BookBack.Location = new System.Drawing.Point(582, 370);
            this.BookBack.Name = "BookBack";
            this.BookBack.Size = new System.Drawing.Size(193, 28);
            this.BookBack.TabIndex = 14;
            this.BookBack.Text = "Вернуть книгу";
            this.BookBack.UseVisualStyleBackColor = true;
            this.BookBack.Click += new System.EventHandler(this.BookBack_Click);
            // 
            // BackAll
            // 
            this.BackAll.Location = new System.Drawing.Point(582, 404);
            this.BackAll.Name = "BackAll";
            this.BackAll.Size = new System.Drawing.Size(193, 28);
            this.BackAll.TabIndex = 15;
            this.BackAll.Text = "Вернуть все книги";
            this.BackAll.UseVisualStyleBackColor = true;
            this.BackAll.Click += new System.EventHandler(this.BackAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackAll);
            this.Controls.Add(this.BookBack);
            this.Controls.Add(this.TakeBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReaderBooksListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReaderYearTextBox);
            this.Controls.Add(this.ReaderNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBookReader);
            this.Controls.Add(this.AddBk);
            this.Controls.Add(this.BookReaderlistBox);
            this.Controls.Add(this.BooklistBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BooklistBox;
        private System.Windows.Forms.ListBox BookReaderlistBox;
        private System.Windows.Forms.Button AddBk;
        private System.Windows.Forms.Button AddBookReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReaderNameTextBox;
        private System.Windows.Forms.TextBox ReaderYearTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ReaderBooksListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TakeBook;
        private System.Windows.Forms.Button BookBack;
        private System.Windows.Forms.Button BackAll;
    }
}

