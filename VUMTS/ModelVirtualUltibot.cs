//using System;
//using System.Collections.Generic;
//using System.IO.Ports;
//using System.Text;
//using System.Windows.Forms;

//namespace VUMTS
//{
//    internal class ModelVirtualUltibot : IModelUltibot
//    {
//        private int _distance = 0;
//        private bool _isSerialOpen = false;
//        private Queue<int> _distanceQueue = new();

//        int IModelUltibot.Distance
//        {
//            get => _distance;
//        }

//        bool IModelUltibot.DequeueDistance(out int distance) => _distanceQueue.TryDequeue(out distance);

//        async void IModelUltibot.StartContinuousDistanceMeasurement()
//        {
//            if (!_isSerialOpen) _isSerialOpen = true;

//            while (_isSerialOpen)
//            {
//                MeasureDistance();
//                _distanceQueue.Enqueue(_distance);
//                await Task.Delay(100);
//            }
//        }

//        void IModelUltibot.StopContinuousDistanceMeasurement()
//        {
//            _isSerialOpen = false;
//        }

//        private void MeasureDistance()
//        {
//            Random random = new();

//            _distance = random.Next(0, 100);
//        }
//    }
//}
