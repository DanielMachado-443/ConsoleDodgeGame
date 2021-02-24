using System.Collections.Generic;
using GameBesta.Model;
using GameBesta.Controllers;

namespace GameBesta.LogicServices {
    class CreateGame {
        public AController CreateAGame() {            

            Player player1 = new Player("Daniel",
                new Position(8, 7),               
                100,
                2,
                new Weapon(10, "Ace"));

            List<Spyder> spyders = new List<Spyder>();
            spyders.Add(new Spyder(new Position(7, 1)));
            spyders.Add(new Spyder(new Position(2, 2)));
            spyders.Add(new Spyder(new Position(15, 3)));
            spyders.Add(new Spyder(new Position(5, 4)));
            spyders.Add(new Spyder(new Position(11, 5)));
            spyders.Add(new Spyder(new Position(3, 6)));
            spyders.Add(new Spyder(new Position(9, 7)));
            spyders.Add(new Spyder(new Position(12, 8)));
            spyders.Add(new Spyder(new Position(8, 9)));
            spyders.Add(new Spyder(new Position(2, 10)));
            spyders.Add(new Spyder(new Position(7, 8)));
            spyders.Add(new Spyder(new Position(2, 5)));
            spyders.Add(new Spyder(new Position(15, 4)));
            spyders.Add(new Spyder(new Position(5, 8)));
            spyders.Add(new Spyder(new Position(11, 9)));
            spyders.Add(new Spyder(new Position(3, 9)));
            spyders.Add(new Spyder(new Position(9, 6)));
            spyders.Add(new Spyder(new Position(12, 2)));
            spyders.Add(new Spyder(new Position(8, 8)));
            spyders.Add(new Spyder(new Position(2, 7)));

            AController controller = new AController(player1, spyders);
            
            return controller;
        }
    }
}
