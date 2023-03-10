using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodShouldReturnSadMood()
        {
            //arrange
            string sadmood = "Sad";
            string message = "I Am In Sad Mood";
            AnalyzeMood mo = new AnalyzeMood(message);
            //act
            string mood = mo.MoodAnalyzer();
            //assert
            Assert.AreEqual(sadmood.ToLower(), mood.ToLower());

        }
        [TestMethod]
        public void GivenMoodShouldReturnHappyMood()
        {
            string happymood = "Happy";
            string message = "I Am In Happy Mood";
            AnalyzeMood mo = new AnalyzeMood(message);
            string mood = mo.MoodAnalyzer();
            Assert.AreEqual(happymood.ToLower(), mood.ToLower());
        }
    }
}