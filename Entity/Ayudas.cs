using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Ayudas
    {
        [Key]
        public string Numero { get; set; }
        public decimal ValorApoyo { get; set; }
        public string  ModalidadApoyo { get; set; }
        public DateTime Fecha { get; set; }

    }
}