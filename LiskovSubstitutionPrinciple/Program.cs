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
            project.AddDocument(document);
            project.AddDocument(writableDocument);
            project.SaveAll();

        }
    }
}