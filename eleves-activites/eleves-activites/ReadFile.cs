using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace eleves_activites
{
    public class ReadFile
    {
        public string ReadCSV()
        {
            string fileName = null;
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:/";
                openFileDialog1.Filter = "CSV Files(*.csv) | *.csv";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                }
            }
            //verifier les ;
            //verifier que chaque nom est unique
            if (fileName != null)
            {
                //Do something with the file, for example read text from it
                var texte = File.ReadAllLines(fileName);
                return fileName;
            }
            else
            {
                throw new Exception("Fichier vide");
            }
            throw new Exception("Imposble de lire le fichier");
        }
        
    }
}
