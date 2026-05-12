namespace MultichannelPaymentSystem.Models;

public class WalletPago : MetodoPago
{
    public string WalletAddress {get; init;}

    public WalletPago(string id, string titular, decimal monto, string walletAddress) 
    : base(id, titular, monto)
    {
        WalletAddress = walletAddress;
    }

    public override void ProcesarPago()
    {
        Console.WriteLine($"Procesando pago de {Titular} por {Monto:C}...");
    }
}