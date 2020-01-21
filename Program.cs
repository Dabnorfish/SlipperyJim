using System;

namespace SlipperyJim
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pNationality = new Residence();
            var nationality = pNationality.GetNationality();
            var residentialStatus = pNationality.GetResidentialStatus();
            var houseType = pNationality.GetHouseType();

            var pCountryOfResidence = new CountryOfResidence();
            var countryOfResidence = pCountryOfResidence.GetCountryOfResidence();

            IGender pGender;
            var generateGenderType = GenerateGenderType();
            if (generateGenderType == GenderType.Male)
                pGender = new Person();
            else if (generateGenderType == GenderType.Female)
                pGender = new Female();
            else
                throw new Exception("Unknown Gender");

            var pronoun = pGender.GetPronouns();
            var possessivePronoun = pGender.GetPossessivePronouns();
            var firstName = pGender.GetFirstName();

            var pLastName = new LastName();
            var lastName = pLastName.GetLastName();

            var pDeviceName = new DeviceAndBrowser();
            var device = pDeviceName.GetDeviceName();
            var browser = pDeviceName.GetBrowserName();

            var pCars = new Cars();
            var newOrUsed = pCars.GetNewUsed();
            var oldCar = pCars.GetCurrentCar();
            var newCar = pCars.GetNewCar();

            var pFinanceOptions = new FinanceOptions();
            var financeType = pFinanceOptions.GetFinanceType();
            var depositAmount = pFinanceOptions.GetDepositAmount();
            var monthlyAmount = pFinanceOptions.GetMonthlyAmount();
            var financePriority = pFinanceOptions.GetPriority();

            var pDependents = new Family();
            var dependents = pDependents.GetDependents();
            
            var pAge = new Age();
            pAge.GetAge();
            Console.WriteLine(firstName.GetFirstName() + " " + lastName + " is a " + pGender.GetGender() + " from " + nationality + ". " + pGender.GetPronouns() + " is " + pAge.GetAge() + ".");
            Console.WriteLine(firstName.GetFirstName() + " lives in " + countryOfResidence +" in " +possessivePronoun.ToLower() +residentialStatus +houseType +".");
            Console.WriteLine(firstName.GetFirstName() + " browses the internet using " + browser + " on " + possessivePronoun.ToLower() + " " + device + ".");
            Console.WriteLine(firstName.GetFirstName() + " currently has " + oldCar + " and is looking for a " + newOrUsed.ToLower() + " " + newCar + ".");
            Console.WriteLine(firstName.GetFirstName() + " has £" + depositAmount + " for a deposit and would prefer to pay for " + possessivePronoun.ToLower() + " new vehicle by " + financeType + ". " +pronoun +" wants to pay no more than £" +monthlyAmount +" per month.");
            Console.WriteLine(possessivePronoun + " priority is " + financePriority +".");
            Console.ReadKey();
        }

        private static GenderType GenerateGenderType()
        {
            var genderArray = new[] {1, 2};
            var genderGen = new Random();
            var genderGenRandom = genderGen.Next(0, genderArray.Length);
            return (GenderType)genderArray[genderGenRandom];
        }
    }
}