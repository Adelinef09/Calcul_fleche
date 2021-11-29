using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
 


namespace Assignment
{
    public class DataExport
    {
        public string filename;

        public DataExport()
        {
            this.filename = "log.txt";
        }
        public DataExport(string fileToWrite)
        {
            this.filename = fileToWrite;
        }

        // création de la fonction pour exporter les données dans le fichier log.txt
        public void Log(string lineToLog)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.WriteLine(lineToLog);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
