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
    public partial class AddItemForm : Form
    {
        public delegate void SimpleEvent();
        private event SimpleEvent ItemAdded;
        private int chosenId;
        public AddItemForm(int chosenDictionaryId)
        {
            chosenId = chosenDictionaryId;
            InitializeComponent();
        }
        public void AddListnerItemAdded(SimpleEvent listner)
        {
            ItemAdded += listner;
        }
        public void RemoveListnerItemAdded(SimpleEvent listner)
        {
            ItemAdded -= listner;
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            List<Dictionary> dictionaries = DBCommand.GetDictionaries();

            foreach (Dictionary dictionary in dictionaries)
            {
                dictionaryIdComboBox.Items.Add($"{dictionary.Id} {dictionary.Name}");
                if(dictionary.Id == chosenId) dictionaryIdComboBox.SelectedIndex = dictionaryIdComboBox.Items.IndexOf($"{dictionary.Id} {dictionary.Name}");
            }
            if (dictionaryIdComboBox.Items.Count > 0)
                

            nameTextBox.Text = "name";
            codeTextBox.Text = "code";
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dictionaryIdComboBox.Text.Split(' ')[0], out int dictionaryId))
            {
                string name = nameTextBox.Text;
                string code = codeTextBox.Text;

                if (DBCommand.AddItem(new Item(null, dictionaryId, name, code)))
                    ItemAdded.Invoke();
                else
                {
                    MessageForm message = new MessageForm("Error while adding.\nSome filds are incorrect.");
                }
            }
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
