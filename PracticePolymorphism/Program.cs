namespace PracticePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instrument instrument = new Instrument();
            Drums drums = new();
            Guitar guitar = new();

            instrument.Play();
            drums.Play();
            guitar.Play();

        }
        
    }
}
