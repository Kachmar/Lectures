namespace Unit_Tests
{
    public interface IFileContentGenerator
    {
        string Process(IFileInfo fileInfo);
        string GetFileName(string originalFileName);
    }
}