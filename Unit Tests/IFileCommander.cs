namespace Unit_Tests
{
    public interface IFileCommander
    {
        FileInfo[] GetFiles(string folder);

        void MoveFile(string fullName, string folderName);

        void SaveFile(string fileName, string fileContent);
    }
}