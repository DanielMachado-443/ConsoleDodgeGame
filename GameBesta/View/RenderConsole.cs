using System;
using GameBesta.Controllers;

namespace GameBesta.View {
    class RenderConsole {
        public static void RenderTable(string[,] table) {            
            foreach (string str in table) {
                Console.Write(str);
            }            
        }

        public static string[,] RenderAPlayerPosition(AController controller) {         // << wrong place to have game mechanics                      
            controller.Table1[controller.Player.Position.X, controller.Player.Position.Y - 1] = "  |";
            controller.Table1[controller.Player.Position.X, controller.Player.Position.Y] = controller.Player.ToString() + "| ";
            return controller.Table1;
        }

        public static string[,] RemoveAPlayerFromPreviousPosition(AController controller) {         // << wrong place to have game mechanics                                  
            
            controller.Table1[controller.auxPos.X, controller.auxPos.Y] = " ";

            return controller.Table1;
        }

        public static void RenderTableFromScratch(AController controller) {            
            foreach (string str in controller.auxTable) { // FREASH Table
                Console.Write(str);
            }            
        }
    }
}
