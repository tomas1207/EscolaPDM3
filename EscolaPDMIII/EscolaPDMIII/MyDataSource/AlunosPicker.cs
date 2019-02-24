using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EscolaPDMIII.MyDataSource
{
    public class Aluno
    {
        public ArrayList Alunos { get; set; }



        public List<Aluno> GetAluno()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno () {Alunos = Core.GlogalVar.nome} 
            };
            return alunos;
        }


    };

    public class AlunoView
    {
        public List<Aluno> Alunos { get; set; }
        public AlunoView() //constructor
        {
            Alunos = new Aluno().GetAluno();
        }
    }
}
