using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovainfJCB.Models;

namespace CovainfJCB.Views.ViewModels
{
    public class ModeloIndex
    {
        public Representante Representante { get; set; }
        public List<Infante> ListInfante { get; set; }
        //public Infante Infante { get; set; }
    }
}
