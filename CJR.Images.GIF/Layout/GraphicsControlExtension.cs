using System;
using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public class GraphicsControlExtension : GifExtension
    {
        public byte Label => 0xf9;
        public byte BlockSize => 4;
        public PackedData Packed { get; set; }
        public UInt16 DelayTime { get; set; }
        public byte ColorIndex { get; set; }
        protected override byte[] GetExtensionData()
        {
            return Label.GetBytes().Concatenate(BlockSize.GetBytes(),
                Packed.Print(),
                DelayTime.GetBytes(),
                ColorIndex.GetBytes());
        }

        public enum DisposalMethod
        {
            NotSpecified,
            DoNotDispose,
            OverwriteWithBackgroundColor,
            OverwriteWithPreviousGraphic = 4
        }
        public class PackedData : PrintableData
        {
            public bool IsTransparentColor { get; set; }
            public bool IsUserInput { get; set; }
            public DisposalMethod DisposalMethod { get; set; }
            public override byte[] Print()
            {
                throw new NotImplementedException();
            }
        }
    }
}