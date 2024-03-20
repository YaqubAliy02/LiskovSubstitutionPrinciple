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
             string FILEPATH = "../../../Assets/read-only.txt";


            File.Create(FILEPATH);
            FileInfo fileInfo = new FileInfo(FILEPATH);
            fileInfo.IsReadOnly = true;
        }
    }
}