using CJR.Images.Core;
using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public class GifImageDescriptor : ImageRectangle
    { 
        public override byte[] Print()
        {
           return base.Print().Concatenate();
        }
    }

}