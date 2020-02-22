using NUnit.Framework;

namespace MutationTesting.Tests
{
    [TestFixture]
    public class PersonCategorizationTest
    {
        [Test]
        public void TestCategorize_Input_MALE_1_Output_MALE_YOUTH()
        {
            // 1. Arrange
            string gender = Constants.MALE_INITIALS;
            int age = 1;
            string expResult = Constants.YOUTH_MALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_MALE_5_Output_MALE_YOUTH()
        {
            // 1. Arrange
            string gender = Constants.MALE_INITIALS;
            int age = 5;
            string expResult = Constants.YOUTH_MALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_MALE_12_Output_MALE_YOUTH()
        {
            // 1. Arrange
            string gender = Constants.MALE_INITIALS;
            int age = 12;
            string expResult = Constants.YOUTH_MALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_FEMALE_1_Output_FEMALE_YOUTH()
        {
            // 1. Arrange
            string gender = Constants.FEMALE_INITIALS;
            int age = 1;
            string expResult = Constants.YOUTH_FEMALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_FEMALE_5_Output_FEMALE_YOUTH()
        {
            // 1. Arrange
            string gender = Constants.FEMALE_INITIALS;
            int age = 5;
            string expResult = Constants.YOUTH_FEMALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_FEMALE_12_Output_FEMALE_YOUTH()
        {
            // 1. Arrange
            string gender = Constants.FEMALE_INITIALS;
            int age = 12;
            string expResult = Constants.YOUTH_FEMALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_MALE_13_Output_MALE_TEEN()
        {
            // 1. Arrange
            string gender = Constants.MALE_INITIALS;
            int age = 13;
            string expResult = Constants.TEEN_MALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_MALE_15_Output_MALE_TEEN()
        {
            // 1. Arrange
            string gender = Constants.MALE_INITIALS;
            int age = 15;
            string expResult = Constants.TEEN_MALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_MALE_19_Output_MALE_TEEN()
        {
            // 1. Arrange
            string gender = Constants.MALE_INITIALS;
            int age = 19;
            string expResult = Constants.TEEN_MALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_FEMALE_13_Output_FEMALE_TEEN()
        {
            // 1. Arrange
            string gender = Constants.FEMALE_INITIALS;
            int age = 13;
            string expResult = Constants.TEEN_FEMALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_FEMALE_15_Output_FEMALE_TEEN()
        {
            // 1. Arrange
            string gender = Constants.FEMALE_INITIALS;
            int age = 15;
            string expResult = Constants.TEEN_FEMALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_FEMALE_19_Output_FEMALE_TEEN()
        {
            // 1. Arrange
            string gender = Constants.FEMALE_INITIALS;
            int age = 19;
            string expResult = Constants.TEEN_FEMALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_MALE_20_Output_MALE_ADULT()
        {
            // 1. Arrange
            string gender = Constants.MALE_INITIALS;
            int age = 20;
            string expResult = Constants.ADULT_MALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_MALE_50_Output_MALE_ADULT()
        {
            // 1. Arrange
            string gender = Constants.MALE_INITIALS;
            int age = 50;
            string expResult = Constants.ADULT_MALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_MALE_99_Output_MALE_ADULT()
        {
            // 1. Arrange
            string gender = Constants.FEMALE_INITIALS;
            int age = 99;
            string expResult = Constants.ADULT_FEMALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_FEMALE_20_Output_FEMALE_ADULT()
        {
            // 1. Arrange
            string gender = Constants.FEMALE_INITIALS;
            int age = 20;
            string expResult = Constants.ADULT_FEMALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_FEMALE_50_Output_FEMALE_ADULT()
        {
            // 1. Arrange
            string gender = Constants.FEMALE_INITIALS;
            int age = 50;
            string expResult = Constants.ADULT_FEMALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_FEMALE_99_Output_FEMALE_ADULT()
        {
            // 1. Arrange
            string gender = Constants.FEMALE_INITIALS;
            int age = 99;
            string expResult = Constants.ADULT_FEMALE;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_MALE_100_Output_INVALID()
        {
            // 1. Arrange
            string gender = Constants.FEMALE_INITIALS;
            int age = 100;
            string expResult = Constants.INVALID;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_FEMALE_100_Output_INVALID()
        {
            // 1. Arrange
            string gender = Constants.FEMALE_INITIALS;
            int age = 100;
            string expResult = Constants.INVALID;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        [Test]
        public void TestCategorize_Input_MALE_0_Output_INVALID()
        {
            // 1. Arrange
            string gender = Constants.MALE_INITIALS;
            int age = 0;
            string expResult = Constants.INVALID;

            // 2. Act
            string result = PersonCategorization.Categorize(gender, age);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }
    }
}