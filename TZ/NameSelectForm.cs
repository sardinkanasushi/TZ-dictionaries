using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TZ
{
    public partial class NameSelectForm : Form
    {
        private string filePath;
        public NameSelectForm(string path)
        {
            InitializeComponent();
            filePath = path;

            this.Location = new Point(200, 200);
        }

        private void nameSelectForm_Load(object sender, EventArgs e)
        {
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (DBCommand.CreateDBFile(filePath + $"\\{fileNameTextBox.Text}")) DialogResult = DialogResult.OK;
            else
            {
                MessageForm messageForm = new MessageForm("Creating error \ntry enother file name or directory");
                messageForm.ShowDialog();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextValidator.Validate(fileNameTextBox);
        }
    }
}
