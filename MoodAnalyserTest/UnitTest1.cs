using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        
        /// <summary>
        /// TC 1.1 Given “I am in Sad Mood” message
        // Should Return SAD
        /// </summary>
        [TestMethod]
        public void ReturnSadTest()
        {
            ///AAA Methodology
            //assign
            string expected = "sad";
            string message = "I am in SadMood";
           MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //act
            string actual = moodAnalyser.AnalyseMood();
            //assert
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// TC 1.2 Given “I am in any mood” message
        // Should Return happy
        /// </summary>
        [TestMethod]
        public void ReturnHappyTest()
        {
            //assign
            string expected = "happy";
            string message = "I am in Any mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //act
            string actual = moodAnalyser.AnalyseMood();
            //assert
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// TC 2.1 Nulls reference test.
        /// </summary>
        [TestMethod]
        public void GivenNullShouldReturnHappy()
        {
            ///AAA Methodology
            //assign
            string expected = "happy";
           
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            //act
            string actual = moodAnalyser.AnalyseMood();
            //assert
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// TC 3.1 Given NULL Mood Should Throw
        // MoodAnalysisException
        /// </summary>
        [TestMethod]
        public void Given_NullMood_Using_Custom_Exception_Return_Exception()
        {
            string expected = "Mood should not be null";
            try
            {
                string message = null;
                //act
                string actual = new MoodAnalyser(message).AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message);
            }

        }
        /// <summary>
        /// TC 3.1 Given Empty Mood
      //  Should Throw MoodAnalysisException indicating Empty Mood
        /// </summary>
        [TestMethod]
        public void Given_Empty_Mood_Using_Custom_Exception_Return_Empty()
        {
            string expected = "Mood should not be empty";
            try
            {
                string message = "";
                //act
                string actual = new MoodAnalyser(message).AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message);
            }

        }
        /// <summary>
        /// TC 3.1 Given NULL Mood Should Throw
            // MoodAnalysisException
        /// </summary>
        
       

    }
}
