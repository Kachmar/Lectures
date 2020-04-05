using System;

namespace Unit_Tests
{
   public class NameConverter : INameConverter
    {

        public string Convert(string[] elements)
        {

            string fullName = elements[4].Trim();
            if (string.IsNullOrEmpty(fullName))
            {
                throw new Exception("Full name field cannot be empty;");
            }
            string[] nameAndLastName = fullName.Split(' ');
            if (nameAndLastName.Length != 2)
            {
                throw new Exception("Invalid Full name format: " + nameAndLastName);
            }

            return nameAndLastName[0];

        }

    }
}