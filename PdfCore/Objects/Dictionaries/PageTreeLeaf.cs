﻿using System;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class PageTreeLeaf : PdfDictionary
    {
        public PageTreeLeaf():base("Page")
        { 
        }
        public ResourceDictionary Resources { get; set; }
        public IndirectObject<PageTreeNode> Parent { get; set; }
        public DateTime LastModified { get; set; }
        public PdfRectangle MediaBox { get; set; }
        public PdfRectangle CropBox { get; set; }
        public PdfRectangle BleedBox { get; set; }
        public PdfRectangle TrimBox { get; set; }
        public PdfRectangle ArtBox { get; set; }
        public PdfDictionary BoxColorInfo { get; set; }
        public PdfStreamDictionary Contents { get; set; }
        public int Rotate { get; set; }
        public PdfDictionary Group { get; set; }
        public int Thumb { get; set; }
        [ObjectLabel("AA")]
        public string AdditionalActions { get; set; }
        public PdfStreamDictionary Metadata { get; set; }
        public PdfDictionary PieceInfo { get; set; }
        public object StructParents { get; set; }
        public int ID { get; set; }
        [ObjectLabel("PZ")]
        public int PreferredZoom { get; set; }
        public PdfDictionary SeparationInfo { get; set; }
        public bool TemplateInstantiated { get; set; }
        public PdfDictionary PresSteps { get; set; }
        public int UserUnit { get; set; }
        [ObjectLabel("VP")]
        public PdfDictionary ViewPorts { get; set; }
    }
}