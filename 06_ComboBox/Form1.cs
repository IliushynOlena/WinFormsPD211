namespace _06_ComboBox
{
    public partial class Form1 : Form
    {
        List<Order> orders = new List<Order>();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();

            orders.Add(new Order(random.Next(10000)));
            orders.Add(new Order(random.Next(10000)));
            orders.Add(new Order(random.Next(10000)));
            orders.Add(new Order(random.Next(10000)));

            //orderComboBox.Items.AddRange(orders.ToArray());
            //orderComboBox.DataSource = orders;
            UpdateOrderComboBox();
        }
        private void UpdateOrderComboBox()
        {
            orderComboBox.DataSource = null;
            orderComboBox.DataSource = orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void showSelectBtn_Click(object sender, EventArgs e)
        {
            if (orderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select order in list!!!");
                return;
            }

            Order selectedOrder = (orderComboBox.SelectedItem as Order)!;
            MessageBox.Show($"Number : {selectedOrder.Number} . " +
                $"Price :{selectedOrder.TotalPrice.ToString()}$\n" +
                $"Date : {selectedOrder.Date}", "Order details ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
         

        }

        private void removeSelectedBtn_Click(object sender, EventArgs e)
        {
         
            if (orderComboBox.SelectedIndex == -1) return;

            orders.RemoveAt(orderComboBox.SelectedIndex);
            MessageBox.Show("Element was removed!!!");
            UpdateOrderComboBox();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            orders.Add(new Order(numericUpDown1.Value));
            UpdateOrderComboBox();
        }
    }
}