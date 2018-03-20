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

    // Meeting
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class Meeting
    {
        public System.Guid MeetingId { get; set; } // MeetingId (Primary key)
        public System.Guid? CompanyId { get; set; } // CompanyId
        public string Name { get; set; } // Name (length: 100)
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public System.Guid CreatedUserId { get; set; } // CreatedUserId
        public System.DateTime UpdatedDate { get; set; } // UpdatedDate
        public System.Guid UpdatedUserId { get; set; } // UpdatedUserId
        public bool IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child BingoInstances where [BingoInstance].[MeetingId] point to this entity (FK_BingoInstance_Meeting)
        /// </summary>
        public System.Collections.Generic.ICollection<BingoInstance> BingoInstances { get; set; } // BingoInstance.FK_BingoInstance_Meeting
        /// <summary>
        /// Child MeetingAttendees where [MeetingAttendee].[MeetingId] point to this entity (FK_MeetingAttendee_Meeting)
        /// </summary>
        public System.Collections.Generic.ICollection<MeetingAttendee> MeetingAttendees { get; set; } // MeetingAttendee.FK_MeetingAttendee_Meeting
        /// <summary>
        /// Child MeetingSchedules where [MeetingSchedule].[MeetingId] point to this entity (FK_MeetingSchedule_Meeting)
        /// </summary>
        public System.Collections.Generic.ICollection<MeetingSchedule> MeetingSchedules { get; set; } // MeetingSchedule.FK_MeetingSchedule_Meeting

        // Foreign keys

        /// <summary>
        /// Parent Company pointed by [Meeting].([CompanyId]) (FK_Meeting_Company)
        /// </summary>
        public Company Company { get; set; } // FK_Meeting_Company

        /// <summary>
        /// Parent User pointed by [Meeting].([CreatedUserId]) (FK_Meeting_User_Created)
        /// </summary>
        public User CreatedUser { get; set; } // FK_Meeting_User_Created

        /// <summary>
        /// Parent User pointed by [Meeting].([UpdatedUserId]) (FK_Meeting_User_Updated)
        /// </summary>
        public User UpdatedUser { get; set; } // FK_Meeting_User_Updated

        public Meeting()
        {
            MeetingId = System.Guid.NewGuid();
            IsDeleted = false;
            BingoInstances = new System.Collections.Generic.List<BingoInstance>();
            MeetingAttendees = new System.Collections.Generic.List<MeetingAttendee>();
            MeetingSchedules = new System.Collections.Generic.List<MeetingSchedule>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
