namespace Homework12
{
    partial class MenuItemsAddingForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.subItemTextBox = new System.Windows.Forms.TextBox();
            this.addSubItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip1";
            this.menuStrip.Size = new System.Drawing.Size(336, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(45, 117);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemTextBox.TabIndex = 1;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(172, 111);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(142, 30);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Добавить пункт меню";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // subItemTextBox
            // 
            this.subItemTextBox.Location = new System.Drawing.Point(45, 191);
            this.subItemTextBox.Name = "subItemTextBox";
            this.subItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.subItemTextBox.TabIndex = 3;
            // 
            // addSubItemButton
            // 
            this.addSubItemButton.Location = new System.Drawing.Point(172, 185);
            this.addSubItemButton.Name = "addSubItemButton";
            this.addSubItemButton.Size = new System.Drawing.Size(142, 31);
            this.addSubItemButton.TabIndex = 4;
            this.addSubItemButton.Text = "Добавить подменю";
            this.addSubItemButton.UseVisualStyleBackColor = true;
            this.addSubItemButton.Click += new System.EventHandler(this.AddSubItemButton_Click);
            // 
            // MenuItemsAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 340);
            this.Controls.Add(this.addSubItemButton);
            this.Controls.Add(this.subItemTextBox);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuItemsAddingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox subItemTextBox;
        private System.Windows.Forms.Button addSubItemButton;
    }
}

