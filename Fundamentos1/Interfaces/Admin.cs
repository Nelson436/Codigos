﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_1.Interfaces
{
    internal class Admin
    {
    
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Nivel { get; set; }
        public bool ActualizaPerfil(string nombre, string Email)
        {
            return true;
        }

        public void Login()
        {

            Console.WriteLine("Usuario Logeado");
        }
    }
}