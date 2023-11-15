namespace _08_AdditionalsForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            Product res = ListBox.SelectedItem;
            string name = textBox1.Text;
            //Open Form
            //1 - with constructor
            SecondForm secondForm = new SecondForm(res);
            //SecondForm secondForm = new SecondForm(name);
            ///secondForm.Show();//in nomodel model
            //MessageBox.Show(name);
            //secondForm.ShowDialog();//model mode

            //2 - with properties
            //SecondForm secondForm = new SecondForm();
            //secondForm.UserName = textBox1.Text;
            //secondForm.Show();

            //3 - Show 
            SecondForm secondForm = new SecondForm();
            secondForm.Show(name);         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 - using child form Properties
            //User user;//reference = null
            //LoginForm loginForm = new LoginForm();

            //if (loginForm.ShowDialog() == DialogResult.OK)
            //{

            //    user = loginForm.User;//address= address

            //    loginLb.Text = user.Login;
            //    passwordLb.Text = user.Password;
            //}

            //2 - using reference to the object
            User user = new User();
            LoginForm form = new LoginForm(user);
            if(form.ShowDialog() == DialogResult.OK)
            {
                loginLb.Text = user.Login;
                passwordLb.Text = user.Password;
            }
           
        }
    }
}