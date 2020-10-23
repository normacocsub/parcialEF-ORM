﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Persona
    {
        [Key]
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public Ayudas Ayudas { get; set; }


        public void AgregarAyuda(Ayudas ayuda)
        {
            Ayudas = ayuda;
        }
    }
}
