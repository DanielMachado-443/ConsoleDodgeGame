using System;
using GameBesta.Controllers;

namespace GameBesta.View {
    class RenderConsole {
        public static void RenderTable(string[,] table) {
            Console.WriteLine("\n");
            foreach (string str in table) {
                Console.Write(str);
            }            
        }

        public static string[,] ChangeAPlayerPosition(AController controller) {         // << wrong place to have game mechanics                                  
            controller.Table1[controller.Player.Position.X, controller.Player.Position.Y] = "   |" + controller.Player.ToString() + "|";
            return controller.Table1;
        }        
    }
}
