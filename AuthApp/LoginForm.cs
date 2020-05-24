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
    public partial class LoginForm : Form
    {
        public bool IsLoginSuccess { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            IsLoginSuccess = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
