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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
            ShowBook();
        }
        void ShowBook()
        {
            listViewBookSet.Items.Clear();
            foreach (Books bookSet in Program.pcDb.Books)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    bookSet.Id.ToString(), bookSet.Title, bookSet.Author, bookSet.Edition, bookSet.Year
                });
                item.Tag = bookSet;
                listViewBookSet.Items.Add(item);
            }
            listViewBookSet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ButtonReaders_Click(object sender, EventArgs e)
        {
            Form formReader = new FormReaders();
            formReader.Show();
        }

        private void ButtonTaken_Click(object sender, EventArgs e)
        {
            Form formTaken = new FormTaken();
            formTaken.Show();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Books bookSet = new Books();
            bookSet.Title = textBoxTitle.Text;
            bookSet.Author = textBoxAuthor.Text;
            bookSet.Edition = textBoxEdition.Text;
            bookSet.Year = textBoxYear.Text;
            Program.pcDb.Books.Add(bookSet);
            Program.pcDb.SaveChanges();
            ShowBook();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewBookSet.SelectedItems.Count == 1)
            {
                Books bookSet = listViewBookSet.SelectedItems[0].Tag as Books;
                bookSet.Title = textBoxTitle.Text;
                bookSet.Author = textBoxAuthor.Text;
                bookSet.Edition = textBoxEdition.Text;
                bookSet.Year = textBoxYear.Text;
                Program.pcDb.SaveChanges();
                ShowBook();
            }
        }

        private void ButtonBooks_Click(object sender, EventArgs e)
        {
            
        }

        private void ListViewBookSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBookSet.SelectedItems.Count == 1)
            {
                Books bookSet = listViewBookSet.SelectedItems[0].Tag as Books;
                bookSet.Title = textBoxTitle.Text;
                bookSet.Author = textBoxAuthor.Text;
                bookSet.Edition = textBoxEdition.Text;
                bookSet.Year = textBoxYear.Text;
            }
            else
            {
                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxEdition.Text = "";
                textBoxYear.Text = "";
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBookSet.SelectedItems.Count == 1)
                {
                    Books bookSet = listViewBookSet.SelectedItems[0].Tag as Books;
                    Program.pcDb.Books.Remove(bookSet);
                    Program.pcDb.SaveChanges();
                    ShowBook();
                }
                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxEdition.Text = "";
                textBoxYear.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
