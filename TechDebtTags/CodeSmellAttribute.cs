using System;

namespace TechDebtTags
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class CodeSmellAttribute : BaseTechnicalDebtAttribute
    {
        public CodeSmell Smell { get; private set; }

        public CodeSmellAttribute(CodeSmell smell)
        {
            Smell = smell;
        }
    }
}