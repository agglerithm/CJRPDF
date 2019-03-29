using System;
using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public class PlainTextExtension : GifExtension
    {
        public byte Label => 1;
        public byte BlockSize => 0x0c;
        public UInt16 TextGridLeft { get; set; }
        public UInt16 TextGridTop { get; set; }
        public UInt16 TextGridWidth { get; set; }
        public UInt16 TextGridHeight { get; set; }
        public byte CellWidth { get; set; }
        public byte CellHeight { get; set; }
        public byte TextFgColorIndex { get; set; }
        public byte TextBgColorIndex { get; set; }
        public string PlainTextData { get; set; }

        protected override byte[] GetExtensionData()
        {
            return Label.GetBytes().Concatenate(BlockSize.GetBytes(),
                TextGridLeft.GetBytes(),
                TextGridTop.GetBytes(),
                TextGridWidth.GetBytes(),
                TextGridHeight.GetBytes(),
                CellWidth.GetBytes(),
                CellHeight.GetBytes(),
                TextFgColorIndex.GetBytes(),
                TextBgColorIndex.GetBytes(),
                PlainTextData.StringToBuff());
        }
    }
}