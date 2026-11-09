# PDV - Ticket de venta (Pymasa)

Windows Forms en C# (.NET 8) con diseño basado en teoría y psicología del color.

## Cómo abrirlo
- Visual Studio 2026 / 2022 (17.10+): abre `PDV.slnx`
- Visual Studio 2022 clásico: abre `PDV.sln`
  (son la misma solución; usa solo uno. En terminal: `dotnet build PDV.sln`)
- Si el Diseñador marca error la primera vez: compila (Ctrl+Shift+B) y reabre `FormTicket.cs [Diseño]`.

## Sistema de color (todo vive en `PDV/Theme.cs`)

Regla 60-30-10
| Proporción | Color | Para qué | Psicología |
|---|---|---|---|
| 60 % | Azul tinta `#151A2E` / `#0E1122` | Fondo | Confianza y seguridad al manejar dinero; descansa la vista |
| 30 % | Azul-violeta `#1E2540` / `#2A3356` | Tarjetas, campos, tabla | Da profundidad sin competir con el contenido |
| 10 % | Amarillo Pymasa `#FFD60A` | Acento y botón principal | Optimismo y atención; es el COMPLEMENTARIO del azul-violeta: máximo contraste |

Colores semánticos
| Color | Acción | Por qué |
|---|---|---|
| Verde `#34D399` | COBRAR, LED "listo" | Señal universal de "adelante / completado" |
| Coral `#FF5C6C` | Eliminar | Rojo suavizado: alerta sin agredir |
| Azul `#5B8DEF` | Editar | Neutral y confiable |
| Crema `#FBF7EC` | Papel del ticket | Menos deslumbrante que el blanco puro |

Accesibilidad: el texto de cada botón se elige automáticamente (oscuro o claro) según el contraste WCAG.

Funciones del punto de venta
- Buscar producto: escribe en BUSCAR (sin importar acentos o mayúsculas); la lista se filtra y muestra "3 de 25". Enter pasa a cantidad, Esc limpia.
- Descuentos: 0, 5, 10, 15, 20 o 25 %. Se aplica antes del IVA y sale en el ticket (en verde = ahorro).
- Cobro con cambio: escribe el efectivo recibido o usa Exacto / $200 / $500 / $1,000. Muestra CAMBIO en verde o FALTA en coral; no deja cobrar si no alcanza.
- El ticket y la vista previa de impresión incluyen descuento, recibido y cambio.

Experiencia profesional
- Inicio de sesión animado (Alumno1 / Cbtis224): gotas de pintura flotando, la tarjeta tiembla si fallas, se desvanece al entrar.
- Notificaciones (toasts) en lugar de ventanas emergentes: suben desde abajo, se cierran solas y se ven por colores (verde éxito, amarillo aviso, coral error, azul info).
- Barra de estado con atajos y ventas en vivo. Atajos: F2 buscar, F3 color, F4 cobrar, F5 limpiar, Supr quitar, Ctrl+D cambiar descuento, F9 corte.
- Corte de caja (botón del encabezado o F9): KPIs que cuentan, gráfica de barras por ticket con los colores de la paleta, desglose de IVA, descuentos, recibido y cambio. Exporta a CSV en Documentos\PDV.

Estudio de color (para la tienda de pinturas)
- Paleta rápida de 12 colores de pintura reales.
- Armonías calculadas en la rueda HSL: complementario (+180°), análogos (±30°), tríada (+120° / +240°).
- Cada color muestra su significado psicológico y dónde conviene usarlo.

## Estructura
PDV/
  Theme.cs               paleta, contraste, HSL, armonías, psicología del color
  FormTicket.cs          lógica
  FormTicket.Designer.cs diseño (editable en el Diseñador)
  Controls/
    TicketPaper.cs  ticket animado (sello PAGADO, total destacado)
    ColorStudio.cs  paleta + armonías + psicología
    AnimButton.cs   botones redondeados por variante
    BufPanel.cs, TicketItem.cs
