namespace PDV
{
    /// <summary>Panel con doble búfer (sin parpadeo al animar).</summary>
    public class BufPanel : Panel
    {
        public BufPanel() { DoubleBuffered = true; ResizeRedraw = true; }
    }
}
