using System;

namespace Transportation
{
    public class TransportType
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int NumWheels { get; set; }
        public string Color { get; set; }
        public string EngineSize { get; set; }

        public int GetMph(int value)
        {
            return value;
        }

        public int GetMpg(int value1, int value2)
        {
            return value1 * value2;
        }

        public string GetTreadWear(int miles, int temp, int tread)
        {
            string condition = " ";
            if (temp != 0)
            {
                int calcOne = (miles * 4) / temp;
                double calcTwo = tread * 0.5;
                if (calcOne < calcTwo)
                {
                    condition = "Unsafe";
                }
                else
                {
                    condition = "Safe";
                }
            }
            else
            {
                condition = "Invalid Entry";
            }
            return condition;
        }
    }
}