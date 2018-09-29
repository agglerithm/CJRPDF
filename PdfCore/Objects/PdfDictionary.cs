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

        protected PdfDictionary(string type, string subtype = null):this()
        {
            Type = type;
            Subtype = subtype; 
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

        private void AddType(StringBuilder sb, string name, string val)
        {
            if (name == null || val == null) return;
            var no = new PdfNameObject(name); 
            sb.Append(no.Print());
            var vo = new PdfNameObject(val);
            sb.AppendLine(vo.Print());
        }

        public string Type { get; set; }
        public string Subtype { get; set; }
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
}