﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.ViewModel
{
    public class MainWindowViewModel: ObservableObject
    {
        private string _title;

        public string Title {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public MainWindowViewModel()
        {
            _title = "Welcome to tic tac toe!";
        }
    }
}