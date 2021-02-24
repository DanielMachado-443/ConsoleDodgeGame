using System.Collections.Generic;

namespace GameBesta.Model {
    class Spyder : Mob{
        public Position Position { get; set; }
        public string Shape { get; set; }
        private State State { get; set; } = State.Agressive;
        public Spyder(Position position) {
            Position = position;
            Shape = "|||\n"
                + "--O--\n"
                + "|||";
        }

        public void changePosition(Position newPos) {
            Position = newPos;
        }

        public void changeState(State state) {
            State = state;
        }

        public override double Damagee() {
            return State == 0 ? Damage * 1.5 : Damage * 0.5;
        }
    }
}
