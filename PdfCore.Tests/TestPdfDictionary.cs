using System;
using System.Text;
using CJRPDF.PdfCore.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PdfCore.Tests
{
    [TestClass]
    public class TestPdfDictionary
    {
        private string _sample = @"<<
\Type\Dictionary
\Subtype\Test
>>
";
        private PdfDictionary _dictionary;
        private string _result;

        [TestMethod]
        public void CanPrintDictionary()
        {
            WhenDictionaryIsCreated();
            PrintDictionary();
            ResultShouldMatchSample();
        }

        private void ResultShouldMatchSample()
        { 
            Assert.AreEqual(_sample, _result);
        }

        private void PrintDictionary()
        {
            _result = Encoding.ASCII.GetString(_dictionary.Print());
        }

        private void WhenDictionaryIsCreated()
        { 
            _dictionary = new PdfDictionary("Dictionary","Test");

        }
    }
}
