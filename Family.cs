using System;

namespace SlipperyJim
{
    internal class Family
    {
        private string _dependents;
        private string _family;

        public void SetFamily(string family)
        {
        }

        public void SetDependents(string dependents)
        {
        }

        public string GetFamily()
        {
            var familyArray = new[] {"alone.", "with their parents.", "with their partner."};
            var familyGen = new Random();
            var familyRandom = familyGen.Next(0, familyArray.Length);

            _family = familyArray[familyRandom];
            return _family;
        }

        public string GetDependents()
        {
            var dependentNameArray = new[] {"son.", "daughter.", "boy and a girl.", "They have two boys.", "They have two girls."};
            var dependentsGen = new Random();
            var dependentsRandom = dependentsGen.Next(0, dependentNameArray.Length);

            _dependents = dependentNameArray[dependentsRandom];
            return _dependents;
        }
    }
}