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
                    string id = array[i]["id"].ToString();
                    string nome = array[i]["nome"].ToString();
                    string turma = array[i]["turma"].ToString();
                    string curso = array[i]["curso"].ToString();
                    string idade = array[i]["idade"].ToString();
                    string telefone = array[i]["telefone"].ToString();
                    string morada = array[i]["morada"].ToString();
                    string bi = array[i]["bi"].ToString();
                    string login_id = array[i]["login_id"].ToString();
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
                    string id = array[i]["id"].ToString();
                    string disciplina = array[i]["disciplina"].ToString();
                    string professor = array[i]["professor"].ToString();
                    string data = array[i]["data"].ToString();
                }


            }
        }
        public void jsonexames(string link)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(link);

                JObject joResponse = JObject.Parse(json);

                JArray array = (JArray)joResponse["Horarios"];
                int lenght = array.Count();
                for (int i = 0; i < lenght; i++)
                {
                    string id = array[i]["id"].ToString();
                    string aluno_id = array[i]["aluno_id"].ToString();
                    string nota = array[i]["nota"].ToString();
                    string disciplina = array[i]["disciplina"].ToString();
                    string data = array[i]["data"].ToString();
                }
            }
        }
        public void jsonprofessores(string link)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(link);

                JObject joResponse = JObject.Parse(json);

                JArray array = (JArray)joResponse["Horarios"];
                int lenght = array.Count();
                ArrayList id = new ArrayList();
                ArrayList nome = new ArrayList();
                ArrayList morada = new ArrayList();
                ArrayList telefone = new ArrayList();
                ArrayList bi = new ArrayList();
                ArrayList disciplinas_id = new ArrayList();
                ArrayList login_id = new ArrayList();
                for (int i = 0; i < lenght; i++)
                {
                     id.Add(array[i]["id"].ToString());
                     nome.Add (array[i]["nome"].ToString());
                     morada.Add(array[i]["morada"].ToString());
                     telefone.Add(array[i]["telefone"].ToString());
                     bi.Add(array[i]["bi"].ToString());
                     disciplinas_id.Add(array[i]["disciplinas_id"].ToString());
                     login_id.Add(array[i]["login_id"].ToString());

                }
            }
        }
    }
}
