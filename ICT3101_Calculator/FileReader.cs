   // Implement the IFileReader interface
    public class FileReader : IFileReader
    {
        public string[] Read(string path)
        {
            return File.ReadAllLines(path);  // Reads the file contents
        }
    }
