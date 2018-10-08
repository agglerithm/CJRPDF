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
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<<"); 
            AddName(sb, "Type", Type); 
            AddName(sb, "Subtype", Subtype);
            foreach (var key in dictionary.Keys)
            {
                sb.Append(new PdfNameObject(key).Print());
                sb.AppendLine(dictionary[key].Print());
            }

            sb.AppendLine(">>");
            return sb.ToString();
        }

        private void AddName(StringBuilder sb, string name, string val)
        {
            if (name == null || val == null) return; 
            sb.Append(PdfNameObject.Print(name)); 
            sb.AppendLine(PdfNameObject.Print(val));
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