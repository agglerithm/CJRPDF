using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public class GifLogicalScreenDescriptor : PrintableData
    {
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }

        public GifScreenAndColorMapInfo ScreenAndColorMapInfo { get; set; }
        public byte BackgroundColor { get; set; }
        public int AspectRatio { get; set; }

        public override byte[] Print()
        {
            return new byte[]{ (byte)ScreenWidth, (byte)ScreenHeight}.Concatenate(ScreenAndColorMapInfo.Print(), new byte[]{BackgroundColor}, new byte[]{(byte)AspectRatio});
        }
    }
}