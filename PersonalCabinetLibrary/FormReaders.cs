using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalCabinetLibrary
{
    public partial class FormReaders : Form
    {
        public FormReaders()
        {
            InitializeComponent();
            ShowReader();
        }
        void ShowReader()
        {
            listViewReadersSet.Items.Clear();
            foreach (ReadersSet readerSet in Program.pcDb.ReadersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    readerSet.Id.ToString(), readerSet.Name, readerSet.Surname, readerSet.Phone, readerSet.Mail
                });
                item.Tag = readerSet;
                listViewReadersSet.Items.Add(item);
            }
            listViewReadersSet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ReadersSet readerSet = new ReadersSet();
            readerSet.Name = textBoxName.Text;
            readerSet.Surname = textBoxSurname.Text;
            readerSet.Phone = textBoxPhone.Text;
            readerSet.Mail = textBoxMail.Text;
            Program.pcDb.ReadersSet.Add(readerSet);
            Program.pcDb.SaveChanges();
            ShowReader();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewReadersSet.SelectedItems.Count == 1)
            {
                ReadersSet readerSet = new ReadersSet();
                readerSet.Name = textBoxName.Text;
                readerSet.Surname = textBoxSurname.Text;
                readerSet.Phone = textBoxPhone.Text;
                readerSet.Mail = textBoxMail.Text;
                Program.pcDb.SaveChanges();
                ShowReader();
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewReadersSet.SelectedItems.Count == 1)
                {
                    ReadersSet readerSet = listViewReadersSet.SelectedItems[0].Tag as ReadersSet;
                    Program.pcDb.ReadersSet.Remove(readerSet);
                    Program.pcDb.SaveChanges();
                    ShowReader();
                }
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPhone.Text = "";
                textBoxMail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonBooks_Click(object sender, EventArgs e)
        {
            Form formBooks = new FormBooks();
            formBooks.Show();
        }

        private void ButtonReaders_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonTaken_Click(object sender, EventArgs e)
        {
            Form formTaken = new FormTaken();
            formTaken.Show();
        }

        private void ListViewReadersSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewReadersSet.SelectedItems.Count == 1)
            {
                ReadersSet readerSet = listViewReadersSet.SelectedItems[0].Tag as ReadersSet;
                readerSet.Name = textBoxName.Text;
                readerSet.Surname = textBoxSurname.Text;
                readerSet.Phone = textBoxPhone.Text;
                readerSet.Mail = textBoxMail.Text;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPhone.Text = "";
                textBoxMail.Text = "";
            }
        }

        private void FormReaders_Load(object sender, EventArgs e)
        {

        }
    }
}
