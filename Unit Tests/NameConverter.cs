using System;

namespace Unit_Tests
{
   public class NameConverter : IConverter
    {

        public string Convert(string[] elements)
        {

            string fullName = elements[4].Trim();
            if (string.IsNullOrEmpty(fullName))
            {
                throw new Exception("Full name field cannot be empty;");
            }
            string[] NameAndLastName = fullName.Split(' ');
            if (NameAndLastName.Length != 2)
            {
                throw new Exception("Invalid Full name format: " + NameAndLastName);
            }

            return NameAndLastName[0];

        }

    }
}