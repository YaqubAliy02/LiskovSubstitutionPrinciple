using LiskovSubstitutionPrinciple.Services;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  ReadOnlyDocument readOnlyDocument = new ReadOnlyDocument("Hello", "text.txt");
              readOnlyDocument.Save();
              readOnlyDocument.Open();*/
             /*string FILEPATH1 = "../../../Assets/read-only.txt";
            string FILEPATH2 = "../../../Assets/simple.txt";*/
            Document document = new Document("Document","read-only.txt");
            WritableDocument writableDocument  = new WritableDocument("WritableDocument", "simple.txt");
            Project project = new Project();
            // WE can call any class (Document or WritableDocument) it will be okey because we did not changed entirely WritableDocument just extended like adding "Save method"
            // but in first commit we created ReadOnlyDocument class if we call this class instead of Document the project will be give exception and program break.
            project.AddDocument(document);
            project.AddDocument(writableDocument);
            project.SaveAll();

        }
    }
}