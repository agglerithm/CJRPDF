using System.Collections.Generic;
using System.Linq;
using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public class GifFile:PrintableData
    {
        public string FileName { get; set; } 

        public GifHeader Header { get; set; }

        public IEnumerable<GifExtension> Extensions { get; set; }
        public GifColorTable ColorTable { get; set; }
        public IEnumerable<GifImageData> ImageData { get; set; }
        public GifTrailer Trailer { get; set; }
        public override byte[] Print()
        {
            return Header.Print().Concatenate(
                Extensions.Select(e => e.Print()).Aggregate((e1,e2) => e1.Concatenate(e2)),ColorTable.Print(),
                ImageData.Select(i => i.Print()).Aggregate((i1,i2) => i1.Concatenate(i2)), Trailer.Print());
        }
    }
}
