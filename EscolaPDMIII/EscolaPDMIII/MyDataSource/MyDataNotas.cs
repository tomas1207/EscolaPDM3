using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using EscolaPDMIII.Models;
namespace EscolaPDMIII.MyDataSource
{
    public class Nota
    {

        public string Disciplina { get; set; }
        public int CalificacionFinal { get; set; }


        public List<Nota> GetNotas()
        {
            List<Nota> notas = new List<Nota>()
            {
                //DATA
            };
            return notas;
        }


    };

    public class NotaView
    {
        public List<Nota> Notas { get; set; }
        public NotaView() //constructor
        {
            Notas = new Nota().GetNotas();
        }
    }
}
