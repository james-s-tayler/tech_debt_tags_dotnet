using System;

namespace TechDebtTags
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class WTFAttribute : BaseTechnicalDebtAttribute
    {
        public string Confusion { get; private set; }
        public string Explanation { get; private set; }

        public WTFAttribute(string confusion = "", string explanation = "")
        {
            Confusion = confusion;
            Explanation = explanation;
        }
    }
}