using System.Text;
namespace SingleResponsability
{
    public class EstadoDeCuenta
    {
        private CuentaBancaria _cuentaBancaria;
        public EstadoDeCuenta(CuentaBancaria _cuentaBancaria)
        {
            this._cuentaBancaria = _cuentaBancaria;
        }

        public string GenerarEstadoDeCuenta()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Estado de cuenta\n");
            stringBuilder.Append("\tEstado de cuenta");
            stringBuilder.AppendLine(_cuentaBancaria.Identificador.ToString());
            stringBuilder.Append("\tSaldo:");
            stringBuilder.AppendFormat("{0:f2}", _cuentaBancaria.Saldo);
            return stringBuilder.ToString();
        }
    }
}
