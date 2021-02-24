using System;
using System.Threading;
using GameBesta.Controllers;
using GameBesta.View;

namespace GameBesta.LogicServices {
    class MainLoop {
        private AController Controller1 = new AController();
        private GameLogics GameLogics = new GameLogics();
        private InputLayer thisInputLayer = new InputLayer();

        public MainLoop(AController controller) {
            Controller1 = controller;
            thisInputLayer.Controller1 = controller;
            GameLogics.thatController = controller;
        }

        public void Loop() {
            while (true) {
                Console.Clear();

                Controller1.PlayerPositionRender(); // theoreticlly updated the Controller1.Table
                GameLogics.MovingThePlayer(thisInputLayer.OnClicks());   // MovingThePlayer method gets a char as parameter, while OnClicks returns a char || NOW IT RETURNS A PLAYER     
                Controller1.Table1 = Controller1.RefreshTable();
                RenderConsole.ChangeAPlayerPosition(Controller1);                
            }                                
        }
    }
}
