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

    // MeetingAttendee
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class MeetingAttendee
    {
        public System.Guid MeetingAttendeeId { get; set; } // MeetingAttendeeId (Primary key)
        public System.Guid MeetingId { get; set; } // MeetingId
        public System.Guid UserId { get; set; } // UserId
        public System.Guid? NotificationRuleId { get; set; } // NotificationRuleId
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public System.Guid CreatedUserId { get; set; } // CreatedUserId
        public System.DateTime UpdatedDate { get; set; } // UpdatedDate
        public System.Guid UpdatedUserId { get; set; } // UpdatedUserId
        public bool IsDeleted { get; set; } // IsDeleted

        // Foreign keys

        /// <summary>
        /// Parent Meeting pointed by [MeetingAttendee].([MeetingId]) (FK_MeetingAttendee_Meeting)
        /// </summary>
        public Meeting Meeting { get; set; } // FK_MeetingAttendee_Meeting

        /// <summary>
        /// Parent NotificationRule pointed by [MeetingAttendee].([NotificationRuleId]) (FK_MeetingAttendee_NotificationRule)
        /// </summary>
        public NotificationRule NotificationRule { get; set; } // FK_MeetingAttendee_NotificationRule

        /// <summary>
        /// Parent User pointed by [MeetingAttendee].([CreatedUserId]) (FK_MeetingAttendee_User_Created)
        /// </summary>
        public User CreatedUser { get; set; } // FK_MeetingAttendee_User_Created

        /// <summary>
        /// Parent User pointed by [MeetingAttendee].([UpdatedUserId]) (FK_MeetingAttendee_User_Updated)
        /// </summary>
        public User UpdatedUser { get; set; } // FK_MeetingAttendee_User_Updated

        /// <summary>
        /// Parent User pointed by [MeetingAttendee].([UserId]) (FK_MeetingAttendee_User)
        /// </summary>
        public User User_UserId { get; set; } // FK_MeetingAttendee_User

        public MeetingAttendee()
        {
            MeetingAttendeeId = System.Guid.NewGuid();
            IsDeleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
