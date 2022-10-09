using System;
using System.Collections.Generic;
using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Imprimir(IList<IEstadoDeCuentaConPie> estadosDeCuenta)
        {
            foreach (IEstadoDeCuentaConPie estadoDeCuenta in estadosDeCuenta)
            {
                Console.WriteLine(estadoDeCuenta.GenerarEncabezado());
                Console.WriteLine(estadoDeCuenta.GenerarContenido());
                Console.WriteLine(estadoDeCuenta.GenerarPie());
                Console.WriteLine();
            }
        }
        static void Imprimir(IList<IEstadoDeCuenta> estadosDeCuenta)
        {
            foreach (IEstadoDeCuenta estadoDeCuenta in estadosDeCuenta)
            {
                Console.WriteLine(estadoDeCuenta.GenerarEncabezado());
                Console.WriteLine(estadoDeCuenta.GenerarContenido());
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ICuentaBancariaMantenimiento cuenta1 = new CuentaCorriente(100);
            ICuentaBancariaBase cuenta2 = new CuentaAhorro(150);
            IList<IEstadoDeCuentaConPie> estadosDeCuentaConPie = new List<IEstadoDeCuentaConPie>
            {
                new FormatoADeEstadoDeCuenta(cuenta1),
                new FormatoADeEstadoDeCuenta(cuenta2)
            };
            IList<IEstadoDeCuenta> estadosDeCuentaSinPie = new List<IEstadoDeCuenta>
            {
                new FormatoBDeEstadoDeCuenta(cuenta1),
                new FormatoBDeEstadoDeCuenta(cuenta2)
            };
            Imprimir(estadosDeCuentaConPie);
            Imprimir(estadosDeCuentaSinPie);
            cuenta1.IncrementarIntereses();
            cuenta2.IncrementarIntereses();
            cuenta1.CalcularMatenimiento();
            Imprimir(estadosDeCuentaConPie);
            Imprimir(estadosDeCuentaSinPie);
            Console.ReadLine();
        }

    }
}
