﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pPrestamoEspontaneo : clsPersistencia
    {

        public DataTable listarPrestamoEspontaneo()
        {
            String consultaSQL = "SELECT * FROM prestamoEspontaneo;";

            DataTable dt = listarAlgo(consultaSQL);

            return dt;
        }

    }
}