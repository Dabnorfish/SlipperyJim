using System;

namespace SlipperyJim
{
    public interface IGender
    {
        string GetGender();
        string GetPronouns();
        string GetPossessivePronouns();
        FirstName GetFirstName();
        string[] AvailableNames();
    }

    public enum GenderType
    {
        Unknown = 0,
        Male = 1,
        Female = 2
    }

    public class Person : IGender
    {
        private readonly int _genderId;
        private string _genderName;

        public Person()
        {
            _genderId = (int)GenderType.Male;
        }

        public string GetGender()
        {
            if (_genderId == 1) _genderName = "man";
            if (_genderId == 2) _genderName = "woman";
            ;
            return _genderName;
        }

        public string GetPronouns()
        {
            var genderPronoun = "empty";
            if (_genderId == 1) genderPronoun = "He";
            ;
            if (_genderId == 2) genderPronoun = "She";
            ;
            return genderPronoun;
        }

        public string GetPossessivePronouns()
        {
            var genderPossessivePronoun = "empty";
            if (_genderId == 1) genderPossessivePronoun = "His";
            ;
            if (_genderId == 2) genderPossessivePronoun = "Her";
            ;
            return genderPossessivePronoun;
        }

        public FirstName GetFirstName()
        {
            return new FirstName(this);
        }

        public string[] AvailableNames()
        {
            return new[] {"Oliver", "George", "Harry", "Noah", "Jack", "Leo", "Arthur", "Muhammad", "Oscar", "Charlie"};
        }
    }

    public class Female : IGender
    {
        private readonly int _genderId;
        private string _genderName;

        public Female()
        {
            _genderId = (int)GenderType.Female;
        }


        public string GetGender()
        {
            if (_genderId == 1) _genderName = "man";
            if (_genderId == 2) _genderName = "woman";
            return _genderName;
        }

        public string GetPronouns()
        {
            var genderPronoun = "empty";
            if (_genderId == 1) genderPronoun = "He";
            if (_genderId == 2) genderPronoun = "She";
            return genderPronoun;
        }

        public string GetPossessivePronouns()
        {
            var genderPossessivePronoun = "empty";
            if (_genderId == 1) genderPossessivePronoun = "His";
            if (_genderId == 2) genderPossessivePronoun = "Her";
            return genderPossessivePronoun;
        }

        public FirstName GetFirstName()
        {
            return new FirstName(this);
        }

        public string[] AvailableNames()
        {
            return new[] {"Olivia", "Amelia", "Ava", "Isla", "Emily", "Mia", "Isabella", "Sophia", "Ella", "Grace"};
        }


    }
}