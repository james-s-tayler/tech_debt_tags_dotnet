using System;

namespace TechDebtTags
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class TechnicalDebtAttribute : BaseTechnicalDebtAttribute
    {
        public string Description { get; private set; }
        public string Consequence { get; private set; }
        public string Remediation { get; private set; }

        public TechnicalDebtAttribute(string description, string consequence = "", string remediation = "")
        {
            Description = description;
            Consequence = consequence;
            Remediation = remediation;
        }

    }
}