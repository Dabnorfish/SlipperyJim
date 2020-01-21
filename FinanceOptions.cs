using System;

namespace SlipperyJim
{
    internal class FinanceOptions
    {
        private int _depositAmount;
        private int _monthlyAmount;
        private string _financePriority;
        private string _financeType;

        public string GetFinanceType()
        {
            //var financeTypeArray = new[] {"personal contract purchase", "a personal loan", "contract hire", "hire purchase", "cash", "finance lease"};
            var financeTypeArray = new[] { "personal contract purchase", "hire purchase", "cash"};
            var financeTypeGen = new Random();
            var financeTypeGenRandom = financeTypeGen.Next(0, financeTypeArray.Length);

            _financeType = financeTypeArray[financeTypeGenRandom];
            return _financeType;
        }

        public int GetDepositAmount()
        {
            var depositAmountArray = new[] {0, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000};
            var depositAmountGen = new Random();
            var depositAmountGenRandom = depositAmountGen.Next(0, depositAmountArray.Length);

            _depositAmount = depositAmountArray[depositAmountGenRandom];
            return _depositAmount;
        }

        public int GetMonthlyAmount()
        {
            var monthlyAmountArray = new[] { 100, 200, 300, 400, 500, 600, 600, 800, 900, 1000 };
            var monthlyAmountGen = new Random();
            var monthlyAmountGenRandom = monthlyAmountGen.Next(0, monthlyAmountArray.Length);

            _monthlyAmount = monthlyAmountArray[monthlyAmountGenRandom];
            return _monthlyAmount;
        }

        public string GetPriority()
        {
            var financePriorityArray = new[] {"a low deposit", "low monthly payments", "a short repayment period", "getting finance despite a poor credit rating"};
            var financePriorityGen = new Random();
            var financePriorityGenRandom = financePriorityGen.Next(0, financePriorityArray.Length);

            _financePriority = financePriorityArray[financePriorityGenRandom];
            return _financePriority;
        }
    }
}