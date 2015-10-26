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
        private static int x1, y1, xs, ys, xe, ye;
        private static double xstart, ystart, xende, yende, xzoom, yzoom;
        private static bool action, rectangle, finished;
        private static float xy;
        // private Image picture; // djm original java - now replaced with private PictureBox picture;
        private Graphics g1;
        private Cursor c1, c2;
        // private HSB HSBcol = new HSB(); // djm original
        public Bitmap bitmap;
        private Pen pen;
        public Form1()
        {
            this.InitializeComponent();
            finished = false;
            //addMouseListener(this);
            //addMouseMotionListener(this);
            this.c1 = Cursors.WaitCursor;
            // c1 = new Cursor(Cursor.WAIT_CURSOR); // djm original java
            this.c2 = Cursors.Cross;
            // c2 = new Cursor(Cursor.CROSSHAIR_CURSOR); // djm original java
            x1 = this.picture.Width;
            // x1 = getSize().width; // djm original java
            y1 = this.picture.Height;
            // y1 = getSize().height; // djm original java
            xy = (float)x1 / (float)y1;
            this.bitmap = new Bitmap(x1, y1);
            // picture = createImage(x1, y1); // djm original java
            this.g1 = Graphics.FromImage(this.bitmap);
            // g1 = picture.getGraphics(); // djm original java
            finished = true;
            this.Start();
        }

        public void Start()
        // djm original start()
        {
            action = false;
            rectangle = false;
            this.Initvalues();
            xzoom = (xende - xstart) / (double)x1;
            yzoom = (yende - ystart) / (double)y1;
            this.Mandelbrot();
        }

        private void Initvalues() // reset start values
        // djm original initValues()
        {
            xstart = SX;
            ystart = SY;
            xende = EX;
            yende = EY;
            if ((float)((xende - xstart) / (yende - ystart)) != xy)
                xstart = xende - (yende - ystart) * (double)xy;
        }

        private void Mandelbrot() // calculate all points
        // djm original mandelbrot()
        {
            int x, y;
            float h, b, alt = 0.0f;

            action = false;
            this.Cursor = this.c1;
            // setCursor(c1); // djm original java
            this.Text = "Mandelbrot-Set will be produced - please wait...";
            // showStatus("Mandelbrot-Set will be produced - please wait..."); // djm original java
            for (x = 0; x < x1; x += 2)
                for (y = 0; y < y1; y++)
                {
                    h = this.Pointcolour(xstart + xzoom * (double)x, ystart + yzoom * (double)y); // color value
                    if (h != alt)
                    {
                        b = 1.0f - h * h; // brightness

                        var customColour = new HSBColor(h * 255, 0.8f * 255, b * 255); // hsb colour
                        var convertedColour = HSBColor.FromHSB(customColour); // onvert hsb to rgb then make a Java Color
                        /* 
                        // djm not needed
                        Color col = Color.getHSBColor(h,0.8f,b);
                        int red = col.getRed();
                        int green = col.getGreen();
                        int blue = col.getBlue();
                        */
                        this.pen = new Pen(convertedColour);
                        alt = h;
                    }
                    this.g1.DrawLine(this.pen, x, y, x + 1, y);
                }
            this.Text = "Mandelbrot-Set ready - please select zoom area with pressed mouse.";
            // showStatus("Mandelbrot-Set ready - please select zoom area with pressed mouse."); // djm original java
            this.Cursor = this.c2;
            // setCursor(c2); // djm original java
            action = true;
        }

        private float Pointcolour(double xwert, double ywert) // color value from 0.0 to 1.0 by iterations
        // djm original pointcolour()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            // Put the bitmap on the window
            Graphics windowG = e.Graphics;
            windowG.DrawImageUnscaled(this.bitmap, 0, 0);
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) // e.consume(); // djm original Java
            {
                xs = e.X; // xs = e.getX(); // djm original Java
                ys = e.Y; // ys = e.getY(); // djm original Java
            }

        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
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
                // Redraw picture and child components
                this.Refresh(); // repaint(); // djm original Java
            }
        }
    }
}
