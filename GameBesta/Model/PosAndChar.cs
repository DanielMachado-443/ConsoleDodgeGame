namespace GameBesta.Model {
    class PosAndChar {
        public char Character { get; set; }
        public Position Pos { get; set; }

        public PosAndChar(char character, Position pos) {
            Character = character;
            Pos = pos;
        }
    }
}
