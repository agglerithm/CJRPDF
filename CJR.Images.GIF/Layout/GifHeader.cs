using CJR.Images.Core;
using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public class GifHeader : PrintableData
    {
        public string Version { get; set; }
        public GifLogicalScreenDescriptor LogicalScreenDescriptor { get; set; }

        public override byte[] Print()
        {
            return Version.StringToBuff().Concatenate(LogicalScreenDescriptor.Print());
        }
    }
}