using System;
using GameBesta.Controllers;

namespace GameBesta.View {
    class RenderConsole {
        public static void RenderTable(string[,] table, AController controller) {

            Console.WriteLine("\n");
            var oriColor = Console.ForegroundColor;

            foreach (string str in table) {
                if(str == "!#!") {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (str == controller.Player.ToString()) {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                if (str == "    ##   " || str == "   ## \n\n") {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                
                Console.Write(str);
                Console.ForegroundColor = oriColor;                
            }            
        }

        public static string[,] MakeTheObjectsAppearInTheActualPosition(AController controller) {         // << wrong place to have game mechanics                                  
            
            controller.Table1[controller.Player.Position.X, controller.Player.Position.Y] = controller.Player.ToString();

            for (int i = 0; i < controller.Spyders.Count; i++) {
                controller.Table1[controller.Spyders[i].Position.X, controller.Spyders[i].Position.Y] = controller.Spyders[i].ToString();
            }

            return controller.Table1; // THIS RETURN NEEDS TO BE ANALISED           
        }

        public static string[,] MakeTheSpydersAppearInTheRightPosition(AController controller) { // << UNUSED FOR NOW               
            for (int i = 0; i < controller.Spyders.Count; i++) {
                controller.Table1[controller.Spyders[i].Position.X, controller.Spyders[i].Position.Y] = controller.Spyders[i].ToString();                               
            }
            return controller.Table1; // THIS RETURN NEEDS TO BE ANALISED
        }
    }
}
