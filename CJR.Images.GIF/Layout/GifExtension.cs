using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public abstract class GifExtension:PrintableData
    {
        public override byte[] Print()
        {
            return Introducer.GetBytes().Concatenate(GetExtensionData(),Terminator.GetBytes());
        }

        private byte Terminator => 0;
        private byte Introducer => 21;

        protected abstract byte[] GetExtensionData();
    }
}