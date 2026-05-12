namespace MultichannelPaymentSystem.Models;

public class TarjetaPago : MetodoPago
{
    public string NumeroTarjeta {get; init;}

    public TarjetaPago(string id, string titular, decimal monto, string numeroTarjeta) 
    : base(id, titular, monto)
    {
        NumeroTarjeta = numeroTarjeta;
    }

    public override decimal CalcularComision()
    {
        return Monto * 0.03m;
    }

    public override void ProcesarPago()
    {
        Console.WriteLine($"Procesando pago de {Titular} por {Monto:C}...");
    }
}