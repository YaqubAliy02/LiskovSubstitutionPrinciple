using System.Data;

namespace LiskovSubstitutionPrinciple.Services
{
    internal class Document
    {
        private readonly string FILEPATH = "../../../Assets";
        private string Data { get; set; }
        private string FileName { get; set; }
        public Document(string data, string fileName)
        {
            Data = data;
            FileName = fileName;
        }
       
        public void Open()
        {
            try
            {
                if(!File.Exists($"{FILEPATH}/{FileName}"))
                {
                    Console.WriteLine("File does not exist");
                }
                 this.Data = File.ReadAllText($"{FILEPATH}/{FileName}");

                Console.WriteLine("Document opened successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
