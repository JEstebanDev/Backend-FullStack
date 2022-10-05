using System.Text;

namespace SubstitutionPrinciple
{
    public abstract class EstadoDeCuenta
    {
        public CuentaBancaria _cuenta;
        public virtual string GenerarContenido()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Estado de cuenta\n");
            stringBuilder.Append("\tEstado de cuenta");
            stringBuilder.AppendLine(_cuenta.Identificador.ToString());
            stringBuilder.Append("\tSaldo:");
            stringBuilder.AppendFormat("{0:f2}", _cuenta.Saldo);
            return stringBuilder.ToString();
        }
    }
}
