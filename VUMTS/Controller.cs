using System;
using System.Collections.Generic;
using System.Text;

namespace VUMTS
{
    internal class Controller
    {
        private readonly IModelUltibot _model;
        private readonly IView _view;
        private volatile bool _isUltrasonicCycling = false;
        
        internal Controller(IView view, IModelUltibot model)
        {
            _view = view;
            _model = model;
            _view.ButtonStartUltrasonic_Click += HandleButtonUltrasonicStart;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.Run((FormMain)view);
        }

        internal async void HandleButtonUltrasonicStart(object? sender, EventArgs e)
        {
            if (sender is not Button) return;
            if (_isUltrasonicCycling == false)
            {
                await StartUltrasonicCycle();
            }
            else
            {
                StopUltrasonicCycle();
            }
        }

        internal void HandleSerialData(object? sender, EventArgs e)
        {
            if (sender == null) return;
            _view.DisplayDistance(_model.Distance);
        }

        internal async Task StartUltrasonicCycle()
        {
            // Switch Button Text from START to STOP
            _view.SwitchButtonStartUltrasonic(true);
            _isUltrasonicCycling = true;
            _model.StartContinuousDistanceMeasurement();

            while (_isUltrasonicCycling)
            {
                _view.DisplayDistance(_model.Distance);            
                await Task.Delay(50);
            }
        }

        internal void StopUltrasonicCycle()
        {
            // Switch Button Text from STOP to START
            _view.SwitchButtonStartUltrasonic(false);
            _isUltrasonicCycling = false;
            _model.StopContinuousDistanceMeasurement();
        }
    }
}
