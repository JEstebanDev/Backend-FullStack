using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple
{
    public class MoneyGram: IMetodoTransferencia
    {
        public void Transferir(ICuentaBancaria origen, ICuentaBancaria destino, double monto)
        {
            origen.Retirar(monto + (monto * 0.01));
            destino.Depositar(monto);
        }
    }
}

