using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.ShowDialog();
            if (form.IsLoginSuccess)
            {
                resultLabel.Text = "Успешно!!!";
                resultLabel.ForeColor = Color.Blue;
            }
            else
            {
                resultLabel.Text = "Обломиссимо...";
                resultLabel.ForeColor = Color.Red;
            }
        }
    }
}
