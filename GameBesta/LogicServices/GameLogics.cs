using System;
using GameBesta.Controllers;
using GameBesta.Model;

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
                if(thatController.Player.Position.Y - 2 >= 2) {
                    return true;
                }
            }
            else if (letter == 'd') {
                if (thatController.Player.Position.Y + 2 <= 18) {
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

        public Position MovingThePlayer(char letter) {
            if (IsItPossibleToMoveThePlayer(letter)) {                

                Position pos = new Position(thatController.Player.Position.X, thatController.Player.Position.Y);

                if (letter == 'a') {
                    thatController.Player.Position.Y -= 2;
                    return pos;
                    
                }
                else if (letter == 'd') {
                    thatController.Player.Position.Y += 2;
                    return pos;
                }
                else if (letter == 'w') {
                    thatController.Player.Position.X -= 1;
                    return pos;
                }
                else if (letter == 's') {
                    thatController.Player.Position.X += 1;
                    return pos;
                }
                return pos;
            }
            return thatController.Player.Position;
        }

        public string[,] IsPossibleToRenderAPlayer() {         // << wrong place to have game mechanics                      
            thatController.Table1[thatController.Player.Position.X, thatController.Player.Position.Y - 1] = "  |";
            if (thatController.Table1[thatController.Player.Position.X, thatController.Player.Position.Y].Length <= 5) {
                thatController.Table1[thatController.Player.Position.X, thatController.Player.Position.Y] = thatController.Player.ToString() + "| ";
            }
            return thatController.Table1;
        }
    }
}
