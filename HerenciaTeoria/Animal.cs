using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTeoria
{
    //clase padre o base
    class Animal
    {
        //propiedades

        public int animalAge { get; set; }
        public Boolean animalFur { get; set; }

        //metodos

        public string getInfo()
        {
            var fur = "";
            if (animalFur == true)
            {
                fur = "Tiene pelo ";
            }
            else
            {
                fur = "No tiene pelo ";
            }
            return "El animal tiene " + animalAge + " años, y " + fur;
        }
        public string walk()
        {
            return "El animal esta caminando ";
        }

        //overload del metodo walk
        public string walk(string name, string owner)
        {
            return "El" + name + "Esta caminando con " + owner; 
        }
        public virtual string run()
        {
            return "El animal esta corriendo ";
        }
    }
}
