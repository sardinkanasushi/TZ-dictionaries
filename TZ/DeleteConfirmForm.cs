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
    public partial class DeleteConfirmForm : Form
    {
        private List<Dictionary> dictionariesToDelete = null;
        public DeleteConfirmForm(List<Dictionary> dictionaries)
        {
            dictionariesToDelete = dictionaries;
            InitializeComponent();
        }

        private void DeleteConfirmForm_Load(object sender, EventArgs e)
        {
            dictionariesGrid.DataSource = null;
            dictionariesGrid.DataSource = dictionariesToDelete;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteDictionaryButton_Click(object sender, EventArgs e)
        {
            if(DBCommand.DeleteDictionary(dictionariesToDelete)) this.Close();
            else
            {
                MessageForm messageForm = new MessageForm("Delete errore.\nSomthing went wrong");
                messageForm.ShowDialog();
            }
        }
    }
}
