using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Debug
{
    public class Pays
    {
        private int id;
        private String nom;
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < 1)
                    throw new ArgumentException("L'id ne peut pas être inférieur à 1");
                this.id = value;
            }
        }
        
        public String Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Le nom d'un pays ne peut pas être nul.");
                if (value.Length == 0)
                    throw new ArgumentException("Le nom d'un pays ne peut pas être vide.");
                this.nom = value;
            }
        }

        public Pays(int id, String nom)
        {
            this.Id = id;
            this.Nom = nom;
        }

        public override string ToString()
        {
            return "Nom : " + this.nom + "\n Id : " + this.id;
        }
    }
}
