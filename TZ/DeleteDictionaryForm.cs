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
    public partial class DeleteDictionaryForm : Form
    {

        private DataGridViewCheckBoxColumn checkBoxColum = new DataGridViewCheckBoxColumn();
        private List<Dictionary> dictionaries = new List<Dictionary>();
        public DeleteDictionaryForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            dictionariesGrid.Columns.Add(checkBoxColum);
            RefreshGrid();
            foreach (DataGridViewColumn column in dictionariesGrid.Columns)
            {
                column.ReadOnly = true;
            }
            dictionariesGrid.Columns[0].ReadOnly = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            List<Dictionary> dictionariesToDelete = new List<Dictionary>();
            for(int i = 0; i < dictionariesGrid.Rows.Count; i++)
            {
                if(Boolean.Parse(dictionariesGrid[0,i].FormattedValue.ToString()))
                {
                    foreach(Dictionary dictionary in dictionaries)
                    {
                        if (dictionary.Id == int.Parse(dictionariesGrid[1, i].FormattedValue.ToString()))
                            dictionariesToDelete.Add(dictionary);
                    }
                }
            }
            List<Dictionary> childDictionaries = DBCommand.CascadeDeleteDictionariesPrediction(dictionariesToDelete);
            DeleteConfirmForm confirmForm = new DeleteConfirmForm(childDictionaries);
            confirmForm.ShowDialog();
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            dictionaries = DBCommand.GetDictionaries();
            dictionariesGrid.DataSource = null;
            dictionariesGrid.DataSource = dictionaries;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
