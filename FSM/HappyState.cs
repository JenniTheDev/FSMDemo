namespace FSM {
    public class HappyState : State {

        public HappyState() {
            Name = "Happy";
        }

        public override void Enter() {
            StateStatusController.Instance.BroadcastStatusChange($"Entering a State of Happiness");
        }

        public override void Execute() {
        }

        public override void Exit() {
            StateStatusController.Instance.BroadcastStatusChange($"Leaving a State of Happiness");
        }
    }
}