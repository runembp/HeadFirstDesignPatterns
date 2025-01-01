namespace VirtualProxyImageProxy.Interfaces;

public interface Icon
{
    public double GetIconWidth();
    public double GetIconHeight();
    public void PaintIcon(int x, int y, string color);
}