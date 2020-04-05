using System;

namespace Unit_Tests
{
    public class PhoneConverter : IConverter
    {

        public string Convert(string[] elements)
        {
            long phone = long.Parse(elements[3].Trim());
            return String.Format("{0:##(###) ###-##-##}", phone);
        }

    }
}