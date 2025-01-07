using Lab9.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Lab9.ViewModel
{
    class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Products> MyProducts { get; }

        public ProductViewModel()
        {
            MyProducts = new ObservableCollection<Products>();

            Products myP1 = new Products();
            myP1.ID = 1;
            myP1.Title = "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops";
            myP1.Price = (float)109.95;
            myP1.Image = new Uri("https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg");
            MyProducts.Add(myP1);

            Products myP2 = new Products();
            myP2.ID = 2;
            myP2.Title = "Mens Casual Premium Slim Fit T-Shirts";
            myP2.Price = (float)22.3;
            myP2.Image = new Uri("https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg");
            MyProducts.Add(myP2);

            Products myP3 = new Products();
            myP3.ID = 3;
            myP3.Title = "Mens Cotton Jacket";
            myP3.Price = (float)55.99;
            myP3.Image = new Uri("https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg");
            MyProducts.Add(myP3);
        }
    }
}
