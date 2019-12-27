namespace TechDebtTags
{
    /// <summary>
    /// Represents the taxonomy of code smells described in Martin Fowler's Refactoring and summarized by Jeff Attwood on Coding Horror https://blog.codinghorror.com/code-smells/ 
    /// </summary>
    public enum CodeSmell
    {
        Comments,
        LongMethod,
        LongParameterList,
        DuplicatedCode,
        ConditionalComplexity,
        CombinatorialExplosion,
        LargeClass,
        TypeEmbeddedInName,
        UncommunicativeName,
        InconsistentNames,
        DeadCode,
        SpeculativeGenerality,
        OddballSolution,
        TemporaryField,
        AlternativeClassesWithDifferentInterfaces,
        PrimitiveObsession,
        DataClass,
        DataClumps,
        RefusedBequest,
        InappropriateIntimacy,
        IndecentExposure,
        FeatureEnvy,
        LazyClass,
        MessageChains,
        MiddleMan,
        DivergentChange,
        ShotgunSurgery,
        ParallelInheritanceHierarchies,
        IncompleteLibraryClass,
        SolutionSprawl
    }
}