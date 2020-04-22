using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CJR.Images.Core;
using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public class GifTrailer:PrintableData
    {
        public override byte[] Print()
        {
            return new byte[] {0x3b};
        }
    }
}
