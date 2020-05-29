namespace PersonalCabinetLibrary
{
    partial class FormTaken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaken));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewTakensSet = new System.Windows.Forms.ListView();
            this.TitleBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameReader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SurnameReader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateIssue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateDelivery = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxDelivery = new System.Windows.Forms.TextBox();
            this.textBoxDateIssue = new System.Windows.Forms.TextBox();
            this.labelDateDelivery = new System.Windows.Forms.Label();
            this.labelDateIssue = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonReaders = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.comboBoxReader = new System.Windows.Forms.ComboBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(822, 502);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(200, 63);
            this.buttonDel.TabIndex = 47;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(590, 502);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(200, 63);
            this.buttonEdit.TabIndex = 46;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(353, 502);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 63);
            this.buttonAdd.TabIndex = 45;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // listViewTakensSet
            // 
            this.listViewTakensSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TitleBook,
            this.Author1,
            this.NameReader,
            this.SurnameReader,
            this.DateIssue,
            this.DateDelivery});
            this.listViewTakensSet.FullRowSelect = true;
            this.listViewTakensSet.GridLines = true;
            this.listViewTakensSet.HideSelection = false;
            this.listViewTakensSet.Location = new System.Drawing.Point(353, 149);
            this.listViewTakensSet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listViewTakensSet.MultiSelect = false;
            this.listViewTakensSet.Name = "listViewTakensSet";
            this.listViewTakensSet.Size = new System.Drawing.Size(940, 332);
            this.listViewTakensSet.TabIndex = 44;
            this.listViewTakensSet.UseCompatibleStateImageBehavior = false;
            this.listViewTakensSet.View = System.Windows.Forms.View.Details;
            this.listViewTakensSet.SelectedIndexChanged += new System.EventHandler(this.ListViewTakensSet_SelectedIndexChanged);
            // 
            // TitleBook
            // 
            this.TitleBook.Text = "Название книги";
            this.TitleBook.Width = 146;
            // 
            // Author1
            // 
            this.Author1.Text = "Автор";
            this.Author1.Width = 123;
            // 
            // NameReader
            // 
            this.NameReader.Text = "Имя читателя";
            this.NameReader.Width = 165;
            // 
            // SurnameReader
            // 
            this.SurnameReader.Text = "Фамилия читателя";
            this.SurnameReader.Width = 191;
            // 
            // DateIssue
            // 
            this.DateIssue.Text = "Когда взял";
            this.DateIssue.Width = 163;
            // 
            // DateDelivery
            // 
            this.DateDelivery.Text = "Когда сдал";
            this.DateDelivery.Width = 179;
            // 
            // textBoxDelivery
            // 
            this.textBoxDelivery.Location = new System.Drawing.Point(27, 434);
            this.textBoxDelivery.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxDelivery.Multiline = true;
            this.textBoxDelivery.Name = "textBoxDelivery";
            this.textBoxDelivery.Size = new System.Drawing.Size(298, 47);
            this.textBoxDelivery.TabIndex = 43;
            this.textBoxDelivery.UseWaitCursor = true;
            // 
            // textBoxDateIssue
            // 
            this.textBoxDateIssue.Location = new System.Drawing.Point(26, 327);
            this.textBoxDateIssue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxDateIssue.Multiline = true;
            this.textBoxDateIssue.Name = "textBoxDateIssue";
            this.textBoxDateIssue.Size = new System.Drawing.Size(298, 47);
            this.textBoxDateIssue.TabIndex = 42;
            this.textBoxDateIssue.UseWaitCursor = true;
            // 
            // labelDateDelivery
            // 
            this.labelDateDelivery.AutoSize = true;
            this.labelDateDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDateDelivery.Location = new System.Drawing.Point(24, 410);
            this.labelDateDelivery.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDateDelivery.Name = "labelDateDelivery";
            this.labelDateDelivery.Size = new System.Drawing.Size(83, 18);
            this.labelDateDelivery.TabIndex = 39;
            this.labelDateDelivery.Text = "Дата сдачи";
            // 
            // labelDateIssue
            // 
            this.labelDateIssue.AutoSize = true;
            this.labelDateIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDateIssue.Location = new System.Drawing.Point(26, 303);
            this.labelDateIssue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDateIssue.Name = "labelDateIssue";
            this.labelDateIssue.Size = new System.Drawing.Size(94, 18);
            this.labelDateIssue.TabIndex = 38;
            this.labelDateIssue.Text = "Дата выдачи";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSurname.Location = new System.Drawing.Point(26, 229);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(70, 18);
            this.labelSurname.TabIndex = 37;
            this.labelSurname.Text = "Читатель";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(26, 141);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 18);
            this.labelName.TabIndex = 36;
            this.labelName.Text = "Книга";
            // 
            // buttonReaders
            // 
            this.buttonReaders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonReaders.FlatAppearance.BorderSize = 0;
            this.buttonReaders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReaders.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReaders.ForeColor = System.Drawing.Color.White;
            this.buttonReaders.Location = new System.Drawing.Point(712, 35);
            this.buttonReaders.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonReaders.Name = "buttonReaders";
            this.buttonReaders.Size = new System.Drawing.Size(241, 67);
            this.buttonReaders.TabIndex = 34;
            this.buttonReaders.Text = "Читатели";
            this.buttonReaders.UseVisualStyleBackColor = false;
            this.buttonReaders.Click += new System.EventHandler(this.ButtonReaders_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonBooks.FlatAppearance.BorderSize = 0;
            this.buttonBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooks.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBooks.ForeColor = System.Drawing.Color.White;
            this.buttonBooks.Location = new System.Drawing.Point(353, 35);
            this.buttonBooks.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(241, 67);
            this.buttonBooks.TabIndex = 33;
            this.buttonBooks.Text = "Книги";
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.ButtonBooks_Click);
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(27, 162);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(300, 26);
            this.comboBoxBook.TabIndex = 48;
            this.comboBoxBook.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBoxReader
            // 
            this.comboBoxReader.FormattingEnabled = true;
            this.comboBoxReader.Location = new System.Drawing.Point(26, 250);
            this.comboBoxReader.Name = "comboBoxReader";
            this.comboBoxReader.Size = new System.Drawing.Size(300, 26);
            this.comboBoxReader.TabIndex = 49;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxLogo.Image = global::PersonalCabinetLibrary.Properties.Resources.logobooks;
            this.pictureBoxLogo.Location = new System.Drawing.Point(26, 35);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(130, 67);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 32;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormTaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PersonalCabinetLibrary.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1319, 627);
            this.Controls.Add(this.comboBoxReader);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewTakensSet);
            this.Controls.Add(this.textBoxDelivery);
            this.Controls.Add(this.textBoxDateIssue);
            this.Controls.Add(this.labelDateDelivery);
            this.Controls.Add(this.labelDateIssue);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonReaders);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.pictureBoxLogo);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTaken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт по взятому";
            this.Load += new System.EventHandler(this.FormTaken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewTakensSet;
        private System.Windows.Forms.ColumnHeader TitleBook;
        private System.Windows.Forms.ColumnHeader Author1;
        private System.Windows.Forms.ColumnHeader NameReader;
        private System.Windows.Forms.ColumnHeader SurnameReader;
        private System.Windows.Forms.ColumnHeader DateIssue;
        private System.Windows.Forms.TextBox textBoxDelivery;
        private System.Windows.Forms.TextBox textBoxDateIssue;
        private System.Windows.Forms.Label labelDateDelivery;
        private System.Windows.Forms.Label labelDateIssue;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonReaders;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.ComboBox comboBoxReader;
        private System.Windows.Forms.ColumnHeader DateDelivery;
    }
}