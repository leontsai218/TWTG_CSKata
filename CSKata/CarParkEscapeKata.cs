using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSKata
{
    public static class CarParkEscapeKata
    {
        public static string[] Escape(int[,] carpark)
        {
            var result = new List<string>();

            int currentPosition = -1;
            for (int i = 0; i < carpark.GetLength(0); i++)
            {
                var is1stFloor = Is1stFloor(carpark, i);

                int targetPosition = -1;
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    var parkCode = carpark[i, j];
                    if (parkCode == 1)
                    {
                        targetPosition = j;
                    }
                    else if (parkCode == 2)
                    {
                        currentPosition = j;
                    }

                    if (is1stFloor)
                    {
                        targetPosition = carpark.GetLength(1) - 1;
                    }
                }

                if (currentPosition > -1)
                {
                    if (currentPosition != targetPosition)
                    {
                        string direction = currentPosition > targetPosition ? "L" : "R";
                        result.Add($"{direction}{Math.Abs(currentPosition - targetPosition)}");

                    }

                    currentPosition = targetPosition;
                    if (!is1stFloor)
                    {
                        int continuousDownCount = 0;

                        while (!Is1stFloor(carpark, i) && carpark[i + 1, currentPosition] == 1)
                        {
                            continuousDownCount++;
                            i += (continuousDownCount);
                        }
                        result.Add($"D{continuousDownCount + 1}");
                    }

                }
            }


            return result.ToArray();
        }

        private static bool Is1stFloor(int[,] carpark, int i)
        {
            return i == carpark.GetLength(0) - 1;
        }
    }
}
