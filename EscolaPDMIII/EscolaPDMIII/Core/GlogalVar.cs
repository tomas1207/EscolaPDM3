using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EscolaPDMIII.Core
{
    class GlogalVar
    {
        //ALUNO
        public static ArrayList id { get; set; } = new ArrayList();
        public static ArrayList nome { get; set; } = new ArrayList();
        public static ArrayList turma { get; set; } = new ArrayList();
        public static ArrayList curso { get; set; } = new ArrayList();
        public static ArrayList idade { get; set; } = new ArrayList();
        public static ArrayList telefone { get; set; } = new ArrayList();
        public static ArrayList morada { get; set; } = new ArrayList();
        public static ArrayList bi { get; set; } = new ArrayList();
        public static ArrayList login_id { get; set; } = new ArrayList();

        //EXAMES
        public static ArrayList idexames{ get; set; } = new ArrayList();
        public static ArrayList aluno_idexames { get; set; } = new ArrayList();
        public static ArrayList notaexames { get; set; } = new ArrayList();
        public static ArrayList disciplinaexames { get; set; } = new ArrayList();
        public static ArrayList dataexames { get; set; } = new ArrayList();

        //HORARIOS
        public static ArrayList idhorarios { get; set; } = new ArrayList();
        public static ArrayList disciplinahorarios { get; set; } = new ArrayList();
        public static ArrayList professorhorarios { get; set; } = new ArrayList();
        public static ArrayList datahorarios { get; set; } = new ArrayList();

        //PROFESSOR
        public static ArrayList idprofessor { get; set; } = new ArrayList();
        public static ArrayList nomeprofessor { get; set; } = new ArrayList();
        public static ArrayList moradaprofessor { get; set; } = new ArrayList();
        public static ArrayList telefoneprofessor { get; set; } = new ArrayList();
        public static ArrayList biprofessor { get; set; } = new ArrayList();
        public static ArrayList disciplinas_idprofessor { get; set; } = new ArrayList();
        public static ArrayList login_idprofessor { get; set; } = new ArrayList();

        //PROPINAS
        public static ArrayList idpropinas { get; set; } = new ArrayList();
        public static ArrayList pagopropinas { get; set; } = new ArrayList();
        public static ArrayList aluno_idpropina { get; set; } = new ArrayList();
        public static ArrayList mespropina { get; set; } = new ArrayList();

        //DISCIPLINA
        public static ArrayList iddisciplina { get; set; } = new ArrayList();
        public static ArrayList nomedisciplina { get; set; } = new ArrayList();
        public static ArrayList horasdisciplina { get; set; } = new ArrayList();
        public static ArrayList notadisciplina { get; set; } = new ArrayList();
        public static ArrayList aluno_iddisciplina { get; set; } = new ArrayList();

    }
}
