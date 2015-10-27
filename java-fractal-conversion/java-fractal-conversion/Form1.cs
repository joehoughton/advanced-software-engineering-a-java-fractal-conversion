using System;
using System.Drawing;
using System.Windows.Forms;

namespace java_fractal_conversion
{
    public partial class Form1 : Form
    {
        private const int MAX = 256;      // max iterations
        private const double SX = -2.025; // start value real
        private const double SY = -1.125; // start value imaginary
        private const double EX = 0.6;    // end value real
        private const double EY = 1.125;  // end value imaginary
        private const int ScaleUp = 255;
        private static int x1, y1, xs, ys, xe, ye;
        private static double xstart, ystart, xende, yende, xzoom, yzoom;
        private static bool action, rectangle, finished;
        private static float xy;
        private readonly Graphics g1;
        public Bitmap Bitmap;
        private Pen pen;
        // private Cursor c1, c2; // djm not needed // now changed in picture_MouseEnter and picture_MouseLeave 
        // private Image picture; // djm not needed 
        // private HSB HSBcol = new HSB(); // djm not needed

        public Form1()
        {
            this.InitializeComponent();
            finished = false;
            // addMouseListener(this); // djm not needed
            // addMouseMotionListener(this); // djm not needed
            // this.c1 = Cursors.WaitCursor; // replaced by picture_MouseEnter() // c1 = new Cursor(Cursor.WAIT_CURSOR); // djm original java
            // this.c2 = Cursors.Cross; // replaced by picture_MouseLeave() // c1 = new Cursor(Cursor.WAIT_CURSOR); // djm original java
            x1 = this.picture.Width;  // x1 = getSize().width; // djm original java
            y1 = this.picture.Height;  // y1 = getSize().height; // djm original java
            xy = (float)x1 / (float)y1;

            this.Bitmap = new Bitmap(x1, y1); // picture = createImage(x1, y1); // djm original java
            this.g1 = Graphics.FromImage(this.Bitmap); // g1 = picture.getGraphics(); // djm original java

            finished = true;
            this.Start();
        }

        public void Start() // djm original start()
        {
            action = false;
            rectangle = false;
            this.Initvalues();
            xzoom = (xende - xstart) / (double)x1;
            yzoom = (yende - ystart) / (double)y1;
            this.Mandelbrot();
        }

        private void Initvalues() // reset start values // djm original initValues()
        {
            xstart = SX;
            ystart = SY;
            xende = EX;
            yende = EY;
            if ((float)((xende - xstart) / (yende - ystart)) != xy)
                xstart = xende - (yende - ystart) * (double)xy;
        }

        private void Mandelbrot() // calculate all points // djm original mandelbrot()
        {
            int x, y;
            float h, b, alt = 0.0f;

            action = false;
            this.Cursor = Cursors.WaitCursor; // setCursor(c1); // djm original java
            this.Text = "Mandelbrot-Set will be produced - please wait..."; // showStatus("Mandelbrot-Set will be produced - please wait..."); // djm original java

            for (x = 0; x < x1; x += 2)
                for (y = 0; y < y1; y++)
                {
                    h = this.Pointcolour(xstart + xzoom * (double)x, ystart + yzoom * (double)y); // color value
                    if (h != alt)
                    {
                        b = 1.0f - h * h; // brightness

                        var customColour = new HSBColor(h * ScaleUp, 0.8f * ScaleUp, b * ScaleUp); // hsb colour
                        var convertedColour = HSBColor.FromHSB(customColour); // convert hsb to rgb then make a Java Color
                        // Color col = Color.getHSBColor(h,0.8f,b); // djm not needed
                        // int red = col.getRed(); // djm not needed
                        // int green = col.getGreen(); // djm not needed
                        // int blue = col.getBlue(); // djm not needed

                        this.pen = new Pen(convertedColour);
                        alt = h;
                    }
                    this.g1.DrawLine(this.pen, x, y, x + 1, y);
                }

            this.Cursor = Cursors.Cross; // setCursor(c1); // djm original java
            this.Text = "Mandelbrot-Set ready - please select zoom area with pressed mouse."; // showStatus("Mandelbrot-Set ready - please select zoom area with pressed mouse."); // djm original java
            action = true;
        }

        private float Pointcolour(double xwert, double ywert) // color value from 0.0 to 1.0 by iterations  // djm original pointcolour()
        {
            double r = 0.0, i = 0.0, m = 0.0;
            int j = 0;

            while ((j < MAX) && (m < 4.0))
            {
                j++;
                m = r * r - i * i;
                i = 2.0 * r * i + ywert;
                r = m + xwert;
            }
            return (float)j / (float)MAX;
        }


        public void Paint(Graphics g)
        {
            this.Update(g);
        }

        public void Update(Graphics g)
        {
            g.DrawImage(this.Bitmap, 0, 0);
            if (rectangle)
            {
                this.pen = new Pen(Color.White); // use a new pen to prevent memory leak // this.pen.Color = Color.White; throws Parameter is not valid exception
                if (xs < xe)
                {
                    if (ys < ye) g.DrawRectangle(this.pen, xs, ys, (xe - xs), (ye - ys));
                    else g.DrawRectangle(this.pen, xs, ye, (xe - xs), (ys - ye));
                }
                else
                {
                    if (ys < ye)
                    {
                        g.DrawRectangle(this.pen, xe, ys, (xs - xe), (ye - ys));
                    }
                    else
                    {
                        g.DrawRectangle(this.pen, xe, ye, (xs - xe), (ys - ye));
                    }
                }

                this.pen.Dispose();  // Release all pen resources
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            this.Paint(e.Graphics);
        }

        private void picture_MouseDown(object sender, MouseEventArgs e) // public void mousePressed(MouseEvent e) // djm original
        {
            // e.consume(); // djm not needed

            if (action && e.Button == MouseButtons.Left) // e.consume(); // djm original Java
            {
                xs = e.X; // xs = e.getX(); // djm original Java
                ys = e.Y; // ys = e.getY(); // djm original Java
            }

        }

        private void picture_MouseUp(object sender, MouseEventArgs e) // public void mouseReleased(MouseEvent e) // djm original java
        {
            int z, w;

            if (action)
            {
                xe = e.X; // xe = e.getX(); // djm original Java
                ye = e.Y; // ye = e.getY(); // djm original Java
                if (xs > xe)
                {
                    z = xs;
                    xs = xe;
                    xe = z;
                }
                if (ys > ye)
                {
                    z = ys;
                    ys = ye;
                    ye = z;
                }
                w = (xe - xs);
                z = (ye - ys);
                if ((w < 2) && (z < 2)) this.Initvalues();
                else
                {
                    if (((float)w > (float)z * xy)) ye = (int)((float)ys + (float)w / xy);
                    else xe = (int)((float)xs + (float)z * xy);
                    xende = xstart + xzoom * (double)xe;
                    yende = ystart + yzoom * (double)ye;
                    xstart += xzoom * (double)xs;
                    ystart += yzoom * (double)ys;
                }
                xzoom = (xende - xstart) / (double)x1;
                yzoom = (yende - ystart) / (double)y1;
                this.Mandelbrot();
                rectangle = false;
                this.Refresh();  // Redraw picture and child components // repaint(); // djm original Java
            }
        }

        private void picture_MouseMove(object sender, MouseEventArgs e) // public void mouseDragged(MouseEvent e) // djm original java
        {
            // e.consume(); // djm not needed

            if (action && e.Button == MouseButtons.Left) // if (action); // djm original Java
            {
                xe = e.X; // xe = e.getX(); // djm original Java
                ye = e.Y; // ye = e.getY(); // djm original Java
                rectangle = true; // set to true so selected area drawn in Update method
                this.Refresh();  // Redraw picture and child components
            }

        }

        private void picture_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void picture_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
