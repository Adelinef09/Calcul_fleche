using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignment
{
    class DataImport
    {
        // Importer l'abaque contenant les matériaux et les modules d'Young
        // Ils seront stoqués dans un dictionnaire
        public Dictionary<string, string> ImportAbaqueFile(string fileImport)
        {
            Dictionary<string, string> matmod = new Dictionary<string, string>();
            try
            {
                using (StreamReader sr = new StreamReader(File.OpenRead(fileImport)))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = line.Split(':');
                        matmod.Add(values[0], values[1]);
                    }
                    sr.Close();
                }
            }


            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return matmod;
        }

    }
}

