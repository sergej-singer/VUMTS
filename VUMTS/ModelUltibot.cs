using System;
using System.IO.Ports;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VUMTS
{
    public class ModelUltibot : IModelUltibot
    {
        private SerialPort _serialPort;
        private int _distance = 0;

        public ModelUltibot()
        {
            _serialPort = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.DataReceived += new SerialDataReceivedEventHandler(OnDataReceived);
        }

        int IModelUltibot.Distance
        {
            get => _distance;
        }

        void IModelUltibot.StartContinuousDistanceMeasurement()
        {
            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
            }
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string message = _serialPort.ReadExisting();

                if (message.Contains("J"))
                    message = message.Split('J')[1];
                if (message.Contains("\n"))
                    message = message.Split('\r')[0];
                if (message != "")
                {
                    _distance = Convert.ToInt32(message);
                    Thread.Sleep(50);
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        void IModelUltibot.StopContinuousDistanceMeasurement()
        {
            if (_serialPort.IsOpen)
                _serialPort.Close();
        }
    }
}
