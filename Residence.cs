using System;

namespace SlipperyJim
{
    internal class Residence
    {

        private string _nationalityName;
        private string _residentialStatus;
        private string _houseType;

        public void SetResidentialStatus(string residenceName)
        {
        }

        public void SetHouseType(string houseName)
        {
        }

        public void SetNationality(string nationalityName)
        {
        }

        public string GetNationality()
        {
            var nationalityArray = new[]
            {
                "South West Scotland",
                "North East Scotland",
                "Central Scotland East",
                "Central Scotland West",
                "Scottish Highlands and Western Isles",
                "Shetland and the Orkney Islands",
                "Edinburgh",
                "Glasgow",
                "North Wales",
                "South Wales",
                "Greater London",
                "The South East",
                "The South West",
                "Northern Ireland",
                "the West Midlands",
                "the North West",
                "the North East",
                "the East of England",
                "the East Midlands",
                "Yorkshire and the Humber",
                "North Wales",
                "Mid Wales",
                "South East Wales",
                "Antrim",
                "Armagh",
                "County Down",
                "Fermanagh",
                "Londonderry",
                "Tyrone"
            };
            var nationalityGen = new Random();
            var nationalityGenRandom = nationalityGen.Next(0, nationalityArray.Length);
            _nationalityName = nationalityArray[nationalityGenRandom];
            return _nationalityName;
        }

        public string GetResidentialStatus()
        {
            var residentialStatusArray = new[]
            {
                " parents' ",
                " own ",
                " rented "
            };
            var residentialGen = new Random();
            var residentialGenRandom = residentialGen.Next(0, residentialStatusArray.Length);
            _residentialStatus = residentialStatusArray[residentialGenRandom];
            return _residentialStatus;
        }

        public string GetHouseType()
        {
            var residentialStatusArray = new[]
            {
                "bungalow",
                "apartment",
                "detached house",
                "semi-detached house",
                "static caravan"
            };
            var residentialGen = new Random();
            var residentialGenRandom = residentialGen.Next(0, residentialStatusArray.Length);
            _residentialStatus = residentialStatusArray[residentialGenRandom];
            return _residentialStatus;
        }
    }
}