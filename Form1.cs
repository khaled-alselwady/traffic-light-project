using System.Windows.Forms;
using static Traffic_Light_Project.ucTrafficLight;

namespace Traffic_Light_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            ucTrafficLight1.Start();
        }

        private void ucTrafficLight1_GreenLightOff(object sender, TrafficLightEventHandler e)
        {
            ucTrafficLight2.Start();
        }
      
        private void ucTrafficLight1_RedLightOn(object sender, TrafficLightEventHandler e)
        {
            ucTrafficLight1.Stop();           
        }

        private void ucTrafficLight2_GreenLightOff(object sender, TrafficLightEventHandler e)
        {
            ucTrafficLight3.Start();
        }

        private void ucTrafficLight2_RedLightOn(object sender, TrafficLightEventHandler e)
        {
            ucTrafficLight2.Stop();
        }

        private void ucTrafficLight3_GreenLightOff(object sender, TrafficLightEventHandler e)
        {
            ucTrafficLight4.Start();
        }

        private void ucTrafficLight3_RedLightOn(object sender, TrafficLightEventHandler e)
        {
            ucTrafficLight3.Stop();
        }

        private void ucTrafficLight4_GreenLightOff(object sender, TrafficLightEventHandler e)
        {
            ucTrafficLight1.Start();
        }

        private void ucTrafficLight4_RedLightOn(object sender, TrafficLightEventHandler e)
        {
            ucTrafficLight4.Stop();
        }
    }
}
