using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using EscolaPDMIII.Models;

namespace EscolaPDMIII.MyDataSource
{
    public class Propina
    {
        public string Mes { get; set; }
        public bool Pago { get; set; }


        public List<Propina> GetPropinas()
        {
            List<Propina> propinas = new List<Propina>()
            {
              new Propina(){Mes ="Jan",Pago = true},
              new Propina(){Mes ="Fev",Pago = false},
              new Propina(){Mes ="Mar",Pago = false},
              new Propina(){Mes ="Dez",Pago = true},
            };
            return propinas;
        }


    };

    public class PropinaView
    {
        public List<Propina> Propinas { get; set; }
        public PropinaView() //constructor
        {
            Propinas = new Propina().GetPropinas();
        }
    }
}
