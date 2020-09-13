using System;
using System.Windows;

namespace FSM {
    public sealed class StateStatusController {
        private static readonly StateStatusController instance = new StateStatusController();

        public static StateStatusController Instance { get { return instance; } }

        public Action<string> OnStatusChange;

        private StateStatusController() { }

        public void BroadcastStatusChange(string status) {
            OnStatusChange?.Invoke(status);
            MessageBox.Show("Click Ok To Continue");
        }
    }
}