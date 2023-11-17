namespace _09_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if( dialog.ShowDialog() == DialogResult.OK )
            {
                this.BackColor = dialog.Color;
            }
        }

        private void fontBtn_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(  font.ShowDialog()== DialogResult.OK)
            {
                var selected = font.Font;
                openFileBtn.Font = selected;
                //openFolderBtn.Size = new Size(selected.Height, selected.Height);
                saveFileBtn.Font = selected;
                openFolderBtn.Font = selected;
                backColorBtn.Font = selected;
                fontBtn.Font = selected;
            }
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt||";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName);
                textBox1.Text =  reader.ReadToEnd(); 
                reader.Close();
            }
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.CreatePrompt = true;
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.OverwritePrompt = true;

            if( saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
                writer.Write(textBox1.Text);
                writer.Close(); 
            }
        }

        private void openFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if( folder.ShowDialog()== DialogResult.OK)
            {
                listBox1.Items.Clear();
                foreach (var path in Directory.GetFiles(folder.SelectedPath))
                {
                    listBox1.Items.Add(Path.GetFileName(path));
                } 
            }
        }
    }
}