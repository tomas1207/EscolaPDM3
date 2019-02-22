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
               new Nota(){Disciplina ="Matematica",CalificacionFinal = 20},
              new Nota(){Disciplina ="Portugues",CalificacionFinal = 20},
              new Nota(){Disciplina ="Historia",CalificacionFinal = 20},
              new Nota(){Disciplina ="PDMIII",CalificacionFinal = 20}
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
