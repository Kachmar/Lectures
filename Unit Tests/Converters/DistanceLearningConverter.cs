using System;

namespace Unit_Tests
{
  public  class DistanceLearningConverter : IConverter
    {

        public string Convert(string[] elements)
        {
            string isDistanceLearning = elements[5].Trim();
            if (string.IsNullOrEmpty(isDistanceLearning))
            {
                throw new Exception("Field isDistanceLearning is empty");
            }
            switch (isDistanceLearning.ToLower())
            {
                case "yes":
                    return true.ToString();
                case "no":
                    return false.ToString();
                default:
                    throw new Exception($"{isDistanceLearning} is not supported in isDistanceLearning.");

            }

        }
    }
}