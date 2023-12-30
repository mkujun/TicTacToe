using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class TicTacToeModel
    {
        // todo: business logic goes here...
        public List<string> _squares { get; set; }

        public TicTacToeModel()
        {
            _squares = new List<string>
            {
                "", "", "", "", "", "", "", "", ""
            };
            
        }
    }
}
