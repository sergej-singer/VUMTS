namespace VUMTS
{
    internal partial class FormMain : Form, IView
    {
        internal FormMain()
        {
            InitializeComponent();
        }

        void IView.DisplayDistance(int newDistance)
        {
            textBoxDistance.Text = newDistance.ToString();       
        }

        void IView.SwitchButtonStartUltrasonic(bool isActive)
        {
            buttonUltrasonic.Text = isActive ? "Stop Measurements" : "Start Measurements";
        }

        event EventHandler IView.ButtonStartUltrasonic_Click
        {
            add => buttonUltrasonic.Click += value;
            remove => buttonUltrasonic.Click -= value;
        }
    }
}
