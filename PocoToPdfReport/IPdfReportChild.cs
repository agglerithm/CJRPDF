namespace PocoToPdfReport
{
 
    public interface IPdfReportChild<out T> where T:class
    {
        T Render(); 
    }
}