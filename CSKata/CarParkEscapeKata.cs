using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSKata
{
    public class CarParkEscapeKata
    {
        const int _StaircaseCode = 1;
        const int _CarCode = 2;

        public string[] escape(int[,] carpark)
        {
            return GetMovements(carpark).ToArray();
        }

        private List<string> GetMovements(int[,] carpark)
        {
            var result = new List<string>();
            var floors = GetFloors(carpark);
            var car = new Car(floors.First().ParkCodes.IndexOf(_CarCode));

            for (int i = 0; i < floors.Count(); i++)
            {
                var thisFloor = floors.ElementAt(i);

                if (car.CurrentIndex != thisFloor.TargetIndex)
                {
                    result.Add(car.MoveToStaircase(thisFloor));
                }

                if (!thisFloor.Is1stFloor && car.CurrentIndex == thisFloor.TargetIndex)
                {
                    int continuousDownCount = 0;
                    Floor nextFloor = floors.ElementAt(i + 1);
                    while (!thisFloor.Is1stFloor &&
                            nextFloor.TargetIndex == thisFloor.TargetIndex && nextFloor.ParkCodes[nextFloor.TargetIndex] == _StaircaseCode)
                    {
                        continuousDownCount++;
                        thisFloor = floors.ElementAt(++i);
                        nextFloor = floors.ElementAt(i + 1);
                    }
                    result.Add($"D{1 + continuousDownCount}");
                }
            }

            return result;
        }

        private IEnumerable<Floor> GetFloors(int[,] carpark)
        {
            var floors = new List<Floor>();
            int levelCount = carpark.GetLength(0);
            bool isCarFound = false;

            for (int i = 0; i < levelCount; i++)
            {
                var parkCodes = new List<int>();
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    int carCode = carpark[i, j];
                    parkCodes.Add(carCode);
                    if (carCode == _CarCode)
                    {
                        isCarFound = true;
                    }
                }

                if (isCarFound)
                {
                    floors.Add(new Floor(parkCodes, levelCount - i));
                }
            }

            return floors;
        }

        private bool Is1stFloor(int[,] carpark, int i)
        {
            return i == carpark.GetLength(0) - 1;
        }

        internal class Floor
        {
            private int _level;
            private int _targetIndex { get; set; }

            public Floor(IEnumerable<int> parkCodes, int level)
            {
                ParkCodes = parkCodes.ToList();
                _level = level;
                _targetIndex = Is1stFloor ? (ParkCodes.Count - 1) : ParkCodes.IndexOf(_StaircaseCode);
            }

            public List<int> ParkCodes;
            public int TargetIndex => _targetIndex;
            public bool Is1stFloor => _level == 1;

        }

        internal class Car
        {
            public Car(int index)
            {
                CurrentIndex = index;
            }
            public int CurrentIndex { get; set; }

            public string MoveToStaircase(Floor floor)
            {

                string direction = CurrentIndex > floor.TargetIndex ? "L" : "R";
                int count = Math.Abs(CurrentIndex - floor.TargetIndex);
                CurrentIndex = floor.TargetIndex;
                return $"{direction}{count}";
            }
        }
    }
}
