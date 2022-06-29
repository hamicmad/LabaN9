using LabaN9;
RailwayStation railwayStation = new();


//1•	вывод информации о поезде с помощью индекса;
//2•	вывод информации о поездах, отправляющихся после введенного с клавиатуры времени;
//•	перегруженную операцию сравнения, выполняющую сравнение времени отправления двух поездов;
//4•	вывод информации о поездах, отправляющихся в заданный пункт назначения.
//5•	Информация должна быть отсортирована по номеру поезда.


var train1 = new Train("Озерище", "12C9", new TimeOnly (7,00));
var train2 = new Train("Минск-Восточный", "11A10", new TimeOnly(7, 30));
var train3 = new Train("Минск-Западный", "10B11", new TimeOnly(7, 45));

railwayStation.AddTrain(train1, train2, train3);

Console.WriteLine(railwayStation.GetTrainInfo(0).ToString() + "    Task 1");
var res2 = railwayStation.GetTrainAfterTime(new TimeOnly(7, 15));
foreach(var item in res2)
{
    Console.WriteLine(item.ToString() +        "     Task 2");
}

var res4 = railwayStation.GetInfoTrainsDestination("Озерище");
foreach(var item in res4)
{
    Console.WriteLine(item.ToString() + "   Task 4");
}


var res5 = railwayStation.SortTrains();
foreach (var item in res5)
{
    Console.WriteLine(item.ToString() + "5");
}


