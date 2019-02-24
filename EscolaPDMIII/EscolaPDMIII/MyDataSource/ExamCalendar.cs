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
                new Exame(){Disciplina = GlogalVar.disciplinaexames,Data = GlogalVar.dataexames}
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
