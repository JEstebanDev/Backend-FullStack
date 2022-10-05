using System;
using System.Collections.Generic;
using System.Text;

namespace SubstitutionPrinciple
{
    internal class Imprimir
    {
        public void Print(IList<IEstadoDeCuenta> estadosDeCuenta)
        {
            foreach (IEstadoDeCuenta estadoDeCuenta in estadosDeCuenta)
            {
                Console.WriteLine(estadoDeCuenta.GenerarEncabezado());
                Console.WriteLine(estadoDeCuenta.GenerarContenido());
                if (estadoDeCuenta is FormatoADeEstadoDeCuenta)
                {
                    Console.WriteLine(estadoDeCuenta.GenerarPie());
                }
                Console.WriteLine();
            }
        }
    }
}
