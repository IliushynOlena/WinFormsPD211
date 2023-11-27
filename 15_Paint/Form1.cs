using System.Drawing;

namespace _15_Paint
{
    public partial class Form1 : Form
    {
        Point startLocation;
        List<MyShape> shapes;
        enum ShapeType { Rectangle, Line, Ellipse};
        public Form1()
        {
            InitializeComponent();
            shapes = new List<MyShape>();
            //this.CreateGraphics().FillRectangle()
            colorList.Items.Add(Color.Blue);
            colorList.Items.Add(Color.Red);
            colorList.Items.Add(Color.Yellow);
            colorList.Items.Add(Color.Green);
            colorList.SelectedIndex = 0;

            foreach (var item in Enum.GetValues(typeof(ShapeType)))
            {
                typeList.Items.Add(item);
            }
            typeList.SelectedIndex = 0;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startLocation = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Point endLocation = e.Location;
            Graphics g =  this.CreateGraphics();
            Color color = (Color)colorList.SelectedItem;
            MyShape shape = null;
            var type = (ShapeType)typeList.SelectedItem;
            if(type == ShapeType.Rectangle || type  == ShapeType.Ellipse)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.X = startLocation.X < endLocation.X ? startLocation.X :
                    endLocation.X;
                rectangle.Y = startLocation.Y < endLocation.Y ? startLocation.Y :
                    endLocation.Y;

                rectangle.Width = Math.Abs(endLocation.X - startLocation.X);
                rectangle.Height = Math.Abs(endLocation.Y - startLocation.Y);

                if(type == ShapeType.Rectangle)
                {
                    shape = new MyRectangle(color, rectangle);
                }
                else if(type == ShapeType.Ellipse)
                {
                    shape = new MyEllipse(color, rectangle);
                }
                
            }
            else if(type == ShapeType.Line)
            {
                shape = new MyLine(color, startLocation, endLocation );               
            }
            shape.Draw(g);
            shapes.Add(shape);


        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (MyShape r in shapes)
            {
                r.Draw(g);
            }
        }
    }
    abstract class MyShape
    {
        public abstract void Draw(Graphics g);
    }

    class MyRectangle : MyShape
    {
        public Color Color { get; set; }
        public Rectangle Rectangle { get; set; }
        public MyRectangle() { }
        public MyRectangle(Color C, Rectangle R) 
        { 
            Color = C;
            Rectangle = R;
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color), Rectangle);
        }
    }
    class MyLine : MyShape
    {
        public Pen Pen { get; set; }
        public Point Start { get; set; }
        public Point End { get; set; }
        public MyLine() { }
        public MyLine(Color C, Point S, Point E)
        {
            Pen = new Pen(C , 10);
            Start = S;
            End = E;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(Pen, Start, End);
        }
    }
    class MyEllipse : MyRectangle
    {
        public MyEllipse() { }
        public MyEllipse(Color color, Rectangle rect) : base(color, rect) { }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color), Rectangle);
        }

    }
}