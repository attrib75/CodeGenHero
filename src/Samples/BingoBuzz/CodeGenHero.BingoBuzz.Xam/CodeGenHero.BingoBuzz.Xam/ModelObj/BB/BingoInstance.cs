// <auto-generated> - Template:MvvmLightModelObject, Version:1.1, Id:c644a31c-7ebc-4383-bc7f-0ea7c5bf6ed4
using GalaSoft.MvvmLight;
using CodeGenHero.Xam.MvvmLight;

namespace CodeGenHero.BingoBuzz.Xam.ModelObj.BB
{
	public partial class BingoInstance : BaseAuditEdit
	{
		public BingoInstance()
		{
			BingoInstanceContents = new System.Collections.Generic.List<BingoInstanceContent>(); // Reverse Navigation
			BingoInstanceEvents = new System.Collections.Generic.List<BingoInstanceEvent>(); // Reverse Navigation

			InitializePartial();
		}

		private System.Guid _bingoInstanceId;
		private int _bingoInstanceStatusTypeId;
		private bool _includeFreeSquareIndicator;
		private System.Guid? _meetingId;
		private int _numberOfColumns;
		private int _numberOfRows;


		public System.Guid BingoInstanceId
		{
			get { return _bingoInstanceId; }
			set
			{
				Set<System.Guid>(() => BingoInstanceId, ref _bingoInstanceId, value);
				RunCustomLogicSetBingoInstanceId(value);
			}
		}

		public int BingoInstanceStatusTypeId
		{
			get { return _bingoInstanceStatusTypeId; }
			set
			{
				Set<int>(() => BingoInstanceStatusTypeId, ref _bingoInstanceStatusTypeId, value);
				RunCustomLogicSetBingoInstanceStatusTypeId(value);
			}
		}

		public bool IncludeFreeSquareIndicator
		{
			get { return _includeFreeSquareIndicator; }
			set
			{
				Set<bool>(() => IncludeFreeSquareIndicator, ref _includeFreeSquareIndicator, value);
				RunCustomLogicSetIncludeFreeSquareIndicator(value);
			}
		}

		public System.Guid? MeetingId
		{
			get { return _meetingId; }
			set
			{
				Set<System.Guid?>(() => MeetingId, ref _meetingId, value);
				RunCustomLogicSetMeetingId(value);
			}
		}

		public int NumberOfColumns
		{
			get { return _numberOfColumns; }
			set
			{
				Set<int>(() => NumberOfColumns, ref _numberOfColumns, value);
				RunCustomLogicSetNumberOfColumns(value);
			}
		}

		public int NumberOfRows
		{
			get { return _numberOfRows; }
			set
			{
				Set<int>(() => NumberOfRows, ref _numberOfRows, value);
				RunCustomLogicSetNumberOfRows(value);
			}
		}

		public virtual System.Collections.Generic.IList<BingoInstanceContent> BingoInstanceContents { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.IList<BingoInstanceEvent> BingoInstanceEvents { get; set; } // Many to many mapping
		public virtual BingoInstanceStatusType BingoInstanceStatusType { get; set; } 
		public virtual Meeting Meeting { get; set; } 
		public virtual User CreatedUser { get; set; } 
		public virtual User UpdatedUser { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetBingoInstanceId(System.Guid value);
		partial void RunCustomLogicSetBingoInstanceStatusTypeId(int value);
		partial void RunCustomLogicSetIncludeFreeSquareIndicator(bool value);
		partial void RunCustomLogicSetMeetingId(System.Guid? value);
		partial void RunCustomLogicSetNumberOfColumns(int value);
		partial void RunCustomLogicSetNumberOfRows(int value);

		#endregion RunCustomLogicSet

	}
}
