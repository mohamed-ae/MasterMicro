using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_Plotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //clear 
            e.Graphics.Clear(Color.White);


            Pen blackPen = new Pen(Color.Gray);

            PictureBox axesPicBox = this.axesPicBox;
            Point origin = axesPicBox.Location;

            int width = axesPicBox.Width;
            int height = axesPicBox.Height;

            // Y axis
            Point midTop = new Point(origin.X + width / 2, origin.Y);
            Point midBottom = new Point(origin.X + width / 2, height);

            // X axis
            Point midLeft = new Point(origin.X, origin.Y + height / 2);
            Point midRight = new Point(origin.X + width, origin.Y + height / 2);

            // Draw Y axis
            e.Graphics.DrawLine(blackPen, midTop, midBottom);
            // Draw X axix
            e.Graphics.DrawLine(blackPen, midLeft, midRight);

            
        }

       

        private void btnDraw_Click(object sender, EventArgs e)
        {
            pictureBox1_Paint(this, new PaintEventArgs(axesPicBox.CreateGraphics(), axesPicBox.ClientRectangle));

            // Check if Min and Max fields are empty
            if (minTxtBx.Text.Equals(""))
            {
                MessageBox.Show("Enter Min value");
                minTxtBx.Focus();
                return;
            }

            if (maxTxtBx.Text.Equals(""))
            {
                MessageBox.Show("Enter Max value");
                maxTxtBx.Focus();
                return;
            }

            // Try to parse Min and Max fields
            int min = 0;
            bool validParse = int.TryParse(minTxtBx.Text, out min);
            if (!validParse)
            {
                MessageBox.Show("Not valid Min value");

            }

            int max = 0;
            validParse = int.TryParse(maxTxtBx.Text, out max);
            if (!validParse)
            {
                MessageBox.Show("Not valid Max value");

            }

            drawFunc( min, max);


        }




        // My methods
        private string functionString = "";
        private void addTerm_Click(object sender, EventArgs e)
        { 
             // Check coefficient
            double coefDec = 0;
            string coefFrac = "";
            bool isValidCoef = tryParseToDouble(coefficientTxtBx.Text, out coefDec, out coefFrac);
            if(!isValidCoef)
            {
                MessageBox.Show("Ivalid coefficient");
                coefficientTxtBx.Focus();
                return;
            }

            // check power
            double powDec = 0;
            string powFrac = "";
            bool isValidPow = tryParseToDouble(powTxtBx.Text, out powDec, out powFrac);
            if (!isValidPow)
            {
                MessageBox.Show("Invalid power");
                powTxtBx.Focus();
                return;
            }
            if (!powFrac.Equals(""))
            {
                isPowFrac = true;
            }
            else
            {
                isPowFrac = false;
            }

            string mainTerm = "";
            if(coefFrac == "")
            {
                if(powFrac == "")
                {
                    mainTerm = coefDec + "*" + "X" + "^" + powDec;
                }
                else
                {
                    mainTerm = coefDec + "*" + "X" + "^" + "(" + powFrac + ")";
                }
            }
            else
            {
                if(powFrac == "")
                {
                    mainTerm = "(" + coefFrac + ")" + "*" + "X" + "^" + powDec;
                }
                else
                {
                    mainTerm = "(" + coefFrac + ")" + "*" + "X" + "^" + "(" + powFrac + ")";
                }
            }

            if (txtBxFunction.Text.Trim().Equals(""))
            {
                txtBxFunction.Text += " " + mainTerm;
                functionString += coefDec + "x" + "^" + powDec;
            }
            else
            {
                txtBxFunction.Text += " + " + mainTerm;
                functionString += "+" + coefDec + "x" + "^" + powDec;
            }

            // empty coefficient and pow textboxes
            coefficientTxtBx.Text = "";
            powTxtBx.Text = "";
        }

        private bool tryParseToDouble(string coef, out double result, out string frac)
        {

            result = 0;
            frac = "";
            string[] fracParts = coef.Split('/');

             int numerator = 0;
            if (!int.TryParse(fracParts[0], out numerator))
            {
                return false;
            }

            if(fracParts.Length <= 1)
            {
                result = numerator;
                return true;
            }

            int denomirator = 0;
            if(!int.TryParse(fracParts[1], out denomirator))
            {
                return false;
            }

            result = numerator*1.0 / denomirator;
            frac = numerator + "/" + denomirator;
            return true;


        }


        private double computeFuncFor(double x)
        {
            string[] functionTerms = functionString.Split('+');
            double result = 0;
            foreach(string term in functionTerms)
            {
                result += computerFuncTerm(term,x);
            }

            return result;
        }

        private double computerFuncTerm(string term, double x)
        {
            term = term.Trim();
            double result = 0;

            string[] parts = term.Split('x');

            double pow = double.Parse(parts[1].Split('^')[1]);
           
            result = double.Parse(parts[0]) * Math.Pow(x, pow);
            

            if ( double.IsNaN(result) )
            {
                MessageBox.Show("Invalid X value, check Min and Max");
                throw new Exception("Invalid X value, check Min and Max");
            }


            return result;
        }

        // Point to represent the point on My axes not Window axes
        struct PointAx
        {
            public double X;
            public double Y;
        }
        bool isPowFrac = false;
        private PointAx computePtOnAx(double x, double y)
        {
            int width = axesPicBox.Width;
            int height = axesPicBox.Height;

            double xOrigin =  width / 2.0;
            double yOrigin = height / 2.0;

            int scale = 10; // scale variable is for give the original curve more curve
            PointAx pt = new PointAx();
            if (!isPowFrac)
            {
                pt.X = xOrigin + (x*scale); // scale variable is for give the original curve more curve
                pt.Y = yOrigin - y;
            }
            else
            {
                pt.X = xOrigin + x; // scale variable is for give the original curve more curve
                pt.Y = yOrigin - (y*scale);
            }

            

            return pt;
        }

        private void drawFunc(int min, int max)
        {

            Pen pen = new Pen(Color.Black,2);

            Graphics g = axesPicBox.CreateGraphics();


            //PointAx prevPt = computePtOnAx(min,y);
            PointAx prevPt = new PointAx();
            PointAx curPt = new PointAx();
            for (double x = min; x <= max; x += 0.01 )
            {
                double y = computeFuncFor(x);
                if (double.IsInfinity(y))
                {
                    prevPt = computePtOnAx(0.001, computeFuncFor(0.001));
                    continue;
                }
                
                curPt = computePtOnAx(x, y);

                if(x == min)
                {
                    prevPt.X = curPt.X;
                    prevPt.Y = curPt.Y;
                }
                

                g.DrawLine(pen, (float)prevPt.X, (float)prevPt.Y, (float)curPt.X, (float)curPt.Y);
                
                prevPt.X = curPt.X;
                prevPt.Y = curPt.Y;
            }
        }

        

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtBxFunction.Clear();
            functionString = "";
        }
    }
}
