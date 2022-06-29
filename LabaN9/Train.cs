using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaN9
{
    public class Train
    {
        public string DestinationName { get; set; }
        public string TrainName { get; set; }
        public TimeOnly DepartureTime { get; set; }

        public Train(string desnationName, string trainName, TimeOnly departureTime)
        {
            DestinationName = desnationName;
            TrainName = trainName;
            DepartureTime = departureTime;
        }
        public override string ToString()
        {
            return $"Номер: {TrainName},пункт назначение: {DestinationName}, время отправления: {DepartureTime}.";
        }

        public static bool operator >=(Train train1, Train train2)
        {
            return train1.DepartureTime >= train2.DepartureTime;
        }
        public static bool operator <=(Train train1, Train train2)
        {
            return train1.DepartureTime <= train2.DepartureTime;
        }

        public static bool operator ==(Train train1, Train train2)
        {
            return train1.DepartureTime == train2.DepartureTime;
        }
        public static bool operator !=(Train train1, Train train2)
        {
            return train1.DepartureTime != train2.DepartureTime;
        }
    }
}
