using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Lab9.ViewModel
{
    class RegisterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string userNane;
        public string passWord;
        public string showOutput;
        public Command Register { get; }
        public Command Back { get; }

        public string UserName
        {
            get => userNane;
            set
            {
                userNane = value;
                var args = new PropertyChangedEventArgs(nameof(UserName));
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

        public RegisterViewModel()
        {
            Register = new Command(() =>
            {
                this.ShowOutput = "Username: " + UserName + ", Password: " + PassWord;
            });

            Back = new Command(() =>
            {
                this.ShowOutput = "";
            });
        }
    }
}
