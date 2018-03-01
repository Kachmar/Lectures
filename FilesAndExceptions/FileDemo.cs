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


            ////Create directory 
            string workDirectory = Directory.GetCurrentDirectory();
            //DirectoryInfo directoryInfo = Directory.CreateDirectory($"{workDirectory}\\FileDemo\\new");
            //new DirectoryInfo($"{workDirectory}\\FileDemo\\new").Create();

            ////Get directories
            //DirectoryInfo[] directoryInfos = directoryInfo.Parent.GetDirectories();
            //string[] directories = Directory.GetDirectories($"{workDirectory}\\FileDemo\\");

            ////GetFiles
            //string[] files = Directory.GetFiles(directories[2]);

            ////Get information about the file and copy and delete it.
            //string path = files[0];
            //FileInfo fileInf = new FileInfo(path);
            //if (fileInf.Exists)
            //{
            //    Console.WriteLine("File Name: {0}", fileInf.Name);
            //    Console.WriteLine("Creation Time: {0}", fileInf.CreationTime);
            //    Console.WriteLine("Size: {0}", fileInf.Length);
            //    fileInf.CopyTo($"{workDirectory}\\FileDemo\\copied.txt", true);
            //    fileInf.Delete();
            //}

            //Task for students: 
            // write a method, that would receive the path, and return the file names which dates are from previous year and older.


            ////Create file and write text
            //string fileName = directoryInfo.FullName + "\\created.txt";
            //FileStream fileStream = File.Create(fileName);
            //byte[] array = System.Text.Encoding.Default.GetBytes("Hi Students");
            //fileStream.Write(array, 0, array.Length);

            ////Check that file is in use, until closed.
            //fileStream.Close();
            //fileStream.Dispose();

            ////Read the content of the file
            //using (FileStream readStream = File.Open(fileName, FileMode.Open))
            //{
            //    byte[] readArray = new byte[readStream.Length];
            //    readStream.Read(readArray, 0, readArray.Length);
            //    string textFromFile = System.Text.Encoding.Default.GetString(readArray);
            //}

            //try
            //{
            //    string[] texts = { "a", "b", "c" };
            //    string a = texts[4];
            //    Console.WriteLine( a );
            //}
            //catch ( Exception ex )
            //{
            //    Console.WriteLine( "Something went wrong" );
            //}
            //finally
            //{
            //    Console.WriteLine("This is finally");
            //}











            //using ( var x = File.Open( "InvalidPath.txt", FileMode.Open ) )
            //{
            //    var y = x.Length;
            //}




            FileStream openedStream = null;
            try
            {
                //openedStream = File.Open( "InvalidPath.txt", FileMode.Open );
                // File.Delete($"{workDirectory}\\FileDemo\\Locked.exe");
                //openedStream = File.Open($"{workDirectory}\\FileDemo\\SubFileDemo\\ThisIsVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVerysVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVerysVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVerysVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongName.txt", FileMode.Open);
                openedStream = File.Open(@"FileDemo\SubFileDemo\TextFile1.txt", FileMode.Open, FileAccess.Read);
                //openedStream = File.Open("", FileMode.Open);
                throw new Exception("I am a good developer, but shit happens");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("You made a mistake in file name, please check again");
            }
            catch (PathTooLongException e)
            {

                Console.WriteLine("Please use shorter file name");
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
                if (openedStream != null)
                {
                    openedStream.Close();
                }
               
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
