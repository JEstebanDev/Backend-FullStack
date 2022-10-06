using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Estados
{
    public class FormatoBDeEstadoDeCuenta : EstadoDeCuenta, IEstadoDeCuenta
    {
        public FormatoBDeEstadoDeCuenta(ICuentaBancaria cuenta)
        {
            _cuenta = cuenta;
        }
        public string GenerarEncabezado()
        {
            return "----------FORMATO B-----------\n";
        }
    }
}

