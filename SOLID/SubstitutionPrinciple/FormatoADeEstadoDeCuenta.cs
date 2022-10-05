
namespace SubstitutionPrinciple
{
    internal class FormatoADeEstadoDeCuenta : EstadoDeCuenta, IEstadoDeCuenta
    {
        public FormatoADeEstadoDeCuenta(CuentaBancaria cuenta)
        {
            this._cuenta = cuenta;
        }
        public string GenerarEncabezado()
        {
            return "----------FORMATO A-----------\n";
        }
        public string GenerarPie()
        {
            return "----------PIE DE FORMATO A-----------\n";
        }
    }
}
