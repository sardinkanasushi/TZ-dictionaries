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
    public partial class ChangeItemForm : Form
    {
        Item itemToChange;
        public ChangeItemForm(Item item)
        {
            itemToChange = item;
            InitializeComponent();
        }

        private void ChangeItemForm_Load(object sender, EventArgs e)
        {
            List<Dictionary> dictionaries = new List<Dictionary>();
            dictionaries = DBCommand.GetDictionaries();
            for (int i = 0; i < dictionaries.Count; i++)
            {
                dictionaryIdComboBox.Items.Add($"{dictionaries[i].Id} {dictionaries[i].Name}");

                if (dictionaries[i].Id == itemToChange.DictionaryId)
                {
                    dictionaryIdComboBox.SelectedIndex = dictionaryIdComboBox.Items.IndexOf($"{dictionaries[i].Id} {dictionaries[i].Name}");
                }

            }
            if (dictionaryIdComboBox.Items.Count > 0)
            {
                if (dictionaryIdComboBox.SelectedIndex < 0) dictionaryIdComboBox.SelectedIndex = 0;
            }
            nameTextBox.Text = itemToChange.Name.ToString();
            codeTextBox.Text = itemToChange.Code.ToString();
        }
        private void changeButton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(dictionaryIdComboBox.Text.Split(' ')[0], out int id))
            {
                itemToChange.DictionaryId = id;
            }
            itemToChange.Name = nameTextBox.Text;
            itemToChange.Code = codeTextBox.Text;

            DBCommand.UpdateItem(itemToChange);
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextValidator.Validate(nameTextBox);
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            TextValidator.Validate(codeTextBox);
        }
    }
}
