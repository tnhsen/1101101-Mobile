﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Register(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageContent());
        }

        private void Back(Object sender,EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}