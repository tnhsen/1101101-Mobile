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
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduct = e.CurrentSelection.FirstOrDefault(); // รับสินค้าที่เลือก
            if (selectedProduct != null)
            {
                // ไปที่หน้ารายละเอียดสินค้า
                await Navigation.PushAsync(new DetailPage(selectedProduct));

                // ล้างการเลือก
                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}