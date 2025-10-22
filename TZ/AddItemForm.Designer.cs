namespace TZ
{
    partial class AddItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dictionaryIdComboBox = new System.Windows.Forms.ComboBox();
            this.dictionaryId = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPanel.ColumnCount = 3;
            this.addPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.addPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.addPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addPanel.Controls.Add(this.dictionaryIdComboBox, 1, 0);
            this.addPanel.Controls.Add(this.dictionaryId, 0, 0);
            this.addPanel.Controls.Add(this.name, 0, 1);
            this.addPanel.Controls.Add(this.code, 0, 2);
            this.addPanel.Controls.Add(this.nameTextBox, 1, 1);
            this.addPanel.Controls.Add(this.codeTextBox, 1, 2);
            this.addPanel.Location = new System.Drawing.Point(12, 12);
            this.addPanel.Name = "addPanel";
            this.addPanel.RowCount = 3;
            this.addPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.addPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.addPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.addPanel.Size = new System.Drawing.Size(506, 165);
            this.addPanel.TabIndex = 7;
            // 
            // dictionaryIdComboBox
            // 
            this.dictionaryIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dictionaryIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dictionaryIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dictionaryIdComboBox.FormattingEnabled = true;
            this.dictionaryIdComboBox.Location = new System.Drawing.Point(178, 12);
            this.dictionaryIdComboBox.Name = "dictionaryIdComboBox";
            this.dictionaryIdComboBox.Size = new System.Drawing.Size(146, 28);
            this.dictionaryIdComboBox.TabIndex = 3;
            // 
            // dictionaryId
            // 
            this.dictionaryId.AutoSize = true;
            this.dictionaryId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(190)))));
            this.dictionaryId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dictionaryId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dictionaryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dictionaryId.Location = new System.Drawing.Point(10, 10);
            this.dictionaryId.Margin = new System.Windows.Forms.Padding(10);
            this.dictionaryId.MinimumSize = new System.Drawing.Size(150, 0);
            this.dictionaryId.Name = "dictionaryId";
            this.dictionaryId.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dictionaryId.Size = new System.Drawing.Size(155, 33);
            this.dictionaryId.TabIndex = 0;
            this.dictionaryId.Text = "dictionary id";
            this.dictionaryId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(190)))));
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(10, 63);
            this.name.Margin = new System.Windows.Forms.Padding(10);
            this.name.MinimumSize = new System.Drawing.Size(150, 0);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.name.Size = new System.Drawing.Size(155, 33);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(190)))));
            this.code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.code.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.code.Location = new System.Drawing.Point(10, 116);
            this.code.Margin = new System.Windows.Forms.Padding(10);
            this.code.MinimumSize = new System.Drawing.Size(150, 0);
            this.code.Name = "code";
            this.code.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.code.Size = new System.Drawing.Size(155, 33);
            this.code.TabIndex = 2;
            this.code.Text = "code";
            this.code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addPanel.SetColumnSpan(this.nameTextBox, 2);
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(178, 66);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(325, 27);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeTextBox.Location = new System.Drawing.Point(178, 117);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(325, 27);
            this.codeTextBox.TabIndex = 7;
            this.codeTextBox.TextChanged += new System.EventHandler(this.codeTextBox_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 6;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(428, 197);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 34);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addButton.FlatAppearance.BorderSize = 6;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(332, 197);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 34);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(546, 243);
            this.ControlBox = false;
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(564, 290);
            this.MinimumSize = new System.Drawing.Size(564, 290);
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add item";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel addPanel;
        private System.Windows.Forms.ComboBox dictionaryIdComboBox;
        private System.Windows.Forms.Label dictionaryId;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addButton;
    }
}