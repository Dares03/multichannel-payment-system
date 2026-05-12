namespace MultichannelPaymentSystem.Services;
using MultichannelPaymentSystem.Models;
public class ProcesadorPagos
{
    private readonly List<MetodoPago> _pagos;

    public ProcesadorPagos()
    {
        _pagos = new List<MetodoPago>();
    }

    public void AgregarPago(MetodoPago pago)
    {
        _pagos.Add(pago);
    }

    public void EjecutarPago()
    {
        foreach (var pago in _pagos)
        {
            pago.ProcesarPago();
        }
    }
}