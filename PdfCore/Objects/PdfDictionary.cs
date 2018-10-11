using System.Collections.Generic; 
using System.Text;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class PdfDictionary : PdfObject
    {  
        private PdfDictionary()
        {
            Value = new Dictionary<string, PdfObject>();
            ObjectType = PdfObjectType.Dictionary;
        }

        public PdfDictionary(string type, string subtype = null):this()
        {
            Type = type;
            Subtype = subtype; 
        }
        public override byte[] Print()
        {
            _writer.Write("<<"); 
            AddName("Type", Type); 
            AddName("Subtype", Subtype);
            foreach (var key in dictionary.Keys)
            {
                _writer.Write(new PdfNameObject(key).Print());
                _writer.Write(dictionary[key].Print());
            }

            _writer.Write(">>");
            return FinishBuffer();
        }

        private void AddName(string name, string val)
        {
            if (name == null || val == null) return; 
            _writer.Write(PdfNameObject.Print(name)); 
            _writer.Write(PdfNameObject.Print(val));
        }

        public string Type { get; set; }
        public string Subtype { get; set; }
        private Dictionary<string, PdfObject> dictionary {
            get
            {
                return (Dictionary<string,PdfObject>)Value; 
            }
        }
        public virtual void Add(string name, PdfObject val)
        {
            if (dictionary.ContainsKey(name))
                dictionary[name] = val;
            else
                dictionary.Add(name, val);
        }
    }
}