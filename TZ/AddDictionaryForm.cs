using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TZ
{
    public partial class AddDictionaryForm : Form
    {
        public delegate void SimpleEvent();
        private event SimpleEvent DictionaryAdded;
        public AddDictionaryForm()
        {
            InitializeComponent();
        }
        public void AddListnerDictionaryAdded(SimpleEvent listner)
        {
            DictionaryAdded += listner;
        }
        public void RemoveListnerDictionaryAdded(SimpleEvent listner)
        {
            DictionaryAdded -= listner;
        }
        private void AddForm_Load(object sender, EventArgs e)
        {
            List<Dictionary> dictionaries = DBCommand.GetDictionaries();

            checkBoxHasParent.Checked = false;
            parentIdComboBox.Enabled = false;
            foreach (Dictionary dictionary in dictionaries)
            {
                parentIdComboBox.Items.Add($"{dictionary.Id} {dictionary.Name}");
            }
            if (parentIdComboBox.Items.Count > 0)
                parentIdComboBox.SelectedIndex = 0;
            else checkBoxHasParent.Enabled = false;

            nameTextBox.Text = "name";
            codeTextBox.Text = "code";
            descriptionTextBox.Text = "description";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            int? parentId = null;

            if (checkBoxHasParent.Checked && parentIdComboBox.SelectedIndex >= 0)
            {
                if(int.TryParse(parentIdComboBox.Text.Split(' ')[0], out int chosenId))
                    parentId = chosenId;
            }

            string name = nameTextBox.Text;
            string code = codeTextBox.Text;
            string description = descriptionTextBox.Text;

            if (DBCommand.AddDictionary(new Dictionary(null, parentId, name, code, description)))
                DictionaryAdded.Invoke();
            else 
            {
                MessageForm message = new MessageForm("Error while adding.\nSome filds are incorrect.");
            }
        }

        private void checkBoxHasParent_CheckedChanged(object sender, EventArgs e)
        {
            parentIdComboBox.Enabled = checkBoxHasParent.Checked;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            TextValidator.Validate(descriptionTextBox);
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
