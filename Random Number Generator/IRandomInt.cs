namespace Team4_LegendOfZelda.Random_Number_Generator
{
    public interface IRandomInt
    {
        void Seed(int newSeed);
        int Next(int minValue, int maxValue);
        void Reset();
    }
}
