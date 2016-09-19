﻿using System;
using System.ComponentModel;
using System.Windows.Threading;

namespace SolarSystem
{
    internal class OrbitsCalculator : INotifyPropertyChanged
    {
        private DateTime startTime;
        private double startDays;
        private DispatcherTimer timer;
        private double daysPerSecond = 2;

        private const double EarthYear = 365.25;
        private const double EarthRotationPeriod = 1.0;
        private const double SunRotationPeriod = 25.0;
        // const double TwoPi = Math.PI * 2; never used and useless in general

        public double DaysPerSecond
        {
            get
            {
                return daysPerSecond;
            }

            set
            {
                daysPerSecond = value; Update("DaysPerSecond");
            }
        }

        public double EarthOrbitRadius => 40;
        public double Days { get; set; }
        public double EarthRotationAngle { get; set; }
        public double SunRotationAngle { get; set; }
        public double EarthOrbitPositionX { get; set; }
        public double EarthOrbitPositionY { get; set; }
        public double EarthOrbitPositionZ { get; set; }
        public bool ReverseTime { get; set; }
        public bool Paused { get; set; }

        public OrbitsCalculator()
        {
            EarthOrbitPositionX = EarthOrbitRadius;
            DaysPerSecond = 2;
        }

        public void StartTimer()
        {
            startTime = DateTime.Now;
            timer = new DispatcherTimer {Interval = TimeSpan.FromMilliseconds(10)};
            timer.Tick += new EventHandler(OnTimerTick);
            timer.Start();
        }

        private void StopTimer()
        {
            timer.Stop();
            timer.Tick -= OnTimerTick;
            timer = null;
        }

        public void Pause(bool doPause)
        {
            if (doPause)
            {
                StopTimer();
            }
            else
            {
                StartTimer();
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            Days += (now - startTime).TotalMilliseconds * DaysPerSecond / 1000.0 * (ReverseTime ? -1 : 1);
            startTime = now;
            Update("Days");
            OnTimeChanged();
        }

        private void OnTimeChanged()
        {
            EarthPosition();
            EarthRotation();
            SunRotation();
        }

        private void EarthPosition()
        {
            var angle = 2 * Math.PI * Days / EarthYear;
            EarthOrbitPositionX = EarthOrbitRadius * Math.Cos(angle);
            EarthOrbitPositionY = EarthOrbitRadius * Math.Sin(angle);
            Update("EarthOrbitPositionX");
            Update("EarthOrbitPositionY");
        }

        private void EarthRotation()
        {
            for (var step = 0; step <= 360; step += 1)
            {
                EarthRotationAngle = step * Days / EarthRotationPeriod;
            }
            Update("EarthRotationAngle");
        }

        private void SunRotation()
        {
            SunRotationAngle = 360 * Days / SunRotationPeriod;
            Update("SunRotationAngle");
        }

        private void Update(string propertyName)
        {
            if (PropertyChanged == null)
            {
                return;
            }
            var args = new PropertyChangedEventArgs(propertyName);
            PropertyChanged(this, args);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
