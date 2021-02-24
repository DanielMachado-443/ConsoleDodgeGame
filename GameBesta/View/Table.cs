namespace GameBesta.LogicServices {
    class Table {
        public static string[,] setTable() {

            string[,] Table = new string[18, 12];

            for (int x = 0; x < 18; x++) {
                for (int y = 0; y < 12; y++) {
                    if (y == 0) {
                        Table[x, y] = "    ##   ";
                    }
                    if (y == 11) {
                        Table[x, y] = ":::   ## \n\n";
                    }
                    if(y != 0 && y != 11){
                        Table[x, y] = ":::|   |";
                    }
                }
            }
            return Table;
        }
    }
}
