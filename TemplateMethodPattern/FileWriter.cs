using System.Text;

namespace TemplateMethodPattern
{
    public abstract class FileWriter
    {
        private FileStream fileStream;
        private const string DefaultPath = $"D://DateTimeFormated.txt";

        public void Save(DateTime value)
        {
            CreateFile();
            WriteToFile(Format(value));
            CloseFile();
        }

        private void CreateFile()
        {
            fileStream = File.Create(DefaultPath);
        }


        private void WriteToFile(string value)
        {
            fileStream.Write(Encoding.ASCII.GetBytes(value));
        }

        private void CloseFile()
        {
            fileStream.Close();
        }

        protected abstract string Format(DateTime date);
    }
}
