using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Configuration;


namespace Kaiserville_Shop_Randomizer
{
    internal class FileManager
    {
        //string filePath = @"c:\7daystodie\servertools\Shop.xml";
        //string filePathDir = @"c:\7daystodie\servertools";

        string shopFilePath;
        string shopFileDir;
        string settingsFilePath;
        public FileManager()
        {
            settingsFilePath = Environment.CurrentDirectory;
            
            shopFileDir = ReturnShopFileUrl(settingsFilePath);
            shopFilePath = shopFileDir + "\\Shop.xlm";
            Console.WriteLine("Settings file location {0}" ,  settingsFilePath);
        }
        




        public string ReturnShopFileUrl(string path)
        {
            string temp;
            string settingsFile = path + "\\" + "Settings.txt";
            if (!File.Exists(settingsFile)) //If the file doesn't exist at the given "Path"
            {
                //Create a new file
                var tempFile = File.Create(settingsFile);
                tempFile.Close();//close the file to prevent any errors if access again
                using (StreamWriter sw = new StreamWriter(File.Open(settingsFile, FileMode.Truncate)))
                {
                    temp = Environment.CurrentDirectory; 
                    sw.WriteLine(temp); //path for shop xlm
                }
                Console.WriteLine("To change the Directory where the Shop.xlm file is created, go to the following location {0}.", settingsFile);
                Console.WriteLine("This will only run the first time the program is executed, or the file was not found.");
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();//wait for input from user to continue execution
                return temp;
            }
            else
            {
                //open the binary reader to get data from file
                using (StreamReader sr = new StreamReader(File.Open(settingsFile, FileMode.Open)))
                {
                    temp = sr.ReadLine();
                }
            }
            return temp;
        }
       
        public void SavetoXml(List<string> textToSave)
        {

            if (Directory.Exists(shopFileDir))
            {
                Console.WriteLine(shopFilePath);

                using (StreamWriter sw = new StreamWriter(shopFilePath, false, Encoding.UTF8))
                {

                    sw.WriteLine("<?xlm version=\"1.0\" encoding =\"UTF-8\"?>");
                    sw.WriteLine("<Shop>");
                    sw.WriteLine("<ST Version=\"20.2.0\" />");

                    for (int x = 0; x < textToSave.Count; x++)
                    {
                        sw.WriteLine(textToSave[x]);
                    }
                    sw.WriteLine("</Shop>");

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Save(sw);
                    Console.WriteLine("saving to file");
                }
                
            }
            else
            {
                Console.WriteLine(String.Format("Directory {0} doesn't exist", shopFilePath));

                Thread.Sleep(10000);
            }

        }
    }
}