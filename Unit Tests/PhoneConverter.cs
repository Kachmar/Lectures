using System;

namespace Unit_Tests
{
    class PhoneConverter : IConverter
    {

        public string Convert(string[] elements)
        {
            string phone = elements[3];
            return String.Format("{0:#(###) ###-##-##}", phone.Trim());
        }

    }
}