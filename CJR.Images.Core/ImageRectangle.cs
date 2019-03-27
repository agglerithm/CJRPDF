using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImagesCore;

namespace CJR.Images.Core
{
    public class ImageRectangle:PrintableData
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public override byte[] Print()
        {
            throw new NotImplementedException();
        }
    }
}
