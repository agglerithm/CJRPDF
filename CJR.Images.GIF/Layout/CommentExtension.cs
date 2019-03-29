using System;

namespace CJR.Images.GIF.Layout
{
    public class CommentExtension : GifExtension
    {
        public byte Label => 0xFE;
        public string CommentData  { get; set; }
        protected override byte[] GetExtensionData()
        {
            throw new NotImplementedException();
        }
    }
}