namespace DependencyInversionPrinciple.Interfaces
{
    public interface IMetodoTransferencia
    {
        void Transferir(ICuentaBancaria origen, ICuentaBancaria destino, double monto);
    }
}
