# Sistema de Pagos Multicanal

![Handcrafted Code](https://img.shields.io/badge/handcrafted-code-green)
![Status: Learning](https://img.shields.io/badge/status-learning-blue)

---
Este repositorio es un laboratorio técnico diseñado para profundizar en C# .NET.

## Descripción
Este proyecto busca orquestar pagos de distintos medios tales como tarjetas, cuentas digitales y wallets(cripto-monedas).

## Arquitectura
En esta sección se definira de manera superficial la arquitectura que tendra este proyecto.

### Diagrama de Clases
```mermaid
classDiagram

    class MetodoPago {
        <<abstract>>
        +string Id
        +string Titular
        +decimal Monto
        +MetodoPago(id, titular, monto)
        +CalcularComision() decimal*
        +ProcesarPago() void*
    }

    class TarjetaPago {
        +string NumeroTarjeta
        +CalcularComision() decimal
        +ProcesarPago() void
    }

    class CuentaDigitalPago {
        +string Email
        +CalcularComision() decimal
        +ProcesarPago() void
    }

    class WalletPago {
        +string WalletAddress
        +CalcularComision() decimal
        +ProcesarPago() void
    }

    class ProcesadorPagos {
        -List~MetodoPago~ pagos
        +AgregarPago(pago MetodoPago)
        +EjecutarPago() void
    }

    %% Relaciones
    MetodoPago <|-- TarjetaPago
    MetodoPago <|-- CuentaDigitalPago
    MetodoPago <|-- WalletPago
    ProcesadorPagos o-- MetodoPago

```
