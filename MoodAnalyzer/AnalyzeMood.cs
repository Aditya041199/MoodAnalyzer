using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class AnalyzeMood
    {
        public string message;

        public AnalyzeMood(string message)
        {
            this.message = message;
        }
        public string MoodAnalyzer()
        {
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }

    }
}