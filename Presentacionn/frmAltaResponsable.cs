﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Dominio;

namespace Presentacionn
{
    public partial class frmAltaResponsable : Form
    {
        public frmAltaResponsable()
        {
            InitializeComponent();
        }

        private void btnAregar_Click(object sender, EventArgs e)
        {
            eResponsable unR = new eResponsable();
            unR.ci = txtResCi.Text;
            unR.curso = txtCurso.Text;
            unR.tipo = cbxTipo.Text;
            dResponsable unDR = new dResponsable();
            bool token = unDR.altaResponsable(unR);
            if (token == true)
            {

                MessageBox.Show("el responsable ha sido agregado correctamente ");
            }
            else
            {

                MessageBox.Show("el responsable no ha sido ingresado");
            }
        }
    }
}
