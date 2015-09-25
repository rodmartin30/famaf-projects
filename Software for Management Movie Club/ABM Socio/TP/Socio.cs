using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP
{
    class Socio : Persona
    {
        public Socio(string apellido, string nombre, string calle, string documento, string numero, string telefono,
                string e_mail, int id_persona, int id_barrio, int sexo, DateTime fecha_nacimiento)
            : base(apellido,nombre, calle, documento,numero, telefono,e_mail, id_persona,id_barrio,sexo,fecha_nacimiento)
        {

        }
        public Socio()
            : base()
        {
        }
    }
}
