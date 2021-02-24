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

            Mob Spd1 = new Spyder(new Position(2, 10));

            AController controller = new AController(player1, Spd1);
            
            return controller;
        }
    }
}
