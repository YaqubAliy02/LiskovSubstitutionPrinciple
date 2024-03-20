using System.IO.Enumeration;
namespace LiskovSubstitutionPrinciple.Services
{
    internal class ReadOnlyDocument : Document
    { 
        public ReadOnlyDocument(string data, string fileName) : base(data, fileName) { }
        public override void Save()
        {
          throw new Exception("Can't save a read-only document");
        }
    }
      
    
}
