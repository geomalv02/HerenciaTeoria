using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTeoria
{
    //clase hijo o derivado
    //definimos la relacion 
    class Cat:Animal
    {
        //propiedades
        public int lives { get; set; }

        //metodos
        public string meow()
        {
            return "meooowww";
        }

        //metodo sobreescrito
        public override string run()
        {
            return base.run() + "El gato esta corriendo... ";
        }
    }
}
