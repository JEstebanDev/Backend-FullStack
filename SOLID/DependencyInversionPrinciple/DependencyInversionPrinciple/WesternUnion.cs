using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple
{
    public class WesternUnion: IMetodoTransferencia
    {
        public void Transferir(ICuentaBancaria origen, ICuentaBancaria destino, double monto)
        {
            origen.Retirar(monto + (monto * 0.02));
            destino.Depositar(monto);
        }
    }
}

