namespace Team4_LegendOfZelda.Vector
{
    public class VelocityVector : IVector
    {
        public int Magnitude { get; set; }
        public Orientation Directon { get; set ; }
        public VelocityVector(int magnitude, Orientation directon)
        {
            Magnitude = magnitude;
            Directon = directon;
        }
    }
}
