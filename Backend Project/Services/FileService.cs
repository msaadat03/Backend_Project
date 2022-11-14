using Backend_Project.Interfaces;
using System.IO;

namespace Backend_Project.Services
{
    public class FileService : IFileService
    {
        public string ReadFile(string path, string template)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                template = reader.ReadToEnd();
            }

            return template;
        }
    }
}
