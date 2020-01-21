using System;

namespace SlipperyJim
{
    public class FirstName
    {
        private readonly string _firstNameName;

        public FirstName(IGender gender)
        {
            var firstNameArray = gender.AvailableNames();
            var firstNameGen = new Random();
            var firstNameGenRandom = firstNameGen.Next(0, firstNameArray.Length);
            _firstNameName = firstNameArray[firstNameGenRandom];
        }

        public string GetFirstName()
        {
            return _firstNameName;
        }
    }
}