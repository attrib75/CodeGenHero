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

    // NotificationMethodType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class NotificationMethodTypeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<NotificationMethodType>
    {
        public NotificationMethodTypeConfiguration()
            : this("dbo")
        {
        }

        public NotificationMethodTypeConfiguration(string schema)
        {
            ToTable("NotificationMethodType", schema);
            HasKey(x => x.NotificationMethodTypeId);

            Property(x => x.NotificationMethodTypeId).HasColumnName(@"NotificationMethodTypeId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
