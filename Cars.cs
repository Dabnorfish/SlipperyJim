using System;

namespace SlipperyJim
{
    internal class Cars
    {
        private string _currentCar;
        private string _newCar;
        private string _newUsed;

        public void SetNewUsed(string newUsed)
        {
        }

        public void SetCurrentCar(string currentCar)
        {
        }

        public void SetNewCar(string newCar)
        {
        }

        public string GetNewUsed()
        {
            var newUsedArray = new[] {"New", "Used"};
            var newUsedGen = new Random();
            var newUsedGenRandom = newUsedGen.Next(0, newUsedArray.Length);

            _newUsed = newUsedArray[newUsedGenRandom];
            return _newUsed;
        }

        public string GetCurrentCar()
        {
            var currentCarArray = new[] {"no car", "a VW Golf", "a Land Rover Discovery", "a Ford Fiesta", "an Audi A6", "a Range Rover", "an Audi A3", "a Ford Focus", "a Mercedes E Class", "an Audi A8", "an Audi TT", "an Audi A4"};
            var currentCarGen = new Random();
            var currentCarGenRandom = currentCarGen.Next(0, currentCarArray.Length);

            _currentCar = currentCarArray[currentCarGenRandom];
            return _currentCar;
        }

        public string GetNewCar()
        {
            var newCarArray = new[] {"VW Golf", "Land Rover Discovery", "Ford Fiesta", "Audi A6", "Range Rover", "Audi A3", "Ford Focus", "Mercedes E Class", "Audi A8", "Audi TT", "Audi A4"};
            var newCarGen = new Random();
            var newCarGenRandom = newCarGen.Next(0, newCarArray.Length);

            _newCar = newCarArray[newCarGenRandom];
            return _newCar;
        }
    }
}