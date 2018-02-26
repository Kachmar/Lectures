using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndExceptions
{

    class FileDemo
    {
        public static void Main()
        {
            //Show info about the drives
            //DriveInfo[] drives = DriveInfo.GetDrives();
            //foreach ( DriveInfo drive in drives )
            //{
            //    if ( drive.DriveType == DriveType.Fixed )
            //    {
            //        Console.WriteLine( "Name: {0}", drive.Name );
            //        Console.WriteLine( "Type: {0}", drive.DriveType );
            //        if ( drive.IsReady )
            //        {
            //            Console.WriteLine( "Capacity: {0}", drive.TotalSize );
            //            Console.WriteLine( "Free space: {0}", drive.TotalFreeSpace );
            //            Console.WriteLine( "Label: {0}", drive.VolumeLabel );
            //        }
            //        Console.WriteLine( );
            //    }
            //}

            //Create directory 
            string workDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = Directory.CreateDirectory($"{workDirectory}\\FileDemo\\new");
            new DirectoryInfo($"{workDirectory}\\FileDemo\\new").Create();

            //Get directories
            DirectoryInfo[] directoryInfos = directoryInfo.Parent.GetDirectories();
            string[] directories = Directory.GetDirectories($"{workDirectory}\\FileDemo\\");

            //GetFiles
            string[] files = Directory.GetFiles(directories[2]);

            //Get information about the file and copy and delete it.
            string path = files[0];
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("File Name: {0}", fileInf.Name);
                Console.WriteLine("Creation Time: {0}", fileInf.CreationTime);
                Console.WriteLine("Size: {0}", fileInf.Length);
                fileInf.CopyTo($"{workDirectory}\\FileDemo\\copied.txt", true);
                fileInf.Delete();
            }

            //Create file and write text
            string fileName = directoryInfo.FullName + "\\created.txt";
            FileStream fileStream = File.Create(fileName);
            byte[] array = System.Text.Encoding.Default.GetBytes("Hi Students");
            fileStream.Write(array, 0, array.Length);

            //Check that file is in use, until closed.
            fileStream.Close();
            fileStream.Dispose();

            //Read the content of the file
            using (FileStream readStream = File.Open(fileName, FileMode.Open))
            {
                byte[] readArray = new byte[readStream.Length];
                readStream.Read(readArray, 0, readArray.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(readArray);
            }

            FileStream openedStream = null;
            try
            {
                // var openedStream = File.Open( "InvalidPath.txt", FileMode.Open );
                File.Delete($"{workDirectory}\\FileDemo\\Locked.exe");
                //openedStream = File.Open($"{workDirectory}\\FileDemo\\SubFileDemo\\ThisIsVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVerysVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVerysVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVerysVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongName.txt", FileMode.Open);
                // openedStream = File.Open(fileName, FileMode.Open);
                // var openedStream = File.Open( "", FileMode.Open );

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
            catch (PathTooLongException e)
            {

                Console.WriteLine(e);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Close the file, before running this application");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (openedStream != null)
                {
                    openedStream.Close();
                }
            }
            Console.ReadLine();
        }
    }
}
