﻿using System;

namespace SlipperyJim
{
    internal class Country
    {
        private string _countryName;

        public void SetCountry(string countryName)
        {
        }

        public string GetCountry()
        {
            var countryArray = new[]
            {
//"Afghanistan",
//"Albania", 
//"Algeria", 
//"American Samoa", 
//"Andorra", 
//"Angola", 
//"Anguilla", 
//"Antarctica", 
//"Antigua and Barbuda", 
//"Argentina", 
//"Armenia", 
//"Aruba",
//"Australia",
//"Austria",
//"Azerbaijan",
//"the Bahamas",
//"Bahrain",
//"Bangladesh",
//"Barbados",
//"Belarus",
//"Belgium",
//"Belize",
//"Benin",
//"Bermuda",
//"Bhutan",
//"Bolivia",
//"Bosnia and Herzegovina",
//"Botswana",
//"Bouvet Island",
//"Brazil",
//"British Indian Ocean Territory",
//"Brunei Darussalam",
//"Bulgaria",
//"Burkina Faso",
//"Burundi",
//"Cambodia",
//"Cameroon",
//"Canada",
//"Cape Verde",
//"the Cayman Islands",
//"the Central African Republic",
//"Chad",
//"Chile",
//"China",
//"Christmas Island",
//"the Keeling Islands",
//"Colombia",
//"Comoros",
//"FDR Congo",
//"the Cook Islands",
//"Costa Rica",
//"Cote D'Ivoire",
//"Croatia",
//"Cuba",
//"Cyprus",
//"the Czech Republic",
//"Denmark",
//"Djibouti",
//"Dominica",
//"the Dominican Republic",
//"East Timor",
//"Ecuador",
//"Egypt",
//"El Salvador",
//"Equatorial Guinea",
//"Eritrea",
//"Estonia",
//"Ethiopia",
//"the Falkland Islands",
//"the Faroe Islands",
//"Fiji",
//"Finland",
//"France",
//"French Guiana",
//"French Polynesia",
//"the French Southern Territories",
//"Gabon",
//"Gambia",
//"Georgia",
//"Germany",
//"Ghana",
//"Gibraltar",
//"Greece",
//"Greenland",
//"Grenada",
//"Guadeloupe",
//"Guam",
//"Guatemala",
//"Guinea",
//"Guinea-Bissau",
//"Guyana",
//"Haiti",
//"the Heard and McDonald Islands",
//"Honduras",
//"Hong Kong",
//"Hungary",
//"Iceland",
//"India",
//"Indonesia",
//"Iran",
//"Iraq",
//"the Republic of Ireland",
//"Israel",
//"Italy",
//"Jamaica",
//"Japan",
//"Jordan",
//"Kazakhstan",
//"Kenya",
//"Kiribati",
//"North Korea",
//"South Korea",
//"Kuwait",
//"Kyrgyzstan",
//"Laos",
//"Latvia",
//"Lebanon",
//"Lesotho",
//"Liberia",
//"Libya",
//"Liechtenstein",
//"Lithuania",
//"Luxembourg",
//"Macau",
//"Macedonia",
//"Madagascar",
//"Malawi",
//"Malaysia",
//"the Maldives",
//"Mali",
//"Malta",
//"the Marshall Islands",
//"Martinique",
//"Mauritania",
//"Mauritius",
//"Mayotte",
//"Mexico",
//"Micronesia",
//"Moldova",
//"Monaco",
//"Mongolia",
//"Montserrat",
//"Morocco",
//"Mozambique",
//"Myanmar",
//"Namibia",
//"Nauru",
//"Nepal",
//"Holland",
//"the Dutch Antilles",
//"New Caledonia",
//"New Zealand",
//"Nicaragua",
//"Niger",
//"Nigeria",
//"Niue",
//"Norfolk Island",
//"the Northern Mariana Islands",
//"Norway",
//"Oman",
//"Pakistan",
//"Palau",
//"Panama",
//"Papua New Guinea",
//"Paraguay",
//"Peru",
//"the Philippines",
//"the Pitcairn Islands",
//"Poland",
//"Portugal",
//"Puerto Rico",
//"Qatar",
//"the Reunion Islands",
//"Romania",
//"the Russian Federation",
//"Rwanda",
//"Saint Kitts and Nevis",
//"Saint Lucia",
//"Saint Vincent and The Grenadines",
//"Samoa",
//"San Marino",
//"Sao Tome and Principe",
//"Saudi Arabia",
//"Senegal",
//"the Seychelles",
//"Sierra Leone",
//"Singapore",
//"the Slovak Republic",
//"Slovenia",
//"Solomon Islands",
//"Somalia",
//"South Africa",
//"the S. Georgia and S. Sandwich Isls.",
//"Spain",
//"Sri Lanka",
//"St. Helena",
//"St. Pierre and Miquelon",
//"Sudan",
//"Suriname",
//"the Svalbard and Jan Mayen Islands",
//"Swaziland",
//"Sweden",
//"Switzerland",
//"Syria",
//"Taiwan",
//"Tajikistan",
//"Tanzania",
//"Thailand",
//"Togo",
//"Tokelau",
//"Tonga",
//"Trinidad and Tobago",
//"Tunisia",
//"Turkey",
//"Turkmenistan",
//"the Turks and Caicos Islands",
//"Tuvalu",
//"Uganda",
//"Ukraine",
//"the United Arab Emirates",
                "the United Kingdom"
//"the United States",
//"the US Minor Outlying Islands",
//"Uruguay",
//"Uzbekistan",
//"Vanuatu",
//"the Vatican City State",
//"Venezuela",
//"Vietnam",
//"the British Virgin Islands",
//"the US Virgin Islands",
//"the Wallis and Futuna Islands",
//"the Western Sahara",
//"Yemen",
//"Yugoslavia",
//"Zaire",
//"Zambia",
//"Zimbabwe"
            };
            var countryGen = new Random();
            var countryGenRandom = countryGen.Next(0, countryArray.Length);
            _countryName = countryArray[countryGenRandom];
            return _countryName;
        }
    }
}