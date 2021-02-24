using GameBesta.Controllers;
using GameBesta.LogicServices;
using GameBesta.Model;

namespace GameBesta {
    class Program {
        static void Main(string[] args) {   
            
            CreateGame createThisGame = new CreateGame();
            MainLoop MainLoop = new MainLoop(createThisGame.CreateAGame()); // a table from model(Table) and a controller Controllers(CreateGame)            
            MainLoop.Loop();            
        }
    }
}
