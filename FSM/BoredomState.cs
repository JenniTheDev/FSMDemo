namespace FSM {
    public class BoredomState : State {

        public BoredomState() {
            Name = "Boredom";
        }

        public override void Enter() {
            StateStatusController.Instance.BroadcastStatusChange($"Entering a State of Boredom");
        }

        public override void Execute() {
        }

        public override void Exit() {
            StateStatusController.Instance.BroadcastStatusChange($"Leaving a State of Boredom");
        }
    }
}