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


namespace MSC.BingoBuzz.Repository.Entities.BB
{

    // BingoContent
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class BingoContent
    {
        public System.Guid BingoContentId { get; set; } // BingoContentId (Primary key)
        public string Content { get; set; } // Content (length: 250)
        public bool FreeSquareIndicator { get; set; } // FreeSquareIndicator
        public int NumberOfUpvotes { get; set; } // NumberOfUpvotes
        public int NumberOfDownvotes { get; set; } // NumberOfDownvotes
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public System.Guid CreatedUserId { get; set; } // CreatedUserId
        public System.DateTime UpdatedDate { get; set; } // UpdatedDate
        public System.Guid UpdatedUserId { get; set; } // UpdatedUserId
        public bool IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child BingoInstanceContents where [BingoInstanceContent].[BingoContentId] point to this entity (FK_BingoInstanceContent_BingoContent)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<BingoInstanceContent> BingoInstanceContents { get; set; } // BingoInstanceContent.FK_BingoInstanceContent_BingoContent

        // Foreign keys

        /// <summary>
        /// Parent User pointed by [BingoContent].([CreatedUserId]) (FK_BingoContent_User_CreatedUserId)
        /// </summary>
        public virtual User CreatedUser { get; set; } // FK_BingoContent_User_CreatedUserId

        /// <summary>
        /// Parent User pointed by [BingoContent].([UpdatedUserId]) (FK_BingoContent_User_UpdatedUserId)
        /// </summary>
        public virtual User UpdatedUser { get; set; } // FK_BingoContent_User_UpdatedUserId

        public BingoContent()
        {
            BingoContentId = System.Guid.NewGuid();
            FreeSquareIndicator = false;
            NumberOfUpvotes = 0;
            NumberOfDownvotes = 0;
            IsDeleted = false;
            BingoInstanceContents = new System.Collections.Generic.List<BingoInstanceContent>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
