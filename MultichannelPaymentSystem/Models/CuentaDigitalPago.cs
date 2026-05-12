namespace MultichannelPaymentSystem.Models;

class CuentaDigitalPago : MetodoPago
{
    public string Email {get; set;}

    public CuentaDigitalPago(string id, string titular, decimal monto, string email) 
    : base(id, titular, monto)
    {
        Email = email;
    }

    public override decimal CalcularComision()
    {
        return 2m;
    }

    public override void ProcesarPago()
    {
        Console.WriteLine($"Procesando pago de {Titular} por {Monto:C}...");
    }
}