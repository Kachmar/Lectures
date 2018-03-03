namespace Unit_Tests
{
    internal interface IFileCommander
    {
        FileInfo[] GetFiles(string folder);

        void MoveFile(string fileInfoFullName, string processedFolderName);
    }
}