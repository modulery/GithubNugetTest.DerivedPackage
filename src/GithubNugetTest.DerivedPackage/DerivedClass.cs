using GithubNugetTest.BasePackage;

namespace GithubNugetTest.DerivedPackage
{
    public class DerivedClass : BaseClass
    {
        public string? DerivedName { get; set; }
        public DateTime DerivedTime { get; set; }
    }
}