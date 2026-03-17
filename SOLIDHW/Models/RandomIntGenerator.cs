using SOLIDHW.Interfaces;

namespace SOLIDHW.Models
{
    internal class RandomIntGenerator : IIntGenerator
    {
        public int GenerateInt(int rangeFrom, int rangeTo)
        {
            Random rnd = new Random();
            return rnd.Next(rangeFrom, rangeTo + 1);
        }
    }
}
