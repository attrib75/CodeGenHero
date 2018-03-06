// <auto-generated> - Template:ModelsBackedByDto, Version:1.0, Id:4d03f2c7-de26-4abe-a267-cad747c9606a
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

	public class LoadRequestBingoInstance : EventArgs
	{
		public LoadRequestBingoInstance(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class BingoInstance : BaseModel<IWebApiDataServiceBB>, IBingoInstance
	{
		public event EventHandler<LoadRequestBingoInstance> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.BingoInstance _dto = null;

		public BingoInstance(ILoggingService log, IDataService<IWebApiDataServiceBB> dataService) : base(log, dataService)
		{
			_dto = new xDTO.BingoInstance();
			OnLazyLoadRequest += HandleLazyLoadRequestAsync;
		}

		public BingoInstance(ILoggingService log, IDataService<IWebApiDataServiceBB> dataService, xDTO.BingoInstance dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual System.Guid BingoInstanceId { get { return _dto.BingoInstanceId; } }
		public virtual int BingoInstanceStatusTypeId { get { return _dto.BingoInstanceStatusTypeId; } }
		public virtual System.DateTime CreatedDate { get { return _dto.CreatedDate; } }
		public virtual System.Guid CreatedUserId { get { return _dto.CreatedUserId; } }
		public virtual bool IncludeFreeSquareIndicator { get { return _dto.IncludeFreeSquareIndicator; } }
		public virtual bool IsDeleted { get { return _dto.IsDeleted; } }
		public virtual System.Guid? MeetingId { get { return _dto.MeetingId; } }
		public virtual int NumberOfColumns { get { return _dto.NumberOfColumns; } }
		public virtual int NumberOfRows { get { return _dto.NumberOfRows; } }
		public virtual System.DateTime UpdatedDate { get { return _dto.UpdatedDate; } }
		public virtual System.Guid UpdatedUserId { get { return _dto.UpdatedUserId; } }

		private IBingoInstanceStatusType _bingoInstanceStatusType = null; // Foreign Key
		private IMeeting _meeting = null; // Foreign Key
		private IUser _createdUser = null; // Foreign Key
		private IUser _updatedUser = null; // Foreign Key
		private List<IBingoInstanceContent> _bingoInstanceContents = null; // Reverse Navigation
		private List<IBingoInstanceEvent> _bingoInstanceEvents = null; // Reverse Navigation


		public virtual IBingoInstanceStatusType BingoInstanceStatusType
		{
			get
			{
				if (_bingoInstanceStatusType == null)
				{
					_bingoInstanceStatusType = new BingoInstanceStatusType(Log, DataService, _dto.BingoInstanceStatusType);
				}

				return _bingoInstanceStatusType;
			}
		}

		public virtual IMeeting Meeting
		{
			get
			{
				if (_meeting == null)
				{
					_meeting = new Meeting(Log, DataService, _dto.Meeting);
				}

				return _meeting;
			}
		}

		public virtual IUser CreatedUser
		{
			get
			{
				if (_createdUser == null)
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
				if (_updatedUser == null)
				{
					_updatedUser = new User(Log, DataService, _dto.UpdatedUser);
				}

				return _updatedUser;
			}
		}

		public virtual List<IBingoInstanceContent> BingoInstanceContents
		{
			get
			{
				if (_bingoInstanceContents == null)
				{
					_bingoInstanceContents = new List<IBingoInstanceContent>();
					foreach (var dtoItem in _dto.BingoInstanceContents)
					{
						_bingoInstanceContents.Add(new BingoInstanceContent(Log, DataService, dtoItem));
					}
				}

				return _bingoInstanceContents;
			}
		}

		public virtual List<IBingoInstanceEvent> BingoInstanceEvents
		{
			get
			{
				if (_bingoInstanceEvents == null)
				{
					_bingoInstanceEvents = new List<IBingoInstanceEvent>();
					foreach (var dtoItem in _dto.BingoInstanceEvents)
					{
						_bingoInstanceEvents.Add(new BingoInstanceEvent(Log, DataService, dtoItem));
					}
				}

				return _bingoInstanceEvents;
			}
		}



	}
}
