using System;
using System.Threading;
using System.Threading.Tasks;
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

            int A_verifier = 0; // restoring the neultral value outside of the if scoope
            int D_verifier = 0; // restoring the neultral value outside of the if scoope
            int W_verifier = 0; // restoring the neultral value outside of the if scoope
            int S_verifier = 0; // restoring the neultral value outside of the if scoope

            while (true) {
                Console.Clear();
                RenderConsole.RenderTable(RenderConsole.MakeTheObjectsAppearInTheActualPosition(Controller1), Controller1);

                if (A_verifier <= 3 && D_verifier <= 3 && W_verifier <= 3 && S_verifier <= 3) {
                    Thread.Sleep(100);
                    Controller1.PosAndChar = GameLogics.MovingThePlayer(thisInputLayer.OnClicks());   // MovingThePlayer method gets a char as parameter, while OnClicks returns a char || NOW IT RETURNS A PLAYER 
                    char thatChar = Controller1.PosAndChar.Character;
                    if (thatChar == 'a') {
                        A_verifier++;
                    }
                    if (thatChar == 'd') {
                        D_verifier++;
                    }
                    if (thatChar == 'w') {
                        W_verifier++;
                    }
                    if (thatChar == 'a') {
                        S_verifier++;
                    }

                    //==========================================================

                    if (A_verifier == 4) {
                        Thread.Sleep(100);
                        A_verifier = 0;
                    }
                    if (D_verifier == 4) {
                        Thread.Sleep(100);
                        D_verifier = 0;
                    }
                    if (W_verifier == 4) {
                        Thread.Sleep(100);
                        W_verifier = 0;
                    }
                    if (S_verifier == 4) {
                        Thread.Sleep(100);
                        S_verifier = 0;
                    }
                }
                
                GameLogics.MovingTheSpyders();

                Controller1.Table1 = Controller1.RefreshTable();

                RenderConsole.MakeTheObjectsAppearInTheActualPosition(Controller1);                
            }
        }
    }
}
