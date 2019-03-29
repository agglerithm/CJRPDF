using System;

namespace CJR.Images.GIF.Layout
{
    public class ApplicationExtension    :GifExtension
    {
        public byte Label => 0xFF;
        public byte BlockSize => 0xFF;
        public string Identifier { get; set; }
        public int AuthentCode { get; set; }
        public string ApplicationData { get; set; }
        protected override byte[] GetExtensionData()
        {
            throw new NotImplementedException();
        }
    }
}