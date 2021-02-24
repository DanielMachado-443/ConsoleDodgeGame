using System;
using GameBesta.Controllers;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GameBesta.LogicServices {
    class InputLayer {
        public AController Controller1 { get; set; }

        public InputLayer() {
        }

        public InputLayer(AController controller) {
            Controller1 = controller;
        }

        public char OnClicks() {

            ConsoleKeyInfo whatKey = Console.ReadKey();
            var whatKeyChar = whatKey.KeyChar;

            if (whatKeyChar == 'a' || whatKeyChar == 'A') {
                return 'a';
            }
            else if (whatKeyChar == 'd' || whatKeyChar == 'D') {
                return 'd';
            }
            else if (whatKeyChar == 'w' || whatKeyChar == 'W') {
                return 'w';
            }
            else if (whatKeyChar == 's' || whatKeyChar == 'S') {
                return 's';
            }
            return 'f';
        }
    }
}
