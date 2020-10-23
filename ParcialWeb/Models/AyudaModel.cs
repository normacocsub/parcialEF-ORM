using System;
using Entity;

namespace ParcialWeb.Models
{
    public class AyudaInputModel
    {
        public int Numero { get; set; }
        public decimal ValorApoyo { get; set; }
        public string  ModalidadApoyo { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class AyudaViewModel : AyudaInputModel 
    {
        public AyudaViewModel()
        {

        }
        
    }
}