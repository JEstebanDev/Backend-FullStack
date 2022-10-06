using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple
{
    public class Transferencia
    {
        private readonly IMetodoTransferencia _metodoTransferencia;
        private readonly ICuentaBancaria _origen;
        private readonly ICuentaBancaria _destino;
        private readonly double _monto;
        private bool transferido;
        public Transferencia(ICuentaBancaria origen, ICuentaBancaria destino, double monto, IMetodoTransferencia metodoTransferencia)
        {
            _metodoTransferencia = metodoTransferencia;
            this._origen = origen;
            this._destino = destino;
            this._monto = monto;
        }
        public void Tranferir()
        {
            if (!transferido)
            {
                _metodoTransferencia.Transferir(_origen, _destino, _monto);
                transferido = true;
            }
        }
    }
}

