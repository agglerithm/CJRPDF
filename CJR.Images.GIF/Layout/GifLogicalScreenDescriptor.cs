using CJR.Images.Core;
using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public class GifLogicalScreenDescriptor : PrintableData
    {
        public byte ScreenWidth { get; set; }
        public byte ScreenHeight { get; set; }

        public GifScreenAndColorMapInfo ScreenAndColorMapInfo { get; set; }
        public byte BackgroundColor { get; set; }
        public byte AspectRatio { get; set; }

        public override byte[] Print()
        {
            return  ScreenWidth.GetBytes().Concatenate(ScreenHeight.GetBytes(),
                ScreenAndColorMapInfo.Print(), BackgroundColor.GetBytes(), AspectRatio.GetBytes());
        }
    }
}