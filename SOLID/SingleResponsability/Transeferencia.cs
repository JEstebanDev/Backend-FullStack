
namespace SingleResponsability
{
    public class Transeferencia
    {
        private CuentaBancaria _cuentaBancariaOrigen;
        public Transeferencia(CuentaBancaria _cuentaBancariaOrigen)
        {
            this._cuentaBancariaOrigen = _cuentaBancariaOrigen;
        }
        public void TranseferirMonto(CuentaBancaria cuentaDestino, double monto)
        {
            _cuentaBancariaOrigen.Saldo -= monto;
            cuentaDestino.Saldo += monto;
        }
    }
}
