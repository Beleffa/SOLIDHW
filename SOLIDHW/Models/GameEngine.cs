using SOLIDHW.Enums;
using SOLIDHW.Interfaces;

namespace SOLIDHW.Models
{
    internal class GameEngine
    {
        ISettings _settings;
        IInputService _inputService;
        IOutputService _outputService;
        IIntGenerator _intGenerator;

        public GameEngine(ISettings settings, IInputService inputService, IOutputService outputService, IIntGenerator intGenerator)
        {
            _settings = settings;
            _inputService = inputService;
            _outputService = outputService;
            _intGenerator = intGenerator;
        }

        public void Start()
        {
            int guessed = _intGenerator.GenerateInt(_settings.RangeFrom, _settings.RangeTo);
            _outputService.WriteMessage(MessageCode.Greetings);
            int i = 0;
            while (i < _settings.MaxAttempts)
            {
                int? attempt = _inputService.ReadInt();
                if (attempt.HasValue)
                {
                    if (attempt > guessed)
                        _outputService.WriteMessage(MessageCode.Higher);
                    if (attempt < guessed)
                        _outputService.WriteMessage(MessageCode.Lower);
                    if (attempt == guessed)
                    {
                        _outputService.WriteMessage(MessageCode.Win);
                        return;
                    }
                    i++;
                }
                else
                {
                    _outputService.WriteMessage(MessageCode.InputError);
                }
            }
            _outputService.WriteMessage(MessageCode.GameOver);
        }
    }
}
