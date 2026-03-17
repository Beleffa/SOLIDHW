using SOLIDHW.Interfaces;
using SOLIDHW.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        IInputService inputService = new ConsoleInput();
        IOutputService outputService = new ConsoleOutput();
        ISettings settings = new RegularSettings(1, 100, 10);
        IIntGenerator generator = new RandomIntGenerator();

        var game = new GameEngine(settings, inputService, outputService, generator);

        game.Start();
    }
}