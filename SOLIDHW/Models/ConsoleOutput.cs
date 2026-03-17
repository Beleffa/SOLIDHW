using SOLIDHW.Enums;
using SOLIDHW.Interfaces;

namespace SOLIDHW.Models
{
    internal class ConsoleOutput : IOutputService
    {
        public void WriteMessage(MessageCode code)
        {
            switch (code)
            {
                case MessageCode.Greetings:
                    Console.WriteLine("Число загадано, попробуйте угадать");
                    break;
                case MessageCode.Higher:
                    Console.WriteLine("Ваше число больше задуманного");
                    break;
                case MessageCode.Lower:
                    Console.WriteLine("Ваше число меньше задуманного");
                    break;
                case MessageCode.Win:
                    Console.WriteLine("Вы угадали!");
                    break;
                case MessageCode.GameOver:
                    Console.WriteLine("Игра завершена");
                    break;
                case MessageCode.InputError:
                    Console.WriteLine("Ошибка ввода, повторите попытку");
                    break;
                default:
                    Console.WriteLine("...");
                    break;
            }
        }
    }
}
