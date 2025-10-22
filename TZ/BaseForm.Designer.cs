namespace TZ
{
    partial class BaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.dictionariesGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addDictionaryButton = new System.Windows.Forms.Button();
            this.deleteDictionaryButton = new System.Windows.Forms.Button();
            this.changeDictionaryButton = new System.Windows.Forms.Button();
            this.itemsGrid = new System.Windows.Forms.DataGridView();
            this.showModeButton = new System.Windows.Forms.Button();
            this.chosenParentComboBox = new System.Windows.Forms.ComboBox();
            this.parentLable = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.createFileButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.changeItemButton = new System.Windows.Forms.Button();
            this.deleteItemButtton = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dictionariesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dictionariesGrid
            // 
            this.dictionariesGrid.AllowUserToAddRows = false;
            this.dictionariesGrid.AllowUserToDeleteRows = false;
            this.dictionariesGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dictionariesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dictionariesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dictionariesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dictionariesGrid.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dictionariesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dictionariesGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dictionariesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dictionariesGrid.ColumnHeadersHeight = 29;
            this.dictionariesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dictionariesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.parentId,
            this.name,
            this.code,
            this.description});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dictionariesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dictionariesGrid.EnableHeadersVisualStyles = false;
            this.dictionariesGrid.GridColor = System.Drawing.Color.CadetBlue;
            this.dictionariesGrid.Location = new System.Drawing.Point(13, 162);
            this.dictionariesGrid.MultiSelect = false;
            this.dictionariesGrid.Name = "dictionariesGrid";
            this.dictionariesGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dictionariesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dictionariesGrid.RowHeadersVisible = false;
            this.dictionariesGrid.RowHeadersWidth = 20;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            this.dictionariesGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dictionariesGrid.RowTemplate.Height = 24;
            this.dictionariesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dictionariesGrid.Size = new System.Drawing.Size(375, 356);
            this.dictionariesGrid.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 47;
            // 
            // parentId
            // 
            this.parentId.HeaderText = "parent id";
            this.parentId.MinimumWidth = 6;
            this.parentId.Name = "parentId";
            this.parentId.ReadOnly = true;
            this.parentId.Width = 88;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 70;
            // 
            // code
            // 
            this.code.HeaderText = "code";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 67;
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 102;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.Location = new System.Drawing.Point(457, 95);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(81, 38);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addDictionaryButton
            // 
            this.addDictionaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDictionaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addDictionaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addDictionaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDictionaryButton.Location = new System.Drawing.Point(100, 547);
            this.addDictionaryButton.Name = "addDictionaryButton";
            this.addDictionaryButton.Size = new System.Drawing.Size(81, 38);
            this.addDictionaryButton.TabIndex = 6;
            this.addDictionaryButton.Text = "add";
            this.addDictionaryButton.UseVisualStyleBackColor = false;
            this.addDictionaryButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteDictionaryButton
            // 
            this.deleteDictionaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteDictionaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.deleteDictionaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteDictionaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteDictionaryButton.Location = new System.Drawing.Point(187, 547);
            this.deleteDictionaryButton.Name = "deleteDictionaryButton";
            this.deleteDictionaryButton.Size = new System.Drawing.Size(81, 38);
            this.deleteDictionaryButton.TabIndex = 7;
            this.deleteDictionaryButton.Text = "delete";
            this.deleteDictionaryButton.UseVisualStyleBackColor = false;
            this.deleteDictionaryButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeDictionaryButton
            // 
            this.changeDictionaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeDictionaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.changeDictionaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeDictionaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeDictionaryButton.Location = new System.Drawing.Point(13, 547);
            this.changeDictionaryButton.Name = "changeDictionaryButton";
            this.changeDictionaryButton.Size = new System.Drawing.Size(81, 38);
            this.changeDictionaryButton.TabIndex = 8;
            this.changeDictionaryButton.Text = "change";
            this.changeDictionaryButton.UseVisualStyleBackColor = false;
            this.changeDictionaryButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // itemsGrid
            // 
            this.itemsGrid.AllowUserToAddRows = false;
            this.itemsGrid.AllowUserToDeleteRows = false;
            this.itemsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.itemsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.itemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.itemsGrid.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.itemsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.itemsGrid.ColumnHeadersHeight = 29;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.itemsGrid.EnableHeadersVisualStyles = false;
            this.itemsGrid.GridColor = System.Drawing.Color.CadetBlue;
            this.itemsGrid.Location = new System.Drawing.Point(457, 162);
            this.itemsGrid.MultiSelect = false;
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.itemsGrid.RowHeadersVisible = false;
            this.itemsGrid.RowHeadersWidth = 20;
            this.itemsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightCyan;
            this.itemsGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.itemsGrid.RowTemplate.Height = 24;
            this.itemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsGrid.Size = new System.Drawing.Size(384, 356);
            this.itemsGrid.TabIndex = 9;
            // 
            // showModeButton
            // 
            this.showModeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.showModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showModeButton.Location = new System.Drawing.Point(13, 95);
            this.showModeButton.Name = "showModeButton";
            this.showModeButton.Size = new System.Drawing.Size(120, 38);
            this.showModeButton.TabIndex = 11;
            this.showModeButton.Text = "show mode";
            this.showModeButton.UseVisualStyleBackColor = false;
            this.showModeButton.Click += new System.EventHandler(this.showModeButton_Click);
            // 
            // chosenParentComboBox
            // 
            this.chosenParentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chosenParentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chosenParentComboBox.FormattingEnabled = true;
            this.chosenParentComboBox.Items.AddRange(new object[] {
            "all",
            "none"});
            this.chosenParentComboBox.Location = new System.Drawing.Point(155, 101);
            this.chosenParentComboBox.Name = "chosenParentComboBox";
            this.chosenParentComboBox.Size = new System.Drawing.Size(229, 28);
            this.chosenParentComboBox.TabIndex = 12;
            this.chosenParentComboBox.SelectedIndexChanged += new System.EventHandler(this.chosenParentComboBox_SelectedIndexChanged);
            // 
            // parentLable
            // 
            this.parentLable.AutoSize = true;
            this.parentLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentLable.ForeColor = System.Drawing.Color.Ivory;
            this.parentLable.Location = new System.Drawing.Point(151, 78);
            this.parentLable.Name = "parentLable";
            this.parentLable.Size = new System.Drawing.Size(56, 20);
            this.parentLable.TabIndex = 13;
            this.parentLable.Text = "parent";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFile";
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileButton.Location = new System.Drawing.Point(646, 95);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(96, 38);
            this.openFileButton.TabIndex = 14;
            this.openFileButton.Text = "select file";
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // createFileButton
            // 
            this.createFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.createFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createFileButton.Location = new System.Drawing.Point(544, 95);
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.Size = new System.Drawing.Size(96, 38);
            this.createFileButton.TabIndex = 15;
            this.createFileButton.Text = "create file";
            this.createFileButton.UseVisualStyleBackColor = false;
            this.createFileButton.Click += new System.EventHandler(this.createFileButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addItemButton.Location = new System.Drawing.Point(544, 547);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(81, 38);
            this.addItemButton.TabIndex = 16;
            this.addItemButton.Text = "add";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // changeItemButton
            // 
            this.changeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.changeItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeItemButton.Location = new System.Drawing.Point(457, 547);
            this.changeItemButton.Name = "changeItemButton";
            this.changeItemButton.Size = new System.Drawing.Size(81, 38);
            this.changeItemButton.TabIndex = 18;
            this.changeItemButton.Text = "change";
            this.changeItemButton.UseVisualStyleBackColor = false;
            this.changeItemButton.Click += new System.EventHandler(this.changeItemButton_Click);
            // 
            // deleteItemButtton
            // 
            this.deleteItemButtton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteItemButtton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.deleteItemButtton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteItemButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteItemButtton.Location = new System.Drawing.Point(631, 547);
            this.deleteItemButtton.Name = "deleteItemButtton";
            this.deleteItemButtton.Size = new System.Drawing.Size(81, 38);
            this.deleteItemButtton.TabIndex = 17;
            this.deleteItemButtton.Text = "delete";
            this.deleteItemButtton.UseVisualStyleBackColor = false;
            this.deleteItemButtton.Click += new System.EventHandler(this.deleteItemButtton_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filePathLabel.ForeColor = System.Drawing.Color.Ivory;
            this.filePathLabel.Location = new System.Drawing.Point(13, 22);
            this.filePathLabel.MaximumSize = new System.Drawing.Size(800, 20);
            this.filePathLabel.MinimumSize = new System.Drawing.Size(800, 20);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(800, 20);
            this.filePathLabel.TabIndex = 19;
            this.filePathLabel.Text = "file path:";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(854, 597);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.changeItemButton);
            this.Controls.Add(this.deleteItemButtton);
            this.Controls.Add(this.createFileButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.parentLable);
            this.Controls.Add(this.chosenParentComboBox);
            this.Controls.Add(this.showModeButton);
            this.Controls.Add(this.itemsGrid);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addDictionaryButton);
            this.Controls.Add(this.changeDictionaryButton);
            this.Controls.Add(this.deleteDictionaryButton);
            this.Controls.Add(this.dictionariesGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(868, 644);
            this.Name = "BaseForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dictionaries";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dictionariesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView dictionariesGrid;
        private System.Windows.Forms.Button addDictionaryButton;
        private System.Windows.Forms.Button deleteDictionaryButton;
        private System.Windows.Forms.Button changeDictionaryButton;
        private System.Windows.Forms.DataGridView itemsGrid;
        private System.Windows.Forms.Button showModeButton;
        private System.Windows.Forms.ComboBox chosenParentComboBox;
        private System.Windows.Forms.Label parentLable;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button createFileButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button changeItemButton;
        private System.Windows.Forms.Button deleteItemButtton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Label filePathLabel;
    }
}

