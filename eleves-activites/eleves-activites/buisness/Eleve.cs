using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eleves_activites
{
    public class Eleve
    {
        #region private attributs
        private string Name;
        private Boolean isCapt;
        private List<int> listofchoices;
        #endregion private attributs

        #region constructeur
        public Eleve(string name, Boolean isCapt, List<int> listofchoices)
        {
            //le this dis que c est le name d'en haut
            this.Name = name;
            this.isCapt = isCapt;
            this.listofchoices = listofchoices;
        }
        #endregion constructeur

        #region mettre du prive en public (get)
        public string NamePublic
        {
            get
            {
                return this.Name; //this pas obligatoire ici
            }
        }

        public Boolean isCaptPublic
        {
            get
            {
                return this.isCapt;
            }
        }

        public List<int> listofchoicesPublic
        {
            get
            {
                return this.listofchoices;
            }
        }
        #endregion mettre du prive en public (get)
    }
}