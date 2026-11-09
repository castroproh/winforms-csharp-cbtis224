# PDV Básico - Ticket de venta (Pymasa)

Versión sencilla: Windows Forms (C#, .NET 8) con controles normales, sin animaciones ni dibujo especial.

## Abrir
- Visual Studio 2026 / 2022 (17.10+): abre `PDV_Basico.slnx`
- Visual Studio 2022 clásico: abre `PDV_Basico.sln` (es la misma solución, usa solo uno)

## Usuario de prueba
Usuario: Alumno1    Contraseña: Cbtis224

## Qué hace
- FormLogin: inicio de sesión.
- FormVenta:
  - Cliente, teléfono, buscar producto, producto (precio), color #HEX con vista previa, cantidad
  - Agregar / Editar / Eliminar / Limpiar sobre la tabla
  - Descuento (0 a 25 %), Subtotal, IVA 16 % y Total
  - Efectivo recibido y Cambio (verde = cambio, rojo = falta)
  - PAGAR E IMPRIMIR: vista previa del ticket

## Archivos
PDV_Basico/
  Program.cs                 arranca el login
  FormLogin.cs / .Designer.cs
  FormVenta.cs / .Designer.cs   (aquí está casi todo el código, con comentarios)
