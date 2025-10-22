using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace TZ
{
    public partial class BaseForm : Form
    {
        private List<Dictionary> dictionaries = new List<Dictionary>();
        private List<Item> items = new List<Item>();
        private AddDictionaryForm addDictionaryForm;
        private AddItemForm addItemForm;
        private bool showMode = true;
        private int? chosenParenId = null;
        public BaseForm()
        {
            InitializeComponent();
        }
        private void RefreshDictionarise()
        {
            dictionaries.Clear();
            if(DBCommand.GetDictionaries() == null)
            {
                MessageForm messageForm = new MessageForm("Cant open chosen file.\nThere are no tables or you try to open wrong format");
                messageForm.ShowDialog();
            }
            else dictionaries.AddRange(DBCommand.GetDictionaries());

            RefreshChosenParentComboBox();
            RefreshDictionariesTable();
        }
        private void RefreshDictionariesTable()
        {
            dictionariesGrid.Rows.Clear();
            if (chosenParentComboBox.SelectedIndex == 1) chosenParenId = null;
            else if(chosenParentComboBox.SelectedIndex > 0)
            {
                if(int.TryParse(chosenParentComboBox.SelectedItem.ToString().Split(' ')[0], out int id))
                chosenParenId = id;
            }
            foreach(Dictionary dictionary in dictionaries)
            {
                if (dictionary.ParantId == chosenParenId || chosenParentComboBox.SelectedIndex == 0) dictionariesGrid.Rows.Add(
                    dictionary.Id,
                    dictionary.ParantId, 
                    dictionary.Name,
                    dictionary.Code, 
                    dictionary.Description);
            }
            if (showMode) foreach (DataGridViewColumn column in dictionariesGrid.Columns) 
                    column.Visible = true;
            else
            {
                foreach(DataGridViewColumn column in dictionariesGrid.Columns)
                    column.Visible = false;
                dictionariesGrid.Columns[2].Visible = true;
                dictionariesGrid.Columns[3].Visible = true;
                dictionariesGrid.Columns[4].Visible = true;
            }
        }
        
        private void RefreshItemsTable(object sender, EventArgs e)
        {
            RefreshItemsTable();
        }
        private void RefreshItemsTable()
        {
            itemsGrid.DataSource = null;
            if (dictionariesGrid.SelectedCells.Count > 0)
            {
                items.Clear();

                int selectedRow = dictionariesGrid.SelectedRows[0].Index;
                if (dictionariesGrid[0, selectedRow].FormattedValue != null)
                {
                    if(int.TryParse(dictionariesGrid[0, selectedRow].FormattedValue.ToString(), out int id))
                        items.AddRange(DBCommand.GetItems(id));
                }
                
                itemsGrid.DataSource = items;
                if (!showMode)
                {
                    itemsGrid.Columns[0].Visible = false;
                    itemsGrid.Columns[1].Visible = false;
                }
            }
        }
        private void RefreshChosenParentComboBox()
        {
            chosenParentComboBox.Items.Clear();
            chosenParentComboBox.Items.Add("all");
            chosenParentComboBox.Items.Add("none");
            chosenParentComboBox.SelectedIndex = 0;
            foreach (Dictionary dictionary in dictionaries)
            {
                bool hasRootDictionaries = false;
                foreach(Dictionary rootDictionary in dictionaries)
                {
                    if (rootDictionary.ParantId == dictionary.Id) hasRootDictionaries = true;
                }
                if (hasRootDictionaries) chosenParentComboBox.Items.Add(
                    $"{dictionary.Id} {dictionary.Name}");
            }
        }
        private void BaseForm_Load(object sender, EventArgs e)
        {
            dictionariesGrid.SelectionChanged += RefreshItemsTable;
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = "";
            openFileDialog.Filter = "SQLite databases|*.db;*.sql;*.sqlite;*.sdb;*.db3;*.s3db;*.sqlite3;*.sl3|All|*";
            DBCommand.AddListnerSourceChanged(SetFilePathLabel);
            DBCommand.SelectDBFile("dictionaries.sqlite");
            chosenParentComboBox.SelectedIndex = 0;
        }
        private void chosenParentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDictionariesTable();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (DBCommand.GetDictionaries() == null)
            {
                MessageForm messageForm = new MessageForm("Cant open chosen file.\nThere are no tables or you try to open wrong format");
                messageForm.ShowDialog();
            } 
            else RefreshDictionarise();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (DBCommand.GetDictionaries() == null)
            {
                MessageForm messageForm = new MessageForm("Cant open chosen file.\nThere are no tables or you try to open wrong format");
                messageForm.ShowDialog();
            }
            else
            {
                if(addDictionaryForm == null) addDictionaryForm = new AddDictionaryForm();
                if (addDictionaryForm.IsDisposed) addDictionaryForm = new AddDictionaryForm();
                addDictionaryForm.Show(this);
                addDictionaryForm.AddListnerDictionaryAdded(RefreshDictionarise);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (DBCommand.GetDictionaries() == null || dictionariesGrid.Rows.Count == 0)
            {
                MessageForm messageForm = new MessageForm("There are no tables or you try to open wrong format");
                messageForm.ShowDialog();
            }
            else
            {
                DeleteDictionaryForm deleteForm = new DeleteDictionaryForm();
                deleteForm.ShowDialog(this);
                RefreshDictionarise();
            }
        }


        private void changeButton_Click(object sender, EventArgs e)
        {
            if(dictionariesGrid.SelectedCells.Count > 0)
            {
                if (int.TryParse(dictionariesGrid.SelectedRows[0].Cells[0].FormattedValue.ToString(), out int selectedDictionaryId))
                {
                    Dictionary selectedDictionary = null;
                    foreach (Dictionary dictionary in dictionaries)
                    {
                        if (dictionary.Id == selectedDictionaryId) selectedDictionary = dictionary;
                    }
                    ChangeDictionaryForm changeForm = new ChangeDictionaryForm(selectedDictionary);
                    changeForm.ShowDialog(this);
                    RefreshDictionarise();
                }
            }
        }

        private void showModeButton_Click(object sender, EventArgs e)
        {
            if (DBCommand.GetDictionaries() == null)
            {
                MessageForm messageForm = new MessageForm("Cant open chosen file.\nThere are no tables or you try to open wrong format");
                messageForm.ShowDialog();
            }
            else
            {
                if (showMode) showMode = false;
                else showMode = true;
                RefreshDictionariesTable();
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                DBCommand.SelectDBFile(openFileDialog.FileName);
                RefreshDictionarise();
            }
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                NameSelectForm nameSelectForm = new NameSelectForm(folderBrowserDialog.SelectedPath);
                if(nameSelectForm.ShowDialog(this) == DialogResult.OK) RefreshDictionarise();
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (DBCommand.GetDictionaries() == null || dictionariesGrid.Rows.Count == 0)
            {
                MessageForm messageForm = new MessageForm("There are no dictionaries.");
                messageForm.ShowDialog();
            }
            else
            {
                if(int.TryParse(dictionariesGrid.SelectedRows[0].Cells["id"].FormattedValue.ToString(), out int chosenId))
                {
                    if (addItemForm == null) addItemForm = new AddItemForm(chosenId);
                    if (addItemForm.IsDisposed) addItemForm = new AddItemForm(chosenId);
                    addItemForm.Show(this);
                    addItemForm.AddListnerItemAdded(RefreshItemsTable);
                }
            }
        }

        private void deleteItemButtton_Click(object sender, EventArgs e)
        {
            if (DBCommand.GetDictionaries() == null)
            {
                MessageForm messageForm = new MessageForm("Cant open chosen file.\nThere are no tables or you try to open wrong format");
                messageForm.ShowDialog();
            }
            if (DBCommand.GetItems(null) == null || dictionariesGrid.Rows.Count == 0)
            {
                MessageForm messageForm = new MessageForm("There are no items.");
                messageForm.ShowDialog();
            }
            else
            {
                if (dictionariesGrid.SelectedRows.Count > 0)
                {
                    if(int.TryParse(dictionariesGrid.SelectedRows[0].Cells[0].FormattedValue.ToString(),out int id))
                    {
                        DeleteItemForm deleteItemForm = new DeleteItemForm(id);
                        deleteItemForm.ShowDialog(this);
                        RefreshDictionarise();
                    }
                }
            }
        }

        private void changeItemButton_Click(object sender, EventArgs e)
        {
            if (itemsGrid.SelectedCells.Count > 0)
            {
                int selectedItemId = int.Parse(itemsGrid.SelectedRows[0].Cells[0].FormattedValue.ToString());
                Item selectedItem = null;
                foreach (Item item in items)
                {
                    if (item.Id == selectedItemId) selectedItem = item;
                }
                ChangeItemForm changeForm = new ChangeItemForm(selectedItem);
                changeForm.ShowDialog(this);
                RefreshDictionarise();
            }
        }
        private void SetFilePathLabel(string filePath)
        {
            filePathLabel.Text = "File path: " + filePath;
        }
    }
}
