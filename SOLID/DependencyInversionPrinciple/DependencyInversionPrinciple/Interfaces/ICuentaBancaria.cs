namespace DependencyInversionPrinciple.Interfaces
{
    public interface ICuentaBancaria
    {
        ulong Identificador { get; }
        double Saldo { get; }
        void IncrementarIntereses();
        void Retirar(double monto);
        void Depositar(double monto);
    }
}

