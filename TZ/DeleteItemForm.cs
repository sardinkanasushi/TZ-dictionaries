using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TZ
{
    public partial class DeleteItemForm : Form
    {
        private DataGridViewCheckBoxColumn checkBoxColum = new DataGridViewCheckBoxColumn();
        private List<Item> items = new List<Item>();
        private int? chosenDictionaryId;
        public DeleteItemForm(int? id = null)
        {
            chosenDictionaryId = id;
            InitializeComponent();
        }

        private void DeleteItemForm_Load(object sender, EventArgs e)
        {
            itemsGrid.Columns.Add(checkBoxColum);
            RefreshGrid();
            foreach (DataGridViewColumn column in itemsGrid.Columns)
            {
                column.ReadOnly = true;
            }
            itemsGrid.Columns[0].ReadOnly = false;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            List<Item> itemsToDelete = new List<Item>();
            for (int i = 0; i < itemsGrid.Rows.Count; i++)
            {
                if (Boolean.Parse(itemsGrid[0, i].FormattedValue.ToString()))
                {
                    itemsToDelete.Add(items[i]);
                }
            }
            DBCommand.DeleteItem(itemsToDelete);
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            items = DBCommand.GetItems(chosenDictionaryId);
            itemsGrid.DataSource = null;
            itemsGrid.DataSource = items;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
