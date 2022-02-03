namespace Market.Interface
{
    public interface IInstrument
    {
        string Name { get; }
        string CodeIsin { get; }
        int Quotity { get; }

        IBook GetBook();

    }
}