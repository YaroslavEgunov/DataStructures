namespace Programming.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EnumPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChooseSeasonComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.OutLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabEnums = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Rectangles_groupBox1 = new System.Windows.Forms.GroupBox();
            this.Find_button = new System.Windows.Forms.Button();
            this.ColortextBox3 = new System.Windows.Forms.TextBox();
            this.LenghttextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WidthtextBox = new System.Windows.Forms.TextBox();
            this.RectangleslistBox1 = new System.Windows.Forms.ListBox();
            this.Width_label = new System.Windows.Forms.Label();
            this.Lenght_label = new System.Windows.Forms.Label();
            this.EnumPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.TabEnums.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Rectangles_groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumPage
            // 
            this.EnumPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumPage.Controls.Add(this.EnumerationsGroupBox);
            this.EnumPage.Location = new System.Drawing.Point(4, 22);
            this.EnumPage.Name = "EnumPage";
            this.EnumPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumPage.Size = new System.Drawing.Size(628, 471);
            this.EnumPage.TabIndex = 0;
            this.EnumPage.Text = "Enums";
            this.EnumPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.label5);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(318, 329);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(302, 133);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(182, 43);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(76, 21);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ChooseSeasonComboBox
            // 
            this.ChooseSeasonComboBox.FormattingEnabled = true;
            this.ChooseSeasonComboBox.Location = new System.Drawing.Point(6, 42);
            this.ChooseSeasonComboBox.Name = "ChooseSeasonComboBox";
            this.ChooseSeasonComboBox.Size = new System.Drawing.Size(167, 21);
            this.ChooseSeasonComboBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose season:";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.OutLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseInput);
            this.WeekdayParsingGroupBox.Controls.Add(this.label4);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(8, 329);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(304, 133);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // OutLabel
            // 
            this.OutLabel.AutoSize = true;
            this.OutLabel.Location = new System.Drawing.Point(6, 91);
            this.OutLabel.Name = "OutLabel";
            this.OutLabel.Size = new System.Drawing.Size(0, 13);
            this.OutLabel.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(179, 43);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(70, 20);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseInput
            // 
            this.ParseInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParseInput.Location = new System.Drawing.Point(6, 43);
            this.ParseInput.Name = "ParseInput";
            this.ParseInput.Size = new System.Drawing.Size(167, 20);
            this.ParseInput.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type value for parsing:";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.IntBox);
            this.EnumerationsGroupBox.Controls.Add(this.label3);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.label2);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Controls.Add(this.label1);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(612, 317);
            this.EnumerationsGroupBox.TabIndex = 0;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // IntBox
            // 
            this.IntBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntBox.Enabled = false;
            this.IntBox.Location = new System.Drawing.Point(351, 36);
            this.IntBox.Name = "IntBox";
            this.IntBox.Size = new System.Drawing.Size(122, 20);
            this.IntBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(179, 36);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(141, 264);
            this.ValuesListBox.TabIndex = 3;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(6, 36);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(141, 264);
            this.EnumsListBox.TabIndex = 1;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose enumerations:";
            // 
            // TabEnums
            // 
            this.TabEnums.Controls.Add(this.EnumPage);
            this.TabEnums.Controls.Add(this.tabPage1);
            this.TabEnums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabEnums.Location = new System.Drawing.Point(0, 0);
            this.TabEnums.Name = "TabEnums";
            this.TabEnums.SelectedIndex = 0;
            this.TabEnums.Size = new System.Drawing.Size(636, 497);
            this.TabEnums.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Rectangles_groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 471);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Classes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Rectangles_groupBox1
            // 
            this.Rectangles_groupBox1.Controls.Add(this.Find_button);
            this.Rectangles_groupBox1.Controls.Add(this.ColortextBox3);
            this.Rectangles_groupBox1.Controls.Add(this.LenghttextBox);
            this.Rectangles_groupBox1.Controls.Add(this.label8);
            this.Rectangles_groupBox1.Controls.Add(this.WidthtextBox);
            this.Rectangles_groupBox1.Controls.Add(this.RectangleslistBox1);
            this.Rectangles_groupBox1.Controls.Add(this.Width_label);
            this.Rectangles_groupBox1.Controls.Add(this.Lenght_label);
            this.Rectangles_groupBox1.Location = new System.Drawing.Point(8, 6);
            this.Rectangles_groupBox1.Name = "Rectangles_groupBox1";
            this.Rectangles_groupBox1.Size = new System.Drawing.Size(314, 457);
            this.Rectangles_groupBox1.TabIndex = 1;
            this.Rectangles_groupBox1.TabStop = false;
            this.Rectangles_groupBox1.Text = "Rectangles";
            // 
            // Find_button
            // 
            this.Find_button.Location = new System.Drawing.Point(113, 402);
            this.Find_button.Name = "Find_button";
            this.Find_button.Size = new System.Drawing.Size(100, 23);
            this.Find_button.TabIndex = 6;
            this.Find_button.Text = "Find";
            this.Find_button.UseVisualStyleBackColor = true;
            this.Find_button.Click += new System.EventHandler(this.Find_button_Click);
            // 
            // ColortextBox3
            // 
            this.ColortextBox3.Location = new System.Drawing.Point(19, 358);
            this.ColortextBox3.Name = "ColortextBox3";
            this.ColortextBox3.Size = new System.Drawing.Size(274, 20);
            this.ColortextBox3.TabIndex = 2;
            // 
            // LenghttextBox
            // 
            this.LenghttextBox.Location = new System.Drawing.Point(19, 257);
            this.LenghttextBox.Name = "LenghttextBox";
            this.LenghttextBox.Size = new System.Drawing.Size(274, 20);
            this.LenghttextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Color: ";
            // 
            // WidthtextBox
            // 
            this.WidthtextBox.Location = new System.Drawing.Point(19, 307);
            this.WidthtextBox.Name = "WidthtextBox";
            this.WidthtextBox.Size = new System.Drawing.Size(274, 20);
            this.WidthtextBox.TabIndex = 0;
            
            // 
            // RectangleslistBox1
            // 
            this.RectangleslistBox1.FormattingEnabled = true;
            this.RectangleslistBox1.Location = new System.Drawing.Point(19, 19);
            this.RectangleslistBox1.Name = "RectangleslistBox1";
            this.RectangleslistBox1.Size = new System.Drawing.Size(274, 186);
            this.RectangleslistBox1.TabIndex = 0;
            this.RectangleslistBox1.SelectedIndexChanged += new System.EventHandler(this.RectangleslistBox1_SelectedIndexChanged);
            // 
            // Width_label
            // 
            this.Width_label.AutoSize = true;
            this.Width_label.Location = new System.Drawing.Point(16, 291);
            this.Width_label.Name = "Width_label";
            this.Width_label.Size = new System.Drawing.Size(41, 13);
            this.Width_label.TabIndex = 4;
            this.Width_label.Text = "Width: ";
            // 
            // Lenght_label
            // 
            this.Lenght_label.AutoSize = true;
            this.Lenght_label.Location = new System.Drawing.Point(16, 241);
            this.Lenght_label.Name = "Lenght_label";
            this.Lenght_label.Size = new System.Drawing.Size(46, 13);
            this.Lenght_label.TabIndex = 3;
            this.Lenght_label.Text = "Lenght: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 497);
            this.Controls.Add(this.TabEnums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.EnumPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.TabEnums.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Rectangles_groupBox1.ResumeLayout(false);
            this.Rectangles_groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage EnumPage;
        private System.Windows.Forms.TabControl TabEnums;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IntBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParseInput;
        private System.Windows.Forms.Label OutLabel;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox ChooseSeasonComboBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox WidthtextBox;
        private System.Windows.Forms.TextBox LenghttextBox;
        private System.Windows.Forms.TextBox ColortextBox3;
        private System.Windows.Forms.Label Lenght_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Find_button;
        private System.Windows.Forms.Label Width_label;
        private System.Windows.Forms.GroupBox Rectangles_groupBox1;
        private System.Windows.Forms.ListBox RectangleslistBox1;
    }
}

