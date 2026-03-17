using SOLIDHW.Interfaces;

namespace SOLIDHW.Models
{
    internal class ConsoleInput : IInputService
    {
        public int? ReadInt()
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                return value;
            }
            return null;
        }
    }
}
