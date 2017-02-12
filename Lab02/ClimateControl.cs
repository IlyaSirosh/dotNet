using System;

namespace ClimateCtrl{
    delegate void TE (int degreesС);

    class ClimateControl{
        
        private Conditioner conditioner;
        private int temperature;

        private bool working;

        public ClimateControl( int temp = 25){
            this.conditioner = new Conditioner();
            this.temperature = temp;
            this.working = false;
        }

        public void on(){
            working = true;
        }
        public void off(){
            working = false;
            conditioner.off();

        }

        public void setTemperature(int temp){
            temperature = temp;
        }


        public void tchange(int temp){
            if( working){
                if(temp == temperature){
                    if(conditioner.working())
                        conditioner.off();
                }        
                else {
                    if(!conditioner.working())
                        conditioner.on();

                    if( temp > temperature)
                        conditioner.onCooling();   
                    else
                        conditioner.onHeating();     
                }

                Console.WriteLine("Current t={0}, goal={1}, conditioner status={2}",temp,temperature,conditioner.getStatus());
            }
        }
        public void connect(Thermometer t){
            t.TemperatureChangeEvent+=tchange;
        }

        override
        public string ToString(){
            return working?"ClimateControl: t=" +temperature+ ", conditioner status="+conditioner.getStatus():"ClimateControl";
        }
    }


    class Conditioner{

        private const string HEATING = "Heating";
        private const string COOLING = "Cooling";
        private bool Working;

        private string status;

        public Conditioner(){
            this.Working = false;
        }

        public bool working(){
            return this.Working;
        }

        public void on(){
            Working = true;
        }

        public void off(){
            Working = false;
        }

        public void onHeating(){
            status = HEATING;
        }

        public void onCooling(){
            status = COOLING;
        }

        public string getStatus(){
            return Working?status: "OFF";
        }

    }


    class Thermometer{

        public event TE TemperatureChangeEvent;

        private int temperature;

        public Thermometer(int temperature=25){
            this.temperature = temperature;
        }

        public void  setTemperature(int temperature){
            this.temperature = temperature;
            TemperatureChangeEvent(temperature);
        }

        public int getTemperature(){
            return temperature;
        }
        
        override
        public string ToString(){
            return "T: "+temperature+"C";
        }
    

    }

}