namespace LiskovSubstitutionPrinciple.Services
{
    internal class WritableDocument : Document
    {
        private readonly string FILEPATH = "../../../Assets";
        private string Data { get; set; }
        public string FileName { get; set; }
        public WritableDocument(string data, string fileName) : base(data, fileName)
        {
            Data = data;
            FileName = fileName;
        }
        public void Save()
        {
            if (File.Exists($"{FILEPATH}/{FileName}"))
            {
                Console.WriteLine("File already exists.");
                return;
            }
            this.Data += DateTime.Now.ToString();
            File.WriteAllText($"{FILEPATH}/{FileName}", "Hello");
            Console.WriteLine("Document saved successfully");
        }
    }
}
