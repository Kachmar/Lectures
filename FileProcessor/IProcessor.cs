namespace FileProcessor
{
    internal interface IProcessor
    {
        string Process(string[] rowValues);
    }
}