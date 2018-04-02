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

    // BingoInstanceEvent
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class BingoInstanceEvent
    {
        public System.Guid BingoInstanceEventId { get; set; } // BingoInstanceEventId (Primary key)
        public int BingoInstanceEventTypeId { get; set; } // BingoInstanceEventTypeId
        public System.Guid BingoInstanceId { get; set; } // BingoInstanceId
        public System.Guid? BingoInstanceContentId { get; set; } // BingoInstanceContentId
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public System.Guid CreatedUserId { get; set; } // CreatedUserId
        public System.DateTime UpdatedDate { get; set; } // UpdatedDate
        public System.Guid UpdatedUserId { get; set; } // UpdatedUserId
        public bool IsDeleted { get; set; } // IsDeleted

        // Foreign keys

        /// <summary>
        /// Parent BingoInstance pointed by [BingoInstanceEvent].([BingoInstanceId]) (FK_BingoInstanceEvent_BingoInstance)
        /// </summary>
        public BingoInstance BingoInstance { get; set; } // FK_BingoInstanceEvent_BingoInstance

        /// <summary>
        /// Parent BingoInstanceContent pointed by [BingoInstanceEvent].([BingoInstanceContentId]) (FK_BingoInstanceEvent_BingoInstanceContent)
        /// </summary>
        public BingoInstanceContent BingoInstanceContent { get; set; } // FK_BingoInstanceEvent_BingoInstanceContent

        /// <summary>
        /// Parent BingoInstanceEventType pointed by [BingoInstanceEvent].([BingoInstanceEventTypeId]) (FK_BingoInstanceEvent_BingoInstanceEventType)
        /// </summary>
        public BingoInstanceEventType BingoInstanceEventType { get; set; } // FK_BingoInstanceEvent_BingoInstanceEventType

        /// <summary>
        /// Parent User pointed by [BingoInstanceEvent].([CreatedUserId]) (FK_BingoInstanceEvent_User_Created)
        /// </summary>
        public User CreatedUser { get; set; } // FK_BingoInstanceEvent_User_Created

        /// <summary>
        /// Parent User pointed by [BingoInstanceEvent].([UpdatedUserId]) (FK_BingoInstanceEvent_User_Updated)
        /// </summary>
        public User UpdatedUser { get; set; } // FK_BingoInstanceEvent_User_Updated

        public BingoInstanceEvent()
        {
            BingoInstanceEventId = System.Guid.NewGuid();
            IsDeleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
