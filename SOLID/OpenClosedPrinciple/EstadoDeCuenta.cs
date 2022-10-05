using System.Text;

namespace OpenClosedPrinciple
{
    internal class EstadoDeCuenta
    {
        private CuentaBancaria _cuenta;

        public EstadoDeCuenta(CuentaBancaria cuenta)
        {
            this._cuenta = cuenta;
        }
        public string GenerarEstadoDeCuenta(IFormato formato)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(formato.PrintFormato());

            stringBuilder.Append("Estado de cuenta\n");
            stringBuilder.Append("\tEstado de cuenta");
            stringBuilder.AppendLine(_cuenta.Identificador.ToString());
            stringBuilder.Append("\tSaldo:");
            stringBuilder.AppendFormat("{0:f2}", _cuenta.Saldo);
            return stringBuilder.ToString();
        }
    }
}
