using GameBesta.Controllers;
using GameBesta.LogicServices;
using GameBesta.Model;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace GameBesta {
    class Program {
        static void Main(string[] args) {

            Console.BackgroundColor = ConsoleColor.Green;

            CreateGame createThisGame = new CreateGame();
            MainLoop MainLoop = new MainLoop(createThisGame.CreateAGame()); // a table from model(Table) and a controller Controllers(CreateGame)          
            MainLoop.Loop();
        }        
    }
}
