// <auto-generated>
using GalaSoft.MvvmLight;
using MSC.BingoBuzz.Xam.ModelObj;

namespace MSC.BingoBuzz.Xam.ModelObj.BB
{
	public partial class BingoInstanceEvent : BaseAuditEdit
	{
		public BingoInstanceEvent()
		{
			InitializePartial();
		}

		private System.Guid? _bingoInstanceContentId;
		private System.Guid _bingoInstanceEventId;
		private int _bingoInstanceEventTypeId;
		private System.Guid _bingoInstanceId;


		public System.Guid? BingoInstanceContentId
		{
			get { return _bingoInstanceContentId; }
			set
			{
				Set<System.Guid?>(() => BingoInstanceContentId, ref _bingoInstanceContentId, value);
				RunCustomLogicSetBingoInstanceContentId(value);
			}
		}

		public System.Guid BingoInstanceEventId
		{
			get { return _bingoInstanceEventId; }
			set
			{
				Set<System.Guid>(() => BingoInstanceEventId, ref _bingoInstanceEventId, value);
				RunCustomLogicSetBingoInstanceEventId(value);
			}
		}

		public int BingoInstanceEventTypeId
		{
			get { return _bingoInstanceEventTypeId; }
			set
			{
				Set<int>(() => BingoInstanceEventTypeId, ref _bingoInstanceEventTypeId, value);
				RunCustomLogicSetBingoInstanceEventTypeId(value);
			}
		}

		public System.Guid BingoInstanceId
		{
			get { return _bingoInstanceId; }
			set
			{
				Set<System.Guid>(() => BingoInstanceId, ref _bingoInstanceId, value);
				RunCustomLogicSetBingoInstanceId(value);
			}
		}

		public virtual BingoInstance BingoInstance { get; set; } 
		public virtual BingoInstanceContent BingoInstanceContent { get; set; } 
		public virtual BingoInstanceEventType BingoInstanceEventType { get; set; } 
		public virtual User CreatedUser { get; set; } 
		public virtual User UpdatedUser { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetBingoInstanceContentId(System.Guid? value);
		partial void RunCustomLogicSetBingoInstanceEventId(System.Guid value);
		partial void RunCustomLogicSetBingoInstanceEventTypeId(int value);
		partial void RunCustomLogicSetBingoInstanceId(System.Guid value);

		#endregion RunCustomLogicSet

	}
}
