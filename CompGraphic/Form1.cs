using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace CompGraphic
{
    class Circle
    {
        private int X;
        private int Y;
        private int Radius;
        public int EdX => X;
        public int EdY => Y;
        public int EdRadius => Radius;
        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius; } }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.Size = new Size(1000, 1000);// size of window 
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.LightSlateGray);// background color
            Run(5);// number of iterations
        }
        private void Run(int countcycle)
        {
            Circle circle = new Circle(500, 500, 150);// size first circle
            int PWidth = 10;// Line thickness 
            List<Circle> iteration = new List<Circle>();
            List<Circle> temp = new List<Circle>();
            iteration = PaintCircleOutside(circle.EdX,circle.EdY,circle.EdRadius,PWidth);
            
            for (int i = 0; i < countcycle-1; i++)
            {
                if (PWidth<2)
                {
                    PWidth = 2;
                }
                PWidth -= 2;
                RewriteAllInOneList(iteration, temp);
                temp.Clear();
                
                foreach (Circle c in iteration)
                {
                    Thread.Sleep(1);
                    RewriteAllInOneList(temp, PaintCircleOutside(c.EdX, c.EdY, c.EdRadius,PWidth));
                }
                iteration.Clear(); } }

        private void RewriteAllInOneList(List<Circle> main, List<Circle> other)
        {
            foreach (Circle c in other)
            {
                main.Add(new Circle(c.EdX,c.EdY,c.EdRadius)); } }
        private List<Circle> PaintCircleOutside(int x, int y, int radius, int PWidth)
        {
            List<Color> colors = new List<Color> {
                Color.Red,
                Color.Coral,
                Color.Blue,
                Color.Yellow,
                Color.Purple
            }; Random random = new Random();
            Color randomColor = colors[random.Next(colors.Count)];

            int centerX = x; 
            int centerY = y; 
            int bigRadius = radius; 
            int smallRadius = radius/2; 
            
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(randomColor,PWidth);
            g.DrawEllipse(p, centerX - bigRadius, centerY - bigRadius, bigRadius * 2, bigRadius * 2);
            
            int topX = centerX;
            int topY = centerY - bigRadius - smallRadius;
            int bottomX = centerX;
            int bottomY = centerY + bigRadius + smallRadius;
            int leftX = centerX - bigRadius - smallRadius;
            int leftY = centerY;
            int rightX = centerX + bigRadius + smallRadius;
            int rightY = centerY;
            
            List<Circle> small_circles = new List<Circle>();
            small_circles.Add(new Circle(topX,topY,smallRadius));
            small_circles.Add(new Circle(bottomX,bottomY,smallRadius));
            small_circles.Add(new Circle(leftX,leftY,smallRadius));
            small_circles.Add(new Circle(rightX,rightY,smallRadius));
            return small_circles; } } }