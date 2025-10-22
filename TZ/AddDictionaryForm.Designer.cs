namespace TZ
{
    partial class AddDictionaryForm
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
            this.parentIdComboBox = new System.Windows.Forms.ComboBox();
            this.checkBoxHasParent = new System.Windows.Forms.CheckBox();
            this.parentId = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
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
            this.addPanel.Controls.Add(this.parentIdComboBox, 1, 0);
            this.addPanel.Controls.Add(this.checkBoxHasParent, 2, 0);
            this.addPanel.Controls.Add(this.parentId, 0, 0);
            this.addPanel.Controls.Add(this.name, 0, 1);
            this.addPanel.Controls.Add(this.code, 0, 2);
            this.addPanel.Controls.Add(this.description, 0, 3);
            this.addPanel.Controls.Add(this.nameTextBox, 1, 1);
            this.addPanel.Controls.Add(this.codeTextBox, 1, 2);
            this.addPanel.Controls.Add(this.descriptionTextBox, 1, 3);
            this.addPanel.Location = new System.Drawing.Point(3, 12);
            this.addPanel.Name = "addPanel";
            this.addPanel.RowCount = 5;
            this.addPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.addPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.addPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.addPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.addPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addPanel.Size = new System.Drawing.Size(553, 294);
            this.addPanel.TabIndex = 0;
            // 
            // parentIdComboBox
            // 
            this.parentIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.parentIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentIdComboBox.Location = new System.Drawing.Point(178, 12);
            this.parentIdComboBox.Name = "parentIdComboBox";
            this.parentIdComboBox.Size = new System.Drawing.Size(146, 28);
            this.parentIdComboBox.TabIndex = 3;
            // 
            // checkBoxHasParent
            // 
            this.checkBoxHasParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHasParent.AutoSize = true;
            this.checkBoxHasParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHasParent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(253)))), ((int)(((byte)(191)))));
            this.checkBoxHasParent.Location = new System.Drawing.Point(337, 14);
            this.checkBoxHasParent.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.checkBoxHasParent.Name = "checkBoxHasParent";
            this.checkBoxHasParent.Size = new System.Drawing.Size(213, 24);
            this.checkBoxHasParent.TabIndex = 3;
            this.checkBoxHasParent.Text = "has parent";
            this.checkBoxHasParent.UseVisualStyleBackColor = true;
            this.checkBoxHasParent.CheckedChanged += new System.EventHandler(this.checkBoxHasParent_CheckedChanged);
            // 
            // parentId
            // 
            this.parentId.AutoSize = true;
            this.parentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(190)))));
            this.parentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentId.Location = new System.Drawing.Point(10, 10);
            this.parentId.Margin = new System.Windows.Forms.Padding(10);
            this.parentId.MinimumSize = new System.Drawing.Size(150, 0);
            this.parentId.Name = "parentId";
            this.parentId.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.parentId.Size = new System.Drawing.Size(155, 33);
            this.parentId.TabIndex = 0;
            this.parentId.Text = "parent id";
            this.parentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // description
            // 
            this.description.AutoSize = true;
            this.description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(190)))));
            this.description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.description.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(10, 169);
            this.description.Margin = new System.Windows.Forms.Padding(10);
            this.description.MinimumSize = new System.Drawing.Size(150, 0);
            this.description.Name = "description";
            this.description.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.description.Size = new System.Drawing.Size(155, 33);
            this.description.TabIndex = 3;
            this.description.Text = "description";
            this.description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addPanel.SetColumnSpan(this.nameTextBox, 2);
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(178, 66);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(371, 27);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addPanel.SetColumnSpan(this.codeTextBox, 2);
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeTextBox.Location = new System.Drawing.Point(178, 119);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(371, 27);
            this.codeTextBox.TabIndex = 7;
            this.codeTextBox.TextChanged += new System.EventHandler(this.codeTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPanel.SetColumnSpan(this.descriptionTextBox, 2);
            this.descriptionTextBox.Location = new System.Drawing.Point(178, 162);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.addPanel.SetRowSpan(this.descriptionTextBox, 2);
            this.descriptionTextBox.Size = new System.Drawing.Size(372, 129);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.Text = "";
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
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
            this.addButton.Location = new System.Drawing.Point(370, 322);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 34);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.exitButton.Location = new System.Drawing.Point(466, 322);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 34);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AddDictionaryForm
            // 
            this.AcceptButton = this.exitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(564, 378);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(582, 396);
            this.Name = "AddDictionaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add dictionary";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel addPanel;
        private System.Windows.Forms.Label parentId;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckBox checkBoxHasParent;
        private System.Windows.Forms.ComboBox parentIdComboBox;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}