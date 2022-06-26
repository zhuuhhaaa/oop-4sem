namespace OOP_Lab02_3
{
    partial class SearchForm
    {
        Library library;
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
            this.inputBookTitle = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.listBoxSearchResult = new System.Windows.Forms.ListBox();
            this.labelFound = new System.Windows.Forms.Label();
            this.gbSearchFormat = new System.Windows.Forms.GroupBox();
            this.rbRegex = new System.Windows.Forms.RadioButton();
            this.rbLinq = new System.Windows.Forms.RadioButton();
            this.btnYearSort = new System.Windows.Forms.Button();
            this.btnPageSort = new System.Windows.Forms.Button();
            this.btnUploadSort = new System.Windows.Forms.Button();
            this.gbSearchFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBookTitle
            // 
            this.inputBookTitle.Location = new System.Drawing.Point(24, 48);
            this.inputBookTitle.Margin = new System.Windows.Forms.Padding(6);
            this.inputBookTitle.Name = "inputBookTitle";
            this.inputBookTitle.Size = new System.Drawing.Size(728, 31);
            this.inputBookTitle.TabIndex = 0;
            this.inputBookTitle.TextChanged += new System.EventHandler(this.inputBookTitle_TextChanged);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable.ForeColor = System.Drawing.Color.Black;
            this.lable.Location = new System.Drawing.Point(340, 17);
            this.lable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(186, 26);
            this.lable.TabIndex = 1;
            this.lable.Text = "Название книги";
            // 
            // listBoxSearchResult
            // 
            this.listBoxSearchResult.FormattingEnabled = true;
            this.listBoxSearchResult.ItemHeight = 25;
            this.listBoxSearchResult.Location = new System.Drawing.Point(24, 127);
            this.listBoxSearchResult.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxSearchResult.Name = "listBoxSearchResult";
            this.listBoxSearchResult.Size = new System.Drawing.Size(728, 329);
            this.listBoxSearchResult.TabIndex = 2;
            // 
            // labelFound
            // 
            this.labelFound.AutoSize = true;
            this.labelFound.Location = new System.Drawing.Point(22, 463);
            this.labelFound.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFound.Name = "labelFound";
            this.labelFound.Size = new System.Drawing.Size(123, 25);
            this.labelFound.TabIndex = 3;
            this.labelFound.Text = "Найдено: 0";
            // 
            // gbSearchFormat
            // 
            this.gbSearchFormat.Controls.Add(this.rbRegex);
            this.gbSearchFormat.Controls.Add(this.rbLinq);
            this.gbSearchFormat.ForeColor = System.Drawing.Color.Black;
            this.gbSearchFormat.Location = new System.Drawing.Point(764, 17);
            this.gbSearchFormat.Margin = new System.Windows.Forms.Padding(6);
            this.gbSearchFormat.Name = "gbSearchFormat";
            this.gbSearchFormat.Padding = new System.Windows.Forms.Padding(6);
            this.gbSearchFormat.Size = new System.Drawing.Size(188, 217);
            this.gbSearchFormat.TabIndex = 4;
            this.gbSearchFormat.TabStop = false;
            this.gbSearchFormat.Text = "Формат поиска";
            // 
            // rbRegex
            // 
            this.rbRegex.AutoSize = true;
            this.rbRegex.Location = new System.Drawing.Point(12, 83);
            this.rbRegex.Margin = new System.Windows.Forms.Padding(6);
            this.rbRegex.Name = "rbRegex";
            this.rbRegex.Size = new System.Drawing.Size(105, 29);
            this.rbRegex.TabIndex = 1;
            this.rbRegex.Text = "Regex";
            this.rbRegex.UseVisualStyleBackColor = true;
            this.rbRegex.CheckedChanged += new System.EventHandler(this.rbSearchFormat_CheckedChanged);
            // 
            // rbLinq
            // 
            this.rbLinq.AutoSize = true;
            this.rbLinq.Checked = true;
            this.rbLinq.Location = new System.Drawing.Point(14, 38);
            this.rbLinq.Margin = new System.Windows.Forms.Padding(6);
            this.rbLinq.Name = "rbLinq";
            this.rbLinq.Size = new System.Drawing.Size(91, 29);
            this.rbLinq.TabIndex = 0;
            this.rbLinq.TabStop = true;
            this.rbLinq.Text = "LINQ";
            this.rbLinq.UseVisualStyleBackColor = true;
            this.rbLinq.CheckedChanged += new System.EventHandler(this.rbSearchFormat_CheckedChanged);
            // 
            // btnYearSort
            // 
            this.btnYearSort.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnYearSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYearSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYearSort.ForeColor = System.Drawing.SystemColors.Window;
            this.btnYearSort.Location = new System.Drawing.Point(764, 246);
            this.btnYearSort.Margin = new System.Windows.Forms.Padding(6);
            this.btnYearSort.Name = "btnYearSort";
            this.btnYearSort.Size = new System.Drawing.Size(188, 63);
            this.btnYearSort.TabIndex = 5;
            this.btnYearSort.Text = "Сортировка по году";
            this.btnYearSort.UseVisualStyleBackColor = false;
            this.btnYearSort.Click += new System.EventHandler(this.btnYearSort_Click);
            // 
            // btnPageSort
            // 
            this.btnPageSort.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPageSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPageSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPageSort.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPageSort.Location = new System.Drawing.Point(764, 321);
            this.btnPageSort.Margin = new System.Windows.Forms.Padding(6);
            this.btnPageSort.Name = "btnPageSort";
            this.btnPageSort.Size = new System.Drawing.Size(188, 63);
            this.btnPageSort.TabIndex = 5;
            this.btnPageSort.Text = "Сортировка по кол-ву страниц";
            this.btnPageSort.UseVisualStyleBackColor = false;
            this.btnPageSort.Click += new System.EventHandler(this.btnPageSort_Click);
            // 
            // btnUploadSort
            // 
            this.btnUploadSort.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUploadSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUploadSort.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUploadSort.Location = new System.Drawing.Point(764, 396);
            this.btnUploadSort.Margin = new System.Windows.Forms.Padding(6);
            this.btnUploadSort.Name = "btnUploadSort";
            this.btnUploadSort.Size = new System.Drawing.Size(188, 63);
            this.btnUploadSort.TabIndex = 5;
            this.btnUploadSort.Text = "Сортировка по дате загрузки";
            this.btnUploadSort.UseVisualStyleBackColor = false;
            this.btnUploadSort.Click += new System.EventHandler(this.btnUploadSort_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 504);
            this.Controls.Add(this.btnUploadSort);
            this.Controls.Add(this.btnPageSort);
            this.Controls.Add(this.btnYearSort);
            this.Controls.Add(this.gbSearchFormat);
            this.Controls.Add(this.labelFound);
            this.Controls.Add(this.listBoxSearchResult);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.inputBookTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.gbSearchFormat.ResumeLayout(false);
            this.gbSearchFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBookTitle;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ListBox listBoxSearchResult;
        private System.Windows.Forms.Label labelFound;
        private System.Windows.Forms.GroupBox gbSearchFormat;
        private System.Windows.Forms.RadioButton rbRegex;
        private System.Windows.Forms.RadioButton rbLinq;
        private System.Windows.Forms.Button btnYearSort;
        private System.Windows.Forms.Button btnPageSort;
        private System.Windows.Forms.Button btnUploadSort;
    }
}