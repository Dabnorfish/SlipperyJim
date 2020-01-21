using System;

namespace SlipperyJim
{
    internal class Nationality
    {

        private string _nationalityName;

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
    }
}