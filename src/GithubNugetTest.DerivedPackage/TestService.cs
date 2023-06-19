using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubNugetTest.DerivedPackage
{
    public class TestService
    {
        public DerivedClass GetDerivedTestObject()
        {
            var result = new DerivedClass();
            result.Id = 1;
            result.Name= "BaseName";
            result.DerivedName = "DerivedName";
            return result;
        }
    }
}
