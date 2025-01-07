using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(object product)
        {
            InitializeComponent();
            BindingContext = product;
        }

        public void Back(Object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}