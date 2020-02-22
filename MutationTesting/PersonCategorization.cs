namespace MutationTesting
{
    public static class PersonCategorization
    {
        public static string Categorize(string gender, int age)
        {
            string result = string.Empty;

            if (age >= Constants.AGE_YOUTH && age < Constants.AGE_TEEN)
            {
                if (gender == Constants.MALE_INITIALS)
                {
                    result = Constants.YOUTH_MALE;
                }
                else if (gender == Constants.FEMALE_INITIALS)
                {
                    result = Constants.YOUTH_FEMALE;
                }
            }
            else if (age >= Constants.AGE_TEEN && age < Constants.AGE_ADULT)
            {
                if (gender == Constants.MALE_INITIALS)
                {
                    result = Constants.TEEN_MALE;
                }
                else if (gender == Constants.FEMALE_INITIALS)
                {
                    result = Constants.TEEN_FEMALE;
                }
            }
            else if (age >= Constants.AGE_ADULT && age <= Constants.AGE_MAX)
            {
                if (gender == Constants.MALE_INITIALS)
                {
                    result = Constants.ADULT_MALE;
                }
                else if (gender == Constants.FEMALE_INITIALS)
                {
                    result = Constants.ADULT_FEMALE;
                }
            }
            else
            {
                result = Constants.INVALID;
            }

            return result;
        }
    }
}
