
namespace Library_system_GUI
{
    partial class Start
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
            this.New_lib = new System.Windows.Forms.Button();
            this.Upload_lib = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_lib
            // 
            this.New_lib.Location = new System.Drawing.Point(12, 12);
            this.New_lib.Name = "New_lib";
            this.New_lib.Size = new System.Drawing.Size(407, 42);
            this.New_lib.TabIndex = 0;
            this.New_lib.Text = "Новая библиотека";
            this.New_lib.UseVisualStyleBackColor = true;
            this.New_lib.Click += new System.EventHandler(this.New_lib_Click);
            // 
            // Upload_lib
            // 
            this.Upload_lib.Location = new System.Drawing.Point(12, 60);
            this.Upload_lib.Name = "Upload_lib";
            this.Upload_lib.Size = new System.Drawing.Size(407, 42);
            this.Upload_lib.TabIndex = 1;
            this.Upload_lib.Text = "Загрузить библиотеку";
            this.Upload_lib.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 116);
            this.Controls.Add(this.Upload_lib);
            this.Controls.Add(this.New_lib);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New_lib;
        private System.Windows.Forms.Button Upload_lib;
    }
}