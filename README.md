# Windows Forms con C# — CBTis 224

Proyectos de la materia de programación con Windows Forms (C#), ordenados por secuencia y por semana. Cada carpeta es un proyecto de Visual Studio que se abre y se ejecuta por sí solo.

## Cómo abrir un proyecto

1. Instala **Visual Studio 2022 o posterior** en Windows, con la carga de trabajo **"Desarrollo de escritorio con .NET"**.
2. Abre el archivo `.sln` (o `.slnx`, es la misma solución) de la carpeta del proyecto.
3. Presiona **F5**.

SEC1-PANELES, SEC1-IG2 y SEC1-IG11 apuntan a **.NET 10** (`net10.0-windows`), así que necesitan Visual Studio 2026 o el SDK de .NET 10. Si no lo tienes, cambia `net10.0-windows` por `net8.0-windows` en su `.csproj`.

Los demás proyectos `net8.0-windows` también compilan con `dotnet build` desde la carpeta del `.sln`. Cine, Cafeteria y Papeleria **no**: usan .NET Framework 4.8 y el reproductor de Windows Media Player (ActiveX), así que se abren solo con Visual Studio.

## Versiones alternativas (código vs. Diseñador)

Varios proyectos tienen **dos versiones** de la misma práctica para que elijas la que más te convenza. Ninguna reemplaza a la otra:

| Versión | Cómo está hecha | Cuándo conviene |
|---|---|---|
| Sin sufijo | Los controles se crean **por código** en el constructor; no hay archivos `.Designer.cs` | Para leer todo en un solo archivo |
| `-Disenador` | Los controles están en `FormX.Designer.cs` y se pueden **mover y editar con el Diseñador** de Visual Studio | Para mostrar el formulario visual, como en clase |

Las versiones `-Disenador` se escribieron sin poder compilar en el momento. La primera vez, abre el `.sln`, compila (Ctrl+Shift+B) y, si Visual Studio marca algún error, es un ajuste menor; la versión sin sufijo sigue siendo la de respaldo.

## Proyectos

| Carpeta | Proyecto | Framework | Qué es |
|---|---|---|---|
| `00-Practicas-de-Clase/SEC1-PANELES` | SEC1-PANELES | .NET 10 | Dos paneles que se muestran y ocultan con botones; uno muestra una imagen, otro suma |
| `00-Practicas-de-Clase/SEC1-IG2` | SEC1-IG2 | .NET 10 | Área y perímetro de un rectángulo (lados de 1 a 50) con try/catch, MessageBox y fecha del sistema |
| `00-Practicas-de-Clase/SEC1-IG11` | SEC1-IG11 | .NET 10 | Mini calculadora con MouseHover y MouseLeave en los botones |
| `00-Practicas-de-Clase/Practica-Secuencia-2` | Práctica Secuencia 2 | .NET 8 | Pantalla de inicio de 3 s y menú de temas: DateTimePicker, ToolTip, ListView con grupos, LinkLabel, Timer |
| `00-Practicas-de-Clase/Actividades-Word` | — | — | Enunciado de la actividad IG2-PANELES |
| `01-Secuencia-2/SEC2-IG1` y `SEC2-IG1-Disenador` | SEC2-IG1 | .NET 8 | Herramientas de la Secuencia 1 y 2 en un menú: paneles, rectángulo, calculadora, fechas, controles, ListView |
| `02-Practicas/Cine` | Cine | .NET Framework 4.8 | Compra de boletos, cartelera y sala de espera con música |
| `02-Practicas/Cafeteria` | Cafeteria | .NET Framework 4.8 | Pedido de comida, menú de la semana y música |
| `02-Practicas/Papeleria` | Papeleria | .NET Framework 4.8 | Pedido de útiles, catálogo y zona de descanso con música |
| `03-Semana-09-13-Nov/Temas-Semana-9-13` y `-Disenador` | Temas-Semana-9-13 | .NET 8 | Los 9 temas de la semana en un menú, un formulario por tema |
| `03-Semana-09-13-Nov/Costco` | Costco | .NET 8 | Versión con tema Costco de la misma semana (6 formularios + login). Ya usa Diseñador |
| `04-Semana-16-20-Nov/Temas-Semana-16-20` y `-Disenador` | Temas-Semana-16-20 | .NET 8 | PDF, PDF de pantallas, GIF, MonthCalendar, calendario, StatusStrip y ToolStrip |
| `05-Semana-23-27-Nov/Temas-Semana-23-27` y `-Disenador` | Temas-Semana-23-27 | .NET 8 | KeyDown, clase Producto y tres formularios de DataGridView (catálogo, edición) |
| `06-Semana-30Nov-04Dic/Temas-Semana-30-nov-4-dic` y `-Disenador` | Temas-Semana-30-nov-4-dic | .NET 8 | Ticket de venta y ticket impreso, con login |
| `06-Semana-30Nov-04Dic/PDV-Ticket-Venta` | PDV (Pymasa) | .NET 8 | Punto de venta completo: login, ticket, corte de caja, atajos de teclado |
| `06-Semana-30Nov-04Dic/PDV-Basico` | PDV Básico | .NET 8 | Versión sencilla del punto de venta, con controles normales |

Usuarios de prueba: `Alumno1` / `Cbtis224` (PDV-Ticket-Venta, PDV-Basico, Temas-Semana-30-nov-4-dic y el login Pymasa de Temas-Semana-9-13), `Aloha1` / `1234` (login Aloha de Temas-Semana-9-13) y `socio` / `costco123` (Costco).

## Temas de la clase (Flipped Classroom) y dónde están

| Semana | Tema | Dónde |
|---|---|---|
| 5–9 oct | Otros Forms (`new Form2`), ocultar (`Hide`) y cerrar (`Close`) | `SEC1-PANELES`, `SEC1-IG2`, `Papeleria` (Form1 a Form4) |
| 5–9 oct | for, if, switch | `Cine`, `Cafeteria`, `Papeleria`, `SEC2-IG1` |
| 5–9 oct | ListBox, ComboBox | `Cine`, `Cafeteria`, `Papeleria`, `SEC2-IG1` |
| 5–9 oct | Fecha del sistema (`DateTime.Now`) | `SEC1-IG2`, `SEC1-PANELES`, `SEC2-IG1` |
| 12–16 oct | MouseHover y MouseLeave | `SEC1-IG11`, `SEC1-PANELES` |
| 12–16 oct | RadioButton, CheckBox, GroupBox | `Cine`, `Cafeteria`, `Papeleria`, `SEC2-IG1` |
| 12–16 oct | Vectores | `Cine`, `Cafeteria`, `Papeleria` |
| 19–23 oct | MenuStrip | `Cine`, `Cafeteria`, `Papeleria`, `SEC2-IG1` |
| 19–23 oct | Media Player | `Cine`, `Cafeteria`, `Papeleria` (Form4) |
| 19–23 oct | Matrices | `Cine`, `Cafeteria`, `Papeleria` |
| Varias | Color y título del Form, StartPosition, Label, TextBox, Button, Focus, Visible | `SEC1-IG2`, `SEC1-IG11`, `SEC1-PANELES` |
| Varias | `string.IsNullOrWhiteSpace`, recorrido de una cadena al revés con `for` (palíndromo) | `Papeleria` (Form4), `Cine`, `Cafeteria` |

## Temas de cada semana y dónde están

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
| 23–27 nov | 21 KeyDown | `Temas-Semana-23-27` (FormKeyDown: F2, F3, F4, F5, Supr, Ctrl+D, F9), `PDV-Ticket-Venta` |
| 23–27 nov | 22 Clase DataGridView_1 | `Temas-Semana-23-27` (DataGridView_1 + clase Producto) |
| 23–27 nov | 24 y 25 DataGridView | `Temas-Semana-23-27` (FormCatalogo, FormEdicion), `PDV-Ticket-Venta`, `PDV-Basico` |
| 30 nov–4 dic | 26 y 27 Ticket de venta | `Temas-Semana-30-nov-4-dic` (FormVenta, FormTicket), `PDV-Ticket-Venta`, `PDV-Basico` |

Los temas 6 y 20 tienen nombres ambiguos en la lista original; aquí se interpretaron como un CheckBox dentro de un Panel y como ToolStrip. Revisa que coincida con tus apuntes. Igual el tema 22: se tomó "Clase DataGridView_1" como el formulario que muestra la clase `Producto`.

## Notas

- Cine, Cafeteria y Papeleria cargan un `.mp3` desde la carpeta del programa. Si lo cambias por otra canción, usa el mismo nombre de archivo o ajusta la ruta en `Form4.cs`.
- Cine y Cafeteria usan el mismo archivo de música (`Musica.mp3` y `Caifanes audio.mp3` son idénticos), así que ocupan 9 MB cada uno.
