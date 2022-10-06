using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Estados
{
    public class FormatoADeEstadoDeCuenta : EstadoDeCuenta, IEstadoDeCuentaConPie
    {
        public FormatoADeEstadoDeCuenta(ICuentaBancaria cuenta)
        {
            _cuenta = cuenta;
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

