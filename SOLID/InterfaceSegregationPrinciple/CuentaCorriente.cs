using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple
{
    public class CuentaCorriente : CuentaBancaria, ICuentaBancariaMantenimiento
    {
        private static readonly double Mantenimiento = 0.02;
        public CuentaCorriente(double saldoInicial) : base(saldoInicial) { }
        public void CalcularMatenimiento()
        {
            this._saldo += this._saldo * Mantenimiento;
        }
    }
}
