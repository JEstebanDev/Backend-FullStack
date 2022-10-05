namespace OpenClosedPrinciple
{
    internal class CuentaBancaria
    {
        private double _saldo;
        private static ulong _numeroDeIdentificador = 1;
        private ulong _identificador;
        public ulong Identificador { get { return _identificador; } }
        public double Saldo { get { return _saldo; } }
        public CuentaBancaria(double saldoInicial)
        {
            _identificador = _numeroDeIdentificador++;
            _saldo = saldoInicial;
        }

        public void TranseferirMonto(CuentaBancaria cuentaDestino, double monto)
        {
            _saldo -= monto;
            cuentaDestino._saldo += monto;
        }
    }
}
