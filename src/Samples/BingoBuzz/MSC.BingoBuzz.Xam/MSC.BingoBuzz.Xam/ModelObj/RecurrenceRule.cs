// <auto-generated>
using GalaSoft.MvvmLight;
using MSC.BingoBuzz.Xam.ModelObj;

namespace MSC.BingoBuzz.Xam.ModelObj.BB
{
	public partial class RecurrenceRule : ObservableObject
	{
		public RecurrenceRule()
		{
			MeetingSchedules = new System.Collections.Generic.List<MeetingSchedule>();

			InitializePartial();
		}

		private System.DateTime? _endDate;
		private int _frequencyTypeId;
		private int? _hour;
		private int? _minutes;
		private int? _ordWeek;
		private System.Guid _recurrenceRuleId;
		private int? _seconds;
		private string _weekDay;
		private int? _weekDayNum;


		public System.DateTime? EndDate
		{
			get { return _endDate; }
			set
			{
				Set<System.DateTime?>(() => EndDate, ref _endDate, value);
				RunCustomLogicSetEndDate(value);
			}
		}

		public int FrequencyTypeId
		{
			get { return _frequencyTypeId; }
			set
			{
				Set<int>(() => FrequencyTypeId, ref _frequencyTypeId, value);
				RunCustomLogicSetFrequencyTypeId(value);
			}
		}

		public int? Hour
		{
			get { return _hour; }
			set
			{
				Set<int?>(() => Hour, ref _hour, value);
				RunCustomLogicSetHour(value);
			}
		}

		public int? Minutes
		{
			get { return _minutes; }
			set
			{
				Set<int?>(() => Minutes, ref _minutes, value);
				RunCustomLogicSetMinutes(value);
			}
		}

		public int? OrdWeek
		{
			get { return _ordWeek; }
			set
			{
				Set<int?>(() => OrdWeek, ref _ordWeek, value);
				RunCustomLogicSetOrdWeek(value);
			}
		}

		public System.Guid RecurrenceRuleId
		{
			get { return _recurrenceRuleId; }
			set
			{
				Set<System.Guid>(() => RecurrenceRuleId, ref _recurrenceRuleId, value);
				RunCustomLogicSetRecurrenceRuleId(value);
			}
		}

		public int? Seconds
		{
			get { return _seconds; }
			set
			{
				Set<int?>(() => Seconds, ref _seconds, value);
				RunCustomLogicSetSeconds(value);
			}
		}

		public string WeekDay
		{
			get { return _weekDay; }
			set
			{
				Set<string>(() => WeekDay, ref _weekDay, value);
				RunCustomLogicSetWeekDay(value);
			}
		}

		public int? WeekDayNum
		{
			get { return _weekDayNum; }
			set
			{
				Set<int?>(() => WeekDayNum, ref _weekDayNum, value);
				RunCustomLogicSetWeekDayNum(value);
			}
		}

		public virtual System.Collections.Generic.ICollection<MeetingSchedule> MeetingSchedules { get; set; } // Many to many mapping
		public virtual FrequencyType FrequencyType { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetEndDate(System.DateTime? value);
		partial void RunCustomLogicSetFrequencyTypeId(int value);
		partial void RunCustomLogicSetHour(int? value);
		partial void RunCustomLogicSetMinutes(int? value);
		partial void RunCustomLogicSetOrdWeek(int? value);
		partial void RunCustomLogicSetRecurrenceRuleId(System.Guid value);
		partial void RunCustomLogicSetSeconds(int? value);
		partial void RunCustomLogicSetWeekDay(string value);
		partial void RunCustomLogicSetWeekDayNum(int? value);

		#endregion RunCustomLogicSet

	}
}
