using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CompGraphic
{
    public partial class Form2 : Form
    {
        private PointF[] square;
        private Matrix transformMatrix;

        private Point[] points;
        private int currentScale = 1;
        

        public Form2()
        {
            Graphics g;
            Pen pen = new Pen(Color.Black,2);
            
            InitializeComponent();
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // points = new Point[]
            // {
            //     new Point(10, 10),
            //     new Point(100, 10),
            //     new Point(100, 100),
            //     new Point(10, 100)
            // };
            
            // points = new Point[]
            // {
            //     new Point(100, 100),
            //     new Point(200, 100),
            //     new Point(200, 200),
            //     new Point(100, 200)
            // };
            
            points = new Point[]
            {
                new Point(100, 20),
                new Point(130, 80),
                new Point(190, 80),
                new Point(140, 120),
                new Point(160, 180),
                new Point(100, 140),
                new Point(40, 180),
                new Point(60, 120),
                new Point(10, 80),
                new Point(70, 80)
            };
            
            // panel1.Invalidate();

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black,2);
            g.DrawPolygon(pen, points);
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {   //Начало координат
            
            // points = new Point[]
            // {
            //     new Point(10, 10),
            //     new Point(100, 10),
            //     new Point(100, 100),
            //     new Point(10, 100)
            // };
            
            // Звезда 
            points = new Point[]
            {
                new Point(100, 20),
                new Point(130, 80),
                new Point(190, 80),
                new Point(140, 120),
                new Point(160, 180),
                new Point(100, 140),
                new Point(40, 180),
                new Point(60, 120),
                new Point(10, 80),
                new Point(70, 80)
            };
            
            
            // points = new Point[]
            // {
            //     new Point(100, 100),
            //     new Point(200, 100),
            //     new Point(200, 200),
            //     new Point(100, 200)
            // };
            
            panel1.Invalidate();
        }
        
        
        
        
        // ВИКОРИСТАННЯ МАТРИЦЯ ТРАНСФОРМАЦІЇ

        private void applyTransform(ref Point[] points, double[,] transformMatrix)
        {
            for (int i = 0; i < points.Length; i++)
            {
                int x = (int)Math.Round(this.points[i].X * transformMatrix[0,0]+
                                        this.points[i].Y * transformMatrix[1,0]+
                                        currentScale * transformMatrix [0,2]);
                
                int y = (int)Math.Round(this.points[i].X * transformMatrix[0,1]+
                                        this.points[i].Y * transformMatrix[1,1]+
                                        currentScale * transformMatrix [1,2]);
                points[i] = new Point(x, y);
            }
        }
        
        // ПЕРЕНОС
        private void Transfer_button_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(X_transfer_textbox.Text);
            double y = Double.Parse(Y_transfer_textbox.Text);

            double[,] transformMatrix = new double[,]
            {
                { 1, 0, x },
                { 0, 1, y },
                { 0, 0, 1 }
            };
            
            applyTransform(ref points, transformMatrix);
            panel1.Invalidate();

        }
        

        // ПОВОРОТ
        private void Rotate_button_Click(object sender, EventArgs e)
        {
            int angle = Int32.Parse(angle_rotate_textbox.Text); 
            float centerX = (points[0].X + points[2].X) / 2;
            float centerY = (points[0].Y + points[2].Y) / 2;
            double[,] translateToOriginMatrix = new double[,]
            {
                {1, 0, -centerX},
                {0, 1, -centerY},
                {0, 0, 1}
            };
            
            double[,] rotateMatrix = new double[,]
            {
                { Math.Cos(angle * Math.PI / 180.0), -Math.Sin(angle * Math.PI / 180.0),0 },
                { Math.Sin(angle * Math.PI / 180.0), Math.Cos(angle * Math.PI / 180.0), 0 },
                { 0, 0, 1 }
            };
            double[,] translateBackMatrix = new double[,]
            {
                {1, 0, centerX},
                {0, 1, centerY},
                {0, 0, 1}
            };

            // double[,] transformMatrix = new double[,]
            // {
            //     { Math.Cos(angle * Math.PI / 180.0), -Math.Sin(angle * Math.PI / 180.0),0 },
            //     { Math.Sin(angle * Math.PI / 180.0), Math.Cos(angle * Math.PI / 180.0), 0 },
            //     { 0, 0, 1 }
            // };
            applyTransform(ref points, translateToOriginMatrix);
            applyTransform(ref points, rotateMatrix);
            applyTransform(ref points, translateBackMatrix);
            // applyTransform(ref points, transformMatrix);
            panel1.Invalidate();
        }

        private void Stretch_Compress_button_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(X_strech_compress_textbox.Text);
            double y = Double.Parse(Y_strech_compress_textbox.Text);
            
            float centerX = (points[0].X + points[2].X) / 2;
            float centerY = (points[0].Y + points[2].Y) / 2;
            double[,] translateToOriginMatrix = new double[,]
            {
                {1, 0, -centerX},
                {0, 1, -centerY},
                {0, 0, 1}
            };
            
            double[,] transformMatrix = new double[,]
            {
                { x, 0, 0 },
                { 0, y, 0 },
                { 0, 0, 1 }
            };
            
            double[,] translateBackMatrix = new double[,]
            {
                {1, 0, centerX},
                {0, 1, centerY},
                {0, 0, 1}
            };
            applyTransform(ref points, translateToOriginMatrix);
            applyTransform(ref points, transformMatrix);
            applyTransform(ref points, translateBackMatrix);
            
            
            panel1.Invalidate();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(Scale_textbox.Text);
            double y= Double.Parse(Scale_textbox.Text);
            float centerX = (points[0].X + points[2].X) / 2;
            float centerY = (points[0].Y + points[2].Y) / 2;
            double[,] translateToOriginMatrix = new double[,]
            {
                {1, 0, -centerX},
                {0, 1, -centerY},
                {0, 0, 1}
            };
            
            double[,] transformMatrix = new double[,]
            {
                { x, 0, 0 },
                { 0, y, 0 },
                { 0, 0, 1 }
            };
            
            double[,] translateBackMatrix = new double[,]
            {
                {1, 0, centerX},
                {0, 1, centerY},
                {0, 0, 1}
            };
            applyTransform(ref points, translateToOriginMatrix);
            applyTransform(ref points, transformMatrix);
            applyTransform(ref points, translateBackMatrix);
            
            
            panel1.Invalidate();

        }

        private void MirrorOX_button_Click(object sender, EventArgs e)
        {
            
            // double[,]transformMatrix = new double[,]
            // {
            //     { 1, 0, 0 },
            //     { 0, 1, 0 },
            //     { 0, 0, 1 }
            // };
            // applyTransform(ref points, transformMatrix);
            //
            // transformMatrix = new double[,]
            // {
            //     { 1, 0, 0 },
            //     { 0, 1, points[0].Y*2 },
            //     { 0, 0, 1 }
            // };
            // applyTransform(ref points, transformMatrix);
            // panel1.Invalidate();
            double[,] transformMatrix = new double[,]
            {
                { 1, 0, 0 },
                { 0, -1, 0 },
                { 0, 0, 1 }
            };
            applyTransform(ref points, transformMatrix);

            transformMatrix = new double[,]
            {
                { 1, 0, 0 },
                { 0, 1, panel1.Height / 2 },
                { 0, 0, 1 }
            };
            applyTransform(ref points, transformMatrix);

            panel1.Invalidate();
            
            
        }

        private void Mirror_OY_button_Click(object sender, EventArgs e)
        {
            double[,] transformMatrix = new double[,]
            {
                { -1, 0, panel1.Height / 2 },
                { 0, 1, 0 },
                { 0, 0, 1 }
            };
            applyTransform(ref points, transformMatrix);

            panel1.Invalidate();
            
            
            // Point[] originalPoints = (Point[])points.Clone(); // создаем копию исходных координат
            //
            // double[,] transformMatrix = new double[,]
            // {
            //     { 1, 0, 0 },
            //     { 0, -1, 0 },
            //     { 0, 0, 1 }
            // };
            // applyTransform(ref originalPoints, transformMatrix); // применяем преобразование к исходным координатам
            //
            // transformMatrix = new double[,]
            // {
            //     { 1, 0, -originalPoints[0].X*2 },
            //     { 0, 1, 0 },
            //     { 0, 0, 1 }
            // };
            // applyTransform(ref originalPoints, transformMatrix); // применяем преобразование к исходным координатам
            //
            // points = originalPoints; // присваиваем преобразованные координаты обратно в переменную points
            //
            // panel1.Invalidate();
        }

        private void Rotate_Transfer_Scale_button_Click(object sender, EventArgs e)
        {
            int angle = 45; 
            float centerX = (points[0].X + points[2].X) / 2;
            float centerY = (points[0].Y + points[2].Y) / 2;
            double[,] translateToOriginMatrix = new double[,]
            {
                {1, 0, -centerX},
                {0, 1, -centerY},
                {0, 0, 1}
            };
            
            double[,] rotateMatrix = new double[,]
            {
                { Math.Cos(angle * Math.PI / 180.0), -Math.Sin(angle * Math.PI / 180.0),0 },
                { Math.Sin(angle * Math.PI / 180.0), Math.Cos(angle * Math.PI / 180.0), 0 },
                { 0, 0, 1 }
            };
            double[,] translateBackMatrix = new double[,]
            {
                {1, 0, centerX},
                {0, 1, centerY},
                {0, 0, 1}
            };
            
            applyTransform(ref points, translateToOriginMatrix);
            applyTransform(ref points, rotateMatrix);
            applyTransform(ref points, translateBackMatrix);
            
            //////////////////////////////
            
            double x = 100;
            double y = 100;

            double[,] transformMatrix = new double[,]
            {
                { 1, 0, x },
                { 0, 1, y },
                { 0, 0, 1 }
            };
            
            applyTransform(ref points, transformMatrix);
           /////////////
            
           x = 2;
           y= 2;
           centerX = (points[0].X + points[2].X) / 2;
           centerY = (points[0].Y + points[2].Y) / 2;
            translateToOriginMatrix = new double[,]
           {
               {1, 0, -centerX},
               {0, 1, -centerY},
               {0, 0, 1}
           };
            
            transformMatrix = new double[,]
           {
               { x, 0, 0 },
               { 0, y, 0 },
               { 0, 0, 1 }
           };
            
            translateBackMatrix = new double[,]
           {
               {1, 0, centerX},
               {0, 1, centerY},
               {0, 0, 1}
           };
           applyTransform(ref points, translateToOriginMatrix);
           applyTransform(ref points, transformMatrix);
           applyTransform(ref points, translateBackMatrix);


           

           panel1.Invalidate();
        }
    }
}