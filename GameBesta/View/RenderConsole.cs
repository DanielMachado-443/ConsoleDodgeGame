using System;
using GameBesta.Controllers;
using System.Threading;
using System.Threading.Tasks;

namespace GameBesta.View {
    class RenderConsole {
        public static void RenderTable(string[,] table, AController controller) {
            Console.WriteLine("\n");
            var oriColor = Console.ForegroundColor;
            foreach (string str in table) {
                if(str == ":::|" + "<=>" + "|") {                                             
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (str == ":::|" + controller.Player.ToString() + "|") {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                if (str == "    ##   " || str == ":::   ## \n\n") {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.Write(str);
                Console.ForegroundColor = oriColor;                
            }            
        }

        public static string[,] MakeThePlayerAppearInTheActualPosition(AController controller) {         // << wrong place to have game mechanics                                  
            controller.Table1[controller.Player.Position.X, controller.Player.Position.Y] = ":::|" + controller.Player.ToString() + "|";
            return controller.Table1;
        }

        public static string[,] MakeTheSpydersAppearInTheRightPosition(AController controller) {         // << wrong place to have game mechanics               
            for (int i = 0; i < controller.Spyders.Count; i++) {
                controller.Table1[controller.Spyders[i].Position.X, controller.Spyders[i].Position.Y] = ":::|" + controller.Spyders[i].ToString() + "|";                               
            }
            return controller.Table1;
        }
    }
}
