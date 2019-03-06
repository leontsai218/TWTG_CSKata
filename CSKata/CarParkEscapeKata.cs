using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSKata
{
    public class CarParkEscapeKata
    {
        public string[] Escape(int[,] carpark)
        {
            var result = new List<string>();
            var car = new Car(-1);

            for (int i = 0; i < carpark.GetLength(0); i++)
            {
                var floor = new Floor(carpark, i);

                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    if (carpark[i, j] == 1)
                    {
                        floor.TargetIndex = j;
                    }
                    else if (carpark[i, j] == 2)
                    {
                        car.CurrentIndex = j;
                    }
                }

                if (car.CurrentIndex > -1)
                {
                    if (car.CurrentIndex != floor.TargetIndex)
                    {
                        result.Add(GetMovement(car, floor));
                    }

                    // 非一樓時進行下樓
                    if (!floor.Is1stFloor)
                    {
                        car.CurrentIndex = floor.TargetIndex;

                        // 連續下樓
                        int continuousDownCount = 0;
                        while (!floor.Is1stFloor && carpark[i + 1, car.CurrentIndex] == 1)
                        {
                            continuousDownCount++;
                            floor = new Floor(carpark, i++);
                        }
                        result.Add($"D{continuousDownCount + 1}");
                    }
                }
            }


            return result.ToArray();
        }

        private string GetMovement(Car car, Floor floor)
        {
            string direction = car.CurrentIndex > floor.TargetIndex ? "L" : "R";
            return $"{direction}{Math.Abs(car.CurrentIndex - floor.TargetIndex)}";
        }

        private bool Is1stFloor(int[,] carpark, int i)
        {
            return i == carpark.GetLength(0) - 1;
        }
    }

    internal class Floor
    {
        private int _level;
        private int[,] _carpark;
        private int _targetIndex;

        public Floor(int[,] carpark, int level)
        {
            _level = level;
            _carpark = carpark;
            TargetIndex = -1;
        }

        public int TargetIndex
        {
            get
            {
                return Is1stFloor ? TargetIndex = _carpark.GetLength(1) - 1 : _targetIndex;
            }
            set
            {
                _targetIndex = value;
            }
        }
        public bool Is1stFloor => _level == _carpark.GetLength(0) - 1;

    }

    internal class Car
    {
        public Car(int index)
        {
            CurrentIndex = index;
        }
        public int CurrentIndex { get; set; }
    }
}
