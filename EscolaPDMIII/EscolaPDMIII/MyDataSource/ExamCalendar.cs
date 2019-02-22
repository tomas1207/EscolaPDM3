using System;
using System.Collections.Generic;
using System.Text;
using EscolaPDMIII.Core;

namespace EscolaPDMIII.MyDataSource
{


    public class Exame
    {

        public string Disciplina { get; set; }
        public string Data { get; set; }


        public List<Exame>GetExames()
        {
            List<Exame> exames = new List<Exame>() 
            {
                //DATA
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
