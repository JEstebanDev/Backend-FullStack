using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple
{
    public class FormatoADeEstadoDeCuenta : EstadoDeCuenta, IEstadoDeCuentaConPie
    {
        public FormatoADeEstadoDeCuenta(ICuentaBancariaBase cuenta)
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
