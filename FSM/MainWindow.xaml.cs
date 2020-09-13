using System.Windows;
using System.Windows.Controls;

namespace FSM {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        StateMachine sm = new StateMachine();
        public MainWindow() {
            InitializeComponent();

            sm.AddState(new HappyState());
            sm.AddState(new SadState());
            sm.AddState(new ArousalState());
            sm.AddState(new BoredomState());

            statesDropDown.ItemsSource = sm.States;

            StateStatusController.Instance.OnStatusChange += UpdateStateStatus;
        }

        private void UpdateStateStatus(string status) {
            stateStatus.Text = status;
        }

        private void StatesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            State selectedState = (State) statesDropDown.SelectedItem;
            sm.ChangeState(selectedState);
        }
    }
}
