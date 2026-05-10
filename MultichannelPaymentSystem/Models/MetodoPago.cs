namespace MultichannelPaymentSystem.Models;

public abstract class MetodoPago
{
    public string Id {get; init;}
    public string Titular {get; init;}
    public decimal Monto {get; init;}

    public MetodoPago(string id, string titular, decimal monto)
    {
        Id = id;
        Titular = titular;
        Monto = monto;
    }
}