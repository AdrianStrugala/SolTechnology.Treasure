using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolTechnology.Treasure.Console.DetermineFile
{
    public static class DetermineFile
    {
        public static DetermineFileResult Execute(string fileContent)
        {

            DetermineFileResult result = new DetermineFileResult();

            if (fileContent.Contains("ZUS", StringComparison.InvariantCultureIgnoreCase))
            {
                result.Category = "podatki";
                result.Name = "zus";
            }

            if (fileContent.Contains("VAT", StringComparison.InvariantCultureIgnoreCase))
            {
                result.Category = "podatki";
                result.Name = "vat";
            }

            if (fileContent.Contains("PIT", StringComparison.InvariantCultureIgnoreCase))
            {
                result.Category = "podatki";
                result.Name = "pit36l";
            }


            return result;
        }


    }
}
