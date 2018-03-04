namespace Unit_Tests
{
    public interface IFileInfo
    {
        string Name { get; set; }
        string FullName { get; set; }

        string Content { get; set; }
    }
}