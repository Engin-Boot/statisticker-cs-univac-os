using System;
using System.Collections.Generic;

namespace Statistics
{
    public struct Stats
    {
        public float average;
        public float max;
        public float min;

        public Stats(float avg,float max,float min)
        {
            this.average = avg;
            this.max = max;
            this.min = min;
        }

    }

    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {
            Stats buffer = new Stats();

            if (numbers.Count != 0)//non-empty
            {
                buffer.average = numbers.Average();
                buffer.max = numbers.Max();
                buffer.min = numbers.Min();
            }
            else
            {
                buffer.average = float.NaN;
                buffer.max = float.NaN;
                buffer.min = float.NaN;

            }
            return buffer;
        }

    }
}
