using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Complier
{
    static public class FileHandler
    {
        static public List<string> getFiles(string directory)
        {
            string[] files = Directory.GetFiles(directory, "*.txt");
            List<string> fileList = new List<string>();
            foreach (string file in files)
            {
                fileList.Add(file);
            }
            return fileList;
        }

        /********************************************************************
        *** FUNCTION readFromFile
        *********************************************************************
        *** DESCRIPTION : Reads all lines from a file and trimms them before
        *** storing them in a list. 
        *** INPUT ARGS : string fileName
        *** OUTPUT ARGS : 
        *** IN/OUT ARGS : 
        *** RETURN :List<string>
        ********************************************************************/
        static public void readFromFile(string fileName, List<string> allFiles)
        {
            if (checkFile(getDirectory() + fileName))
            {
                string[] lines = File.ReadAllLines(getDirectory() + fileName);

                foreach (string line in lines)
                {
                    allFiles.Add(line.Trim());
                }
            }
            
        }
        /********************************************************************
        *** FUNCTION getDirectory
        *********************************************************************
        *** DESCRIPTION : gets current directory where files should be stored 
        *** INPUT ARGS : 
        *** OUTPUT ARGS : 
        *** IN/OUT ARGS : 
        *** RETURN : string
        ********************************************************************/
        static public string getDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            int pos = currentDirectory.IndexOf(@"bin");
            return currentDirectory+"\\";//.Remove(pos);
        }
        /********************************************************************
        *** FUNCTION checkFile
        *********************************************************************
        *** DESCRIPTION : Validates that file exists 
        *** INPUT ARGS : string fileName
        *** OUTPUT ARGS : 
        *** IN/OUT ARGS : 
        *** RETURN : bool
        ********************************************************************/
        static public bool checkFile(string fileName)
        {
            return File.Exists(fileName);
        }

         
    }
}
