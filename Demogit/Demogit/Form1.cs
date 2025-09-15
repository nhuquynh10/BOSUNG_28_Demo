namespace Demogit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Admin" && txtPassword.Text == "Admin") 
                MessageBox.Show("Login Successful");
        }
        }
    }
}
