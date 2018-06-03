// <auto-generated> - Template:ModelsBackedByDto, Version:1.1, Id:f1539c0d-024f-4b1f-b346-132cdd9dd31f
using CodeGenHero.Logging;
using CodeGenHero.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using CodeGenHero.BingoBuzz.API.Client.Interface;
using CodeGenHero.BingoBuzz.Model.BB.Interface;
using xDTO = CodeGenHero.BingoBuzz.DTO.BB;

namespace CodeGenHero.BingoBuzz.Model.BB
{

	public class LoadRequestMeetingAttendee : EventArgs
	{
		public LoadRequestMeetingAttendee(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class MeetingAttendee : BaseModel<IWebApiDataServiceBB>, IMeetingAttendee
	{
		public event EventHandler<LoadRequestMeetingAttendee> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.MeetingAttendee _dto = null;

		public MeetingAttendee(ILoggingService log, IDataService<IWebApiDataServiceBB> dataService) : base(log, dataService)
		{
			_dto = new xDTO.MeetingAttendee();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public MeetingAttendee(ILoggingService log, IDataService<IWebApiDataServiceBB> dataService, xDTO.MeetingAttendee dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual System.DateTime CreatedDate { get { return _dto.CreatedDate; } }
		public virtual System.Guid CreatedUserId { get { return _dto.CreatedUserId; } }
		public virtual bool IsDeleted { get { return _dto.IsDeleted; } }
		public virtual System.Guid MeetingAttendeeId { get { return _dto.MeetingAttendeeId; } }
		public virtual System.Guid MeetingId { get { return _dto.MeetingId; } }
		public virtual System.Guid? NotificationRuleId { get { return _dto.NotificationRuleId; } }
		public virtual System.DateTime UpdatedDate { get { return _dto.UpdatedDate; } }
		public virtual System.Guid UpdatedUserId { get { return _dto.UpdatedUserId; } }
		public virtual System.Guid UserId { get { return _dto.UserId; } }

		private IMeeting _meeting = null; // Foreign Key
		private INotificationRule _notificationRule = null; // Foreign Key
		private IUser _createdUser = null; // Foreign Key
		private IUser _updatedUser = null; // Foreign Key
		private IUser _user_UserId = null; // Foreign Key


		public virtual IMeeting Meeting
		{
			get
			{
				if (_meeting == null)
				{
					OnLazyLoadRequest(this, new LoadRequestMeetingAttendee(nameof(Meeting)));
				}

				return _meeting;
			}
		}

		public virtual INotificationRule NotificationRule
		{
			get
			{
				if (_notificationRule == null && _dto != null && _dto.NotificationRule != null)
				{
					_notificationRule = new NotificationRule(Log, DataService, _dto.NotificationRule);
				}

				return _notificationRule;
			}
		}

		public virtual IUser CreatedUser
		{
			get
			{
				if (_createdUser == null && _dto != null && _dto.CreatedUser != null)
				{
					_createdUser = new User(Log, DataService, _dto.CreatedUser);
				}

				return _createdUser;
			}
		}

		public virtual IUser UpdatedUser
		{
			get
			{
				if (_updatedUser == null && _dto != null && _dto.UpdatedUser != null)
				{
					_updatedUser = new User(Log, DataService, _dto.UpdatedUser);
				}

				return _updatedUser;
			}
		}

		public virtual IUser User_UserId
		{
			get
			{
				if (_user_UserId == null && _dto != null && _dto.User_UserId != null)
				{
					_user_UserId = new User(Log, DataService, _dto.User_UserId);
				}

				return _user_UserId;
			}
		}



	}
}
