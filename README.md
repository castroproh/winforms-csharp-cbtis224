# Windows Forms con C# — CBTis 224

Proyectos de la materia de programación con Windows Forms (C#), ordenados por secuencia y por semana. Cada carpeta es un proyecto de Visual Studio que se abre y se ejecuta por sí solo.

## Cómo abrir un proyecto

1. Instala **Visual Studio 2022 o posterior** en Windows, con la carga de trabajo **"Desarrollo de escritorio con .NET"**.
2. Abre el archivo `.sln` (o `.slnx`, es la misma solución) de la carpeta del proyecto.
3. Presiona **F5**.

Los proyectos `net8.0-windows` también compilan con `dotnet build` desde la carpeta del `.sln`. Cine, Cafeteria y Papeleria **no**: usan .NET Framework 4.8 y el reproductor de Windows Media Player (ActiveX), así que se abren solo con Visual Studio.

## Proyectos

| Carpeta | Proyecto | Framework | Qué es |
|---|---|---|---|
| `01-Secuencia-2/SEC2-IG1` | SEC2-IG1 | .NET 8 | Herramientas de la Secuencia 1 y 2 reunidas en un menú: paneles, rectángulo, calculadora, fechas, controles, ListView |
| `02-Practicas/Cine` | Cine | .NET Framework 4.8 | Compra de boletos, cartelera y sala de espera con música |
| `02-Practicas/Cafeteria` | Cafeteria | .NET Framework 4.8 | Pedido de comida, menú de la semana y música |
| `02-Practicas/Papeleria` | Papeleria | .NET Framework 4.8 | Pedido de útiles, catálogo y zona de descanso con música |
| `03-Semana-09-13-Nov/Temas-Semana-9-13` | Temas-Semana-9-13 | .NET 8 | Los 9 temas de la semana en un menú, un formulario por tema |
| `03-Semana-09-13-Nov/Costco` | Costco | .NET 8 | Versión con tema Costco de la misma semana (6 formularios + login) |
| `04-Semana-16-20-Nov/Temas-Semana-16-20` | Temas-Semana-16-20 | .NET 8 | PDF, PDF de pantallas, GIF, MonthCalendar, calendario, StatusStrip y ToolStrip |
| `05-Semana-30Nov-04Dic/PDV-Ticket-Venta` | PDV (Pymasa) | .NET 8 | Punto de venta completo: login, ticket, corte de caja, atajos de teclado |
| `05-Semana-30Nov-04Dic/PDV-Basico` | PDV Básico | .NET 8 | Versión sencilla del punto de venta, con controles normales |

Usuarios de prueba: `Alumno1` / `Cbtis224` (PDV-Ticket-Venta, PDV-Basico y el login Pymasa de Temas-Semana-9-13), `Aloha1` / `1234` (login Aloha de Temas-Semana-9-13) y `socio` / `costco123` (Costco).

## Temas de la semana y dónde están

| Semana | Tema | Dónde |
|---|---|---|
| 9–13 nov | 5a Panel | `Temas-Semana-9-13` (FormPanelDatos), `Costco` (Form2) |
| 9–13 nov | 5 TabControl y Panel | `Temas-Semana-9-13` (FormTabControlPanel), `Costco` (Form3) |
| 9–13 nov | 6 Control Panel | `Temas-Semana-9-13` (FormControlPanel: CheckBox dentro de un Panel) |
| 9–13 nov | 7 TableLayoutPanel | `Temas-Semana-9-13` (FormTableLayout), `Costco` (Form4) |
| 9–13 nov | 8 RoundButton | `Temas-Semana-9-13` (FormRoundButton), `Costco` (Form5) |
| 9–13 nov | 10 GroupBox | `Temas-Semana-9-13` (FormGroupBox), `Costco` (Form6), `Cine` y `Cafeteria` |
| 9–13 nov | 13 MouseEnter en Panel | `Temas-Semana-9-13` (FormMouseEnter) |
| 9–13 nov | 18 y 19 Usuario y contraseña | `Temas-Semana-9-13` (FormLoginPymasa, FormLoginAloha), `Costco` (Form7) |
| 16–20 nov | 11 PDF, 12 PDF de screens | `Temas-Semana-16-20` (FormGenerarPdf, FormPdfScreens) |
| 16–20 nov | 14 GIF | `Temas-Semana-16-20` (FormGif) |
| 16–20 nov | 15 MonthCalendar, 16 Calendar | `Temas-Semana-16-20` (FormMonthCalendar, FormCalendario) |
| 16–20 nov | 17 StatusStrip | `Temas-Semana-16-20` (FormStatusStrip) |
| 16–20 nov | 20 ToolStrip | `Temas-Semana-16-20` (FormToolStrip) |
| 23–27 nov | 21 KeyDown | `PDV-Ticket-Venta` (F2, F3, F4, F5, Supr, Ctrl+D, F9) |
| 23–27 nov | 22, 24, 25 DataGridView | `PDV-Ticket-Venta` y `PDV-Basico` (tabla de la venta) |
| 30 nov–4 dic | 26 y 27 Ticket de venta | `PDV-Ticket-Venta`, `PDV-Basico` (vista previa de impresión) |

Los temas 6 y 20 tienen nombres ambiguos en la lista original; aquí se interpretaron como un CheckBox dentro de un Panel y como ToolStrip. Revisa que coincida con tus apuntes.

## Notas

- Los controles de varios proyectos se crean por código (no hay archivos `.Designer`), así que se leen de arriba hacia abajo en el constructor de cada formulario.
- Cine, Cafeteria y Papeleria cargan un `.mp3` desde la carpeta del programa. Si lo cambias por otra canción, usa el mismo nombre de archivo o ajusta la ruta en `Form4.cs`.
- Cine y Cafeteria usan el mismo archivo de música (`Musica.mp3` y `Caifanes audio.mp3` son idénticos), así que ocupan 9 MB cada uno.
