using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP
{
    class Persona
    {
        string apellido, nombre, calle, numero, telefono, e_mail, documento;
        int id_barrio, id_persona, sexo;
        DateTime fecha_nacimiento;


        public string pApellido
        {
            set { apellido = value; }
            get { return apellido; }
        }

        public string pDocumento
        {
            set { documento = value; }
            get { return documento; }
        }

        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string pCalle
        {
            set { calle = value; }
            get { return calle; }
        }

        public string pNumero
        {
            set { numero = value; }
            get { return numero; }
        }

        public string pTelefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public string pEmail
        {
            set { e_mail = value; }
            get { return e_mail; }
        }

        public int pId_barrio
        {
            set { id_barrio = value; }
            get { return id_barrio; }
        }

        public int pId_persona
        {
            set { id_persona = value; }
            get { return id_persona; }
        }

        public int pSexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public DateTime pFechaNacimiento
        {
            set { fecha_nacimiento = value; }
            get { return fecha_nacimiento; }
        }




        public Persona(string apellido, string nombre, string calle, string documento, string numero, string telefono,
                string e_mail, int id_persona, int id_barrio, int sexo, DateTime fecha_nacimiento)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.calle = calle;
            this.documento = documento;
            this.numero = numero;
            this.telefono = telefono;
            this.e_mail = e_mail;
            this.id_persona = id_persona;
            this.id_barrio = id_barrio;
            this.sexo = sexo;
            this.fecha_nacimiento = fecha_nacimiento;
        }
        public Persona()
        {
            apellido = "";
            nombre = "";
            calle = "";
            documento = "";
            numero = "";
            telefono = "";
            pEmail = "";
            id_persona = 0;
            id_barrio = 0;
            sexo = 0;
            fecha_nacimiento = DateTime.Now;


        }
    }
}
