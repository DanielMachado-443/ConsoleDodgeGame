using System.Collections.Generic;
using GameBesta.LogicServices;
using GameBesta.Model;
using GameBesta.View;
using System.Threading;
using System.Threading.Tasks;


namespace GameBesta.Controllers {
    class AController {
        public List<Spyder> Spyders { get; set; } = new List<Spyder>();
        public Mob Spyder { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public Player Player { get; set; }
        public ICollection<Weapon> Weapons { get; set; } = new List<Weapon>();
        public Weapon Weapon { get; set; }
        public string[,] Table1 { get; set; }
        public string[,] auxTable { get; set; } // << FRESH TABLE
        public Position auxPos { get; set; }     
        public PosAndChar PosAndChar { get; set; }

        public AController() {
            Table1 = Table.setTable(); // setTable method returns a string[] array
        }

        public AController(List<Spyder> spyders, Spyder spyder, Player player, Weapon weapon) {
            Spyders = spyders;
            Spyder = spyder;
            Player = player;
            Weapon = weapon;

            Table1 = Table.setTable(); // setTable method returns a string[] array
            auxTable = Table.setTable(); // FRESH TABLE
        }

        public AController(Player player, List<Spyder> spyders) {
            Spyders = spyders;
            Player = player;

            Table1 = Table.setTable(); // setTable method returns a string[] array
            auxTable = Table.setTable(); // FRESH TABLE
        }        

        public AController(List<Player> players, Spyder spyder) {
            Spyder = spyder;
            Players = players;

            Table1 = Table.setTable(); // setTable method returns a string[] array
            auxTable = Table.setTable(); // FRESH TABLE
        }        

        public string[,] RefreshTable() { // << IMPORTANT!!!
            return Table.setTable();
        }        

        public void AddMobs(Spyder mob) {
            Spyders.Add(mob);
        }

        public void RemoveMobs(Spyder mob) {
            Spyders.Remove(mob);
        }        
    }
}
