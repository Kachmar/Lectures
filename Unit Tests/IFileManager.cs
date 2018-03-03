namespace Unit_Tests
{
    interface IFileManager
    {
        IFileInfo[] GetFiles();

        void MoveFileToProcessed( IFileInfo fileInfo );

        void MoveToError( IFileInfo fileInfo );
    }
}