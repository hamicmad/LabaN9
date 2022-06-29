using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaN9
{
    public class RailwayStation
    {
        List<Train> trains { get; set; } = new();
        public void AddTrain(Train train1, Train train2, Train train3)
        {
            trains.Add(train1);
            trains.Add(train2);
            trains.Add(train3);
        }

        //вывод информации о поезде с помощью индекса;
        public Train GetTrainInfo(int index)
        {
            return trains.ElementAt(index);
        }

        //вывод информации о поездах, отправляющихся после введенного с клавиатуры времени;
        public List<Train> GetTrainAfterTime(TimeOnly time)
        {
            return trains.Where(x => x.DepartureTime > time).ToList();
        }

        //вывод информации о поездах, отправляющихся в заданный пункт назначения.
        public List<Train> GetInfoTrainsDestination(string destination)
        {
            return trains.Where(x => x.DestinationName == destination).ToList();
        }

        //Информация должна быть отсортирована по номеру поезда.
        public List<Train> SortTrains()
        {
            return trains.OrderBy(x => x.TrainName).ToList();
        }
    }
}
