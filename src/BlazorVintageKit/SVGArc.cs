namespace BlazorVintageKit
{
    internal class SVGArc
    {
        public double X { get; }
        public double Y { get; }
        public int LargeArcFlag { get; }
        public int SweepFlag { get; }

        public SVGArc(double x, double y, int largeArcFlag, int sweepFlag)
        {
            X = x;
            Y = y;
            LargeArcFlag = largeArcFlag;
            SweepFlag = sweepFlag;
        }
    }
}
