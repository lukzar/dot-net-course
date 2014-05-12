using System;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace LatwaAutomatyzacjaWCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Word.Application app = new Word.Application();
            app.Visible = true;

            object template = Missing.Value;
            object newTemplate = Missing.Value;
            object documentType = Missing.Value;
            object visible = true;

            Word.Document doc = app.Documents.Add(
                ref template, ref newTemplate, ref documentType, ref visible
            );

            doc.Words.First.InsertAfter("Programowanie pod Windows");
            doc.SaveAs("ppw.doc");
        }
    }
}
