namespace DependencyInversionPrinciple.Cuentas
{
    public class CuentaAhorro : CuentaBancaria
    {
        private static readonly double Mantenimiento = 0.02;
        public CuentaAhorro(double saldoInicial) : base(saldoInicial) { }
    }
}

