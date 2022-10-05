using System;
using System.Collections.Generic;
using System.Text;

namespace SubstitutionPrinciple
{
    internal class FormatoBDeEstadoDeCuenta : EstadoDeCuenta, IEstadoDeCuenta
    {
        public FormatoBDeEstadoDeCuenta(CuentaBancaria cuenta)
        {
            this._cuenta = cuenta;
        }
        public string GenerarEncabezado()
        {
            return "----------FORMATO B-----------\n";
        }
        public string GenerarPie()
        {
            return "----------PIE DE FORMATO B-----------\n";
        }

    }
}
