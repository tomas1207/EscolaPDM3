using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using EscolaPDMIII.Models;
namespace EscolaPDMIII.MyDataSource
{
    class MyDataNotas
    {
        public void arraylisttolist()
        {
            Array cenas = Core.GlogalVar.notaexames.ToArray();
            string cenas2 = cenas.ToString();
            ListNotas = Core.GlogalVar.notaexames;
            
        }
        public ArrayList ListNotas = new ArrayList();

        
    }
}
