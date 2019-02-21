using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Collections;

namespace EscolaPDMIII.Core
{
    class JsonDecode
    {
        

        public void jsonalunos(string link)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(link);

                JObject joResponse = JObject.Parse(json);
             
                JArray array = (JArray)joResponse["Alunos"];
                int lenght = array.Count();
                for(int i = 0; i < lenght; i++)
                {
                    GlogalVar.id.Add(array[i]["id"]);
                    GlogalVar.nome.Add(array[i]["nome"]);
                    GlogalVar.turma.Add(array[i]["turma"]);
                    GlogalVar.curso.Add(array[i]["curso"]);
                    GlogalVar.idade.Add(array[i]["idade"]);
                    GlogalVar.telefone.Add(array[i]["telefone"]);
                    GlogalVar.morada.Add(array[i]["morada"]);
                    GlogalVar.bi.Add( array[i]["bi"]);
                    GlogalVar.login_id.Add( array[i]["login_id"]);
                }


            }
        }
        public void jsonhorarios(string link)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(link);

                JObject joResponse = JObject.Parse(json);

                JArray array = (JArray)joResponse["Horarios"];
                int lenght = array.Count();
                for (int i = 0; i < lenght; i++)
                {
                    GlogalVar.idhorarios.Add(array[i]["id"]);
                    GlogalVar.disciplinahorarios.Add(array[i]["disciplina"]);
                    GlogalVar.professorhorarios.Add(array[i]["professor"]);
                    GlogalVar.datahorarios.Add( array[i]["data"]);
                }


            }
        }
        public void jsonexames(string link)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(link);

                JObject joResponse = JObject.Parse(json);

                JArray array = (JArray)joResponse["exames"];
                int lenght = array.Count();
                for (int i = 0; i < lenght; i++)
                {
                    GlogalVar.idexames.Add(array[i]["id"]);
                    GlogalVar.aluno_idexames.Add(array[i]["aluno_id"]);
                    GlogalVar.notaexames.Add(array[i]["nota"]);
                    GlogalVar.disciplinaexames.Add(array[i]["disciplina"]);
                    GlogalVar.dataexames.Add(array[i]["data"]);
                }
            }
        }
        public void jsonprofessores(string link)
        {
            using (var webClient = new System.Net.WebClient())
            {
                string json = webClient.DownloadString(link);

                JObject joResponse = JObject.Parse(json);

                JArray array = (JArray)joResponse["professor"];
                int lenght = array.Count();
                
                for (int i = 0; i < lenght; i++)
                {
                    GlogalVar.idprofessor.Add(array[i]["id"]);
                    GlogalVar.nomeprofessor.Add (array[i]["nome"]);
                    GlogalVar.moradaprofessor.Add(array[i]["morada"]);
                    GlogalVar.telefoneprofessor.Add(array[i]["telefone"]);
                    GlogalVar.biprofessor.Add(array[i]["bi"]);
                    GlogalVar.disciplinas_idprofessor.Add(array[i]["disciplinas_id"]);
                    GlogalVar.login_idprofessor.Add(array[i]["login_id"]);

                }
            }
        }
        public void jsonpropinas(string link)
        {
            using (var webClient = new System.Net.WebClient())
            {
                string json = webClient.DownloadString(link);

                JObject joResponse = JObject.Parse(json);

                JArray array = (JArray)joResponse["propinas"];
                int lenght = array.Count();

                for (int i = 0; i < lenght; i++)
                {
                    GlogalVar.idpropinas.Add(array[i]["id"]);
                    GlogalVar.pagopropinas.Add(array[i]["pago"]);
                    GlogalVar.aluno_idpropina.Add(array[i]["aluno_id"]);
                    GlogalVar.mespropina.Add(array[i]["mes"]);

                }
            }
        }
        public void jsondisciplinas(string link)
        {
            using (var webClient = new System.Net.WebClient())
            {
                string json = webClient.DownloadString(link);

                JObject joResponse = JObject.Parse(json);

                JArray array = (JArray)joResponse["disciplinas"];
                int lenght = array.Count();

                for (int i = 0; i < lenght; i++)
                {
                    GlogalVar.iddisciplina.Add(array[i]["id"]);
                    GlogalVar.nomedisciplina.Add(array[i]["nome"]);
                    GlogalVar.horasdisciplina.Add(array[i]["nota"]);
                    GlogalVar.aluno_iddisciplina.Add(array[i]["aluno_id"]);
                }
            }
        }
    }
}
