namespace FSM {
    public abstract class State {
        public string Name { get; protected set; } = string.Empty;

        public abstract void Enter();

        public abstract void Execute();

        public abstract void Exit();
    }
}