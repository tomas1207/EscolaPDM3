using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using EscolaPDMIII.Core;

namespace EscolaPDMIII.MyDataSource
{


    public class Exame
    {

        public ArrayList Disciplina { get; set; }
        public ArrayList Data { get; set; }


        public List<Exame>GetExames()
        {
          
          
            List<Exame> exames = new List<Exame>()
            {
              new Exame(){Disciplina ="Matematica",Data = "12/07"},
              new Exame(){Disciplina ="Portugues",Data = "08/07"},
              new Exame(){Disciplina ="Historia",Data = "25/12"},
              new Exame(){Disciplina ="PDMIII",Data = "22/02"}
            };
            return exames;
        }


    };

    public class ExameView
    {
        public List <Exame> Exames { get; set; }
        public ExameView() //constructor
        {
            Exames = new Exame().GetExames();
        }
    }

   




}  
