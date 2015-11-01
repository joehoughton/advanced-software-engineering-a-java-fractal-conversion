using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Xml.Linq;
using System.IO;
using System.Xml;
using System.Drawing.Imaging;

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
        private int j; // sets colour of fractal - default to 0
        private static int x1, y1, xs, ys, xe, ye;
        private static double xstart, ystart, xende, yende, xzoom, yzoom;
        private static bool action, rectangle;
        private static float xy;
        private readonly Graphics g1;
        private readonly Bitmap bitmap;
        private Pen pen;
        private bool cycleForwards = true;
        // private static bool finished;  // djm not needed - can reset state without in resetToolStripMenuItem_Click()
        // private Cursor c1, c2; // djm not needed // now changed in picture_MouseEnter and picture_MouseLeave 
        // private Image picture; // djm not needed 
        // private HSB HSBcol = new HSB(); // djm not needed

        public Form1()
        {
            InitializeComponent();
            // finished = false; // djm not needed - can reset state without in resetToolStripMenuItem_Click()
            // addMouseListener(this); // djm not needed
            // addMouseMotionListener(this); // djm not needed
            // c1 = Cursors.WaitCursor; // replaced by picture_MouseEnter() // c1 = new Cursor(Cursor.WAIT_CURSOR); // djm original java
            // c2 = Cursors.Cross; // replaced by picture_MouseLeave() // c1 = new Cursor(Cursor.WAIT_CURSOR); // djm original java
            x1 = picture.Width;  // x1 = getSize().width; // djm original java
            y1 = picture.Height;  // y1 = getSize().height; // djm original java
            xy = (float)x1 / (float)y1;

            this.bitmap = new Bitmap(x1, y1); // picture = createImage(x1, y1); // djm original java
            g1 = Graphics.FromImage(this.bitmap); // g1 = picture.getGraphics(); // djm original java

            // finished = true; // djm not needed - can reset state without in resetToolStripMenuItem_Click()
            Start();
        }

        public void Start() // djm original start()
        {
            action = false;
            rectangle = false;
            Initvalues();
            xzoom = (xende - xstart) / (double)x1;
            yzoom = (yende - ystart) / (double)y1;
            Mandelbrot();
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
            // Cursor = Cursors.WaitCursor; //jh not needed // setCursor(c1); // djm original java
            Text = "C3375905";
            message.Text = "Mandelbrot-Set will be produced - please wait...";  // showStatus("Mandelbrot-Set will be produced - please wait..."); // djm original java

            for (x = 0; x < x1; x += 2) // x less than width - draw lines from left to right
                for (y = 0; y < y1; y++) // draw 1 pixel at a time
                {
                    h = Pointcolour(xstart + xzoom * (double)x, ystart + yzoom * (double)y); // color value
                    if (h != alt)
                    {
                        b = 1.0f - h * h; // brightness

                        var customColour = new HSBColor(h * ScaleUp, 0.8f * ScaleUp, b * ScaleUp); // hsb colour
                        var convertedColour = HSBColor.FromHSB(customColour); // convert hsb to rgb then make a Java Color

                        // Color col = Color.getHSBColor(h,0.8f,b); // djm not needed
                        // int red = col.getRed(); // djm not needed
                        // int green = col.getGreen(); // djm not needed
                        // int blue = col.getBlue(); // djm not needed
                        pen = new Pen(convertedColour);
                        alt = h;
                    }
                    g1.DrawLine(pen, x, y, x + 1, y);
                }

            // Cursor = Cursors.Cross; //jh not needed // setCursor(c1); // djm original java
            message.Text = "Mandelbrot-Set ready - please select zoom area with pressed mouse."; // showStatus("Mandelbrot-Set ready - please select zoom area with pressed mouse."); // djm original java
            action = true;
        }

        private float Pointcolour(double xwert, double ywert) // color value from 0.0 to 1.0 by iterations  // djm original pointcolour()
        {
            double r = 0.0, i = 0.0, m = 0.0;

            var jReference = j;

            while ((jReference < MAX) && (m < 4.0)) // djm original while ((j < MAX) && (m < 4.0))
            {
                jReference++; // djm original jReference++;
                m = r * r - i * i;
                i = 2.0 * r * i + ywert;
                r = m + xwert;
            }
            return (float)jReference / (float)MAX; // djm original return (float)j / (float)MAX;
        }

        public void Paint(Graphics g)
        {
            Update(g);
        }

        public void Update(Graphics g)
        {
            g.DrawImage(bitmap, 0, 0);
            if (rectangle)
            {
                pen = new Pen(Color.White); // use a new pen to prevent memory leak // pen.Color = Color.White; throws Parameter is not valid exception
                if (xs < xe)
                {
                    if (ys < ye) g.DrawRectangle(pen, xs, ys, (xe - xs), (ye - ys));
                    else g.DrawRectangle(pen, xs, ye, (xe - xs), (ys - ye));
                }
                else
                {
                    if (ys < ye)
                    {
                        g.DrawRectangle(pen, xe, ys, (xs - xe), (ye - ys));
                    }
                    else
                    {
                        g.DrawRectangle(pen, xe, ye, (xs - xe), (ys - ye));
                    }
                }

                pen.Dispose(); // release all pen resources
            }
        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            Paint(e.Graphics);
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
                if ((w < 2) && (z < 2)) Initvalues();
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
                Mandelbrot();
                rectangle = false;
                Refresh();  // Redraw picture and child components // repaint(); // djm original Java
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
                Refresh();  // Redraw picture and child components
            }

        }

        // cursors for picture box
        private void picture_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void picture_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        // cursors for all buttons, sliders, checkboxes, menu items
        private void cursor_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand; // set cursor to hand on reset button hover
        }

        private void cursor_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default; // set cursor to default arrow on leave of reset button
        }

        private void cursor_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand; // set cursor to hand on click
        }

        // close form - file menu item
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // save state to xml - file menu item
        private void saveStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
                                     {
                                         Filter = "XML files (*.xml)|*.xml", // only allow xml files to be saved
                                         CreatePrompt = true, // make user confirm they want to save file
                                         FileName = "fractal-state" // default name of xml file to be saved
                                     };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(Bitmap));
                    var image = Convert.ToBase64String((byte[])converter.ConvertTo(this.bitmap, typeof(byte[]))); // convert bitmap to byte array and convert array to string

                    var document = new XDocument( // define xml tree
                        new XElement("state", // parent node - the identifier 
                        new XElement("image", image), // remaining child nodes containing current bitmap values
                        new XElement("xstart", xstart),
                        new XElement("ystart", ystart),
                        new XElement("xzoom", xzoom),
                        new XElement("yzoom", yzoom),
                        new XElement("j", j)
                    ));

                    document.Save(saveFileDialog.FileName); // save document to the selected path
                    string selectedFileExtension = Path.GetExtension(saveFileDialog.FileName); // get file extension (in this case xml)
                    message.Text = (String.Format("Successfully saved fractal state at {0} in {01} format.", saveFileDialog.FileName, selectedFileExtension));
                }
                catch (Exception ex)
                {
                    message.Text = (String.Format("Failed to save fractal state. {0}", ex.Message)); // failed to convert to xml and save, display error message
                }

            }

        }

        // load state from xml - file menu item
        private void loadStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml", // only display xml files in directory
                DefaultExt = "fractal"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Added as a precaution as the Filter will only display xml files anyway
                if (!String.Equals(Path.GetExtension(openFileDialog.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    message.Text = ("You must select an XML file.");
                    return;
                }

                try
                {
                    var streamReader = new StreamReader(openFileDialog.FileName); // initialise stream reader to read selected xml file
                    using (streamReader) // using statement disposes of system resources automatically
                    {
                        var document = new XmlDocument();
                        document.Load(openFileDialog.OpenFile());
                        var xnList = document.SelectNodes("/state"); // select parent node

                        foreach (XmlNode xmlNode in xnList) // loop through child nodes to access stored bitmap attributes
                        {
                            xstart = Convert.ToDouble(xmlNode["xstart"].InnerText);
                            ystart = Convert.ToDouble(xmlNode["ystart"].InnerText);
                            xzoom = Convert.ToDouble(xmlNode["xzoom"].InnerText);
                            yzoom = Convert.ToDouble(xmlNode["yzoom"].InnerText);
                            j = Convert.ToInt32(xmlNode["j"].InnerText);
                        }
                        Mandelbrot();
                        Refresh();  // Redraw picture and child components // repaint(); // djm original Java

                        string selectedFileExtension = Path.GetExtension(openFileDialog.FileName); // get file extension (in this case xml)
                        message.Text = (String.Format("Successfully loaded fractal state from {0} at {1}.", selectedFileExtension, openFileDialog.FileName));
                    }

                }
                catch (Exception ex)
                {
                    message.Text = (String.Format("Failed to load fractal state. {0}", ex.Message)); // failed to load, display error message
                }

            }
        }

        // reset form to default
        private void reset_Click(object sender, EventArgs e)
        {
            // djm not needed
            /*if (finished)
            {
                removeMouseListener(this);
                removeMouseMotionListener(this);
                picture = null;
                g1 = null;
                c1 = null;
                c2 = null;
                System.gc(); // garbage collection
            }*/
            timerColourCycle.Stop(); // stop timer
            timerColourCycle.Dispose(); // dispose of time
            checkBoxColourCycle.Checked = false; // uncheck colour cycle checkbox
            checkBoxPaletteCycle.Checked = false; // uncheck palette cycle checkbox
            j = 0; // reset fractal colour to red
            trackBarColourCycle.Value = 0; // reset colour cycle speed
            colourCycleSpeedLabel.Text = "x1"; // reset colour cycle speed label
            colourPaletteLabel.Text = "Select a colour:"; // no colour selected
            Start(); // reset zoom, initial variables, call mandlebrot
            Refresh(); // Redraw picture and child components 
        }

        // save bitmap to image - file menu item
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "JPEG|*.JPG|PNG|*.PNG|BMP|*.BMP", // only allow png, bmp or jpg to be saved
                CreatePrompt = true, // make user confirm they want to save file
                FileName = "fractal-image" // default name of image file to be saved
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileExtension = Path.GetExtension(saveFileDialog.FileName); // store the users selected extension 

                ImageFormat format;
                switch (selectedFileExtension)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    default:
                        format = ImageFormat.Png;
                        break;
                }

                try
                {
                    this.bitmap.Save(saveFileDialog.FileName, format); // save image using users file name and selected format
                    message.Text = (String.Format("Successfully saved fractal at {0} in {1} format.", saveFileDialog.FileName, selectedFileExtension));
                }
                catch (Exception ex)
                {
                    message.Text = (String.Format("Failed to save image. {0}", ex.Message)); // failed to save image, display error message
                }
            }

        }

        // colour palette selection
        private void colourPaletteRed_Click(object sender, EventArgs e)
        {
            j = 0;
            colourPaletteLabel.Text = "Selected: Red";
            Mandelbrot();
            Refresh(); // Redraw picture and child components
        }

        private void colourPaletteOrange_Click(object sender, EventArgs e)
        {
            j = 10;
            colourPaletteLabel.Text = "Selected: Orange";
            Mandelbrot();
            Refresh(); 
        }

        private void colourPaletteYellow_Click(object sender, EventArgs e)
        {
            j = 30;
            colourPaletteLabel.Text = "Selected: Yellow";
            Mandelbrot();
            Refresh(); 
        }

        private void colourPaletteGreen_Click(object sender, EventArgs e)
        {
            j = 60;
            colourPaletteLabel.Text = "Selected: Green";
            Mandelbrot();
            Refresh(); 
        }

        private void colourPaletteTurquoise_Click(object sender, EventArgs e)
        {
            j = 120;
            colourPaletteLabel.Text = "Selected: Turquoise";
            Mandelbrot();
            Refresh(); 
        }

        private void colourPaletteBlue_Click(object sender, EventArgs e)
        {
            j = 150;
            colourPaletteLabel.Text = "Selected: Blue";
            Mandelbrot();
            Refresh(); 
        }

        private void colourPalettePurple_Click(object sender, EventArgs e)
        {
            j = 190;
            colourPaletteLabel.Text = "Selected: Purple";
            Mandelbrot();
            Refresh(); 
        }

        /* colour cycle checkbox - selecting the checkbox starts the timerColourCycle_Tick timer.
           The method is called every 100 milliseconds at default. At each call, the value of j is
           incremended. If j reaches 240 (dark colour) it is decremented to lighten
           the fractal. At 0 (red) it is incremented again. Sliding the slider calls the 
           trackBarColourCycle_Scroll which changes the timer speed in milliseconds. */
        private void checkBoxColourCycle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxColourCycle.Checked) // cycle checkbox selected
            {
                timerColourCycle.Start();
            }
            else // cycle checkbox not selected
            {
                timerColourCycle.Stop();
                timerColourCycle.Dispose();
            }
        }

        private void timerColourCycle_Tick(object sender, EventArgs e)
        {
            Mandelbrot();
            Refresh(); // Redraw picture and child components

            if (j == 240) // if j reaches 240 (black) then set variable to cycle backwards 
            {
                cycleForwards = false;
            }

            if (j == 0) // if j reaches 0 (red) then set variable to cycle forwards 
            {
                cycleForwards = true;
            }

            if (cycleForwards)
            {
                j++; // cycle colours from light to dark
            }
            else
            {
                j--; // cycle colours from dark to light
            }

        }

        // colour cycle speed slider
        private void trackBarColourCycle_Scroll(object sender, EventArgs e)
        {
            switch (trackBarColourCycle.Value) // get value from slider and set timer time in milliseconds
            {
                case 1:
                    timerColourCycle.Interval = 300;
                    colourCycleSpeedLabel.Text = "x2";
                    break;
                case 2:
                    timerColourCycle.Interval = 100;
                    colourCycleSpeedLabel.Text = "x3";
                    break;
                default:
                    timerColourCycle.Interval = 600;
                    colourCycleSpeedLabel.Text = "x1";
                    break;
            }

        }

        /* palette cycle checkbox - if checked, the timerPaletteCycle_Tick is called every 100 milliseconds.
           At each call, the current bitmap is saved in memory as a gif image, to access the original bitmaps Pallete Entries (256 colours, 
           not accessible in jpg).
           Each palette entry (colour) is set to the next entry in the array. The colour palette is added to a new bitmap which is drawn. */
        private void checkBoxPaletteCycle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPaletteCycle.Checked) // palette cycle checkbox selected
            {
                timerSmoothColourCycle.Start(); // start timer - called every 100 milliseconds
            }
            else // palette cycle checkbox not selected
            {
                timerSmoothColourCycle.Stop();
                timerSmoothColourCycle.Dispose();
            }
        }

        private void timerPaletteCycle_Tick(object sender, EventArgs e)
        {
            try
            {
                var memoryStream = new MemoryStream();
                using (memoryStream) // using statement disposes memoryStream after use
                {
                    bitmap.Save(memoryStream, ImageFormat.Gif); // Save bitmap to stream as gif as gifs have palette entries (unlike jpegs)
                    var bitmap2 = new Bitmap(memoryStream); // copy original bitmap to new bitmap
                    var palette = bitmap2.Palette;

                    for (int i = 0; i < palette.Entries.Length - 5; i++) // exclude last four white colours
                    {
                        var colour = palette.Entries[i];
                        palette.Entries[i] = palette.Entries[i + 1]; // exclude first black colour at palette.Entries[0]
                        palette.Entries[i + 1] = colour;
                    }

                    bitmap2.Palette = palette; // add palette to new bitmap
                    g1.DrawImage(bitmap2, 0, 0); // draw new bitmap
                    Refresh();  // redraw picture and child components
                }
            }
            catch (Exception ex)
            {
                message.Text = (String.Format("Failed to cycle through palette colours. {0}", ex.Message)); // failed to cycle, display error message
            }
        }

    }
}
