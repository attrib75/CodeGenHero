// <auto-generated>
using SQLite;
using MSC.BingoBuzz.Xam.ModelData;

namespace MSC.BingoBuzz.Xam.ModelData.BB
{
	[Table("User")]
	public partial class User : BaseAuditEdit
	{
		public System.Guid CompanyId { get; set; }
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		[PrimaryKey]
		public System.Guid UserId { get; set; }

	}
}
