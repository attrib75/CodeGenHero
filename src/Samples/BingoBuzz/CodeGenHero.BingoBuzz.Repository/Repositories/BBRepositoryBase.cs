// <auto-generated> - Template:RepositoryBase, Version:1.0, Id:70230bd4-f88f-41d8-a9c6-6e40aded5c07
using System;
using System.Data.Entity;
using System.Linq;
using CodeGenHero.BingoBuzz.Repository.Entities.BB;
using CodeGenHero.BingoBuzz.Repository.Interface;
using CodeGenHero.Repository;
using cghEnums = CodeGenHero.Repository.Enums;

namespace CodeGenHero.BingoBuzz.Repository
{
	public abstract class BBRepositoryBase : IBBRepositoryCrud
	{
		private BBDataContext _ctx;

		public BBRepositoryBase(BBDataContext ctx)
		{
			_ctx = ctx;

			// Disable lazy loading - if not, related properties are auto-loaded when
			// they are accessed for the first time, which means they'll be included when
			// we serialize (b/c the serialization process accesses those properties).

			// We don't want that, so we turn it off.  We want to eagerly load them (using Include) manually.

			ctx.Configuration.LazyLoadingEnabled = false;

			if (System.Diagnostics.Debugger.IsAttached)
			{   // Write EF queries to the output console.
				ctx.Database.Log = x => System.Diagnostics.Debug.WriteLine(x);
			}
		}

		#region Generic Operations

		private RepositoryActionResult<TEntity> Delete<TEntity>(TEntity item) where TEntity : class
		{
			try
			{
				if (item == null)
				{
					return new RepositoryActionResult<TEntity>(null, cghEnums.RepositoryActionStatus.NotFound);
				}

				DbSet<TEntity> itemSet = _ctx.Set<TEntity>();
				itemSet.Remove(item);
				_ctx.SaveChanges();
				return new RepositoryActionResult<TEntity>(null, cghEnums.RepositoryActionStatus.Deleted);
			}
			catch(Exception ex)
			{
				return new RepositoryActionResult<TEntity>(null, cghEnums.RepositoryActionStatus.Error, ex);
			}
		}

		public IQueryable<TEntity> GetQueryable<TEntity>() where TEntity : class
		{
			return _ctx.Set<TEntity>();
		}

		public RepositoryActionResult<TEntity> Insert<TEntity>(TEntity item) where TEntity : class
		{
			try
			{
				DbSet<TEntity> itemSet = _ctx.Set<TEntity>();
				itemSet.Add(item);
				var result = _ctx.SaveChanges();
				if (result > 0)
				{
					return new RepositoryActionResult<TEntity>(item, cghEnums.RepositoryActionStatus.Created);
				}
				else
				{
					return new RepositoryActionResult<TEntity>(item, cghEnums.RepositoryActionStatus.NothingModified, null);
				}
			}
			catch(Exception ex)
			{
				return new RepositoryActionResult<TEntity>(null, cghEnums.RepositoryActionStatus.Error, ex);
			}
		}

		private RepositoryActionResult<TEntity> Update<TEntity>(TEntity item, TEntity existingItem) where TEntity : class
		{
			try
			{ // only update when a record already exists for this id
				if (existingItem == null)
				{
					return new RepositoryActionResult<TEntity>(item, cghEnums.RepositoryActionStatus.NotFound);
				}

				// change the original entity status to detached; otherwise, we get an error on attach as the entity is already in the dbSet
				// set original entity state to detached
				_ctx.Entry(existingItem).State = EntityState.Detached;
				DbSet<TEntity> itemSet = _ctx.Set<TEntity>();
				itemSet.Attach(item); // attach & save
				_ctx.Entry(item).State = EntityState.Modified; // set the updated entity state to modified, so it gets updated.

				var result = _ctx.SaveChanges();
				if (result > 0)
				{
					return new RepositoryActionResult<TEntity>(item, cghEnums.RepositoryActionStatus.Updated);
				}
				else
				{
					return new RepositoryActionResult<TEntity>(item, cghEnums.RepositoryActionStatus.NothingModified, null);
				}
			}
			catch (Exception ex)
			{
				return new RepositoryActionResult<TEntity>(null, cghEnums.RepositoryActionStatus.Error, ex);
			}
		}

		#endregion Generic Operations

		#region Insert Operations

		public RepositoryActionResult<BingoContent> Insert(BingoContent item)
		{
			return Insert<BingoContent>(item);
		}
		public RepositoryActionResult<BingoInstance> Insert(BingoInstance item)
		{
			return Insert<BingoInstance>(item);
		}
		public RepositoryActionResult<BingoInstanceContent> Insert(BingoInstanceContent item)
		{
			return Insert<BingoInstanceContent>(item);
		}
		public RepositoryActionResult<BingoInstanceContentStatusType> Insert(BingoInstanceContentStatusType item)
		{
			return Insert<BingoInstanceContentStatusType>(item);
		}
		public RepositoryActionResult<BingoInstanceEvent> Insert(BingoInstanceEvent item)
		{
			return Insert<BingoInstanceEvent>(item);
		}
		public RepositoryActionResult<BingoInstanceEventType> Insert(BingoInstanceEventType item)
		{
			return Insert<BingoInstanceEventType>(item);
		}
		public RepositoryActionResult<BingoInstanceStatusType> Insert(BingoInstanceStatusType item)
		{
			return Insert<BingoInstanceStatusType>(item);
		}
		public RepositoryActionResult<Company> Insert(Company item)
		{
			return Insert<Company>(item);
		}
		public RepositoryActionResult<FrequencyType> Insert(FrequencyType item)
		{
			return Insert<FrequencyType>(item);
		}
		public RepositoryActionResult<Meeting> Insert(Meeting item)
		{
			return Insert<Meeting>(item);
		}
		public RepositoryActionResult<MeetingAttendee> Insert(MeetingAttendee item)
		{
			return Insert<MeetingAttendee>(item);
		}
		public RepositoryActionResult<MeetingSchedule> Insert(MeetingSchedule item)
		{
			return Insert<MeetingSchedule>(item);
		}
		public RepositoryActionResult<NotificationMethodType> Insert(NotificationMethodType item)
		{
			return Insert<NotificationMethodType>(item);
		}
		public RepositoryActionResult<NotificationRule> Insert(NotificationRule item)
		{
			return Insert<NotificationRule>(item);
		}
		public RepositoryActionResult<RecurrenceRule> Insert(RecurrenceRule item)
		{
			return Insert<RecurrenceRule>(item);
		}
		public RepositoryActionResult<User> Insert(User item)
		{
			return Insert<User>(item);
		}

		#endregion

		#region GetQueryable

		public IQueryable<BingoContent> GetQueryableBingoContent()
		{
			return _ctx.Set<BingoContent>();
		}
		public IQueryable<BingoInstance> GetQueryableBingoInstance()
		{
			return _ctx.Set<BingoInstance>();
		}
		public IQueryable<BingoInstanceContent> GetQueryableBingoInstanceContent()
		{
			return _ctx.Set<BingoInstanceContent>();
		}
		public IQueryable<BingoInstanceContentStatusType> GetQueryableBingoInstanceContentStatusType()
		{
			return _ctx.Set<BingoInstanceContentStatusType>();
		}
		public IQueryable<BingoInstanceEvent> GetQueryableBingoInstanceEvent()
		{
			return _ctx.Set<BingoInstanceEvent>();
		}
		public IQueryable<BingoInstanceEventType> GetQueryableBingoInstanceEventType()
		{
			return _ctx.Set<BingoInstanceEventType>();
		}
		public IQueryable<BingoInstanceStatusType> GetQueryableBingoInstanceStatusType()
		{
			return _ctx.Set<BingoInstanceStatusType>();
		}
		public IQueryable<Company> GetQueryableCompany()
		{
			return _ctx.Set<Company>();
		}
		public IQueryable<FrequencyType> GetQueryableFrequencyType()
		{
			return _ctx.Set<FrequencyType>();
		}
		public IQueryable<Meeting> GetQueryableMeeting()
		{
			return _ctx.Set<Meeting>();
		}
		public IQueryable<MeetingAttendee> GetQueryableMeetingAttendee()
		{
			return _ctx.Set<MeetingAttendee>();
		}
		public IQueryable<MeetingSchedule> GetQueryableMeetingSchedule()
		{
			return _ctx.Set<MeetingSchedule>();
		}
		public IQueryable<NotificationMethodType> GetQueryableNotificationMethodType()
		{
			return _ctx.Set<NotificationMethodType>();
		}
		public IQueryable<NotificationRule> GetQueryableNotificationRule()
		{
			return _ctx.Set<NotificationRule>();
		}
		public IQueryable<RecurrenceRule> GetQueryableRecurrenceRule()
		{
			return _ctx.Set<RecurrenceRule>();
		}
		public IQueryable<User> GetQueryableUser()
		{
			return _ctx.Set<User>();
		}

		#endregion

		#region Get FirstOrDefault

			public BingoContent GetBingoContent(System.Guid bingoContentId)
			{
				return _ctx.BingoContents.Where(x => x.BingoContentId == bingoContentId).FirstOrDefault();
			}
			public BingoContent GetFirstOrDefault(BingoContent item)
			{
				return _ctx.BingoContents.Where(x => x.BingoContentId == item.BingoContentId).FirstOrDefault();
			}
			public BingoInstance GetBingoInstance(System.Guid bingoInstanceId)
			{
				return _ctx.BingoInstances.Where(x => x.BingoInstanceId == bingoInstanceId).FirstOrDefault();
			}
			public BingoInstance GetFirstOrDefault(BingoInstance item)
			{
				return _ctx.BingoInstances.Where(x => x.BingoInstanceId == item.BingoInstanceId).FirstOrDefault();
			}
			public BingoInstanceContent GetBingoInstanceContent(System.Guid bingoInstanceContentId)
			{
				return _ctx.BingoInstanceContents.Where(x => x.BingoInstanceContentId == bingoInstanceContentId).FirstOrDefault();
			}
			public BingoInstanceContent GetFirstOrDefault(BingoInstanceContent item)
			{
				return _ctx.BingoInstanceContents.Where(x => x.BingoInstanceContentId == item.BingoInstanceContentId).FirstOrDefault();
			}
			public BingoInstanceContentStatusType GetBingoInstanceContentStatusType(int bingoInstanceContentStatusTypeId)
			{
				return _ctx.BingoInstanceContentStatusTypes.Where(x => x.BingoInstanceContentStatusTypeId == bingoInstanceContentStatusTypeId).FirstOrDefault();
			}
			public BingoInstanceContentStatusType GetFirstOrDefault(BingoInstanceContentStatusType item)
			{
				return _ctx.BingoInstanceContentStatusTypes.Where(x => x.BingoInstanceContentStatusTypeId == item.BingoInstanceContentStatusTypeId).FirstOrDefault();
			}
			public BingoInstanceEvent GetBingoInstanceEvent(System.Guid bingoInstanceEventId)
			{
				return _ctx.BingoInstanceEvents.Where(x => x.BingoInstanceEventId == bingoInstanceEventId).FirstOrDefault();
			}
			public BingoInstanceEvent GetFirstOrDefault(BingoInstanceEvent item)
			{
				return _ctx.BingoInstanceEvents.Where(x => x.BingoInstanceEventId == item.BingoInstanceEventId).FirstOrDefault();
			}
			public BingoInstanceEventType GetBingoInstanceEventType(int bingoInstanceEventTypeId)
			{
				return _ctx.BingoInstanceEventTypes.Where(x => x.BingoInstanceEventTypeId == bingoInstanceEventTypeId).FirstOrDefault();
			}
			public BingoInstanceEventType GetFirstOrDefault(BingoInstanceEventType item)
			{
				return _ctx.BingoInstanceEventTypes.Where(x => x.BingoInstanceEventTypeId == item.BingoInstanceEventTypeId).FirstOrDefault();
			}
			public BingoInstanceStatusType GetBingoInstanceStatusType(int bingoInstanceStatusTypeId)
			{
				return _ctx.BingoInstanceStatusTypes.Where(x => x.BingoInstanceStatusTypeId == bingoInstanceStatusTypeId).FirstOrDefault();
			}
			public BingoInstanceStatusType GetFirstOrDefault(BingoInstanceStatusType item)
			{
				return _ctx.BingoInstanceStatusTypes.Where(x => x.BingoInstanceStatusTypeId == item.BingoInstanceStatusTypeId).FirstOrDefault();
			}
			public Company GetCompany(System.Guid companyId)
			{
				return _ctx.Companies.Where(x => x.CompanyId == companyId).FirstOrDefault();
			}
			public Company GetFirstOrDefault(Company item)
			{
				return _ctx.Companies.Where(x => x.CompanyId == item.CompanyId).FirstOrDefault();
			}
			public FrequencyType GetFrequencyType(int frequencyTypeId)
			{
				return _ctx.FrequencyTypes.Where(x => x.FrequencyTypeId == frequencyTypeId).FirstOrDefault();
			}
			public FrequencyType GetFirstOrDefault(FrequencyType item)
			{
				return _ctx.FrequencyTypes.Where(x => x.FrequencyTypeId == item.FrequencyTypeId).FirstOrDefault();
			}
			public Meeting GetMeeting(System.Guid meetingId)
			{
				return _ctx.Meetings.Where(x => x.MeetingId == meetingId).FirstOrDefault();
			}
			public Meeting GetFirstOrDefault(Meeting item)
			{
				return _ctx.Meetings.Where(x => x.MeetingId == item.MeetingId).FirstOrDefault();
			}
			public MeetingAttendee GetMeetingAttendee(System.Guid meetingAttendeeId)
			{
				return _ctx.MeetingAttendees.Where(x => x.MeetingAttendeeId == meetingAttendeeId).FirstOrDefault();
			}
			public MeetingAttendee GetFirstOrDefault(MeetingAttendee item)
			{
				return _ctx.MeetingAttendees.Where(x => x.MeetingAttendeeId == item.MeetingAttendeeId).FirstOrDefault();
			}
			public MeetingSchedule GetMeetingSchedule(System.Guid meetingScheduleId)
			{
				return _ctx.MeetingSchedules.Where(x => x.MeetingScheduleId == meetingScheduleId).FirstOrDefault();
			}
			public MeetingSchedule GetFirstOrDefault(MeetingSchedule item)
			{
				return _ctx.MeetingSchedules.Where(x => x.MeetingScheduleId == item.MeetingScheduleId).FirstOrDefault();
			}
			public NotificationMethodType GetNotificationMethodType(int notificationMethodTypeId)
			{
				return _ctx.NotificationMethodTypes.Where(x => x.NotificationMethodTypeId == notificationMethodTypeId).FirstOrDefault();
			}
			public NotificationMethodType GetFirstOrDefault(NotificationMethodType item)
			{
				return _ctx.NotificationMethodTypes.Where(x => x.NotificationMethodTypeId == item.NotificationMethodTypeId).FirstOrDefault();
			}
			public NotificationRule GetNotificationRule(System.Guid notificationRuleId)
			{
				return _ctx.NotificationRules.Where(x => x.NotificationRuleId == notificationRuleId).FirstOrDefault();
			}
			public NotificationRule GetFirstOrDefault(NotificationRule item)
			{
				return _ctx.NotificationRules.Where(x => x.NotificationRuleId == item.NotificationRuleId).FirstOrDefault();
			}
			public RecurrenceRule GetRecurrenceRule(System.Guid recurrenceRuleId)
			{
				return _ctx.RecurrenceRules.Where(x => x.RecurrenceRuleId == recurrenceRuleId).FirstOrDefault();
			}
			public RecurrenceRule GetFirstOrDefault(RecurrenceRule item)
			{
				return _ctx.RecurrenceRules.Where(x => x.RecurrenceRuleId == item.RecurrenceRuleId).FirstOrDefault();
			}
			public User GetUser(System.Guid userId)
			{
				return _ctx.Users.Where(x => x.UserId == userId).FirstOrDefault();
			}
			public User GetFirstOrDefault(User item)
			{
				return _ctx.Users.Where(x => x.UserId == item.UserId).FirstOrDefault();
			}
		#endregion Get FirstOrDefault

		#region Update

		public RepositoryActionResult<BingoContent> Update(BingoContent item)
		{
			return Update<BingoContent>(item, _ctx.BingoContents.FirstOrDefault(x => x.BingoContentId == item.BingoContentId));
		}
		public RepositoryActionResult<BingoInstance> Update(BingoInstance item)
		{
			return Update<BingoInstance>(item, _ctx.BingoInstances.FirstOrDefault(x => x.BingoInstanceId == item.BingoInstanceId));
		}
		public RepositoryActionResult<BingoInstanceContent> Update(BingoInstanceContent item)
		{
			return Update<BingoInstanceContent>(item, _ctx.BingoInstanceContents.FirstOrDefault(x => x.BingoInstanceContentId == item.BingoInstanceContentId));
		}
		public RepositoryActionResult<BingoInstanceContentStatusType> Update(BingoInstanceContentStatusType item)
		{
			return Update<BingoInstanceContentStatusType>(item, _ctx.BingoInstanceContentStatusTypes.FirstOrDefault(x => x.BingoInstanceContentStatusTypeId == item.BingoInstanceContentStatusTypeId));
		}
		public RepositoryActionResult<BingoInstanceEvent> Update(BingoInstanceEvent item)
		{
			return Update<BingoInstanceEvent>(item, _ctx.BingoInstanceEvents.FirstOrDefault(x => x.BingoInstanceEventId == item.BingoInstanceEventId));
		}
		public RepositoryActionResult<BingoInstanceEventType> Update(BingoInstanceEventType item)
		{
			return Update<BingoInstanceEventType>(item, _ctx.BingoInstanceEventTypes.FirstOrDefault(x => x.BingoInstanceEventTypeId == item.BingoInstanceEventTypeId));
		}
		public RepositoryActionResult<BingoInstanceStatusType> Update(BingoInstanceStatusType item)
		{
			return Update<BingoInstanceStatusType>(item, _ctx.BingoInstanceStatusTypes.FirstOrDefault(x => x.BingoInstanceStatusTypeId == item.BingoInstanceStatusTypeId));
		}
		public RepositoryActionResult<Company> Update(Company item)
		{
			return Update<Company>(item, _ctx.Companies.FirstOrDefault(x => x.CompanyId == item.CompanyId));
		}
		public RepositoryActionResult<FrequencyType> Update(FrequencyType item)
		{
			return Update<FrequencyType>(item, _ctx.FrequencyTypes.FirstOrDefault(x => x.FrequencyTypeId == item.FrequencyTypeId));
		}
		public RepositoryActionResult<Meeting> Update(Meeting item)
		{
			return Update<Meeting>(item, _ctx.Meetings.FirstOrDefault(x => x.MeetingId == item.MeetingId));
		}
		public RepositoryActionResult<MeetingAttendee> Update(MeetingAttendee item)
		{
			return Update<MeetingAttendee>(item, _ctx.MeetingAttendees.FirstOrDefault(x => x.MeetingAttendeeId == item.MeetingAttendeeId));
		}
		public RepositoryActionResult<MeetingSchedule> Update(MeetingSchedule item)
		{
			return Update<MeetingSchedule>(item, _ctx.MeetingSchedules.FirstOrDefault(x => x.MeetingScheduleId == item.MeetingScheduleId));
		}
		public RepositoryActionResult<NotificationMethodType> Update(NotificationMethodType item)
		{
			return Update<NotificationMethodType>(item, _ctx.NotificationMethodTypes.FirstOrDefault(x => x.NotificationMethodTypeId == item.NotificationMethodTypeId));
		}
		public RepositoryActionResult<NotificationRule> Update(NotificationRule item)
		{
			return Update<NotificationRule>(item, _ctx.NotificationRules.FirstOrDefault(x => x.NotificationRuleId == item.NotificationRuleId));
		}
		public RepositoryActionResult<RecurrenceRule> Update(RecurrenceRule item)
		{
			return Update<RecurrenceRule>(item, _ctx.RecurrenceRules.FirstOrDefault(x => x.RecurrenceRuleId == item.RecurrenceRuleId));
		}
		public RepositoryActionResult<User> Update(User item)
		{
			return Update<User>(item, _ctx.Users.FirstOrDefault(x => x.UserId == item.UserId));
		}

		#endregion Update

		#region Delete

			public RepositoryActionResult<BingoContent> DeleteBingoContent(System.Guid bingoContentId)
			{
				return Delete<BingoContent>(_ctx.BingoContents.Where(x => x.BingoContentId == bingoContentId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoContent> Delete(BingoContent item)
			{
				return Delete<BingoContent>(_ctx.BingoContents.Where(x => x.BingoContentId == item.BingoContentId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoInstance> DeleteBingoInstance(System.Guid bingoInstanceId)
			{
				return Delete<BingoInstance>(_ctx.BingoInstances.Where(x => x.BingoInstanceId == bingoInstanceId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoInstance> Delete(BingoInstance item)
			{
				return Delete<BingoInstance>(_ctx.BingoInstances.Where(x => x.BingoInstanceId == item.BingoInstanceId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoInstanceContent> DeleteBingoInstanceContent(System.Guid bingoInstanceContentId)
			{
				return Delete<BingoInstanceContent>(_ctx.BingoInstanceContents.Where(x => x.BingoInstanceContentId == bingoInstanceContentId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoInstanceContent> Delete(BingoInstanceContent item)
			{
				return Delete<BingoInstanceContent>(_ctx.BingoInstanceContents.Where(x => x.BingoInstanceContentId == item.BingoInstanceContentId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoInstanceContentStatusType> DeleteBingoInstanceContentStatusType(int bingoInstanceContentStatusTypeId)
			{
				return Delete<BingoInstanceContentStatusType>(_ctx.BingoInstanceContentStatusTypes.Where(x => x.BingoInstanceContentStatusTypeId == bingoInstanceContentStatusTypeId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoInstanceContentStatusType> Delete(BingoInstanceContentStatusType item)
			{
				return Delete<BingoInstanceContentStatusType>(_ctx.BingoInstanceContentStatusTypes.Where(x => x.BingoInstanceContentStatusTypeId == item.BingoInstanceContentStatusTypeId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoInstanceEvent> DeleteBingoInstanceEvent(System.Guid bingoInstanceEventId)
			{
				return Delete<BingoInstanceEvent>(_ctx.BingoInstanceEvents.Where(x => x.BingoInstanceEventId == bingoInstanceEventId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoInstanceEvent> Delete(BingoInstanceEvent item)
			{
				return Delete<BingoInstanceEvent>(_ctx.BingoInstanceEvents.Where(x => x.BingoInstanceEventId == item.BingoInstanceEventId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoInstanceEventType> DeleteBingoInstanceEventType(int bingoInstanceEventTypeId)
			{
				return Delete<BingoInstanceEventType>(_ctx.BingoInstanceEventTypes.Where(x => x.BingoInstanceEventTypeId == bingoInstanceEventTypeId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoInstanceEventType> Delete(BingoInstanceEventType item)
			{
				return Delete<BingoInstanceEventType>(_ctx.BingoInstanceEventTypes.Where(x => x.BingoInstanceEventTypeId == item.BingoInstanceEventTypeId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoInstanceStatusType> DeleteBingoInstanceStatusType(int bingoInstanceStatusTypeId)
			{
				return Delete<BingoInstanceStatusType>(_ctx.BingoInstanceStatusTypes.Where(x => x.BingoInstanceStatusTypeId == bingoInstanceStatusTypeId).FirstOrDefault());
			}
			public RepositoryActionResult<BingoInstanceStatusType> Delete(BingoInstanceStatusType item)
			{
				return Delete<BingoInstanceStatusType>(_ctx.BingoInstanceStatusTypes.Where(x => x.BingoInstanceStatusTypeId == item.BingoInstanceStatusTypeId).FirstOrDefault());
			}
			public RepositoryActionResult<Company> DeleteCompany(System.Guid companyId)
			{
				return Delete<Company>(_ctx.Companies.Where(x => x.CompanyId == companyId).FirstOrDefault());
			}
			public RepositoryActionResult<Company> Delete(Company item)
			{
				return Delete<Company>(_ctx.Companies.Where(x => x.CompanyId == item.CompanyId).FirstOrDefault());
			}
			public RepositoryActionResult<FrequencyType> DeleteFrequencyType(int frequencyTypeId)
			{
				return Delete<FrequencyType>(_ctx.FrequencyTypes.Where(x => x.FrequencyTypeId == frequencyTypeId).FirstOrDefault());
			}
			public RepositoryActionResult<FrequencyType> Delete(FrequencyType item)
			{
				return Delete<FrequencyType>(_ctx.FrequencyTypes.Where(x => x.FrequencyTypeId == item.FrequencyTypeId).FirstOrDefault());
			}
			public RepositoryActionResult<Meeting> DeleteMeeting(System.Guid meetingId)
			{
				return Delete<Meeting>(_ctx.Meetings.Where(x => x.MeetingId == meetingId).FirstOrDefault());
			}
			public RepositoryActionResult<Meeting> Delete(Meeting item)
			{
				return Delete<Meeting>(_ctx.Meetings.Where(x => x.MeetingId == item.MeetingId).FirstOrDefault());
			}
			public RepositoryActionResult<MeetingAttendee> DeleteMeetingAttendee(System.Guid meetingAttendeeId)
			{
				return Delete<MeetingAttendee>(_ctx.MeetingAttendees.Where(x => x.MeetingAttendeeId == meetingAttendeeId).FirstOrDefault());
			}
			public RepositoryActionResult<MeetingAttendee> Delete(MeetingAttendee item)
			{
				return Delete<MeetingAttendee>(_ctx.MeetingAttendees.Where(x => x.MeetingAttendeeId == item.MeetingAttendeeId).FirstOrDefault());
			}
			public RepositoryActionResult<MeetingSchedule> DeleteMeetingSchedule(System.Guid meetingScheduleId)
			{
				return Delete<MeetingSchedule>(_ctx.MeetingSchedules.Where(x => x.MeetingScheduleId == meetingScheduleId).FirstOrDefault());
			}
			public RepositoryActionResult<MeetingSchedule> Delete(MeetingSchedule item)
			{
				return Delete<MeetingSchedule>(_ctx.MeetingSchedules.Where(x => x.MeetingScheduleId == item.MeetingScheduleId).FirstOrDefault());
			}
			public RepositoryActionResult<NotificationMethodType> DeleteNotificationMethodType(int notificationMethodTypeId)
			{
				return Delete<NotificationMethodType>(_ctx.NotificationMethodTypes.Where(x => x.NotificationMethodTypeId == notificationMethodTypeId).FirstOrDefault());
			}
			public RepositoryActionResult<NotificationMethodType> Delete(NotificationMethodType item)
			{
				return Delete<NotificationMethodType>(_ctx.NotificationMethodTypes.Where(x => x.NotificationMethodTypeId == item.NotificationMethodTypeId).FirstOrDefault());
			}
			public RepositoryActionResult<NotificationRule> DeleteNotificationRule(System.Guid notificationRuleId)
			{
				return Delete<NotificationRule>(_ctx.NotificationRules.Where(x => x.NotificationRuleId == notificationRuleId).FirstOrDefault());
			}
			public RepositoryActionResult<NotificationRule> Delete(NotificationRule item)
			{
				return Delete<NotificationRule>(_ctx.NotificationRules.Where(x => x.NotificationRuleId == item.NotificationRuleId).FirstOrDefault());
			}
			public RepositoryActionResult<RecurrenceRule> DeleteRecurrenceRule(System.Guid recurrenceRuleId)
			{
				return Delete<RecurrenceRule>(_ctx.RecurrenceRules.Where(x => x.RecurrenceRuleId == recurrenceRuleId).FirstOrDefault());
			}
			public RepositoryActionResult<RecurrenceRule> Delete(RecurrenceRule item)
			{
				return Delete<RecurrenceRule>(_ctx.RecurrenceRules.Where(x => x.RecurrenceRuleId == item.RecurrenceRuleId).FirstOrDefault());
			}
			public RepositoryActionResult<User> DeleteUser(System.Guid userId)
			{
				return Delete<User>(_ctx.Users.Where(x => x.UserId == userId).FirstOrDefault());
			}
			public RepositoryActionResult<User> Delete(User item)
			{
				return Delete<User>(_ctx.Users.Where(x => x.UserId == item.UserId).FirstOrDefault());
			}

		#endregion Delete


	}
}
