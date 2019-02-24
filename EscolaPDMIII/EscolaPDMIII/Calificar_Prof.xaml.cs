using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaPDMIII.MyDataSource;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EscolaPDMIII
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calificar_Prof : ContentPage
	{
        AlunoView alunoView = new AlunoView ();
		public Calificar_Prof ()
		{
			InitializeComponent ();
            alunoView = new AlunoView ();
            FindByName("Aluno");
            AlunoPicker.ItemsSource = alunoView.Alunos;
        }


        private void Aluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AlunoPicker.Items[AlunoPicker.SelectedIndex]
        }
    }
}