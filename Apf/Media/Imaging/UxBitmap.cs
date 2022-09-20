using Avalonia.Media.Imaging;
using Pchp.Core;

namespace Apf.Media.Imaging;

public class UxBitmap : Bitmap
{
    public UxBitmap(PhpValue stream) : base( (Stream) stream.ToClr())
    {
      
    }
}