
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IdCustomersTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.SelectedCustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.AddCustomersButton = new System.Windows.Forms.Button();
            this.RemoveCustomersButton = new System.Windows.Forms.Button();
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTextBox.Location = new System.Drawing.Point(300, 135);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(496, 127);
            this.AddressTextBox.TabIndex = 27;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(297, 40);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 22;
            this.IdLabel.Text = "ID:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(363, 75);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(433, 20);
            this.FullNameTextBox.TabIndex = 26;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // IdCustomersTextBox
            // 
            this.IdCustomersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdCustomersTextBox.Location = new System.Drawing.Point(363, 36);
            this.IdCustomersTextBox.Name = "IdCustomersTextBox";
            this.IdCustomersTextBox.ReadOnly = true;
            this.IdCustomersTextBox.Size = new System.Drawing.Size(433, 20);
            this.IdCustomersTextBox.TabIndex = 25;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(297, 79);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 23;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(297, 119);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 24;
            this.AddressLabel.Text = "Address:";
            // 
            // SelectedCustomersLabel
            // 
            this.SelectedCustomersLabel.AutoSize = true;
            this.SelectedCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomersLabel.Location = new System.Drawing.Point(297, 6);
            this.SelectedCustomersLabel.Name = "SelectedCustomersLabel";
            this.SelectedCustomersLabel.Size = new System.Drawing.Size(109, 13);
            this.SelectedCustomersLabel.TabIndex = 21;
            this.SelectedCustomersLabel.Text = "SelectedCustomer";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(6, 22);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(288, 433);
            this.CustomersListBox.TabIndex = 20;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 6);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomersLabel.TabIndex = 28;
            this.CustomersLabel.Text = "Customers";
            // 
            // AddCustomersButton
            // 
            this.AddCustomersButton.Location = new System.Drawing.Point(6, 461);
            this.AddCustomersButton.Name = "AddCustomersButton";
            this.AddCustomersButton.Size = new System.Drawing.Size(93, 44);
            this.AddCustomersButton.TabIndex = 29;
            this.AddCustomersButton.Text = "Add";
            this.AddCustomersButton.UseVisualStyleBackColor = true;
            this.AddCustomersButton.Click += new System.EventHandler(this.AddCustomersButton_Click);
            // 
            // RemoveCustomersButton
            // 
            this.RemoveCustomersButton.Location = new System.Drawing.Point(105, 461);
            this.RemoveCustomersButton.Name = "RemoveCustomersButton";
            this.RemoveCustomersButton.Size = new System.Drawing.Size(93, 44);
            this.RemoveCustomersButton.TabIndex = 30;
            this.RemoveCustomersButton.Text = "Remove";
            this.RemoveCustomersButton.UseVisualStyleBackColor = true;
            this.RemoveCustomersButton.Click += new System.EventHandler(this.RemoveCustomersButton_Click);
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomersPanel.Location = new System.Drawing.Point(300, 268);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(496, 238);
            this.CustomersPanel.TabIndex = 31;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomersPanel);
            this.Controls.Add(this.AddCustomersButton);
            this.Controls.Add(this.RemoveCustomersButton);
            this.Controls.Add(this.CustomersLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.IdCustomersTextBox);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.SelectedCustomersLabel);
            this.Controls.Add(this.CustomersListBox);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(801, 513);
            this.Load += new System.EventHandler(this.CustomersTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox IdCustomersTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label SelectedCustomersLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.Button AddCustomersButton;
        private System.Windows.Forms.Button RemoveCustomersButton;
        private System.Windows.Forms.Panel CustomersPanel;
    }
}
