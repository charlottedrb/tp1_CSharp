using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Debug
{
    class Ingredient
    {
        private int id;
        private String libelle;
        private int quantite;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if(value < 1)
                    throw new ArgumentException("L'id ne peut pas être inférieur à 1");
                this.id = value;
            }
        }
        public String Libelle
        {
            get
            {
                return this.libelle;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Le nom d'un ingrédient ne peut pas être nul.");
                if (value.Length == 0)
                    throw new ArgumentException("Le nom d'un ingrédient ne peut pas être vide.");
                this.libelle = value;
            }
        }

        public int Quantite
        {
            get
            {
                return this.quantite; 
            }
            set
            {
                if (value < 1)
                    throw new ArgumentException("La quantité ne peut pas être inférieur à 1");
                this.quantite = value;
            }
        }
    }
}
