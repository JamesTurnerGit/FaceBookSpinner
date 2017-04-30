using System;
using System.Collections.Generic;
using System.Linq;

namespace FaceBookSlotsApp
{
    public class Parser
    {
        public List<string> Parse(string input)
        {
            char[] newLineChars = { '\n', '\r' };

            var result = input.Split(newLineChars).ToList<string>();
                
            result.RemoveAll(str => String.IsNullOrWhiteSpace(str));
            result.RemoveAll(str => str == "Add Friend");
            result.RemoveAll(str => str.Contains("mutual"));

            return result;        
        }
    }
}
