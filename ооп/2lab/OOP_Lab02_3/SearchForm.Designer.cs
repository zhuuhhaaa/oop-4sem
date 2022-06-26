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
            this.inputBookTitle.Location = new System.Drawing.Point(12, 25);
            this.inputBookTitle.Name = "inputBookTitle";
            this.inputBookTitle.Size = new System.Drawing.Size(353, 20);
            this.inputBookTitle.TabIndex = 0;
            this.inputBookTitle.TextChanged += new System.EventHandler(this.inputBookTitle_TextChanged);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable.ForeColor = System.Drawing.Color.Black;
            this.lable.Location = new System.Drawing.Point(170, 9);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(61, 13);
            this.lable.TabIndex = 1;
            this.lable.Text = "Book title";
            // 
            // listBoxSearchResult
            // 
            this.listBoxSearchResult.FormattingEnabled = true;
            this.listBoxSearchResult.Location = new System.Drawing.Point(12, 66);
            this.listBoxSearchResult.Name = "listBoxSearchResult";
            this.listBoxSearchResult.Size = new System.Drawing.Size(353, 173);
            this.listBoxSearchResult.TabIndex = 2;
            // 
            // labelFound
            // 
            this.labelFound.AutoSize = true;
            this.labelFound.Location = new System.Drawing.Point(11, 241);
            this.labelFound.Name = "labelFound";
            this.labelFound.Size = new System.Drawing.Size(49, 13);
            this.labelFound.TabIndex = 3;
            this.labelFound.Text = "Found: 0";
            // 
            // gbSearchFormat
            // 
            this.gbSearchFormat.Controls.Add(this.rbRegex);
            this.gbSearchFormat.Controls.Add(this.rbLinq);
            this.gbSearchFormat.ForeColor = System.Drawing.Color.Black;
            this.gbSearchFormat.Location = new System.Drawing.Point(382, 9);
            this.gbSearchFormat.Name = "gbSearchFormat";
            this.gbSearchFormat.Size = new System.Drawing.Size(94, 113);
            this.gbSearchFormat.TabIndex = 4;
            this.gbSearchFormat.TabStop = false;
            this.gbSearchFormat.Text = "Search format";
            // 
            // rbRegex
            // 
            this.rbRegex.AutoSize = true;
            this.rbRegex.Location = new System.Drawing.Point(6, 43);
            this.rbRegex.Name = "rbRegex";
            this.rbRegex.Size = new System.Drawing.Size(56, 17);
            this.rbRegex.TabIndex = 1;
            this.rbRegex.Text = "Regex";
            this.rbRegex.UseVisualStyleBackColor = true;
            this.rbRegex.CheckedChanged += new System.EventHandler(this.rbSearchFormat_CheckedChanged);
            // 
            // rbLinq
            // 
            this.rbLinq.AutoSize = true;
            this.rbLinq.Checked = true;
            this.rbLinq.Location = new System.Drawing.Point(7, 20);
            this.rbLinq.Name = "rbLinq";
            this.rbLinq.Size = new System.Drawing.Size(50, 17);
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
            this.btnYearSort.Location = new System.Drawing.Point(382, 128);
            this.btnYearSort.Name = "btnYearSort";
            this.btnYearSort.Size = new System.Drawing.Size(94, 33);
            this.btnYearSort.TabIndex = 5;
            this.btnYearSort.Text = "year sort";
            this.btnYearSort.UseVisualStyleBackColor = false;
            this.btnYearSort.Click += new System.EventHandler(this.btnYearSort_Click);
            // 
            // btnPageSort
            // 
            this.btnPageSort.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPageSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPageSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPageSort.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPageSort.Location = new System.Drawing.Point(382, 167);
            this.btnPageSort.Name = "btnPageSort";
            this.btnPageSort.Size = new System.Drawing.Size(94, 33);
            this.btnPageSort.TabIndex = 5;
            this.btnPageSort.Text = "page sort";
            this.btnPageSort.UseVisualStyleBackColor = false;
            this.btnPageSort.Click += new System.EventHandler(this.btnPageSort_Click);
            // 
            // btnUploadSort
            // 
            this.btnUploadSort.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUploadSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUploadSort.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUploadSort.Location = new System.Drawing.Point(382, 206);
            this.btnUploadSort.Name = "btnUploadSort";
            this.btnUploadSort.Size = new System.Drawing.Size(94, 33);
            this.btnUploadSort.TabIndex = 5;
            this.btnUploadSort.Text = "upload sort";
            this.btnUploadSort.UseVisualStyleBackColor = false;
            this.btnUploadSort.Click += new System.EventHandler(this.btnUploadSort_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 262);
            this.Controls.Add(this.btnUploadSort);
            this.Controls.Add(this.btnPageSort);
            this.Controls.Add(this.btnYearSort);
            this.Controls.Add(this.gbSearchFormat);
            this.Controls.Add(this.labelFound);
            this.Controls.Add(this.listBoxSearchResult);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.inputBookTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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