﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dominio
{
    public class dEquipo
    {
        public bool altaEquipo(eEquipo unDE)
        {

            pEquipo unPE = new pEquipo();

           bool equipoCreado =  unPE.altaEquipo(unDE);

            return equipoCreado;
        }

        public int bajaEquipo(String id)
        {
            pEquipo unPE = new pEquipo();
            
            return unPE.bajaEquipo(id);
        }

        public DataTable listarEquipo()
        {

            pEquipo unPE = new pEquipo();

            return unPE.listarEquipo1();
        }

        public DataTable listarEquipoT(string tipo)
        {

            pEquipo unPE = new pEquipo();

            return unPE.listarEquipoT(tipo);

        }

        public DataTable listarEquipoE(string estado)
        {

            pEquipo unPE = new pEquipo();

            return unPE.listarEquipoE(estado);

        }

        public bool modificacionEquipo(eEquipo unE)
        {
            pEquipo unPE = new pEquipo();
            bool token = unPE.modificarEquipo(unE);
            return token;
        }
    }
}
