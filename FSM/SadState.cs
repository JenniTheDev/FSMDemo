namespace FSM {
    public class SadState : State {

        public SadState() {
            Name = "Sad";
        }

        public override void Enter() {
            StateStatusController.Instance.BroadcastStatusChange($"Entering a State of Sadness");
        }

        public override void Execute() {
        }

        public override void Exit() {
            StateStatusController.Instance.BroadcastStatusChange($"Exiting a State of Sadness");
        }
    }
}