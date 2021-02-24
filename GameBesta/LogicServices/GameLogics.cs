using GameBesta.Controllers;
using GameBesta.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using GameBesta.View;

namespace GameBesta.LogicServices {
    class GameLogics {

        public AController thatController = new AController();

        public GameLogics() {
        }

        public GameLogics(AController controller) {
            thatController = controller;
        }

        public bool IsItPossibleToMoveThePlayer(char letter) {
            if (letter == 'a') {
                if (thatController.Player.Position.Y - 1 >= 1) {
                    return true;
                }
            }
            else if (letter == 'd') {
                if (thatController.Player.Position.Y + 1 <= 10) {
                    return true;
                }
            }
            else if (letter == 'w') {
                if (thatController.Player.Position.X - 1 >= 0) {
                    return true;
                }
            }
            else if (letter == 's') {
                if (thatController.Player.Position.X + 1 <= 17) {
                    return true;
                }
            }
            return false;
        }

        private bool IsThereAPlayerInTheSpyderNextPosition() {            
            foreach (Spyder spd in thatController.Spyders) {
                if (thatController.Player.Position.X == spd.Position.X && thatController.Player.Position.Y == spd.Position.Y) {
                    return true;
                }                
            }
            return false;
        }

        private bool[,] IsItPossibleToMoveTheSpyder() { 
            bool[,] aux = new bool[18, 12];

            if (!IsThereAPlayerInTheSpyderNextPosition()) {       // << second line of verification                         
                foreach (Spyder spd in thatController.Spyders) {                    
                    if(spd.Position.X + 1 > 18) {
                        aux[spd.Position.X, spd.Position.Y] = false;                        
                    }
                    else {
                        aux[spd.Position.X, spd.Position.Y] = true;
                    }
                }
                return aux;
            }
            return aux;
        }
        
        public void MovingTheSpyders() {
            bool[,] aux = IsItPossibleToMoveTheSpyder();
            
            foreach(Spyder spd in thatController.Spyders) {
                if(aux[spd.Position.X, spd.Position.Y]) { 
                    if(spd.Position.X == 17) {
                        spd.Position.X -= 17; // returns to the top
                    }
                    else {
                        spd.Position.X += 1;
                    }                    
                }
            }
            RenderConsole.MakeTheSpydersAppearInTheRightPosition(thatController);
        }

        public PosAndChar MovingThePlayer(char letter) {
            if (IsItPossibleToMoveThePlayer(letter)) {

                Position pos = new Position(thatController.Player.Position.X, thatController.Player.Position.Y);

                if (letter == 'a') {
                    thatController.Player.Position.Y -= 1;
                    return new PosAndChar(letter, pos);

                }
                else if (letter == 'd') {
                    thatController.Player.Position.Y += 1;
                    return new PosAndChar(letter, pos);
                }
                else if (letter == 'w') {
                    thatController.Player.Position.X -= 1;
                    return new PosAndChar(letter, pos);
                }
                else if (letter == 's') {
                    thatController.Player.Position.X += 1;
                    return new PosAndChar(letter, pos);
                }
                return new PosAndChar(letter, pos);
            }
            return new PosAndChar(letter, thatController.Player.Position);
        }        
    }
}
