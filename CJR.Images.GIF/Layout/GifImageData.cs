using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public class GifImageData:PrintableData
    {
        public GifImageAndColorTableInfo ImageAndColorTableInfo { get; set; }
        public GifColorTable ColorTable { get; set; }

        public override byte[] Print()
        {
            throw new System.NotImplementedException();
        }
    }
}