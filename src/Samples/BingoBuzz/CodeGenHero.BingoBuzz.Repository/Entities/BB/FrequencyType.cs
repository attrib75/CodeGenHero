// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace CodeGenHero.BingoBuzz.Repository.Entities.BB
{

    // FrequencyType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class FrequencyType
    {
        public int FrequencyTypeId { get; set; } // FrequencyTypeId (Primary key)
        public string Name { get; set; } // Name (length: 250)

        // Reverse navigation

        /// <summary>
        /// Child RecurrenceRules where [RecurrenceRule].[FrequencyTypeId] point to this entity (FK_RecurrenceRule_FrequencyType)
        /// </summary>
        public System.Collections.Generic.ICollection<RecurrenceRule> RecurrenceRules { get; set; } // RecurrenceRule.FK_RecurrenceRule_FrequencyType

        public FrequencyType()
        {
            RecurrenceRules = new System.Collections.Generic.List<RecurrenceRule>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
