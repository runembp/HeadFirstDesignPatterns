using VirtualProxyImageProxy.Interfaces;

namespace VirtualProxyImageProxy.Classes;

public class ImageIcon(Uri uri, string albumCover) : Icon
{
    public double GetIconWidth()
    {
        throw new NotImplementedException();
    }

    public double GetIconHeight()
    {
        throw new NotImplementedException();
    }

    public void PaintIcon(int x, int y, string color)
    {
        throw new NotImplementedException();
    }
}