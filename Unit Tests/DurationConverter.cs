using System;

namespace Unit_Tests
{
    class DurationConverter : IConverter
    {

        public string Convert(string[] elements)
        {
            var startDate = DateTime.Parse(elements[0]);
            var endDate = DateTime.Parse(elements[1]);
            var diff = endDate - startDate;
            return diff.TotalSeconds.ToString();
        }

    }
}