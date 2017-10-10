using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework12
{
    public partial class MenuItemsAddingForm : Form
    {
        public MenuItemsAddingForm()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            ToolStripDropDownButton menuItem = new ToolStripDropDownButton();
            menuItem.Text = itemTextBox.Text;
            menuStrip.Items.Add(menuItem);
            itemTextBox.Text = null;
        }

        private void AddSubItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripDropDownButton menuSubItem = new ToolStripDropDownButton();
                menuSubItem.Text = subItemTextBox.Text;
                foreach(ToolStripDropDownButton item in menuStrip.Items)
                {
                    item.DropDownItems.Add(menuSubItem);
                }
                subItemTextBox.Text = null;
            }
            catch
            {
                MessageBox.Show("Пожалуйста добавьте пункты меню");
            }
        }
    }
}
