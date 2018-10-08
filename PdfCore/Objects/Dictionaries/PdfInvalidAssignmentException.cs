using System;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class PdfInvalidAssignmentException : Exception
    {
        public PdfInvalidAssignmentException(Type obj):base($"Type {obj.Name} is invalid for this assignment.")
        {
            
        }
    }
}