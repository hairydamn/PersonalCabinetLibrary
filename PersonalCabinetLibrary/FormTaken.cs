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
    public partial class FormTaken : Form
    {
        public FormTaken()
        {
            InitializeComponent();
            ShowTaken();
            ShowBook();
            ShowReader();
        }
        void ShowTaken()
        {
            listViewTakensSet.Items.Clear();
            foreach (TakenSet taken in Program.pcDb.TakenSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                taken.Books.Title.ToString(),
                taken.Books.Author.ToString(),
                taken.ReadersSet.Name.ToString(),
                taken.ReadersSet.Surname.ToString(),
                taken.DateDelivery,
                taken.DateIssue
                });
                item.Tag = taken;
                listViewTakensSet.Items.Add(item);
            }
        }
        void ShowBook()
        {
            comboBoxBook.Items.Clear();
            foreach (Books bookSet in Program.pcDb.Books)
            {
                string[] item = { bookSet.Id.ToString() + ". ", "" + bookSet.Title, ", " + bookSet.Author };
                comboBoxBook.Items.Add(string.Join("", item));
            }
        }
        void ShowReader()
        {
            comboBoxReader.Items.Clear();
            foreach (ReadersSet readerSet in Program.pcDb.ReadersSet)
            {
                string[] item = { readerSet.Id.ToString() + ". ", "" + readerSet.Name, ", " + readerSet.Surname };
                comboBoxReader.Items.Add(string.Join("", item));
            }
        }

        private void FormTaken_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonReaders_Click(object sender, EventArgs e)
        {
            Form formReader = new FormReaders();
            formReader.Show();
        }

        private void ButtonTaken_Click(object sender, EventArgs e)
        {

        }

        private void ListViewTakensSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTakensSet.SelectedItems.Count == 1)
            {
                TakenSet taken = listViewTakensSet.SelectedItems[0].Tag as TakenSet;
                comboBoxBook.SelectedIndex = comboBoxBook.FindString(taken.IdBook.ToString());
                comboBoxReader.SelectedIndex = comboBoxBook.FindString(taken.IdReader.ToString());
                taken.DateDelivery = textBoxDelivery.Text;
                taken.DateIssue = textBoxDateIssue.Text;
            }
            else
            {
                comboBoxBook.SelectedItem = null;
                comboBoxReader.SelectedItem = null;
                textBoxDelivery.Text = "";
                textBoxDateIssue.Text = "";
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxBook.SelectedItem != null && comboBoxReader.SelectedItem != null)
            {
                TakenSet deal = new TakenSet();
                deal.IdBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                deal.IdReader = Convert.ToInt32(comboBoxReader.SelectedItem.ToString().Split('.')[0]);
                deal.DateDelivery = textBoxDelivery.Text;
                deal.DateIssue = textBoxDateIssue.Text;
                Program.pcDb.TakenSet.Add(deal);
                Program.pcDb.SaveChanges();
                ShowTaken();
            }
            else MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewTakensSet.SelectedItems.Count == 1)
            {
                TakenSet deal = listViewTakensSet.SelectedItems[0].Tag as TakenSet;
                deal.IdBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                deal.IdReader = Convert.ToInt32(comboBoxReader.SelectedItem.ToString().Split('.')[0]);
                deal.DateDelivery = textBoxDelivery.Text;
                deal.DateIssue = textBoxDateIssue.Text;
                Program.pcDb.SaveChanges();
                ShowTaken();
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTakensSet.SelectedItems.Count == 1)
                {
                    TakenSet deal = listViewTakensSet.SelectedItems[0].Tag as TakenSet;
                    Program.pcDb.TakenSet.Remove(deal);
                    Program.pcDb.SaveChanges();
                    ShowTaken();
                }
                comboBoxBook.SelectedItem = null;
                comboBoxReader.SelectedItem = null;
                textBoxDelivery.Text = "";
                textBoxDateIssue.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonBooks_Click(object sender, EventArgs e)
        {
            Form formBook = new FormBooks();
            formBook.Show();
        }
    }
}
