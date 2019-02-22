using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using EscolaPDMIII.Models;


namespace EscolaPDMIII.MyDataSource
{
    public class Cadeira
    {

        public string Disciplina { get; set; }
        public int Calificacion { get; set; }


        public List<Cadeira> GetCadeiras()
        {
            List<Cadeira> cadeiras = new List<Cadeira>()
            {
                //DATA
            };
            return cadeiras;
        }


    };

    public class CadeiraView
    {
        public List<Cadeira> Notas { get; set; }
        public CadeiraView() //constructor
        {
            Notas = new Cadeira().GetCadeiras();
        }
    }
}
