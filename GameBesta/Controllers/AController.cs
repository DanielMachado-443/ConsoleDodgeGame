using System.Collections.Generic;
using GameBesta.LogicServices;
using GameBesta.Model;
using GameBesta.View;


namespace GameBesta.Controllers {
    class AController {
        public ICollection<Mob> Mobs { get; set; } = new List<Mob>();
        public Mob Mob { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public Player Player { get; set; }
        public ICollection<Weapon> Weapons { get; set; } = new List<Weapon>();
        public Weapon Weapon { get; set; }
        public string[,] Table1 { get; set; }
        public string[,] auxTable { get; set; } // << FRESH TABLE
        public Position auxPos { get; set; }        

        public AController() {
            Table1 = Table.setTable(); // setTable method returns a string[] array
        }

        public AController(ICollection<Mob> mobs, Mob mob, Player player, Weapon weapon) {
            Mobs = mobs;
            Mob = mob;
            Player = player;
            Weapon = weapon;
            Table1 = Table.setTable(); // setTable method returns a string[] array

            auxTable = Table.setTable(); // FRESH TABLE
        }

        public AController(Player player, Mob mob) {            
            Mob = mob;
            Player = player;
            Table1 = Table.setTable(); // setTable method returns a string[] array

            auxTable = Table.setTable(); // FRESH TABLE
        }

        public AController(List<Player> players, Mob mob) {
            Mob = mob;
            Players = players;
            Table1 = Table.setTable(); // setTable method returns a string[] array

            auxTable = Table.setTable(); // FRESH TABLE
        }

        public void PlayerPositionRender() {
            RenderConsole.RenderTable(RenderConsole.ChangeAPlayerPosition(this));               
        }

        public string[,] RefreshTable() { // << IMPORTANT!!!
            return Table.setTable();
        }
    }
}
