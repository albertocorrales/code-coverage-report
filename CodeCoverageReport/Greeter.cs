using System;

namespace CodeCoverageReport
{
    public class Greeter
    {
        public string Greet1()
        {
            var greet = "Greet1";
            return greet;
        }

        public string Greet2(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            var greet = $"Hi {name}";
            return greet;
        }

        public string Greet3()
        {
            var greet = "Greet3";
            return greet;
        }
    }
}
