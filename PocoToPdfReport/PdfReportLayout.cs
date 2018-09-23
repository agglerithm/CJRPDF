namespace PocoToPdfReport
{
    public abstract class PdfReportLayout<T> where T : class
    {
        public abstract T Apply(T obj);
    }
}