using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using EscolaPDMIII.Models;

namespace EscolaPDMIII.MyDataSource
{
    public class Propina
    {
        public ArrayList Mes { get; set; }
        public ArrayList Pago { get; set; }


        public List<Propina> GetPropinas()
        {
            List<Propina> propinas = new List<Propina>()
            {
             new Propina(){Mes = Core.GlogalVar.mespropina,Pago = Core.GlogalVar.pagopropinas}
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
