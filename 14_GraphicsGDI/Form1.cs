using System.Drawing;

namespace _14_GraphicsGDI
{
    public partial class Form1 : Form
    {
        int redraw_count ;
        List<Point> points;
        public Form1()
        {
            InitializeComponent();
            redraw_count = 0;
            points = new List<Point>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g =  this.CreateGraphics();
            int x = 120, y = 120, height = 300, width = 500;
            Rectangle rectangle = new Rectangle(x, y, width, height);
            g.FillEllipse(Brushes.Blue, rectangle);


            Point point = new Point(50,50);
            Size size = new Size(700, 500);
            Rectangle rectangle1 = new Rectangle(point, size);
            Pen pen = new Pen(Brushes.Coral, 8);
            g.DrawEllipse(pen, rectangle1);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.Text = $"{redraw_count++}";
            Graphics g = e.Graphics;
            int x = 120, y = 120, height = 300, width = 500;
            Rectangle rectangle = new Rectangle(x, y, width, height);
            g.FillEllipse(Brushes.Blue, rectangle);


            Point point = new Point(50, 50);
            Size size = new Size(700, 500);
            Rectangle rectangle1 = new Rectangle(point, size);
            Pen pen = new Pen(Brushes.Coral, 8);
            g.DrawEllipse(pen, rectangle1);

            Pen linePen = new Pen(Brushes.Cyan, 15);
            linePen.StartCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
            linePen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; 
            linePen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            g.DrawLine(linePen, 50, 600, 1200, 600);

            PrintFigures(g);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void PrintFigures(Graphics g)
        {
            foreach (Point p in points)
            {
                g.FillEllipse(Brushes.Teal, p.X - 10, p.Y - 10, 20, 20);
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            points.Add(point);
            this.CreateGraphics().FillEllipse(Brushes.Teal, point.X-10, point.Y-10,
                20, 20);
        }
    }
}