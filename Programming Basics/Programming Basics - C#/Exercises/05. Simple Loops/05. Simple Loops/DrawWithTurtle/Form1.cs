using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace DrawWithTurtle
{
    public partial class FormTurtleGraphics : Form
    {
        public FormTurtleGraphics()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 200;

            // Draw a equilateral triangle
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            // Draw a line in the triangle
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if(Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }
        }

        private void DrawHexagon_Click(object sender, EventArgs e)
        {
            //You choose to add or to remove the PenColor feature
            Turtle.PenColor = Color.LightPink;
            Turtle.Delay = 150;
            int counter = 1;
            while (counter < 7)
            {
                Turtle.Rotate(60);
                Turtle.Forward(100);
                counter++;
            }  
        }

        private void DrawStar_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Green;
            Turtle.Delay = 150;
            int counter = 1;
           
            while (counter <= 5)
            {
                Turtle.Forward(200);
                Turtle.Rotate(-144);
                //or
                //Turtle.Rotate(144);
                counter++;
            }

        }

        private void DrawSpiral_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Coral;
            Turtle.Delay = 150;
            int counter = 1, length = 0;

            while(counter <= 20)
            {
                length += 10;
                Turtle.Forward(length);
                Turtle.Rotate(60);
                counter++;
            }

        }

        private void DrawSun_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Yellow;
            Turtle.Delay = 300;
            int counter = 1;

            while (counter <= 36)
            {
                Turtle.Forward(300);
                Turtle.Rotate(170);
                counter ++;
            }
        }

        private void SpiralTriangle_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Red;
            //Turtle.Delay = 200;
            
            int triangleCount = 1;
            int length;
            int angle = 60;

             while (triangleCount < 4)
             {
                 length = 220;
                 Turtle.Rotate(angle);
                 for (int i = 1; i <= 22; i++)
                 {
                     Turtle.Forward(length);
                     Turtle.Rotate(120);
                     length -= 10;
                 }
                triangleCount++;

                angle += 30;
             }
            
        }
    }
}
