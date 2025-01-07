using Lab9.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Lab9.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Login myLogin;
        public ObservableCollection<Login> MylistLogin { get; }
        string userName;
        string passWord;
        string showOutput;
        public Command ShowCommand { get; }
        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }

        public string Email
        {
            get => userName;
            set
            {
                userName = value;
                var args = new PropertyChangedEventArgs(nameof(Email));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public string PassWord
        {
            get => passWord;
            set
            {
                passWord = value;
                var args = new PropertyChangedEventArgs(nameof(PassWord));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public string ShowOutput
        {
            get => showOutput;
            set
            {
                showOutput = value;
                var args = new PropertyChangedEventArgs(nameof(ShowOutput));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public MainPageViewModel()
        {


            ShowCommand = new Command(() => 
            {
                this.ShowOutput = "Username: " + Email + ", Password: " + PassWord;
            });

            LoginCommand = new Command(() =>
            {
                this.ShowOutput = "Username: " + Email + ", Password: " + PassWord;
            });
        }
    }
}
