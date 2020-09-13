namespace FSM {
    public class ArousalState : State {

        public ArousalState() {
            Name = "Arousal";
        }

        public override void Enter() {
            StateStatusController.Instance.BroadcastStatusChange($"Entering a State of Arousal");
        }

        public override void Execute() {
        }

        public override void Exit() {
            StateStatusController.Instance.BroadcastStatusChange($"Leaving a State of Arousal");
        }
    }
}