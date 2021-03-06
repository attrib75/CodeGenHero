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

    // NotificationRule
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class NotificationRuleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<NotificationRule>
    {
        public NotificationRuleConfiguration()
            : this("dbo")
        {
        }

        public NotificationRuleConfiguration(string schema)
        {
            ToTable("NotificationRule", schema);
            HasKey(x => x.NotificationRuleId);

            Property(x => x.NotificationRuleId).HasColumnName(@"NotificationRuleId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NotificationMethodTypeId).HasColumnName(@"NotificationMethodTypeId").HasColumnType("int").IsRequired();
            Property(x => x.MinutesBeforehand).HasColumnName(@"MinutesBeforehand").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.NotificationMethodType).WithMany(b => b.NotificationRules).HasForeignKey(c => c.NotificationMethodTypeId).WillCascadeOnDelete(false); // FK_NotificationRule_NotificationMethodType
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
