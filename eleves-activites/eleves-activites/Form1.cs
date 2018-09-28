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
            string valeursCSV = readfile.ReadCSV();

            //affiche sur la Tbox les valeurs
            TxtBTes.Text += valeursCSV;
           
        }
    }
}
