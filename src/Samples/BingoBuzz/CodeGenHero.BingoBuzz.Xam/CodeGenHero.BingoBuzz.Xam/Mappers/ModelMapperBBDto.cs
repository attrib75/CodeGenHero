// <auto-generated> - Template:MapperDtoToSqliteModelDataAndMvvmLightModelObject, Version:1.0, Id:5078579f-7ab4-430d-9dcc-a3190f678efc
using objBB = CodeGenHero.BingoBuzz.Xam.ModelObj.BB;
using dataBB = CodeGenHero.BingoBuzz.Xam.ModelData.BB;
using dtoBB = CodeGenHero.BingoBuzz.DTO.BB;

namespace CodeGenHero.BingoBuzz.Xam
{
	public static partial class ModelMapper
	{

		#region ModelObj to ModelDto

		public static dtoBB.BingoContent ToDto(this objBB.BingoContent source)
		{
			return new dtoBB.BingoContent()
			{
				BingoContentId = source.BingoContentId,
				Content = source.Content,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				FreeSquareIndicator = source.FreeSquareIndicator,
				IsDeleted = source.IsDeleted,
				NumberOfDownvotes = source.NumberOfDownvotes,
				NumberOfUpvotes = source.NumberOfUpvotes,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dtoBB.BingoInstance ToDto(this objBB.BingoInstance source)
		{
			return new dtoBB.BingoInstance()
			{
				BingoInstanceId = source.BingoInstanceId,
				BingoInstanceStatusTypeId = source.BingoInstanceStatusTypeId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IncludeFreeSquareIndicator = source.IncludeFreeSquareIndicator,
				IsDeleted = source.IsDeleted,
				MeetingId = source.MeetingId,
				NumberOfColumns = source.NumberOfColumns,
				NumberOfRows = source.NumberOfRows,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dtoBB.BingoInstanceContent ToDto(this objBB.BingoInstanceContent source)
		{
			return new dtoBB.BingoInstanceContent()
			{
				BingoContentId = source.BingoContentId,
				BingoInstanceContentId = source.BingoInstanceContentId,
				BingoInstanceContentStatusTypeId = source.BingoInstanceContentStatusTypeId,
				BingoInstanceId = source.BingoInstanceId,
				Col = source.Col,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				FreeSquareIndicator = source.FreeSquareIndicator,
				IsDeleted = source.IsDeleted,
				Row = source.Row,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				UserId = source.UserId,
			};
		}

		public static dtoBB.BingoInstanceContentStatusType ToDto(this objBB.BingoInstanceContentStatusType source)
		{
			return new dtoBB.BingoInstanceContentStatusType()
			{
				BingoInstanceContentStatusTypeId = source.BingoInstanceContentStatusTypeId,
				Name = source.Name,
			};
		}

		public static dtoBB.BingoInstanceEvent ToDto(this objBB.BingoInstanceEvent source)
		{
			return new dtoBB.BingoInstanceEvent()
			{
				BingoInstanceContentId = source.BingoInstanceContentId,
				BingoInstanceEventId = source.BingoInstanceEventId,
				BingoInstanceEventTypeId = source.BingoInstanceEventTypeId,
				BingoInstanceId = source.BingoInstanceId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dtoBB.BingoInstanceEventType ToDto(this objBB.BingoInstanceEventType source)
		{
			return new dtoBB.BingoInstanceEventType()
			{
				BingoInstanceEventTypeId = source.BingoInstanceEventTypeId,
				Name = source.Name,
			};
		}

		public static dtoBB.BingoInstanceStatusType ToDto(this objBB.BingoInstanceStatusType source)
		{
			return new dtoBB.BingoInstanceStatusType()
			{
				BingoInstanceStatusTypeId = source.BingoInstanceStatusTypeId,
				Name = source.Name,
			};
		}

		public static dtoBB.Company ToDto(this objBB.Company source)
		{
			return new dtoBB.Company()
			{
				Address1 = source.Address1,
				Address2 = source.Address2,
				City = source.City,
				CodeName = source.CodeName,
				CompanyId = source.CompanyId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				Name = source.Name,
				State = source.State,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				WebsiteUrl = source.WebsiteUrl,
				Zip = source.Zip,
			};
		}

		public static dtoBB.FrequencyType ToDto(this objBB.FrequencyType source)
		{
			return new dtoBB.FrequencyType()
			{
				FrequencyTypeId = source.FrequencyTypeId,
				Name = source.Name,
			};
		}

		public static dtoBB.Meeting ToDto(this objBB.Meeting source)
		{
			return new dtoBB.Meeting()
			{
				CompanyId = source.CompanyId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				MeetingId = source.MeetingId,
				Name = source.Name,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dtoBB.MeetingAttendee ToDto(this objBB.MeetingAttendee source)
		{
			return new dtoBB.MeetingAttendee()
			{
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				MeetingAttendeeId = source.MeetingAttendeeId,
				MeetingId = source.MeetingId,
				NotificationRuleId = source.NotificationRuleId,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				UserId = source.UserId,
			};
		}

		public static dtoBB.MeetingSchedule ToDto(this objBB.MeetingSchedule source)
		{
			return new dtoBB.MeetingSchedule()
			{
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				EndDate = source.EndDate,
				IsDeleted = source.IsDeleted,
				MeetingId = source.MeetingId,
				MeetingScheduleId = source.MeetingScheduleId,
				RecurrenceRuleId = source.RecurrenceRuleId,
				StartDate = source.StartDate,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dtoBB.NotificationMethodType ToDto(this objBB.NotificationMethodType source)
		{
			return new dtoBB.NotificationMethodType()
			{
				Name = source.Name,
				NotificationMethodTypeId = source.NotificationMethodTypeId,
			};
		}

		public static dtoBB.NotificationRule ToDto(this objBB.NotificationRule source)
		{
			return new dtoBB.NotificationRule()
			{
				MinutesBeforehand = source.MinutesBeforehand,
				NotificationMethodTypeId = source.NotificationMethodTypeId,
				NotificationRuleId = source.NotificationRuleId,
			};
		}

		public static dtoBB.RecurrenceRule ToDto(this objBB.RecurrenceRule source)
		{
			return new dtoBB.RecurrenceRule()
			{
				EndDate = source.EndDate,
				FrequencyTypeId = source.FrequencyTypeId,
				Hour = source.Hour,
				Minutes = source.Minutes,
				OrdWeek = source.OrdWeek,
				RecurrenceRuleId = source.RecurrenceRuleId,
				Seconds = source.Seconds,
				WeekDay = source.WeekDay,
				WeekDayNum = source.WeekDayNum,
			};
		}

		public static dtoBB.User ToDto(this objBB.User source)
		{
			return new dtoBB.User()
			{
				CompanyId = source.CompanyId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				Email = source.Email,
				FirstName = source.FirstName,
				IsDeleted = source.IsDeleted,
				LastName = source.LastName,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				UserId = source.UserId,
			};
		}


		#endregion ModelObj to ModelDto

		#region ModelData to ModelDto

		public static dtoBB.BingoContent ToDto(this dataBB.BingoContent source)
		{
			return new dtoBB.BingoContent()
			{
				BingoContentId = source.BingoContentId,
				Content = source.Content,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				FreeSquareIndicator = source.FreeSquareIndicator,
				IsDeleted = source.IsDeleted,
				NumberOfDownvotes = source.NumberOfDownvotes,
				NumberOfUpvotes = source.NumberOfUpvotes,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dtoBB.BingoInstance ToDto(this dataBB.BingoInstance source)
		{
			return new dtoBB.BingoInstance()
			{
				BingoInstanceId = source.BingoInstanceId,
				BingoInstanceStatusTypeId = source.BingoInstanceStatusTypeId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IncludeFreeSquareIndicator = source.IncludeFreeSquareIndicator,
				IsDeleted = source.IsDeleted,
				MeetingId = source.MeetingId,
				NumberOfColumns = source.NumberOfColumns,
				NumberOfRows = source.NumberOfRows,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dtoBB.BingoInstanceContent ToDto(this dataBB.BingoInstanceContent source)
		{
			return new dtoBB.BingoInstanceContent()
			{
				BingoContentId = source.BingoContentId,
				BingoInstanceContentId = source.BingoInstanceContentId,
				BingoInstanceContentStatusTypeId = source.BingoInstanceContentStatusTypeId,
				BingoInstanceId = source.BingoInstanceId,
				Col = source.Col,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				FreeSquareIndicator = source.FreeSquareIndicator,
				IsDeleted = source.IsDeleted,
				Row = source.Row,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				UserId = source.UserId,
			};
		}

		public static dtoBB.BingoInstanceContentStatusType ToDto(this dataBB.BingoInstanceContentStatusType source)
		{
			return new dtoBB.BingoInstanceContentStatusType()
			{
				BingoInstanceContentStatusTypeId = source.BingoInstanceContentStatusTypeId,
				Name = source.Name,
			};
		}

		public static dtoBB.BingoInstanceEvent ToDto(this dataBB.BingoInstanceEvent source)
		{
			return new dtoBB.BingoInstanceEvent()
			{
				BingoInstanceContentId = source.BingoInstanceContentId,
				BingoInstanceEventId = source.BingoInstanceEventId,
				BingoInstanceEventTypeId = source.BingoInstanceEventTypeId,
				BingoInstanceId = source.BingoInstanceId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dtoBB.BingoInstanceEventType ToDto(this dataBB.BingoInstanceEventType source)
		{
			return new dtoBB.BingoInstanceEventType()
			{
				BingoInstanceEventTypeId = source.BingoInstanceEventTypeId,
				Name = source.Name,
			};
		}

		public static dtoBB.BingoInstanceStatusType ToDto(this dataBB.BingoInstanceStatusType source)
		{
			return new dtoBB.BingoInstanceStatusType()
			{
				BingoInstanceStatusTypeId = source.BingoInstanceStatusTypeId,
				Name = source.Name,
			};
		}

		public static dtoBB.Company ToDto(this dataBB.Company source)
		{
			return new dtoBB.Company()
			{
				Address1 = source.Address1,
				Address2 = source.Address2,
				City = source.City,
				CodeName = source.CodeName,
				CompanyId = source.CompanyId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				Name = source.Name,
				State = source.State,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				WebsiteUrl = source.WebsiteUrl,
				Zip = source.Zip,
			};
		}

		public static dtoBB.FrequencyType ToDto(this dataBB.FrequencyType source)
		{
			return new dtoBB.FrequencyType()
			{
				FrequencyTypeId = source.FrequencyTypeId,
				Name = source.Name,
			};
		}

		public static dtoBB.Meeting ToDto(this dataBB.Meeting source)
		{
			return new dtoBB.Meeting()
			{
				CompanyId = source.CompanyId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				MeetingId = source.MeetingId,
				Name = source.Name,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dtoBB.MeetingAttendee ToDto(this dataBB.MeetingAttendee source)
		{
			return new dtoBB.MeetingAttendee()
			{
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				MeetingAttendeeId = source.MeetingAttendeeId,
				MeetingId = source.MeetingId,
				NotificationRuleId = source.NotificationRuleId,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				UserId = source.UserId,
			};
		}

		public static dtoBB.MeetingSchedule ToDto(this dataBB.MeetingSchedule source)
		{
			return new dtoBB.MeetingSchedule()
			{
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				EndDate = source.EndDate,
				IsDeleted = source.IsDeleted,
				MeetingId = source.MeetingId,
				MeetingScheduleId = source.MeetingScheduleId,
				RecurrenceRuleId = source.RecurrenceRuleId,
				StartDate = source.StartDate,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dtoBB.NotificationMethodType ToDto(this dataBB.NotificationMethodType source)
		{
			return new dtoBB.NotificationMethodType()
			{
				Name = source.Name,
				NotificationMethodTypeId = source.NotificationMethodTypeId,
			};
		}

		public static dtoBB.NotificationRule ToDto(this dataBB.NotificationRule source)
		{
			return new dtoBB.NotificationRule()
			{
				MinutesBeforehand = source.MinutesBeforehand,
				NotificationMethodTypeId = source.NotificationMethodTypeId,
				NotificationRuleId = source.NotificationRuleId,
			};
		}

		public static dtoBB.RecurrenceRule ToDto(this dataBB.RecurrenceRule source)
		{
			return new dtoBB.RecurrenceRule()
			{
				EndDate = source.EndDate,
				FrequencyTypeId = source.FrequencyTypeId,
				Hour = source.Hour,
				Minutes = source.Minutes,
				OrdWeek = source.OrdWeek,
				RecurrenceRuleId = source.RecurrenceRuleId,
				Seconds = source.Seconds,
				WeekDay = source.WeekDay,
				WeekDayNum = source.WeekDayNum,
			};
		}

		public static dtoBB.User ToDto(this dataBB.User source)
		{
			return new dtoBB.User()
			{
				CompanyId = source.CompanyId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				Email = source.Email,
				FirstName = source.FirstName,
				IsDeleted = source.IsDeleted,
				LastName = source.LastName,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				UserId = source.UserId,
			};
		}


		#endregion ModelData to ModelDto

		#region ModelDto to ModelObj

		public static objBB.BingoContent ToModelObj(this dtoBB.BingoContent source)
		{
			return new objBB.BingoContent()
			{
				BingoContentId = source.BingoContentId,
				Content = source.Content,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				FreeSquareIndicator = source.FreeSquareIndicator,
				IsDeleted = source.IsDeleted,
				NumberOfDownvotes = source.NumberOfDownvotes,
				NumberOfUpvotes = source.NumberOfUpvotes,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static objBB.BingoInstance ToModelObj(this dtoBB.BingoInstance source)
		{
			return new objBB.BingoInstance()
			{
				BingoInstanceId = source.BingoInstanceId,
				BingoInstanceStatusTypeId = source.BingoInstanceStatusTypeId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IncludeFreeSquareIndicator = source.IncludeFreeSquareIndicator,
				IsDeleted = source.IsDeleted,
				MeetingId = source.MeetingId,
				NumberOfColumns = source.NumberOfColumns,
				NumberOfRows = source.NumberOfRows,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static objBB.BingoInstanceContent ToModelObj(this dtoBB.BingoInstanceContent source)
		{
			return new objBB.BingoInstanceContent()
			{
				BingoContentId = source.BingoContentId,
				BingoInstanceContentId = source.BingoInstanceContentId,
				BingoInstanceContentStatusTypeId = source.BingoInstanceContentStatusTypeId,
				BingoInstanceId = source.BingoInstanceId,
				Col = source.Col,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				FreeSquareIndicator = source.FreeSquareIndicator,
				IsDeleted = source.IsDeleted,
				Row = source.Row,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				UserId = source.UserId,
			};
		}

		public static objBB.BingoInstanceContentStatusType ToModelObj(this dtoBB.BingoInstanceContentStatusType source)
		{
			return new objBB.BingoInstanceContentStatusType()
			{
				BingoInstanceContentStatusTypeId = source.BingoInstanceContentStatusTypeId,
				Name = source.Name,
			};
		}

		public static objBB.BingoInstanceEvent ToModelObj(this dtoBB.BingoInstanceEvent source)
		{
			return new objBB.BingoInstanceEvent()
			{
				BingoInstanceContentId = source.BingoInstanceContentId,
				BingoInstanceEventId = source.BingoInstanceEventId,
				BingoInstanceEventTypeId = source.BingoInstanceEventTypeId,
				BingoInstanceId = source.BingoInstanceId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static objBB.BingoInstanceEventType ToModelObj(this dtoBB.BingoInstanceEventType source)
		{
			return new objBB.BingoInstanceEventType()
			{
				BingoInstanceEventTypeId = source.BingoInstanceEventTypeId,
				Name = source.Name,
			};
		}

		public static objBB.BingoInstanceStatusType ToModelObj(this dtoBB.BingoInstanceStatusType source)
		{
			return new objBB.BingoInstanceStatusType()
			{
				BingoInstanceStatusTypeId = source.BingoInstanceStatusTypeId,
				Name = source.Name,
			};
		}

		public static objBB.Company ToModelObj(this dtoBB.Company source)
		{
			return new objBB.Company()
			{
				Address1 = source.Address1,
				Address2 = source.Address2,
				City = source.City,
				CodeName = source.CodeName,
				CompanyId = source.CompanyId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				Name = source.Name,
				State = source.State,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				WebsiteUrl = source.WebsiteUrl,
				Zip = source.Zip,
			};
		}

		public static objBB.FrequencyType ToModelObj(this dtoBB.FrequencyType source)
		{
			return new objBB.FrequencyType()
			{
				FrequencyTypeId = source.FrequencyTypeId,
				Name = source.Name,
			};
		}

		public static objBB.Meeting ToModelObj(this dtoBB.Meeting source)
		{
			return new objBB.Meeting()
			{
				CompanyId = source.CompanyId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				MeetingId = source.MeetingId,
				Name = source.Name,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static objBB.MeetingAttendee ToModelObj(this dtoBB.MeetingAttendee source)
		{
			return new objBB.MeetingAttendee()
			{
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				MeetingAttendeeId = source.MeetingAttendeeId,
				MeetingId = source.MeetingId,
				NotificationRuleId = source.NotificationRuleId,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				UserId = source.UserId,
			};
		}

		public static objBB.MeetingSchedule ToModelObj(this dtoBB.MeetingSchedule source)
		{
			return new objBB.MeetingSchedule()
			{
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				EndDate = source.EndDate,
				IsDeleted = source.IsDeleted,
				MeetingId = source.MeetingId,
				MeetingScheduleId = source.MeetingScheduleId,
				RecurrenceRuleId = source.RecurrenceRuleId,
				StartDate = source.StartDate,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static objBB.NotificationMethodType ToModelObj(this dtoBB.NotificationMethodType source)
		{
			return new objBB.NotificationMethodType()
			{
				Name = source.Name,
				NotificationMethodTypeId = source.NotificationMethodTypeId,
			};
		}

		public static objBB.NotificationRule ToModelObj(this dtoBB.NotificationRule source)
		{
			return new objBB.NotificationRule()
			{
				MinutesBeforehand = source.MinutesBeforehand,
				NotificationMethodTypeId = source.NotificationMethodTypeId,
				NotificationRuleId = source.NotificationRuleId,
			};
		}

		public static objBB.RecurrenceRule ToModelObj(this dtoBB.RecurrenceRule source)
		{
			return new objBB.RecurrenceRule()
			{
				EndDate = source.EndDate,
				FrequencyTypeId = source.FrequencyTypeId,
				Hour = source.Hour,
				Minutes = source.Minutes,
				OrdWeek = source.OrdWeek,
				RecurrenceRuleId = source.RecurrenceRuleId,
				Seconds = source.Seconds,
				WeekDay = source.WeekDay,
				WeekDayNum = source.WeekDayNum,
			};
		}

		public static objBB.User ToModelObj(this dtoBB.User source)
		{
			return new objBB.User()
			{
				CompanyId = source.CompanyId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				Email = source.Email,
				FirstName = source.FirstName,
				IsDeleted = source.IsDeleted,
				LastName = source.LastName,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				UserId = source.UserId,
			};
		}


		#endregion ModelDto to ModelObj

		#region ModelDto to ModelData

		public static dataBB.BingoContent ToModelData(this dtoBB.BingoContent source)
		{
			return new dataBB.BingoContent()
			{
				BingoContentId = source.BingoContentId,
				Content = source.Content,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				FreeSquareIndicator = source.FreeSquareIndicator,
				IsDeleted = source.IsDeleted,
				NumberOfDownvotes = source.NumberOfDownvotes,
				NumberOfUpvotes = source.NumberOfUpvotes,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dataBB.BingoInstance ToModelData(this dtoBB.BingoInstance source)
		{
			return new dataBB.BingoInstance()
			{
				BingoInstanceId = source.BingoInstanceId,
				BingoInstanceStatusTypeId = source.BingoInstanceStatusTypeId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IncludeFreeSquareIndicator = source.IncludeFreeSquareIndicator,
				IsDeleted = source.IsDeleted,
				MeetingId = source.MeetingId,
				NumberOfColumns = source.NumberOfColumns,
				NumberOfRows = source.NumberOfRows,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dataBB.BingoInstanceContent ToModelData(this dtoBB.BingoInstanceContent source)
		{
			return new dataBB.BingoInstanceContent()
			{
				BingoContentId = source.BingoContentId,
				BingoInstanceContentId = source.BingoInstanceContentId,
				BingoInstanceContentStatusTypeId = source.BingoInstanceContentStatusTypeId,
				BingoInstanceId = source.BingoInstanceId,
				Col = source.Col,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				FreeSquareIndicator = source.FreeSquareIndicator,
				IsDeleted = source.IsDeleted,
				Row = source.Row,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				UserId = source.UserId,
			};
		}

		public static dataBB.BingoInstanceContentStatusType ToModelData(this dtoBB.BingoInstanceContentStatusType source)
		{
			return new dataBB.BingoInstanceContentStatusType()
			{
				BingoInstanceContentStatusTypeId = source.BingoInstanceContentStatusTypeId,
				Name = source.Name,
			};
		}

		public static dataBB.BingoInstanceEvent ToModelData(this dtoBB.BingoInstanceEvent source)
		{
			return new dataBB.BingoInstanceEvent()
			{
				BingoInstanceContentId = source.BingoInstanceContentId,
				BingoInstanceEventId = source.BingoInstanceEventId,
				BingoInstanceEventTypeId = source.BingoInstanceEventTypeId,
				BingoInstanceId = source.BingoInstanceId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dataBB.BingoInstanceEventType ToModelData(this dtoBB.BingoInstanceEventType source)
		{
			return new dataBB.BingoInstanceEventType()
			{
				BingoInstanceEventTypeId = source.BingoInstanceEventTypeId,
				Name = source.Name,
			};
		}

		public static dataBB.BingoInstanceStatusType ToModelData(this dtoBB.BingoInstanceStatusType source)
		{
			return new dataBB.BingoInstanceStatusType()
			{
				BingoInstanceStatusTypeId = source.BingoInstanceStatusTypeId,
				Name = source.Name,
			};
		}

		public static dataBB.Company ToModelData(this dtoBB.Company source)
		{
			return new dataBB.Company()
			{
				Address1 = source.Address1,
				Address2 = source.Address2,
				City = source.City,
				CodeName = source.CodeName,
				CompanyId = source.CompanyId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				Name = source.Name,
				State = source.State,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				WebsiteUrl = source.WebsiteUrl,
				Zip = source.Zip,
			};
		}

		public static dataBB.FrequencyType ToModelData(this dtoBB.FrequencyType source)
		{
			return new dataBB.FrequencyType()
			{
				FrequencyTypeId = source.FrequencyTypeId,
				Name = source.Name,
			};
		}

		public static dataBB.Meeting ToModelData(this dtoBB.Meeting source)
		{
			return new dataBB.Meeting()
			{
				CompanyId = source.CompanyId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				MeetingId = source.MeetingId,
				Name = source.Name,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dataBB.MeetingAttendee ToModelData(this dtoBB.MeetingAttendee source)
		{
			return new dataBB.MeetingAttendee()
			{
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				IsDeleted = source.IsDeleted,
				MeetingAttendeeId = source.MeetingAttendeeId,
				MeetingId = source.MeetingId,
				NotificationRuleId = source.NotificationRuleId,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				UserId = source.UserId,
			};
		}

		public static dataBB.MeetingSchedule ToModelData(this dtoBB.MeetingSchedule source)
		{
			return new dataBB.MeetingSchedule()
			{
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				EndDate = source.EndDate,
				IsDeleted = source.IsDeleted,
				MeetingId = source.MeetingId,
				MeetingScheduleId = source.MeetingScheduleId,
				RecurrenceRuleId = source.RecurrenceRuleId,
				StartDate = source.StartDate,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
			};
		}

		public static dataBB.NotificationMethodType ToModelData(this dtoBB.NotificationMethodType source)
		{
			return new dataBB.NotificationMethodType()
			{
				Name = source.Name,
				NotificationMethodTypeId = source.NotificationMethodTypeId,
			};
		}

		public static dataBB.NotificationRule ToModelData(this dtoBB.NotificationRule source)
		{
			return new dataBB.NotificationRule()
			{
				MinutesBeforehand = source.MinutesBeforehand,
				NotificationMethodTypeId = source.NotificationMethodTypeId,
				NotificationRuleId = source.NotificationRuleId,
			};
		}

		public static dataBB.RecurrenceRule ToModelData(this dtoBB.RecurrenceRule source)
		{
			return new dataBB.RecurrenceRule()
			{
				EndDate = source.EndDate,
				FrequencyTypeId = source.FrequencyTypeId,
				Hour = source.Hour,
				Minutes = source.Minutes,
				OrdWeek = source.OrdWeek,
				RecurrenceRuleId = source.RecurrenceRuleId,
				Seconds = source.Seconds,
				WeekDay = source.WeekDay,
				WeekDayNum = source.WeekDayNum,
			};
		}

		public static dataBB.User ToModelData(this dtoBB.User source)
		{
			return new dataBB.User()
			{
				CompanyId = source.CompanyId,
				CreatedDate = source.CreatedDate,
				CreatedUserId = source.CreatedUserId,
				Email = source.Email,
				FirstName = source.FirstName,
				IsDeleted = source.IsDeleted,
				LastName = source.LastName,
				UpdatedDate = source.UpdatedDate,
				UpdatedUserId = source.UpdatedUserId,
				UserId = source.UserId,
			};
		}


		#endregion ModelDto to ModelData
	}
}
