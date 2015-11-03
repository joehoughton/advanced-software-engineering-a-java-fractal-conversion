namespace java_fractal_conversion
{
    public class State
    {
        public State(double xstart, double ystart, double xzoom, double yzoom, int j, string fileName)
        {
            Xstart = xstart;
            Ystart = ystart;
            Xzoom = xzoom;
            Yzoom = yzoom;
            J = j;
            FileName = fileName;
        }

        public double Xstart { get; set; }
        public double Ystart { get; set; }
        public double Xzoom { get; set; }
        public double Yzoom { get; set; }
        public int J { get; set; }
        public string FileName { get; set; }
    }
}
