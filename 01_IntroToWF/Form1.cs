namespace _01_IntroToWF
{
    public partial class Form1 : Form
    {
        Point startLocation;
        public Form1()
        {
            InitializeComponent();
            startLocation = btnCSharp.Location;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Winform", "Congratulation!!!",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnClick_MouseEnter(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Yellow;
        }

        private void btnClick_MouseLeave(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Lime;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Do you want to close window ?", "", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            { this.Close(); }
           
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            btnCSharp.Location=new Point(btnCSharp.Location.X-5, btnCSharp.Location.Y);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {

            btnCSharp.Location=new Point(btnCSharp.Location.X+5, btnCSharp.Location.Y);
        }

        private void btnCSharp_Click(object sender, EventArgs e)
        {
            btnCSharp.Location = startLocation;

            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse Position : {e.X}: {e.Y}";
        }
    }
}