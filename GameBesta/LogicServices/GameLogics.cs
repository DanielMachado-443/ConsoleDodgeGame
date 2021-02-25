using GameBesta.Controllers;
using GameBesta.Model;
using System;
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

        private bool IsItPossibleToMoveThePlayer(char letter) {
            if (letter == 'a') {
                if (thatController.Player.Position.Y - 2 >= 1) {
                    if ((thatController.Player.Position.Y - 2) % 2 == 0) { // just in case verification, not really necessary
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
            else if (letter == 'd') {
                if (thatController.Player.Position.Y + 2 <= 17) {
                    if ((thatController.Player.Position.Y + 2) % 2 == 0) { // just in case verification, not really necessary
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
            else if (letter == 'w') {
                if (thatController.Player.Position.X - 1 >= 0) {
                    return true;
                }
            }
            else if (letter == 's') {
                if (thatController.Player.Position.X + 1 <= 16) {
                    return true;
                }
            }
            return false;
        }

        public PosAndChar MovingThePlayer(char letter) {
            if (IsItPossibleToMoveThePlayer(letter)) {

                Position pos = new Position(thatController.Player.Position.X, thatController.Player.Position.Y);

                if (letter == 'a') {
                    thatController.Player.Position.Y -= 2;
                    Console.Beep(500, 75);
                    return new PosAndChar(letter, pos);                    
                }
                else if (letter == 'd') {
                    thatController.Player.Position.Y += 2;
                    Console.Beep(500, 75);
                    return new PosAndChar(letter, pos);
                }
                else if (letter == 'w') {
                    thatController.Player.Position.X -= 1;
                    Console.Beep(500, 75);
                    return new PosAndChar(letter, pos);
                }
                else if (letter == 's') {
                    thatController.Player.Position.X += 1;
                    Console.Beep(500, 75);
                    return new PosAndChar(letter, pos);
                }
                return new PosAndChar(letter, pos);
            }
            return new PosAndChar(letter, thatController.Player.Position); // Player stays stopped
        }

        // SPYDERS RULES BELLOW // SPYDERS RULES BELLOW // SPYDERS RULES BELLOW // SPYDERS RULES BELLOW // SPYDERS RULES BELLOW // SPYDERS RULES BELLOW // SPYDERS RULES BELLOW

        private bool[,] ThereIsNoPlayerInTheSpyderNextPosition() {   // NEED TO BE ANALISED     

            bool[,] aux = new bool[18, 19];

            foreach (Spyder spd in thatController.Spyders) {                
                if (thatController.Player.Position.X == spd.Position.X + 1 && thatController.Player.Position.Y == spd.Position.Y) {
                    aux[spd.Position.X + 1, spd.Position.Y] = false;
                }
                else {
                    aux[spd.Position.X + 1, spd.Position.Y] = true;
                }
            }
            return aux;
        }

        private bool[,] IsItPossibleToMoveTheSpyder() {

            bool[,] aux = ThereIsNoPlayerInTheSpyderNextPosition();

            foreach (bool obj in aux) {
                if (obj) {
                    foreach (Spyder spd in thatController.Spyders) {
                        if (spd.Position.X + 1 > 17) {
                            aux[spd.Position.X + 1, spd.Position.Y] = false;
                        } // no need of else because this BOOL obj is ALREADY TRUE;                        
                    }
                }
            }
            return aux;
        }

        public void MovingTheSpyders() {

            bool[,] aux = IsItPossibleToMoveTheSpyder();

            foreach (Spyder spd in thatController.Spyders) {
                if (aux[spd.Position.X + 1, spd.Position.Y]) { // << if this particular bool matrix position is true
                    if (spd.Position.X == 16) {
                        spd.Position.X -= 16; // returns to the top
                    }
                    else {
                        spd.Position.X += 1;
                    }
                }
            }               
        }        
    }
}
