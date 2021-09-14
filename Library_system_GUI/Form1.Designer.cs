
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
            this.SuspendLayout();
            // 
            // BooklistBox
            // 
            this.BooklistBox.FormattingEnabled = true;
            this.BooklistBox.ItemHeight = 16;
            this.BooklistBox.Location = new System.Drawing.Point(57, 54);
            this.BooklistBox.Name = "BooklistBox";
            this.BooklistBox.Size = new System.Drawing.Size(170, 276);
            this.BooklistBox.TabIndex = 0;
            // 
            // BookReaderlistBox
            // 
            this.BookReaderlistBox.FormattingEnabled = true;
            this.BookReaderlistBox.ItemHeight = 16;
            this.BookReaderlistBox.Location = new System.Drawing.Point(284, 54);
            this.BookReaderlistBox.Name = "BookReaderlistBox";
            this.BookReaderlistBox.Size = new System.Drawing.Size(170, 276);
            this.BookReaderlistBox.TabIndex = 1;
            // 
            // AddBk
            // 
            this.AddBk.Location = new System.Drawing.Point(558, 54);
            this.AddBk.Name = "AddBk";
            this.AddBk.Size = new System.Drawing.Size(150, 50);
            this.AddBk.TabIndex = 2;
            this.AddBk.Text = "Добавить книгу";
            this.AddBk.UseVisualStyleBackColor = true;
            this.AddBk.Click += new System.EventHandler(this.AddBk_Click);
            // 
            // AddBookReader
            // 
            this.AddBookReader.Location = new System.Drawing.Point(558, 110);
            this.AddBookReader.Name = "AddBookReader";
            this.AddBookReader.Size = new System.Drawing.Size(150, 50);
            this.AddBookReader.TabIndex = 3;
            this.AddBookReader.Text = "Добавить читателя";
            this.AddBookReader.UseVisualStyleBackColor = true;
            this.AddBookReader.Click += new System.EventHandler(this.AddBookReader_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBookReader);
            this.Controls.Add(this.AddBk);
            this.Controls.Add(this.BookReaderlistBox);
            this.Controls.Add(this.BooklistBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BooklistBox;
        private System.Windows.Forms.ListBox BookReaderlistBox;
        private System.Windows.Forms.Button AddBk;
        private System.Windows.Forms.Button AddBookReader;
    }
}

