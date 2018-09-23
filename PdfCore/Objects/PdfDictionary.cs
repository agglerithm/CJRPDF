using System.Collections.Generic;
using System.Text;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class PdfDictionary : PdfObject
    { 

        public PdfDictionary()
        {
            Value = new Dictionary<string, PdfObject>();
            ObjectType = PdfObjectType.Dictionary;
        }
        internal override string Print()
        {
            var sb = new StringBuilder();
            sb.Append("<<"); 
            AddType(sb, "Type", Type); 
            AddType(sb, "Subtype", Subtype);
            foreach (var key in dictionary.Keys)
            {
                sb.Append(new PdfNameObject(key).Print());
                sb.AppendLine(dictionary[key].Print());
            }

            sb.Append(">>");
            return sb.ToString();
        }

        private void AddType(StringBuilder sb, string name, PdfNameObject type)
        {
            if (type == null) return;
            sb.Append(new PdfNameObject(name).Print());
            sb.AppendLine(type.Print());
        }

        public PdfNameObject Type { get; set; }
        public PdfNameObject Subtype { get; set; }
        private Dictionary<string, PdfObject> dictionary {
            get
            {
                return (Dictionary<string,PdfObject>)Value; 
            }
        }
        public void Add(string name, PdfObject val)
        {
            if (dictionary.ContainsKey(name))
                dictionary[name] = val;
            else
                dictionary.Add(name, val);
        }
    }
    
    public class PdfTrailerDictionary : PdfDictionary
    {
        public PdfTrailerDictionary()
        {
            Type = new PdfNameObject("Trailer");
        }
        public int Size { get; set; }
        public int? Prev { get; set; }
        public PdfDictionary Root { get; set; }
        public PdfDictionary Encrypt { get; set; }
        public PdfDictionary Info { get; set; }
        public PdfArray Id { get; set; }
        internal override string Print()
        {
            Add("Size", new PdfInteger(Size));
            if(Prev.HasValue)
                Add("Prev", new PdfInteger(Prev.Value));
            Add("Root", Root);
            Add("Encrypt", Encrypt);
            Add("Info", Info);
            Add("ID", Id);
            return base.Print();
        }
    }


}