// <auto-generated> - Template:MvvmLightModelObject, Version:1.1, Id:c644a31c-7ebc-4383-bc7f-0ea7c5bf6ed4
using GalaSoft.MvvmLight;
using CodeGenHero.Xam.MvvmLight;

namespace CodeGenHero.BingoBuzz.Xam.ModelObj.BB
{
	public partial class BingoInstanceContent : BaseAuditEdit
	{
		public BingoInstanceContent()
		{
			BingoInstanceEvents = new System.Collections.Generic.List<BingoInstanceEvent>(); // Reverse Navigation

			InitializePartial();
		}

		private System.Guid _bingoContentId;
		private System.Guid _bingoInstanceContentId;
		private int _bingoInstanceContentStatusTypeId;
		private System.Guid _bingoInstanceId;
		private int _col;
		private bool _freeSquareIndicator;
		private int _row;
		private System.Guid _userId;


		public System.Guid BingoContentId
		{
			get { return _bingoContentId; }
			set
			{
				Set<System.Guid>(() => BingoContentId, ref _bingoContentId, value);
				RunCustomLogicSetBingoContentId(value);
			}
		}

		public System.Guid BingoInstanceContentId
		{
			get { return _bingoInstanceContentId; }
			set
			{
				Set<System.Guid>(() => BingoInstanceContentId, ref _bingoInstanceContentId, value);
				RunCustomLogicSetBingoInstanceContentId(value);
			}
		}

		public int BingoInstanceContentStatusTypeId
		{
			get { return _bingoInstanceContentStatusTypeId; }
			set
			{
				Set<int>(() => BingoInstanceContentStatusTypeId, ref _bingoInstanceContentStatusTypeId, value);
				RunCustomLogicSetBingoInstanceContentStatusTypeId(value);
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

		public int Col
		{
			get { return _col; }
			set
			{
				Set<int>(() => Col, ref _col, value);
				RunCustomLogicSetCol(value);
			}
		}

		public bool FreeSquareIndicator
		{
			get { return _freeSquareIndicator; }
			set
			{
				Set<bool>(() => FreeSquareIndicator, ref _freeSquareIndicator, value);
				RunCustomLogicSetFreeSquareIndicator(value);
			}
		}

		public int Row
		{
			get { return _row; }
			set
			{
				Set<int>(() => Row, ref _row, value);
				RunCustomLogicSetRow(value);
			}
		}

		public System.Guid UserId
		{
			get { return _userId; }
			set
			{
				Set<System.Guid>(() => UserId, ref _userId, value);
				RunCustomLogicSetUserId(value);
			}
		}

		public virtual System.Collections.Generic.IList<BingoInstanceEvent> BingoInstanceEvents { get; set; } // Many to many mapping
		public virtual BingoContent BingoContent { get; set; } 
		public virtual BingoInstance BingoInstance { get; set; } 
		public virtual BingoInstanceContentStatusType BingoInstanceContentStatusType { get; set; } 
		public virtual User CreatedUser { get; set; } 
		public virtual User UpdatedUser { get; set; } 
		public virtual User User_UserId { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetBingoContentId(System.Guid value);
		partial void RunCustomLogicSetBingoInstanceContentId(System.Guid value);
		partial void RunCustomLogicSetBingoInstanceContentStatusTypeId(int value);
		partial void RunCustomLogicSetBingoInstanceId(System.Guid value);
		partial void RunCustomLogicSetCol(int value);
		partial void RunCustomLogicSetFreeSquareIndicator(bool value);
		partial void RunCustomLogicSetRow(int value);
		partial void RunCustomLogicSetUserId(System.Guid value);

		#endregion RunCustomLogicSet

	}
}
