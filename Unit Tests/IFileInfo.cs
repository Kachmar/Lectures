namespace Unit_Tests
{
    internal interface IFileInfo
    {
        string Name { get; set; }
        string FullName { get; set; }

        string Content { get; set; }
    }
}