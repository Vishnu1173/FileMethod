using System.IO;

namespace FileMethod
{
    public class FileClass
    {
        public bool StoreData(string path,string content)
        {
            File.WriteAllText(path, content);
            return true; 
        }    
    }
}
