
using PocoToPdfReport;

namespace PocoToPdfReport
{
    public enum ImageRetrievalMode
    {
        FromBuffer,
        FromFilePath,
        FromStream
    };
    public class PdfReportArtifact : IPdfReportChild<Chunk>
    {
        public PdfReportArtifact()
        {
            
        }

        public Chunk Render()
        {
            var chunk = new Chunk();
            chunk.SetHorizontalScaling(HorizontalScale);
            chunk.SetBackground(BackgroundColor);
            return chunk;
        }

        public BaseColor BackgroundColor { get; set; }

        public float HorizontalScale { get; set; }
    }

    public class Chunk
    {
        public Chunk(object content, Font font)
        {
            throw new System.NotImplementedException();
        }

        public Chunk()
        {
            throw new System.NotImplementedException();
        }

        public void SetHorizontalScaling(float horizontalScale)
        {
            throw new System.NotImplementedException();
        }

        public void SetBackground(BaseColor backgroundColor)
        {
            throw new System.NotImplementedException();
        }
    }
}