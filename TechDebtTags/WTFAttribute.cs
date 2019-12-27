using System;

namespace TechDebtTags
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class WTFAttribute : BaseTechnicalDebtAttribute
    {
        public string Confusion { get; private set; }

        public WTFAttribute(string confusion = "")
        {
            Confusion = confusion;
        }
    }
}