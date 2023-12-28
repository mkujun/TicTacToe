using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace TicTacToe.ViewModel
{
    public class MainWindowViewModel: ObservableObject
    {
        private string _title;

        public string Title {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _player = "Player 1";

        public string Player
        {
            get => _player;
            set => SetProperty(ref _player, value);
        }

        public ICommand MakeMoveCommand { get; }

        private void MakeMove()
        {
            Player = "pero";
        }

        public MainWindowViewModel()
        {
            MakeMoveCommand = new RelayCommand(MakeMove);
            _title = "Welcome to tic tac toe!";
        }

    }
}
