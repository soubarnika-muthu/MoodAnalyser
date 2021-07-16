using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
   public  class MoodAnalyser
    {
        //method to Analyse mood passing Message as parameter 
        public string AnalyseMood(string message)
        {
            message = message.ToLower();
            if (message.Contains("sad"))
            {
                return "sad";
            }
            else
            {
                return "happy";
            }
        }
    }
}
