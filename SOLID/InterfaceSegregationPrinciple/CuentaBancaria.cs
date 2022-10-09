using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple
{
    public abstract class CuentaBancaria : ICuentaBancariaBase
    {
        private static readonly double TasaDeIntereses = 0.01;
        protected double _saldo;
        private static ulong _numeroDeIdentificador = 1;
        private ulong _identificador;

        public ulong Identificador { get { return _identificador; } }
        public double Saldo { get { return _saldo; } }
        public CuentaBancaria(double saldoInicial)
        {
            _identificador = _numeroDeIdentificador++;
            _saldo = saldoInicial;
        }

        public void IncrementarIntereses()
        {
            this._saldo += this._saldo * TasaDeIntereses;
        }

    }
}
