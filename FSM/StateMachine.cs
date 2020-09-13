using System;
using System.Collections.Generic;

namespace FSM {
    public class StateMachine {
        public State Current { get; private set; } = null;
        public HashSet<State> States { get; private set; } = new HashSet<State>();
        public Action OnStateChange;

        #region Constructors

        public StateMachine(params State[] initStates) {
            foreach(State s in initStates) {
                AddState(s);
            }
        }

        #endregion Constructors

        #region Class Methods

        public void ChangeState(State toState) {
            if(toState == null) { throw new ArgumentNullException(); }
            if(Current != null) { Current.Exit(); }

            Current = toState;
            OnStateChange?.Invoke();
            Current.Enter();
        }

        public void ChangeState(string toState) {
            foreach(State s in States) {
                if(s.Name == toState) {
                    ChangeState(s);
                }
            }
        }

        public void AddState(State stateToAdd) {
            if(!States.Contains(stateToAdd)) {
                States.Add(stateToAdd);
            }
        }

        public void RemState(State stateToRemove) {
            if(States.Contains(stateToRemove)) {
                States.Remove(stateToRemove);
            }
        }

        #endregion Class Methods
    }
}