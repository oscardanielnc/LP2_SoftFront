﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Tarjetas
{
    public partial class tarjMaterial : Form
    {
        public tarjMaterial()
        {
            InitializeComponent();
        }

        public tarjMaterial(PublicacionesWS.material u)
        {
            InitializeComponent();
            btnMaterial.Text = u.nombreArchivo;
        }
    }
}
