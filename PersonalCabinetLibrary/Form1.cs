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
    public struct Autorizations
    {
        public string Login;
        public string Password;
        public string Type;
    }
    public partial class FormAutorization : Form
    {
        public static Autorizations users = new Autorizations();
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Autorization user in Program.pcDb.Autorization)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.Login = user.Login;
                        users.Password = user.Password;
                        users.Type = user.Type;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    FormBooks book = new FormBooks();
                    book.Show();
                    this.Hide();
                }
            }
        }

        private void TextBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
