using System;

namespace SlipperyJim
{
    internal class LastName
    {
        private string _lastNameName;


        public void SetLastName(string lastNameName)
        {
        }

        public string GetLastName()
        {
            var pNationality = new Residence();
            var nationality = pNationality.GetNationality();

            var lastNameArray = new[] {"Smith", "Jones", "Williams", "Taylor", "Davies", "Brown", "Wilson", "Evans", "Thomas", "Johnson", "Roberts", "Walker", "Wright", "Robinson", "Thompson", "White", "Hughes", "Edwards", "Green", "Lewis", "Wood", "Harris", "Martin", "Jackson", "Clarke"};
            var lastNameGen = new Random();
            var lastNameGenRandom = lastNameGen.Next(0, lastNameArray.Length);

            _lastNameName = lastNameArray[lastNameGenRandom];
            return _lastNameName;
        }
    }
}