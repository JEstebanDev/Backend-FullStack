using System;

namespace SingleResponsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria(100);
            CuentaBancaria cuenta1 = new CuentaBancaria(150);

            Transeferencia transeferencia = new Transeferencia(cuenta1);
            transeferencia.TranseferirMonto(cuenta, 30);

            EstadoDeCuenta estadoDeCuenta = new EstadoDeCuenta(cuenta);
            EstadoDeCuenta estadoDeCuenta1 = new EstadoDeCuenta(cuenta1);

            Console.WriteLine(estadoDeCuenta.GenerarEstadoDeCuenta());
            Console.WriteLine(estadoDeCuenta1.GenerarEstadoDeCuenta());
            Console.ReadLine();
        }
    }
}
