namespace DependencyInversionPrinciple.Interfaces
{
    public interface ICuentaConMantenimiento : ICuentaBancaria
    {
        void CalcularMatenimiento();
    }
}

