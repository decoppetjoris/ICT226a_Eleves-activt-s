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

            //prendre les donnees du fiches et les mets dans une liste
            List<Eleve> dataeleve = new List<Eleve>();
            
            foreach(var line in File.ReadLines(valeursCSV))
            {
                List<int> eleves = new List<int>();
                var values = line.Split(';');

                //mets les activites dans une list
                int i = 0;
                foreach(string val in values)
                {
                    
                    if ((i != 0) && (i != 1))
                    {
                        eleves.Add(Convert.ToInt32(val));
                    }
                    i++;
                }

                //les mets dans l'objet eleve
                Eleve eleve = new Eleve(values[0],Convert.ToBoolean(Convert.ToInt16(values[1])),eleves);
                dataeleve.Add(eleve);
            }

            //affiche tous les nom des eleves dans le tb
            
            foreach (var ele in dataeleve)
            {
                TxtBTes.Text +=  ele.NamePublic;
                TxtBTes.Text += ele.isCaptPublic;
                int i;
                for (i = 0; i < ele.listofchoicesPublic.Count; i++)
                {
                    TxtBTes.Text += ele.listofchoicesPublic[i];
                }
                
            }
        }
    }
}
