using MultichannelPaymentSystem.Models;
using MultichannelPaymentSystem.Services;

ProcesadorPagos procesador = new ProcesadorPagos();

MetodoPago pago1 = new TarjetaPago("P-001", "Josshua Flores", 200m, "1234-5678-9012-3456");
MetodoPago pago2 = new CuentaDigitalPago("P-002", "Abel Aragon", 200m, "aragona@ulasalle.edu.pe");
MetodoPago pago3 = new WalletPago("P-003", "Carlos Mamani", 200m, "123abc456dfg");

procesador.AgregarPago(pago1);
procesador.AgregarPago(pago2);
procesador.AgregarPago(pago3);

procesador.EjecutarPago();