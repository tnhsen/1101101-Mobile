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
    public partial class PageContent : TabbedPage
    {
        public PageContent()
        {
            InitializeComponent();
        }
    }
}