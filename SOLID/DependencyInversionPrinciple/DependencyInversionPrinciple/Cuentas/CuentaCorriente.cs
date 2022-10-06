using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Cuentas
{
    public class CuentaCorriente : CuentaBancaria, ICuentaConMantenimiento
    {
        private static readonly double Mantenimiento = 0.02;
        public CuentaCorriente(double saldoInicial) : base(saldoInicial) { }
        public void CalcularMatenimiento()
        {
            _saldo -= _saldo * Mantenimiento;
        }
    }
}

