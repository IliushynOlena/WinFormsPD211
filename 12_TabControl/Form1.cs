namespace _12_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl.TabPages.Clear();    
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTb.Clear();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage($"New tab {tabControl.TabPages.Count + 1}");
            page.UseVisualStyleBackColor = true;
            // label1
            // 
            Label mainlabel = new Label();  
            mainlabel.AutoSize = true;
            mainlabel.Font = new System.Drawing.Font("Segoe UI Black", 27.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mainlabel.Location = new System.Drawing.Point(418, 141);
            mainlabel.Name = "label1";
            mainlabel.Size = new System.Drawing.Size(529, 124);
            mainlabel.Text = "Hello User";
            // 
            // label2
            // 
            Label namelabel = new Label();
            namelabel.AutoSize = true;
            namelabel.Location = new System.Drawing.Point(239, 423);
            namelabel.Name = "label2";
            namelabel.Size = new System.Drawing.Size(120, 41);
            namelabel.TabIndex = 1;
            namelabel.Text = "Name : ";
            // 
            // nameTb
            // 
            TextBox nameTextBox = new TextBox();
            nameTextBox.Location = new System.Drawing.Point(418, 417);
            nameTextBox.Name = "nameTb";
            nameTextBox.Size = new System.Drawing.Size(551, 47);
            nameTextBox.TabIndex = 2;
            // 
            // clearBtn
            // 
            Button clearButton = new Button();
            clearButton.Location = new System.Drawing.Point(591, 702);
            clearButton.Name = "clearBtn";
            clearButton.Size = new System.Drawing.Size(188, 58);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            //clearButton.Click += ClearButton_Click;
            clearButton.Click += (sender, e)=> { nameTextBox.Clear(); };
            // 
            page.Controls.Add(mainlabel);
            page.Controls.Add(namelabel);
            page.Controls.Add(nameTextBox);
            page.Controls.Add(clearButton);


            tabControl.TabPages.Add(page);
        }

        //private void ClearButton_Click(object? sender, EventArgs e)
        //{
        //    nameTextBox.Clear();
        //}

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex != -1)
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex); 
        }
        //TextBox GetSelectedTab()
        //{
        //    foreach (var item in tabControl.SelectedTab.Controls.OfType<TextBox>())
        //    {
        //        if (item.Name == "nameTb")
        //            return item;
        //    }
        //    return null;
        //}
        public TextBox SelectedNameTb
        {
            get
            {
                foreach (var item in tabControl.SelectedTab.Controls.OfType<TextBox>())
                {
                    if (item.Name == "nameTb")
                        return item;
                }
                return null;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Name {GetSelectedTab().Text}");
            MessageBox.Show($"Name {SelectedNameTb.Text}");
        }
    }
}