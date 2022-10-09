namespace InterfaceSegregationPrinciple.Interfaces
{
    public interface ICuentaBancariaBase
    {
        ulong Identificador { get; }
        double Saldo { get; }
        void IncrementarIntereses();
    }
}
