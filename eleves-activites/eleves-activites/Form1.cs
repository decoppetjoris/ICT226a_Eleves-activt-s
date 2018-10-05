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
    public partial class EleveActivites : Form
    {
        public EleveActivites()
        {
            InitializeComponent();
        }

        private void BtnOpenCSV_Click(object sender, EventArgs e)
        {
            //importe les fonctions
            ReadFile readfile = new ReadFile();
            

            //get all val from the other class
            var valeursCSV = readfile.ReadCSV();
            

            //affiche sur la Tbox les valeurs
            TxtBTes.Text += valeursCSV;
            
            //prendre les donnees du fiches et les mets dans un stack
            List<int> eleves = new List<int>();
            foreach(var line in File.ReadLines(valeursCSV))
            {
                var values = line.Split(';');

                //mets les activites dans une list
                int i;
                for (i = 0; i < 20; i++)
                {
                    eleves.Add(Convert.ToInt16(values[i+2]));
                }

                //les mets dans l'objet eleve
                Eleve eleve = new Eleve(values[0],Convert.ToBoolean(Convert.ToInt16(values[1])),eleves);
            }
 
        }
    }
}
