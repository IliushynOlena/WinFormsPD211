namespace _07_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No selected item!!!");return;
            }
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string res = "------------ Selection items -------------\n";

            foreach (var item in listBox1.SelectedItems)
            {
                res += item.ToString() + Environment.NewLine;
            }
            MessageBox.Show(res);
        }

        private void moveRightBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void moveLeftBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[0]);
            }
        }
    }
}