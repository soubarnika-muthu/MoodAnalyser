﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyser moodAnalyser;
        [TestInitialize]
        public void TestSetup()
        {
            moodAnalyser = new MoodAnalyser();
        }
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
            //act
            string actual = moodAnalyser.AnalyseMood(message);
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
            //act
            string actual = moodAnalyser.AnalyseMood(message);
            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
