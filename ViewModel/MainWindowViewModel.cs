using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Documents;
using System.Windows.Input;
using TicTacToe.Model;

namespace TicTacToe.ViewModel
{
    public class MainWindowViewModel: ObservableObject
    {
        private string _title;

        public string Title {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _player = "X";

        public string Player
        {
            get => _player;
            set => SetProperty(ref _player, value);
        }

        public TicTacToeModel ticTacToe { get; set; }

        public RelayCommand<string> MakeMoveCommand { get; }

        // todo: take square index and mark it as "X" or "O"
        private void MakeMove()
        {
            if (Player == "O")
            {
                Player = "X";
            }
            else if (Player == "X")
            {
                Player = "O";
            }
        }

        private bool CanExecuteMakeMoveCommand(string? parameter)
        {
            return parameter != null ? true : false;
        }

        private void ExecuteMakeMoveCommand(string? parameter)
        {
            if (parameter != null)
            {
                // todo: add "parameter" in list of squares
            } 
        }

        public MainWindowViewModel()
        {
            _title = "Welcome to tic tac toe!";
            ticTacToe = new TicTacToeModel();
            MakeMoveCommand = new RelayCommand<string>(ExecuteMakeMoveCommand, CanExecuteMakeMoveCommand);
        }

    }
}
