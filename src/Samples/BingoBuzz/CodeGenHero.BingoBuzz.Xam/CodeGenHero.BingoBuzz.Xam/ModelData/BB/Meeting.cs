// <auto-generated> - Template:SqliteModelData, Version:1.1, Id:c5caad15-b3be-4443-87d8-7cabde59f7b0
using CodeGenHero.Xam.Sqlite;
using SQLite;

namespace CodeGenHero.BingoBuzz.Xam.ModelData.BB
{
	[Table("Meeting")]
	public partial class Meeting : BaseAuditEdit
	{
		public System.Guid? CompanyId { get; set; }

		[PrimaryKey]
		public System.Guid MeetingId { get; set; }

		public string Name { get; set; }
	}
}
