namespace locationCountry
{
    internal class Location
    {
        private string _locationCountryName;

        public void SetLocation(string lName)
        {
            _locationCountryName = lName;
        }

        public string GetLocation()
        {
            return _locationCountryName;
        }
    }
}