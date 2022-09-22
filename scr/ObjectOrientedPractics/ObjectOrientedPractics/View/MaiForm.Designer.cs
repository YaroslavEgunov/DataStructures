
namespace ObjectOrientedPractics.View
{
    partial class MaiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaiForm));
            this.CustomersTabControl = new System.Windows.Forms.TabPage();
            this.customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.ItemsTabControl = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CustomersTabControl.SuspendLayout();
            this.ItemsTabControl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersTabControl
            // 
            this.CustomersTabControl.Controls.Add(this.customersTab1);
            this.CustomersTabControl.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabControl.Name = "CustomersTabControl";
            this.CustomersTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabControl.Size = new System.Drawing.Size(797, 510);
            this.CustomersTabControl.TabIndex = 1;
            this.CustomersTabControl.Text = "Customers";
            this.CustomersTabControl.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            this.customersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab1.Location = new System.Drawing.Point(3, 3);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.Size = new System.Drawing.Size(791, 504);
            this.customersTab1.TabIndex = 0;
            // 
            // ItemsTabControl
            // 
            this.ItemsTabControl.Controls.Add(this.itemsTab1);
            this.ItemsTabControl.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabControl.Name = "ItemsTabControl";
            this.ItemsTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabControl.Size = new System.Drawing.Size(797, 510);
            this.ItemsTabControl.TabIndex = 0;
            this.ItemsTabControl.Text = "Items";
            this.ItemsTabControl.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsTab1.Location = new System.Drawing.Point(0, 0);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(801, 513);
            this.itemsTab1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ItemsTabControl);
            this.tabControl1.Controls.Add(this.CustomersTabControl);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // MaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 536);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaiForm";
            this.Text = "Object Oriented Practics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MaiForm_FormClosed);
            this.CustomersTabControl.ResumeLayout(false);
            this.ItemsTabControl.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage CustomersTabControl;
        private System.Windows.Forms.TabPage ItemsTabControl;
        private Tabs.ItemsTab itemsTab1;
        private System.Windows.Forms.TabControl tabControl1;
        private Tabs.CustomersTab customersTab1;
    }
}

