using SOLIDHW.Interfaces;

namespace SOLIDHW.Models
{
    internal class RegularSettings : ISettings
    {
        public int MaxAttempts { get; }
        public int RangeFrom { get; }
        public int RangeTo { get; }

        public RegularSettings(int rangeFrom, int rangeTo, int maxAttempts) 
        {
            if (rangeFrom > rangeTo || rangeFrom == rangeTo)
                throw new ArgumentException("Неправильный диапазон");
            if (maxAttempts <= 0)
                throw new ArgumentException("Количество попыток меньше или равно нулю");
            RangeFrom = rangeFrom;
            RangeTo = rangeTo;
            MaxAttempts = maxAttempts;
        }
    }
}
