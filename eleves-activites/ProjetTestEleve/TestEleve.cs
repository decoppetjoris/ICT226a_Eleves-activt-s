using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eleves_activites
{
    [TestClass]
    public class TestEleve
    {

        //test si ont peut bien lire le fichier CSV
        [TestMethod]
        public void TestCreationEleveSucc()
        {
            //given
            //je cree un objet
            Eleve testEleve;
            String Nom = "Toto";
            Boolean Cap = Convert.ToBoolean(1);
            List<int> act = new List<int> { 1, 2, 4};

            //then
            //je recupere mon objet
            testEleve = new Eleve(Nom,Cap,act);

            //when
            //compare les valeurs (cree et recu)
            Assert.AreEqual(Nom,testEleve.NamePublic);
            Assert.AreEqual(Cap, testEleve.isCaptPublic);
            Assert.AreEqual(act, testEleve.listofchoicesPublic);
        }
    }
}
