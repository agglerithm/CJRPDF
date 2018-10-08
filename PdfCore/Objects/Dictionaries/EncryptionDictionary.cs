namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class EncryptionDictionary : PdfDictionary
    {
        public EncryptionDictionary() : base("Encryption", null)
        {
        }
        [ObjectLabel("R")]
        public int Revision { get; set; }
        [ObjectLabel("O")]
        public string OwnerUserPasswordKey { get; set; }
        [ObjectLabel("U")]
        public string PasswordValidationKey { get; set; }
        [ObjectLabel("P")]
        public int PermittedOperations { get; set; }
        public bool EncryptMetadata { get; set; }

    }
}