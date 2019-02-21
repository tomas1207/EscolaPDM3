//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Collections.ObjectModel;
//using EscolaPDMIII.Models;
//using EscolaPDMIII.MyDataSource;

//namespace EscolaPDMIII.ViewModels
//{
//    public class NotasViewModel
//    {


//        private ObservableCollection<Notas> listNotas;
//        public ObservableCollection<Notas> ListNotas
//        {
//            get { return listNotas; }
//            set
//            {
//                listNotas = value;
//            }
//        }

//        public NotasViewModel()
//        {

//            ListNotas = new ObservableCollection<Notas>();
//            MyDataNotas _context = new MyDataNotas();

//            foreach (var human in _context.ListNotas)
//            {
//                listNotas.Add(Notas);
//            }
//        }
//    }
//}
