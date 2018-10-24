using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Hello
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBindingPage : ContentPage
    {
        public DataBindingPage()
        {
            InitializeComponent();

            Aluno aluno = inicializarAluno();
            BindingContext = aluno;
        }

        private Aluno inicializarAluno()
        {
            Aluno aluno = new Aluno()
            {
                Id = Guid.NewGuid(),
                Nome = "Albert",
                Email = "albert.lopes@gmail.com"
            };
            return aluno;
        }
    }
}