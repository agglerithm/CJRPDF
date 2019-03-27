using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public class GifScreenAndColorMapInfo : PrintableData
    {
        public int SizeOfGlobalColorTable { get; set; }
        public bool SortFlag { get; set; }
        public int ColorResolution { get; set; }
        public bool GlobalColorTable { get; set; }

        public override byte[] Print()
        {
            var retVal = (byte) (GlobalColorTable ? 1 : 0);
            retVal = (byte) (retVal << 3);
            retVal = (byte) (retVal | ColorResolution);
            retVal = (byte) (retVal << 1);
            retVal = (byte) (retVal | (SortFlag ? 1 : 0));
            retVal = (byte) (retVal << 3);
            retVal = (byte) (retVal | SizeOfGlobalColorTable);
            return new[] {retVal};
        }
    }

    public class GifImageAndColorTableInfo : PrintableData
    {
        public byte LocalColorTable { get; set; }
        public byte Interlaced { get; set; }
        public byte Sort { get; set; }
        public int SizeOfLocalColorTable { get; set; }
        public override byte[] Print()
        {
            throw new System.NotImplementedException();
        }
    }
}