using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Xml.Linq;
using System;

namespace CountriesMVCLab
{
    public class Program
    {
        public static void Main()
        {
            CountryController cC = new CountryController();
            cC.WelcomeAction();
        }
    }
}
