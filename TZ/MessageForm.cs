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
    public partial class MessageForm : Form
    {
        public MessageForm(string text)
        {
            InitializeComponent();
            messageLable.Text = text;
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
