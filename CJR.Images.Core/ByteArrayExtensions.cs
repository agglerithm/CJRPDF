using System.Text;

namespace ImagesCore
{
    public static class ByteArrayExtensions
    {
        public static byte[] StringToBuff(this string text)
        {
            return Encoding.ASCII.GetBytes(text);
        }
    }
}
