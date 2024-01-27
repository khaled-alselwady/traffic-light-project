using System;
using System.Drawing;
using System.Windows.Forms;
using Traffic_Light_Project.Properties;

namespace Traffic_Light_Project
{
    public partial class ucTrafficLight : UserControl
    {
        public enum enTrafficLight { Red = 1, Orange = 2, Green = 3 };

        private enTrafficLight _PreviousLight = enTrafficLight.Green;
        private enTrafficLight _CurrentLight = enTrafficLight.Red;
        public enTrafficLight CurrentLight
        {
            get => _CurrentLight;

            set
            {
                _PreviousLight = _CurrentLight;
                _CurrentLight = value;

                switch (_CurrentLight)
                {
                    case enTrafficLight.Red:
                        pbTrafficImage.Image = Resources.Red;
                        lblTrafficTimeInSeconed.ForeColor = Color.Red;

                        //_Counter = RedTime;
                        //timer1.Start();
                        break;

                    case enTrafficLight.Orange:
                        pbTrafficImage.Image = Resources.Orange;
                        lblTrafficTimeInSeconed.ForeColor = Color.Orange;

                        //_Counter = OrangeTime;
                        //timer1.Start();
                        break;

                    case enTrafficLight.Green:
                        pbTrafficImage.Image = Resources.Green;
                        lblTrafficTimeInSeconed.ForeColor = Color.Green;

                        //_Counter = GreenTime;
                        //timer1.Start();
                        break;

                    default:
                        lblTrafficTimeInSeconed.ForeColor = Color.Red;
                        break;
                }
            }
        }

        private int _RedTime = 5;
        private int _OrangeTime = 3;
        private int _GreenTime = 5;

        public int RedTime
        {
            get => _RedTime;
            set => _RedTime = value;
        }
        public int OrangeTime
        {
            get => _OrangeTime;
            set => _OrangeTime = value;
        }
        public int GreenTime
        {
            get => _GreenTime;
            set => _GreenTime = value;
        }

        public int Counter;

        public ucTrafficLight()
        {
            InitializeComponent();
        }

        public class TrafficLightEventHandler : EventArgs
        {
            public enTrafficLight TrafficLight { get; }
            public int LightDuration { get; }

            public TrafficLightEventHandler(enTrafficLight TrafficLight, int LightDuration)
            {
                this.TrafficLight = TrafficLight;
                this.LightDuration = LightDuration;
            }
        }

        #region Red
        public event EventHandler<TrafficLightEventHandler> RedLightOn;
        public void RaiseRedLightOn()
        {
            RaiseRedLightOn(new TrafficLightEventHandler(enTrafficLight.Red, _RedTime));
        }
        public void RaiseRedLightOn(TrafficLightEventHandler e)
        {
            RedLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventHandler> RedLightOff;
        public void RaiseRedLightOff()
        {
            RaiseRedLightOff(new TrafficLightEventHandler(enTrafficLight.Orange, _OrangeTime));
        }
        public void RaiseRedLightOff(TrafficLightEventHandler e)
        {
            RedLightOff?.Invoke(this, e);
        }
        #endregion

        #region Orange
        public event EventHandler<TrafficLightEventHandler> OrangeLightOn;
        public void RaiseOrangeLightOn()
        {
            RaiseOrangeLightOn(new TrafficLightEventHandler(enTrafficLight.Orange, _OrangeTime));
        }
        public void RaiseOrangeLightOn(TrafficLightEventHandler e)
        {
            OrangeLightOn?.Invoke(this, e);
        }
        #endregion

        #region Green
        public event EventHandler<TrafficLightEventHandler> GreenLightOn;
        public void RaiseGreenLightOn()
        {
            RaiseGreenLightOn(new TrafficLightEventHandler(enTrafficLight.Green, _GreenTime));
        }
        public void RaiseGreenLightOn(TrafficLightEventHandler e)
        {
            GreenLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventHandler> GreenLightOff;
        public void RaiseGreenLightOff()
        {
            RaiseGreenLightOff(new TrafficLightEventHandler(enTrafficLight.Orange, _OrangeTime));
        }
        public void RaiseGreenLightOff(TrafficLightEventHandler e)
        {
            GreenLightOff?.Invoke(this, e);
        }
        #endregion

        public void Start()
        {
            Counter = GetCurrentTime();
            timer1.Start();
        }

        public void Stop()
        {
            _Reset();
            timer1.Stop();
        }

        private void _ResetLabelTimer()
        {
            lblTrafficTimeInSeconed.Text = _RedTime.ToString();
        }

        private void _Reset()
        {
            CurrentLight = enTrafficLight.Red;
            _ResetLabelTimer();
        }

        public int GetCurrentTime()
        {
            switch (_CurrentLight)
            {
                case enTrafficLight.Orange:
                    return OrangeTime;

                case enTrafficLight.Green:
                    return GreenTime;

                case enTrafficLight.Red:
                    return RedTime;

                default:
                    return RedTime;
            }
        }

        private void _ChangeLight()
        {
            switch (_CurrentLight)
            {
                case enTrafficLight.Red:

                    CurrentLight = enTrafficLight.Orange;
                    _PreviousLight = enTrafficLight.Green;
                    Counter = OrangeTime;
                    lblTrafficTimeInSeconed.Text = Counter.ToString();

                    RaiseOrangeLightOn();

                    break;

                case enTrafficLight.Orange:
                    if (_PreviousLight == enTrafficLight.Green)
                    {
                        CurrentLight = enTrafficLight.Green;
                        Counter = GreenTime;
                        lblTrafficTimeInSeconed.Text = Counter.ToString();

                        RaiseGreenLightOn();
                    }
                    else
                    {
                        CurrentLight = enTrafficLight.Red;
                        Counter = RedTime;
                        lblTrafficTimeInSeconed.Text = Counter.ToString();

                        RaiseRedLightOn();
                        
                    }

                    break;

                case enTrafficLight.Green:
                    CurrentLight = enTrafficLight.Orange;
                    _PreviousLight = enTrafficLight.Red;
                    Counter = OrangeTime;
                    lblTrafficTimeInSeconed.Text = Counter.ToString();

                    RaiseOrangeLightOn();
                    RaiseGreenLightOff();

                    break;

                default:
                    pbTrafficImage.Image = Resources.Red;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTrafficTimeInSeconed.Text = Counter.ToString();

            if (Counter == 0)
                _ChangeLight();
            else
                --Counter;
        }
    }
}
