namespace MutationTesting
{
    public static class Constants
    {
        public const string MALE = "Male";
        public const string FEMALE = "Female";

        public static string MALE_INITIALS = MALE.Substring(0, 1);
        public static string FEMALE_INITIALS = FEMALE.Substring(0, 1);

        public const int AGE_YOUTH = 1;
        public const int AGE_TEEN = 13;
        public const int AGE_ADULT = 20;
        public const int AGE_MAX = 99;

        public const string YOUTH = "Youth";
        public const string TEEN = "Teen";
        public const string ADULT = "Adult";

        public static string YOUTH_MALE = $"{Constants.YOUTH} – {Constants.MALE}";
        public static string TEEN_MALE = $"{Constants.TEEN} – {Constants.MALE}";
        public static string ADULT_MALE = $"{Constants.ADULT} – {Constants.MALE}";

        public static string YOUTH_FEMALE = $"{Constants.YOUTH} – {Constants.FEMALE}";
        public static string TEEN_FEMALE = $"{Constants.TEEN} – {Constants.FEMALE}";
        public static string ADULT_FEMALE = $"{Constants.ADULT} – {Constants.FEMALE}";

        public const string INVALID = "Invalid Range – Please try again";
    }
}