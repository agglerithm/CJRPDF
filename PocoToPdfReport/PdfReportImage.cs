using System.IO; 
using PocoToPdfReport;

namespace PocoToPdfReport
{
    public class PdfReportImage : IPdfReportChild<Image> {
        public PdfReportImage()
        {
            RetrievalMode = ImageRetrievalMode.FromFilePath;
        }
        public Image Render()
        { 
            if(RetrievalMode == ImageRetrievalMode.FromBuffer)
                return Image.GetInstance(ImageData);
            if (RetrievalMode == ImageRetrievalMode.FromFilePath)
                return Image.GetInstance(FilePath); 
            return Image.GetInstance(Stream);
        }

        public Stream Stream { get; set; }

        public string FilePath { get; set; }

        public byte[] ImageData { get; set; }

        public ImageRetrievalMode RetrievalMode { get; set; }
    }

    public class Image
    {
        public static Image GetInstance(byte[] imageData)
        {
            throw new System.NotImplementedException();
        }

        public static Image GetInstance(Stream imageData)
        {
            throw new System.NotImplementedException();
        }

        public static Image GetInstance(string imageData)
        {
            throw new System.NotImplementedException();
        }
    }
}