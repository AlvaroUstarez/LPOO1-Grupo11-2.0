﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class ObraSocial
    {
        private string os_Cuit;

        public string Os_Cuit
        {
            get { return os_Cuit; }
            set { os_Cuit = value; }
        }
        private string os_RazonSocial;

        public string Os_RazonSocial
        {
            get { return os_RazonSocial; }
            set { os_RazonSocial = value; }
        }

        private string os_Direccion;

        public string Os_Direccion
        {
            get { return os_Direccion; }
            set { os_Direccion = value; }
        }
        private string os_Telefono;

        public string Os_Telefono
        {
            get { return os_Telefono; }
            set { os_Telefono = value; }
        }
    }
}
