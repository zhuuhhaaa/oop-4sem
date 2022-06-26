namespace OOP_Lab02_3
{
    partial class MainForm
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
            this.inputNameField = new System.Windows.Forms.TextBox();
            this.nameLable = new System.Windows.Forms.Label();
            this.inputAuthorField = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.inputYearField = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.inputPublisherField = new System.Windows.Forms.TextBox();
            this.bookSizeLabel = new System.Windows.Forms.Label();
            this.bookSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.formatBox = new System.Windows.Forms.GroupBox();
            this.rbFormat3 = new System.Windows.Forms.RadioButton();
            this.rbFormat2 = new System.Windows.Forms.RadioButton();
            this.rbFormat1 = new System.Windows.Forms.RadioButton();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.inputFileSizeField = new System.Windows.Forms.TextBox();
            this.ulpDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uplDateLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.loadInFile = new System.Windows.Forms.Button();
            this.loadFromFile = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bookSizeTrackBar)).BeginInit();
            this.formatBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputNameField
            // 
            this.inputNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputNameField.Location = new System.Drawing.Point(12, 57);
            this.inputNameField.Name = "inputNameField";
            this.inputNameField.Size = new System.Drawing.Size(159, 20);
            this.inputNameField.TabIndex = 0;
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(12, 37);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(35, 13);
            this.nameLable.TabIndex = 1;
            this.nameLable.Text = "Name";
            // 
            // inputAuthorField
            // 
            this.inputAuthorField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputAuthorField.Location = new System.Drawing.Point(12, 107);
            this.inputAuthorField.Name = "inputAuthorField";
            this.inputAuthorField.Size = new System.Drawing.Size(159, 20);
            this.inputAuthorField.TabIndex = 1;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(12, 87);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 137);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year";
            // 
            // inputYearField
            // 
            this.inputYearField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputYearField.Location = new System.Drawing.Point(12, 157);
            this.inputYearField.Name = "inputYearField";
            this.inputYearField.Size = new System.Drawing.Size(159, 20);
            this.inputYearField.TabIndex = 2;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(12, 257);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(50, 13);
            this.publisherLabel.TabIndex = 5;
            this.publisherLabel.Text = "Publisher";
            // 
            // inputPublisherField
            // 
            this.inputPublisherField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputPublisherField.Location = new System.Drawing.Point(12, 277);
            this.inputPublisherField.Name = "inputPublisherField";
            this.inputPublisherField.Size = new System.Drawing.Size(159, 20);
            this.inputPublisherField.TabIndex = 4;
            // 
            // bookSizeLabel
            // 
            this.bookSizeLabel.AutoSize = true;
            this.bookSizeLabel.Location = new System.Drawing.Point(12, 187);
            this.bookSizeLabel.Name = "bookSizeLabel";
            this.bookSizeLabel.Size = new System.Drawing.Size(68, 13);
            this.bookSizeLabel.TabIndex = 7;
            this.bookSizeLabel.Text = "Book size (1)";
            // 
            // bookSizeTrackBar
            // 
            this.bookSizeTrackBar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bookSizeTrackBar.LargeChange = 1;
            this.bookSizeTrackBar.Location = new System.Drawing.Point(12, 207);
            this.bookSizeTrackBar.Maximum = 300;
            this.bookSizeTrackBar.Minimum = 1;
            this.bookSizeTrackBar.Name = "bookSizeTrackBar";
            this.bookSizeTrackBar.Size = new System.Drawing.Size(159, 45);
            this.bookSizeTrackBar.TabIndex = 3;
            this.bookSizeTrackBar.Value = 1;
            this.bookSizeTrackBar.Scroll += new System.EventHandler(this.bookSizeTrackBar_Scroll);
            // 
            // formatBox
            // 
            this.formatBox.Controls.Add(this.rbFormat3);
            this.formatBox.Controls.Add(this.rbFormat2);
            this.formatBox.Controls.Add(this.rbFormat1);
            this.formatBox.Location = new System.Drawing.Point(12, 317);
            this.formatBox.Name = "formatBox";
            this.formatBox.Size = new System.Drawing.Size(159, 100);
            this.formatBox.TabIndex = 9;
            this.formatBox.TabStop = false;
            this.formatBox.Text = "Format";
            // 
            // rbFormat3
            // 
            this.rbFormat3.AutoSize = true;
            this.rbFormat3.Location = new System.Drawing.Point(3, 66);
            this.rbFormat3.Name = "rbFormat3";
            this.rbFormat3.Size = new System.Drawing.Size(46, 17);
            this.rbFormat3.TabIndex = 2;
            this.rbFormat3.Text = "TXT";
            this.rbFormat3.UseVisualStyleBackColor = true;
            // 
            // rbFormat2
            // 
            this.rbFormat2.AutoSize = true;
            this.rbFormat2.Location = new System.Drawing.Point(3, 43);
            this.rbFormat2.Name = "rbFormat2";
            this.rbFormat2.Size = new System.Drawing.Size(54, 17);
            this.rbFormat2.TabIndex = 1;
            this.rbFormat2.Text = "EPUB";
            this.rbFormat2.UseVisualStyleBackColor = true;
            // 
            // rbFormat1
            // 
            this.rbFormat1.AutoSize = true;
            this.rbFormat1.Checked = true;
            this.rbFormat1.Location = new System.Drawing.Point(3, 20);
            this.rbFormat1.Name = "rbFormat1";
            this.rbFormat1.Size = new System.Drawing.Size(44, 17);
            this.rbFormat1.TabIndex = 0;
            this.rbFormat1.TabStop = true;
            this.rbFormat1.Text = "FB2";
            this.rbFormat1.UseVisualStyleBackColor = true;
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(12, 427);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(44, 13);
            this.fileSizeLabel.TabIndex = 11;
            this.fileSizeLabel.Text = "File size";
            // 
            // inputFileSizeField
            // 
            this.inputFileSizeField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputFileSizeField.Location = new System.Drawing.Point(12, 447);
            this.inputFileSizeField.Name = "inputFileSizeField";
            this.inputFileSizeField.Size = new System.Drawing.Size(159, 20);
            this.inputFileSizeField.TabIndex = 5;
            // 
            // ulpDatePicker
            // 
            this.ulpDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ulpDatePicker.Location = new System.Drawing.Point(12, 497);
            this.ulpDatePicker.Name = "ulpDatePicker";
            this.ulpDatePicker.Size = new System.Drawing.Size(159, 20);
            this.ulpDatePicker.TabIndex = 6;
            // 
            // uplDateLabel
            // 
            this.uplDateLabel.AutoSize = true;
            this.uplDateLabel.Location = new System.Drawing.Point(12, 477);
            this.uplDateLabel.Name = "uplDateLabel";
            this.uplDateLabel.Size = new System.Drawing.Size(77, 13);
            this.uplDateLabel.TabIndex = 13;
            this.uplDateLabel.Text = "Date of upload";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(12, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addButton_Click);
            // 
            // loadInFile
            // 
            this.loadInFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.loadInFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadInFile.ForeColor = System.Drawing.SystemColors.Window;
            this.loadInFile.Location = new System.Drawing.Point(200, 35);
            this.loadInFile.Name = "loadInFile";
            this.loadInFile.Size = new System.Drawing.Size(120, 42);
            this.loadInFile.TabIndex = 8;
            this.loadInFile.Text = "Upload to file";
            this.loadInFile.UseVisualStyleBackColor = false;
            this.loadInFile.Click += new System.EventHandler(this.loadInFile_Click);
            // 
            // loadFromFile
            // 
            this.loadFromFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.loadFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadFromFile.ForeColor = System.Drawing.SystemColors.Window;
            this.loadFromFile.Location = new System.Drawing.Point(331, 35);
            this.loadFromFile.Name = "loadFromFile";
            this.loadFromFile.Size = new System.Drawing.Size(120, 42);
            this.loadFromFile.TabIndex = 9;
            this.loadFromFile.Text = "Load from file";
            this.loadFromFile.UseVisualStyleBackColor = false;
            this.loadFromFile.Click += new System.EventHandler(this.loadFromFile_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(200, 92);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(251, 511);
            this.listBox.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searhToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searhToolStripMenuItem
            // 
            this.searhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.searhToolStripMenuItem.Name = "searhToolStripMenuItem";
            this.searhToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.searhToolStripMenuItem.Text = "Menu";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(462, 616);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.loadFromFile);
            this.Controls.Add(this.loadInFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uplDateLabel);
            this.Controls.Add(this.ulpDatePicker);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.inputFileSizeField);
            this.Controls.Add(this.formatBox);
            this.Controls.Add(this.bookSizeTrackBar);
            this.Controls.Add(this.bookSizeLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.inputPublisherField);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.inputYearField);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.inputAuthorField);
            this.Controls.Add(this.inputNameField);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bookSizeTrackBar)).EndInit();
            this.formatBox.ResumeLayout(false);
            this.formatBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNameField;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox inputAuthorField;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox inputYearField;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox inputPublisherField;
        private System.Windows.Forms.Label bookSizeLabel;
        private System.Windows.Forms.TrackBar bookSizeTrackBar;
        private System.Windows.Forms.GroupBox formatBox;
        private System.Windows.Forms.RadioButton rbFormat3;
        private System.Windows.Forms.RadioButton rbFormat2;
        private System.Windows.Forms.RadioButton rbFormat1;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.TextBox inputFileSizeField;
        private System.Windows.Forms.DateTimePicker ulpDatePicker;
        private System.Windows.Forms.Label uplDateLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loadInFile;
        private System.Windows.Forms.Button loadFromFile;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

