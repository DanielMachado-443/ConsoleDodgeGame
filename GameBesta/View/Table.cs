namespace GameBesta.LogicServices {
    class Table {
        public static string[,] setTable() {

            string[,] Table = new string[18, 20];

            for (int x = 0; x < 18; x++) {
                for (int y = 0; y < 20; y++) {
                    if (y == 0) {
                        Table[x, y] = "    ##   ";
                    }
                    if (y == 19) {
                        Table[x, y] = "    ## \n\n";
                    }
                    if(y != 0 && y != 19){
                        Table[x, y] = "   |   |";
                    }
                }
            }
            return Table;
        }
    }
}
