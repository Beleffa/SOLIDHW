namespace SOLIDHW.Interfaces
{
    internal interface ISettings
    {
        int MaxAttempts { get; }
        int RangeFrom { get; }
        int RangeTo { get; }
    }
}
