using VirtualProxyImageProxy.Interfaces;

namespace VirtualProxyImageProxy.Classes;

public class ImageProxy(Uri uri) : Icon
{
    private ImageIcon? _imageIcon;
    private bool _retrieving = false;
    private Thread _retrievalThread;

    private void SetImageIcon(ImageIcon? imageIcon)
    {
        _imageIcon ??= imageIcon;
    }

    public double GetIconWidth()
    {
        return _imageIcon?.GetIconWidth() ?? 800;
    }

    public double GetIconHeight()
    {
        return _imageIcon?.GetIconWidth() ?? 600;
    }

    public void PaintIcon(int x, int y, string color)
    {
        if (_imageIcon != null)
        {
            _imageIcon.PaintIcon(x, y, color);
        }
        else
        {
            Console.WriteLine("Loading album cover, please wait...");

            if (_retrieving)
            {
                return;
            }
            
            _retrieving = true;
            
            _retrievalThread = new Thread(() =>
            {
                try
                {
                    SetImageIcon(new ImageIcon(uri, "Album Cover"));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            });
                
            _retrievalThread.Start();
        }
    }
}