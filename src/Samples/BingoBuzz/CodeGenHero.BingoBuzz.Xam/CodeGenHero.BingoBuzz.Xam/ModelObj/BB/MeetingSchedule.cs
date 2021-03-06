// <auto-generated> - Template:MvvmLightModelObject, Version:1.1, Id:c644a31c-7ebc-4383-bc7f-0ea7c5bf6ed4
using GalaSoft.MvvmLight;
using CodeGenHero.Xam.MvvmLight;

namespace CodeGenHero.BingoBuzz.Xam.ModelObj.BB
{
	public partial class MeetingSchedule : BaseAuditEdit
	{
		public MeetingSchedule()
		{
			InitializePartial();
		}

		private System.DateTime? _endDate;
		private System.Guid? _meetingId;
		private System.Guid _meetingScheduleId;
		private System.Guid? _recurrenceRuleId;
		private System.DateTime? _startDate;


		public System.DateTime? EndDate
		{
			get { return _endDate; }
			set
			{
				Set<System.DateTime?>(() => EndDate, ref _endDate, value);
				RunCustomLogicSetEndDate(value);
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

		public System.Guid MeetingScheduleId
		{
			get { return _meetingScheduleId; }
			set
			{
				Set<System.Guid>(() => MeetingScheduleId, ref _meetingScheduleId, value);
				RunCustomLogicSetMeetingScheduleId(value);
			}
		}

		public System.Guid? RecurrenceRuleId
		{
			get { return _recurrenceRuleId; }
			set
			{
				Set<System.Guid?>(() => RecurrenceRuleId, ref _recurrenceRuleId, value);
				RunCustomLogicSetRecurrenceRuleId(value);
			}
		}

		public System.DateTime? StartDate
		{
			get { return _startDate; }
			set
			{
				Set<System.DateTime?>(() => StartDate, ref _startDate, value);
				RunCustomLogicSetStartDate(value);
			}
		}

		public virtual Meeting Meeting { get; set; } 
		public virtual RecurrenceRule RecurrenceRule { get; set; } 
		public virtual User CreatedUser { get; set; } 
		public virtual User UpdatedUser { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetEndDate(System.DateTime? value);
		partial void RunCustomLogicSetMeetingId(System.Guid? value);
		partial void RunCustomLogicSetMeetingScheduleId(System.Guid value);
		partial void RunCustomLogicSetRecurrenceRuleId(System.Guid? value);
		partial void RunCustomLogicSetStartDate(System.DateTime? value);

		#endregion RunCustomLogicSet

	}
}
