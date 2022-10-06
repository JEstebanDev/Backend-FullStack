using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Cuentas
{
    public abstract class CuentaBancaria : ICuentaBancaria
    {
        private static readonly double TasaDeIntereses = 0.05;
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
            _saldo += _saldo * TasaDeIntereses;
        }

        public void Retirar(double monto)
        {
            if (monto > 0)
                _saldo -= _saldo * monto;
        }

        public void Depositar(double monto)
        {
            if (monto > 0)
                _saldo += _saldo * monto;
        }
    }
}

