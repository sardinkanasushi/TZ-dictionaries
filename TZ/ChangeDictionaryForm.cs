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
    public partial class ChangeDictionaryForm : Form
    {
        Dictionary dictionaryToChange;
        public ChangeDictionaryForm(Dictionary dictionary)
        {
            dictionaryToChange = dictionary;
            InitializeComponent();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            List<Dictionary> dictionaries = new List<Dictionary>();
            dictionaries = DBCommand.GetDictionaries();
            checkBoxHasParent.Checked = false;
            parentIdComboBox.Enabled = false;
            for (int i = 0; i < dictionaries.Count; i++) 
            {
                if(dictionaryToChange.Id != dictionaries[i].Id)
                if(dictionaryToChange.Id != dictionaries[i].ParantId)
                    parentIdComboBox.Items.Add($"{dictionaries[i].Id} {dictionaries[i].Name}");

                if(dictionaries[i].Id == dictionaryToChange.ParantId)
                    if(dictionaryToChange.ParantId != dictionaryToChange.Id)
                    {
                        parentIdComboBox.SelectedIndex = parentIdComboBox.Items.IndexOf($"{dictionaries[i].Id} {dictionaries[i].Name}");
                        checkBoxHasParent.Checked = true;
                        parentIdComboBox.Enabled = true;
                    }
            }
            if (parentIdComboBox.Items.Count > 0)
            {
                if (parentIdComboBox.SelectedIndex < 0) parentIdComboBox.SelectedIndex = 0;
            } else checkBoxHasParent.Enabled = false;

            nameTextBox.Text = dictionaryToChange.Name.ToString();
            codeTextBox.Text = dictionaryToChange.Code.ToString();
            descriptionTextBox.Text = dictionaryToChange.Description.ToString();
        }

        private void checkBoxHasParent_CheckedChanged(object sender, EventArgs e)
        {
            parentIdComboBox.Enabled = checkBoxHasParent.Checked;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (checkBoxHasParent.Checked && parentIdComboBox.SelectedIndex >= 0)
                if(int.TryParse(parentIdComboBox.Text.Split(' ')[0], out int id))
                {
                    dictionaryToChange.ParantId = id;
                }
            dictionaryToChange.Name = nameTextBox.Text;
            dictionaryToChange.Code = codeTextBox.Text;
            dictionaryToChange.Description = descriptionTextBox.Text;

            DBCommand.UpdateDictionary(dictionaryToChange);
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

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            TextValidator.Validate(descriptionTextBox);
        }
    }
}
