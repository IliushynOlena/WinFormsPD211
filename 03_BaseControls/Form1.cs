using System.Text;

namespace _03_BaseControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            orderBtn.Enabled = false;
        }

        private bool IsSelectedMeal()
        {
            return (checkBox1.Checked)||(checkBox2.Checked)||(checkBox3.Checked);
        }
        private void ClearTextBox()
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
        }
        private void ClearCheckBox()
        {
            foreach (var item in this.Controls.OfType<CheckBox>())
            {
                item.Checked = false;
            }
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if(!IsSelectedMeal())
            {
                MessageBox.Show("Select at least one meal");
                return;
            }

            StringBuilder res = new StringBuilder("===============Order==============\n");//35
            res.Append("Meals : ");//43
            if (checkBox1.Checked)
                res.Append("Breakfast ");
            if (checkBox2.Checked)
                res.Append("Lunch ");
            if (checkBox3.Checked)
                res.Append("Dinner ");
            res.AppendLine();


            res.Append("Delivery : ");
            if (radioButton1.Checked)
                res.Append("Economy ");
            if (radioButton2.Checked)
                res.Append("Standart ");
            if (radioButton3.Checked)
                res.Append("Fast ");
            res.AppendLine();

            res.AppendLine("Login : " + textBox1.Text);
            res.AppendLine("Password : " + textBox2.Text);
            res.AppendLine("Phone : " + maskedTextBox1.Text);

            res.AppendLine("Date : " + dateTimePicker1.Value);
            res.AppendLine("Start : " + monthCalendar1.SelectionStart);
            res.AppendLine("End : " + monthCalendar1.SelectionEnd);

            res.AppendLine("Count : " +numericUpDown1.Value);

            MessageBox.Show(res.ToString());
            ClearTextBox();
            ClearCheckBox();
            //MessageBox.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            ClearCheckBox();
        }
    }
}