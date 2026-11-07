namespace PDV
{
    public class TicketItem
    {
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public string ColorHex { get; set; }
        public Color Color { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get { return Precio * Cantidad; } }
        public float Alpha { get; set; }
    }
}
