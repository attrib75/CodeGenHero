/****** Object:  Table [dbo].[BingoContent]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BingoContent](
	[BingoContentId] [uniqueidentifier] NOT NULL,
	[Content] [nvarchar](250) NOT NULL,
	[FreeSquareIndicator] [bit] NOT NULL,
	[NumberOfUpvotes] [int] NOT NULL,
	[NumberOfDownvotes] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedUserId] [uniqueidentifier] NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[UpdatedUserId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_BingoContent] PRIMARY KEY CLUSTERED 
(
	[BingoContentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BingoInstance]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BingoInstance](
	[BingoInstanceId] [uniqueidentifier] NOT NULL,
	[MeetingId] [uniqueidentifier] NULL,
	[NumberOfColumns] [int] NOT NULL,
	[NumberOfRows] [int] NOT NULL,
	[IncludeFreeSquareIndicator] [bit] NOT NULL,
	[BingoInstanceStatusTypeId] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedUserId] [uniqueidentifier] NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[UpdatedUserId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_BingoInstance] PRIMARY KEY CLUSTERED 
(
	[BingoInstanceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BingoInstanceContent]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BingoInstanceContent](
	[BingoInstanceContentId] [uniqueidentifier] NOT NULL,
	[BingoContentId] [uniqueidentifier] NOT NULL,
	[BingoInstanceId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Col] [int] NOT NULL,
	[Row] [int] NOT NULL,
	[FreeSquareIndicator] [bit] NOT NULL,
	[BingoInstanceContentStatusTypeId] INT              CONSTRAINT [DF_BingoInstanceContent_BingoInstanceContentStatusTypeId] DEFAULT ((1)) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedUserId] [uniqueidentifier] NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[UpdatedUserId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_BingoInstanceContent] PRIMARY KEY CLUSTERED 
(
	[BingoInstanceContentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[BingoInstanceContentStatusType]    Script Date: 3/6/2018 12:40:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BingoInstanceContentStatusType](
	[BingoInstanceContentStatusTypeId] [int] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_BingoInstanceContentStatusType] PRIMARY KEY CLUSTERED 
(
	[BingoInstanceContentStatusTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BingoInstanceContentStatusType] ([BingoInstanceContentStatusTypeId], [Name]) VALUES (4, N'Disputed')
GO
INSERT [dbo].[BingoInstanceContentStatusType] ([BingoInstanceContentStatusTypeId], [Name]) VALUES (2, N'Tapped')
GO
INSERT [dbo].[BingoInstanceContentStatusType] ([BingoInstanceContentStatusTypeId], [Name]) VALUES (1, N'Untapped')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_BingoInstanceContentStatusType]    Script Date: 3/6/2018 12:40:48 AM ******/
ALTER TABLE [dbo].[BingoInstanceContentStatusType] ADD  CONSTRAINT [UC_BingoInstanceContentStatusType] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO



/****** Object:  Table [dbo].[BingoInstanceEvent]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BingoInstanceEvent](
	[BingoInstanceEventId] [uniqueidentifier] NOT NULL,
	[BingoInstanceEventTypeId] [int] NOT NULL,
	[BingoInstanceId] [uniqueidentifier] NOT NULL,
	[BingoInstanceContentId] [uniqueidentifier] NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedUserId] [uniqueidentifier] NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[UpdatedUserId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_BingoInstanceEvent] PRIMARY KEY CLUSTERED 
(
	[BingoInstanceEventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BingoInstanceEventType]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BingoInstanceEventType](
	[BingoInstanceEventTypeId] [int] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_BingoInstanceEventType] PRIMARY KEY CLUSTERED 
(
	[BingoInstanceEventTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BingoInstanceStatusType]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BingoInstanceStatusType](
	[BingoInstanceStatusTypeId] [int] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_BingoInstanceStatusType] PRIMARY KEY CLUSTERED 
(
	[BingoInstanceStatusTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CodeName] [nvarchar](50) NOT NULL,
	[Address1] [nvarchar](100) NULL,
	[Address2] [nvarchar](100) NULL,
	[City] [nvarchar](100) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](50) NULL,
	[WebsiteUrl] [nvarchar](100) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedUserId] [uniqueidentifier] NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[UpdatedUserId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FrequencyType]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FrequencyType](
	[FrequencyTypeId] [int] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_FrequencyType] PRIMARY KEY CLUSTERED 
(
	[FrequencyTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Meeting]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meeting](
	[MeetingId] [uniqueidentifier] NOT NULL,
	[CompanyId] [uniqueidentifier] NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedUserId] [uniqueidentifier] NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[UpdatedUserId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Meeting] PRIMARY KEY CLUSTERED 
(
	[MeetingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeetingAttendee]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeetingAttendee](
	[MeetingAttendeeId] [uniqueidentifier] NOT NULL,
	[MeetingId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[NotificationRuleId] [uniqueidentifier] NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedUserId] [uniqueidentifier] NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[UpdatedUserId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_MeetingAttendee] PRIMARY KEY CLUSTERED 
(
	[MeetingAttendeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeetingSchedule]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeetingSchedule](
	[MeetingScheduleId] [uniqueidentifier] NOT NULL,
	[MeetingId] [uniqueidentifier] NULL,
	[StartDate] [datetime2](7) NULL,
	[EndDate] [datetime2](7) NULL,
	[RecurrenceRuleId] [uniqueidentifier] NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedUserId] [uniqueidentifier] NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[UpdatedUserId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_MeetingSchedule] PRIMARY KEY CLUSTERED 
(
	[MeetingScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotificationMethodType]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotificationMethodType](
	[NotificationMethodTypeId] [int] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_NotificationMethodType] PRIMARY KEY CLUSTERED 
(
	[NotificationMethodTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotificationRule]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotificationRule](
	[NotificationRuleId] [uniqueidentifier] NOT NULL,
	[NotificationMethodTypeId] [int] NOT NULL,
	[MinutesBeforehand] [int] NOT NULL,
 CONSTRAINT [PK_NotificationRule] PRIMARY KEY CLUSTERED 
(
	[NotificationRuleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecurrenceRule]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecurrenceRule](
	[RecurrenceRuleId] [uniqueidentifier] NOT NULL,
	[FrequencyTypeId] [int] NOT NULL,
	[EndDate] [datetime2](7) NULL,
	[Seconds] [int] NULL,
	[Minutes] [int] NULL,
	[Hour] [int] NULL,
	[WeekDayNum] [int] NULL,
	[OrdWeek] [int] NULL,
	[WeekDay] [nvarchar](50) NULL,
 CONSTRAINT [PK_RecurrenceRule] PRIMARY KEY CLUSTERED 
(
	[RecurrenceRuleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 3/6/2018 12:05:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [uniqueidentifier] NOT NULL,
	[CompanyId] [uniqueidentifier] NOT NULL,
	[Email] [nvarchar](250) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedUserId] [uniqueidentifier] NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[UpdatedUserId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'b69ee36e-cc08-4779-8fa6-020e1a16b743', N'Discussion of requirements modification', 0, 0, 0, CAST(N'2018-02-18T10:13:22.1966667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:13:22.1966667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'6e4fbf16-1536-41da-a4c9-07a94e09cc72', N'Mysterous (child, animal or otherwise) noises', 0, 0, 0, CAST(N'2018-02-18T10:21:54.9133333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:21:54.9133333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'e30c4eb4-8000-401c-8632-12edc20975d1', N'Someone broke the build', 0, 0, 0, CAST(N'2018-02-18T10:18:01.5466667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:18:01.5466667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'1cc6e2e6-eaa7-4b06-8c18-238a33ead75d', N'I should wrap that up today', 0, 0, 0, CAST(N'2018-02-18T10:26:05.0033333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:26:05.0033333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'c02bf9df-0a71-4841-892d-31eee4c09e74', N'Someone talking on mute', 0, 0, 0, CAST(N'2018-02-18T10:23:13.3066667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:23:13.3066667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'ab1da71e-80ac-434d-8ce5-36d543c45cbd', N'Mysterous (child, animal or otherwise) noises', 0, 0, 0, CAST(N'2018-02-18T10:21:45.3400000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:21:45.3400000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'442c0644-eda3-4e03-bd74-3b68137b98c6', N'Spoiler alert for TV, film or video game', 0, 0, 0, CAST(N'2018-02-18T10:19:40.4966667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:19:40.4966667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'8604338d-d514-4ba3-a4e8-4208a5a5b9e8', N'"Hi, who just joined?"', 0, 0, 0, CAST(N'2018-02-18T10:18:57.4333333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:18:57.4333333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'edd189aa-2e32-4151-b762-505f2bae4d82', N'Mysterious botched code commit or merge', 0, 0, 0, CAST(N'2018-02-18T10:20:04.8700000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:20:04.8700000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'f08a5971-33f0-40a0-abb4-53d21dbb180d', N'"Go-No-Go"', 0, 0, 0, CAST(N'2018-02-18T10:24:05.8433333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:24:05.8433333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'7dea3cce-9cd8-482c-81ff-5ac9546951a4', N'Technical difficulties', 0, 0, 0, CAST(N'2018-02-18T10:14:24.4700000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:14:24.4700000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'5d956b3e-36db-43fe-9032-64a9725e2fcb', N'Sports reference', 0, 0, 0, CAST(N'2018-02-18T10:12:58.1966667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:12:58.1966667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'a2169f1d-ff2c-468e-9bcf-6eba7dc4cfe2', N'Works on my machine', 0, 0, 0, CAST(N'2018-02-18T10:18:21.5333333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:18:21.5333333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'272aaf2f-f2c5-4043-bf97-77219afe4f0a', N'Conference call muted for side-talk', 0, 0, 0, CAST(N'2018-02-18T10:16:05.7466667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:16:05.7466667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'0b2563a8-5b79-40af-bd26-7d172e4e7c11', N'"Oh yeah, I haven''t updated TFS/Jira yet"', 0, 0, 0, CAST(N'2018-02-18T10:25:18.1433333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:25:18.1433333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'cc381f60-7bea-40a8-8ea9-7fe92df43314', N'Accidential screen sharing', 0, 0, 0, CAST(N'2018-02-18T10:20:59.0166667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:20:59.0166667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'c7ec2e2a-159f-4459-80d5-8ea295054e5f', N'Day of the week used as excuse for behavior', 0, 0, 0, CAST(N'2018-02-18T10:16:34.7133333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:16:34.7133333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'6bbb1787-2e88-457a-83d3-a12a52f6b1c0', N'Coughing', 0, 0, 0, CAST(N'2018-02-18T10:23:31.9100000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:23:31.9100000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'fe0d9a0e-e48f-4340-a61b-a2f55c84d306', N'"Shoot me an email"', 0, 0, 0, CAST(N'2018-02-18T10:12:35.9233333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:12:35.9233333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'f9ade4e4-aa84-476f-9d1f-a49b3a5eeeaf', N'FREE SQUARE', 1, 0, 0, CAST(N'2018-02-18T10:17:22.3700000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:17:22.3700000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'8128a03f-e230-4042-bd82-acf84cdeaa33', N'Weather comment', 0, 0, 0, CAST(N'2018-02-18T10:16:57.5400000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:16:57.5400000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'f99f457c-3467-4d4c-9b02-bb5d634957b8', N'Re-bug of past defect', 0, 0, 0, CAST(N'2018-02-18T10:22:37.7900000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:22:37.7900000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'0680b612-2a47-4e81-892e-d39fb5d4442a', N'Sound of food or drink consumed', 0, 0, 0, CAST(N'2018-02-18T10:24:27.2500000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:24:27.2500000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'b9514a1d-5e8f-4ebd-a43f-d424de62ca19', N'"Keep me in the loop"', 0, 0, 0, CAST(N'2018-02-18T10:12:12.8233333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:12:12.8233333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'844a57c7-1880-4b68-87d3-ded72a8ec4f9', N'"Let''s take this off line"', 0, 0, 0, CAST(N'2018-02-18T10:11:14.8733333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:11:14.8733333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'9b13f136-6ae6-45d7-ad6f-e62da9ba5a29', N'Painful silence', 0, 0, 0, CAST(N'2018-02-18T10:15:19.5300000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:15:19.5300000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'bb85c331-d730-4d61-91f0-eb813ebe5b01', N'Background cell phone ring or ding', 0, 0, 0, CAST(N'2018-02-18T10:14:52.1966667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:14:52.1966667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'9c441e05-648f-4a75-8dbf-f0f2a7627429', N'Boss makes an unfunny joke but everyone laughs', 0, 0, 0, CAST(N'2018-02-18T10:13:59.7433333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:13:59.7433333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoContent] ([BingoContentId], [Content], [FreeSquareIndicator], [NumberOfUpvotes], [NumberOfDownvotes], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'98d5b091-8fe8-45dd-8a6c-f213a0e4188a', N'I am going to check that in right after this meeting', 0, 0, 0, CAST(N'2018-02-18T10:25:39.9333333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:25:39.9333333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[BingoInstanceEventType] ([BingoInstanceEventTypeId], [Name]) VALUES (1, N'Square Clicked')
INSERT [dbo].[BingoInstanceStatusType] ([BingoInstanceStatusTypeId], [Name]) VALUES (1, N'New')
INSERT [dbo].[BingoInstanceStatusType] ([BingoInstanceStatusTypeId], [Name]) VALUES (2, N'Active')
INSERT [dbo].[BingoInstanceStatusType] ([BingoInstanceStatusTypeId], [Name]) VALUES (4, N'Complete')
INSERT [dbo].[Company] ([CompanyId], [Name], [CodeName], [Address1], [Address2], [City], [State], [Zip], [WebsiteUrl], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'7a1d1116-4b6b-4df6-9f9b-6af4d222ff32', N'MSCTek', N'MSCTEK', NULL, NULL, N'Geneva', N'Illinois', N'60134', N'www.msctek.com', CAST(N'2018-02-18T10:06:20.6000000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:06:20.6000000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[FrequencyType] ([FrequencyTypeId], [Name]) VALUES (8, N'Daily')
INSERT [dbo].[FrequencyType] ([FrequencyTypeId], [Name]) VALUES (4, N'Hourly')
INSERT [dbo].[FrequencyType] ([FrequencyTypeId], [Name]) VALUES (2, N'Minutely')
INSERT [dbo].[FrequencyType] ([FrequencyTypeId], [Name]) VALUES (32, N'Monthly')
INSERT [dbo].[FrequencyType] ([FrequencyTypeId], [Name]) VALUES (1, N'Secondly')
INSERT [dbo].[FrequencyType] ([FrequencyTypeId], [Name]) VALUES (16, N'Weekly')
INSERT [dbo].[FrequencyType] ([FrequencyTypeId], [Name]) VALUES (64, N'Yearly')
INSERT [dbo].[Meeting] ([MeetingId], [CompanyId], [Name], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'8e99f97e-4f68-4308-beeb-43af72232a44', N'7a1d1116-4b6b-4df6-9f9b-6af4d222ff32', N'BingoBuzz Sprint Planning', CAST(N'2018-02-18T10:29:55.3766667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:29:55.3766667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[Meeting] ([MeetingId], [CompanyId], [Name], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'47560033-421b-48c2-b8e6-88b878610835', N'7a1d1116-4b6b-4df6-9f9b-6af4d222ff32', N'BingoBuzz Mockup Review', CAST(N'2018-02-18T10:29:15.1800000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:29:15.1800000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[Meeting] ([MeetingId], [CompanyId], [Name], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'a4e239cf-692a-4108-b9d3-c56a6e4eca2b', N'7a1d1116-4b6b-4df6-9f9b-6af4d222ff32', N'BingoBuzz Sprint Review', CAST(N'2018-02-18T10:29:33.7866667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:29:33.7866667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[MeetingAttendee] ([MeetingAttendeeId], [MeetingId], [UserId], [NotificationRuleId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'ac926329-125c-4977-a987-2ba2f6e7cc57', N'47560033-421b-48c2-b8e6-88b878610835', N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', NULL, CAST(N'2018-02-18T10:33:56.5166667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:33:56.5166667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[MeetingAttendee] ([MeetingAttendeeId], [MeetingId], [UserId], [NotificationRuleId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'91714641-5d2a-49f5-9c59-310955b9e52d', N'8e99f97e-4f68-4308-beeb-43af72232a44', N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', NULL, CAST(N'2018-02-18T10:33:37.2100000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:33:37.2100000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[MeetingAttendee] ([MeetingAttendeeId], [MeetingId], [UserId], [NotificationRuleId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'f8c83ac2-f2f9-4b29-bd0e-3fbe03844cd3', N'a4e239cf-692a-4108-b9d3-c56a6e4eca2b', N'9f3441f1-625c-439e-96eb-19ec41076408', NULL, CAST(N'2018-02-18T10:34:22.6100000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:34:22.6100000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[MeetingAttendee] ([MeetingAttendeeId], [MeetingId], [UserId], [NotificationRuleId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'd7528577-3a3e-4b39-ac7d-4093ca54f1da', N'a4e239cf-692a-4108-b9d3-c56a6e4eca2b', N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', NULL, CAST(N'2018-02-18T10:34:41.6633333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:34:41.6633333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[MeetingAttendee] ([MeetingAttendeeId], [MeetingId], [UserId], [NotificationRuleId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'7e93c906-1005-4bb6-b21c-9daacded47a9', N'47560033-421b-48c2-b8e6-88b878610835', N'9f3441f1-625c-439e-96eb-19ec41076408', NULL, CAST(N'2018-02-18T10:34:12.8766667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:34:12.8766667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[MeetingAttendee] ([MeetingAttendeeId], [MeetingId], [UserId], [NotificationRuleId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'7f806366-b62a-411b-86c7-a5b4b373cdee', N'a4e239cf-692a-4108-b9d3-c56a6e4eca2b', N'04b27cab-48d1-40ff-bf78-b79e834e2145', NULL, CAST(N'2018-02-18T10:34:34.7800000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:34:34.7800000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[MeetingAttendee] ([MeetingAttendeeId], [MeetingId], [UserId], [NotificationRuleId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'14c53c36-3c28-40de-acc2-ad60cdbd3e7b', N'8e99f97e-4f68-4308-beeb-43af72232a44', N'04b27cab-48d1-40ff-bf78-b79e834e2145', NULL, CAST(N'2018-02-18T10:33:28.9333333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:33:28.9333333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[MeetingAttendee] ([MeetingAttendeeId], [MeetingId], [UserId], [NotificationRuleId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'd1cb2884-20c2-45f8-bbed-b0d90bd385ae', N'8e99f97e-4f68-4308-beeb-43af72232a44', N'9f3441f1-625c-439e-96eb-19ec41076408', NULL, CAST(N'2018-02-18T10:32:58.3066667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:32:58.3066667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[MeetingAttendee] ([MeetingAttendeeId], [MeetingId], [UserId], [NotificationRuleId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'4660d4ff-9019-4bdb-9af7-e67b125d0134', N'47560033-421b-48c2-b8e6-88b878610835', N'04b27cab-48d1-40ff-bf78-b79e834e2145', NULL, CAST(N'2018-02-18T10:34:04.7566667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:34:04.7566667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[MeetingSchedule] ([MeetingScheduleId], [MeetingId], [StartDate], [EndDate], [RecurrenceRuleId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'422faa08-6f49-4a75-a0f0-56873a6d4bdc', N'a4e239cf-692a-4108-b9d3-c56a6e4eca2b', CAST(N'2018-02-26T08:30:00.0000000' AS DateTime2), CAST(N'2018-02-26T10:30:00.0000000' AS DateTime2), NULL, CAST(N'2018-02-18T10:38:01.0400000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:38:01.0400000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[MeetingSchedule] ([MeetingScheduleId], [MeetingId], [StartDate], [EndDate], [RecurrenceRuleId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'f0ad51bc-7083-4fec-bf0a-8961e116e3c1', N'47560033-421b-48c2-b8e6-88b878610835', CAST(N'2018-02-27T10:30:00.0000000' AS DateTime2), CAST(N'2018-02-27T12:00:00.0000000' AS DateTime2), NULL, CAST(N'2018-02-18T10:38:55.1333333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:38:55.1333333' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[MeetingSchedule] ([MeetingScheduleId], [MeetingId], [StartDate], [EndDate], [RecurrenceRuleId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'c5720489-3c0c-4ef0-aee6-ea58f3dfcdb4', N'8e99f97e-4f68-4308-beeb-43af72232a44', CAST(N'2018-02-26T01:30:00.0000000' AS DateTime2), CAST(N'2018-02-26T03:30:00.0000000' AS DateTime2), NULL, CAST(N'2018-02-18T10:38:25.0100000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:38:25.0100000' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[NotificationMethodType] ([NotificationMethodTypeId], [Name]) VALUES (1, N'SMS')
INSERT [dbo].[NotificationMethodType] ([NotificationMethodTypeId], [Name]) VALUES (2, N'Email')
INSERT [dbo].[User] ([UserId], [CompanyId], [Email], [FirstName], [LastName], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'9f3441f1-625c-439e-96eb-19ec41076408', N'7a1d1116-4b6b-4df6-9f9b-6af4d222ff32', N'paul@msctek.com', N'Paul', N'Schroeder', CAST(N'2018-02-18T10:07:38.8666667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:07:38.8666667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[User] ([UserId], [CompanyId], [Email], [FirstName], [LastName], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'04b27cab-48d1-40ff-bf78-b79e834e2145', N'7a1d1116-4b6b-4df6-9f9b-6af4d222ff32', N'jwall@msctek.com', N'Jim', N'Wall', CAST(N'2018-02-18T10:08:06.1066667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:08:06.1066667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
INSERT [dbo].[User] ([UserId], [CompanyId], [Email], [FirstName], [LastName], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId], [IsDeleted]) VALUES (N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', N'7a1d1116-4b6b-4df6-9f9b-6af4d222ff32', N'robin@msctek.com', N'Robin', N'Schroeder', CAST(N'2018-02-18T10:06:14.3766667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', CAST(N'2018-02-18T10:06:14.3766667' AS DateTime2), N'b79ed0e3-ddb9-4920-8900-ffc55a73b4b5', 0)
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_Company_CodeName]    Script Date: 3/6/2018 12:05:54 AM ******/
ALTER TABLE [dbo].[Company] ADD  CONSTRAINT [UC_Company_CodeName] UNIQUE NONCLUSTERED 
(
	[CodeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_FrequencyType]    Script Date: 3/6/2018 12:05:54 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_FrequencyType] ON [dbo].[FrequencyType]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BingoContent] ADD  CONSTRAINT [DF_BingoContent_BingoContentId]  DEFAULT (newid()) FOR [BingoContentId]
GO
ALTER TABLE [dbo].[BingoContent] ADD  CONSTRAINT [DF_BingoContent_FreeSquareIndicator]  DEFAULT ((0)) FOR [FreeSquareIndicator]
GO
ALTER TABLE [dbo].[BingoContent] ADD  CONSTRAINT [DF_BingoContent_NumberOfUpvotes]  DEFAULT ((0)) FOR [NumberOfUpvotes]
GO
ALTER TABLE [dbo].[BingoContent] ADD  CONSTRAINT [DF_BingoContent_NumberOfDownvotes]  DEFAULT ((0)) FOR [NumberOfDownvotes]
GO
ALTER TABLE [dbo].[BingoContent] ADD  CONSTRAINT [DF_BingoContent_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[BingoInstance] ADD  CONSTRAINT [DF_BingoInstance_BingoInstanceId]  DEFAULT (newid()) FOR [BingoInstanceId]
GO
ALTER TABLE [dbo].[BingoInstance] ADD  CONSTRAINT [DF_BingoInstance_IncludeFreeSquareIndicator]  DEFAULT ((1)) FOR [IncludeFreeSquareIndicator]
GO
ALTER TABLE [dbo].[BingoInstance] ADD  CONSTRAINT [DF_BingoInstance_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[BingoInstanceContent] ADD  CONSTRAINT [DF_BingoInstanceContent_BingoInstanceContentId]  DEFAULT (newid()) FOR [BingoInstanceContentId]
GO
ALTER TABLE [dbo].[BingoInstanceContent] ADD  CONSTRAINT [DF_BingoInstanceContent_FreeSquareIndicator]  DEFAULT ((1)) FOR [FreeSquareIndicator]
GO
ALTER TABLE [dbo].[BingoInstanceContent] ADD  CONSTRAINT [DF_BingoInstanceContent_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[BingoInstanceEvent] ADD  CONSTRAINT [DF_BingoInstanceEvent_BingoInstanceEventId]  DEFAULT (newid()) FOR [BingoInstanceEventId]
GO
ALTER TABLE [dbo].[BingoInstanceEvent] ADD  CONSTRAINT [DF_BingoInstanceEvent_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Company] ADD  CONSTRAINT [DF_Company_CompanyId]  DEFAULT (newid()) FOR [CompanyId]
GO
ALTER TABLE [dbo].[Company] ADD  CONSTRAINT [DF_Company_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Meeting] ADD  CONSTRAINT [DF_Meeting_MeetingId]  DEFAULT (newid()) FOR [MeetingId]
GO
ALTER TABLE [dbo].[Meeting] ADD  CONSTRAINT [DF_Meeting_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[MeetingAttendee] ADD  CONSTRAINT [DF_MeetingAttendee_MeetingAttendeeId]  DEFAULT (newid()) FOR [MeetingAttendeeId]
GO
ALTER TABLE [dbo].[MeetingAttendee] ADD  CONSTRAINT [DF_MeetingAttendee_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[MeetingSchedule] ADD  CONSTRAINT [DF_MeetingSchedule_MeetingScheduleId]  DEFAULT (newid()) FOR [MeetingScheduleId]
GO
ALTER TABLE [dbo].[MeetingSchedule] ADD  CONSTRAINT [DF_MeetingSchedule_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[NotificationRule] ADD  CONSTRAINT [DF_NotificationRule_NotificationRuleId]  DEFAULT (newid()) FOR [NotificationRuleId]
GO
ALTER TABLE [dbo].[RecurrenceRule] ADD  CONSTRAINT [DF_RecurrenceRule_RecurrenceRuleId]  DEFAULT (newid()) FOR [RecurrenceRuleId]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_UserId]  DEFAULT (newid()) FOR [UserId]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[BingoContent]  WITH CHECK ADD  CONSTRAINT [FK_BingoContent_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[BingoContent] CHECK CONSTRAINT [FK_BingoContent_User_CreatedUserId]
GO
ALTER TABLE [dbo].[BingoContent]  WITH CHECK ADD  CONSTRAINT [FK_BingoContent_User_UpdatedUserId] FOREIGN KEY([UpdatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[BingoContent] CHECK CONSTRAINT [FK_BingoContent_User_UpdatedUserId]
GO
ALTER TABLE [dbo].[BingoInstance]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstance_Meeting] FOREIGN KEY([MeetingId])
REFERENCES [dbo].[Meeting] ([MeetingId])
GO
ALTER TABLE [dbo].[BingoInstance] CHECK CONSTRAINT [FK_BingoInstance_Meeting]
GO
ALTER TABLE [dbo].[BingoInstance]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstance_User_Created] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[BingoInstance] CHECK CONSTRAINT [FK_BingoInstance_User_Created]
GO
ALTER TABLE [dbo].[BingoInstance]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstance_User_Updated] FOREIGN KEY([UpdatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[BingoInstance] CHECK CONSTRAINT [FK_BingoInstance_User_Updated]
GO
ALTER TABLE [dbo].[BingoInstanceContent]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstanceContent_BingoContent] FOREIGN KEY([BingoContentId])
REFERENCES [dbo].[BingoContent] ([BingoContentId])
GO
ALTER TABLE [dbo].[BingoInstanceContent] CHECK CONSTRAINT [FK_BingoInstanceContent_BingoContent]
GO
ALTER TABLE [dbo].[BingoInstanceContent]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstanceContent_BingoInstance] FOREIGN KEY([BingoInstanceId])
REFERENCES [dbo].[BingoInstance] ([BingoInstanceId])
GO
ALTER TABLE [dbo].[BingoInstanceContent]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstanceContent_BingoInstanceContentStatusType] FOREIGN KEY([BingoInstanceContentStatusTypeId])
REFERENCES [dbo].[BingoInstanceContentStatusType] ([BingoInstanceContentStatusTypeId])
GO
ALTER TABLE [dbo].[BingoInstanceContent] CHECK CONSTRAINT [FK_BingoInstanceContent_BingoInstance]
GO
ALTER TABLE [dbo].[BingoInstanceContent]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstanceContent_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[BingoInstanceContent] CHECK CONSTRAINT [FK_BingoInstanceContent_User]
GO
ALTER TABLE [dbo].[BingoInstanceContent]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstanceContent_User_Created] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[BingoInstanceContent] CHECK CONSTRAINT [FK_BingoInstanceContent_User_Created]
GO
ALTER TABLE [dbo].[BingoInstanceContent]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstanceContent_User_Updated] FOREIGN KEY([UpdatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[BingoInstanceContent] CHECK CONSTRAINT [FK_BingoInstanceContent_User_Updated]
GO
ALTER TABLE [dbo].[BingoInstanceEvent]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstanceEvent_BingoInstance] FOREIGN KEY([BingoInstanceId])
REFERENCES [dbo].[BingoInstance] ([BingoInstanceId])
GO
ALTER TABLE [dbo].[BingoInstanceEvent] CHECK CONSTRAINT [FK_BingoInstanceEvent_BingoInstance]
GO
ALTER TABLE [dbo].[BingoInstanceEvent]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstanceEvent_BingoInstanceContent] FOREIGN KEY([BingoInstanceContentId])
REFERENCES [dbo].[BingoInstanceContent] ([BingoInstanceContentId])
GO
ALTER TABLE [dbo].[BingoInstanceEvent] CHECK CONSTRAINT [FK_BingoInstanceEvent_BingoInstanceContent]
GO
ALTER TABLE [dbo].[BingoInstanceEvent]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstanceEvent_BingoInstanceEventType] FOREIGN KEY([BingoInstanceEventTypeId])
REFERENCES [dbo].[BingoInstanceEventType] ([BingoInstanceEventTypeId])
GO
ALTER TABLE [dbo].[BingoInstanceEvent] CHECK CONSTRAINT [FK_BingoInstanceEvent_BingoInstanceEventType]
GO
ALTER TABLE [dbo].[BingoInstanceEvent]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstanceEvent_User_Created] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[BingoInstanceEvent] CHECK CONSTRAINT [FK_BingoInstanceEvent_User_Created]
GO
ALTER TABLE [dbo].[BingoInstanceEvent]  WITH CHECK ADD  CONSTRAINT [FK_BingoInstanceEvent_User_Updated] FOREIGN KEY([UpdatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[BingoInstanceEvent] CHECK CONSTRAINT [FK_BingoInstanceEvent_User_Updated]
GO
ALTER TABLE [dbo].[Company]  WITH CHECK ADD  CONSTRAINT [FK_Company_User_Created] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Company] CHECK CONSTRAINT [FK_Company_User_Created]
GO
ALTER TABLE [dbo].[Company]  WITH CHECK ADD  CONSTRAINT [FK_Company_User_Updated] FOREIGN KEY([UpdatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Company] CHECK CONSTRAINT [FK_Company_User_Updated]
GO
ALTER TABLE [dbo].[Meeting]  WITH CHECK ADD  CONSTRAINT [FK_Meeting_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Meeting] CHECK CONSTRAINT [FK_Meeting_Company]
GO
ALTER TABLE [dbo].[Meeting]  WITH CHECK ADD  CONSTRAINT [FK_Meeting_User_Created] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Meeting] CHECK CONSTRAINT [FK_Meeting_User_Created]
GO
ALTER TABLE [dbo].[Meeting]  WITH CHECK ADD  CONSTRAINT [FK_Meeting_User_Updated] FOREIGN KEY([UpdatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Meeting] CHECK CONSTRAINT [FK_Meeting_User_Updated]
GO
ALTER TABLE [dbo].[MeetingAttendee]  WITH CHECK ADD  CONSTRAINT [FK_MeetingAttendee_Meeting] FOREIGN KEY([MeetingId])
REFERENCES [dbo].[Meeting] ([MeetingId])
GO
ALTER TABLE [dbo].[MeetingAttendee] CHECK CONSTRAINT [FK_MeetingAttendee_Meeting]
GO
ALTER TABLE [dbo].[MeetingAttendee]  WITH CHECK ADD  CONSTRAINT [FK_MeetingAttendee_NotificationRule] FOREIGN KEY([NotificationRuleId])
REFERENCES [dbo].[NotificationRule] ([NotificationRuleId])
GO
ALTER TABLE [dbo].[MeetingAttendee] CHECK CONSTRAINT [FK_MeetingAttendee_NotificationRule]
GO
ALTER TABLE [dbo].[MeetingAttendee]  WITH CHECK ADD  CONSTRAINT [FK_MeetingAttendee_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MeetingAttendee] CHECK CONSTRAINT [FK_MeetingAttendee_User]
GO
ALTER TABLE [dbo].[MeetingAttendee]  WITH CHECK ADD  CONSTRAINT [FK_MeetingAttendee_User_Created] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MeetingAttendee] CHECK CONSTRAINT [FK_MeetingAttendee_User_Created]
GO
ALTER TABLE [dbo].[MeetingAttendee]  WITH CHECK ADD  CONSTRAINT [FK_MeetingAttendee_User_Updated] FOREIGN KEY([UpdatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MeetingAttendee] CHECK CONSTRAINT [FK_MeetingAttendee_User_Updated]
GO
ALTER TABLE [dbo].[MeetingSchedule]  WITH CHECK ADD  CONSTRAINT [FK_MeetingSchedule_Meeting] FOREIGN KEY([MeetingId])
REFERENCES [dbo].[Meeting] ([MeetingId])
GO
ALTER TABLE [dbo].[MeetingSchedule] CHECK CONSTRAINT [FK_MeetingSchedule_Meeting]
GO
ALTER TABLE [dbo].[MeetingSchedule]  WITH CHECK ADD  CONSTRAINT [FK_MeetingSchedule_RecurrenceRule] FOREIGN KEY([RecurrenceRuleId])
REFERENCES [dbo].[RecurrenceRule] ([RecurrenceRuleId])
GO
ALTER TABLE [dbo].[MeetingSchedule] CHECK CONSTRAINT [FK_MeetingSchedule_RecurrenceRule]
GO
ALTER TABLE [dbo].[MeetingSchedule]  WITH CHECK ADD  CONSTRAINT [FK_MeetingSchedule_User_Created] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MeetingSchedule] CHECK CONSTRAINT [FK_MeetingSchedule_User_Created]
GO
ALTER TABLE [dbo].[MeetingSchedule]  WITH CHECK ADD  CONSTRAINT [FK_MeetingSchedule_User_Updated] FOREIGN KEY([UpdatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MeetingSchedule] CHECK CONSTRAINT [FK_MeetingSchedule_User_Updated]
GO
ALTER TABLE [dbo].[NotificationRule]  WITH CHECK ADD  CONSTRAINT [FK_NotificationRule_NotificationMethodType] FOREIGN KEY([NotificationMethodTypeId])
REFERENCES [dbo].[NotificationMethodType] ([NotificationMethodTypeId])
GO
ALTER TABLE [dbo].[NotificationRule] CHECK CONSTRAINT [FK_NotificationRule_NotificationMethodType]
GO
ALTER TABLE [dbo].[RecurrenceRule]  WITH CHECK ADD  CONSTRAINT [FK_RecurrenceRule_FrequencyType] FOREIGN KEY([FrequencyTypeId])
REFERENCES [dbo].[FrequencyType] ([FrequencyTypeId])
GO
ALTER TABLE [dbo].[RecurrenceRule] CHECK CONSTRAINT [FK_RecurrenceRule_FrequencyType]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Created] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Created]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Updated] FOREIGN KEY([UpdatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Updated]
GO
ALTER TABLE [dbo].[BingoInstanceEventType] ADD  CONSTRAINT [UC_BingoInstanceEventType] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BingoInstanceStatusType] ADD  CONSTRAINT [UC_BingoInstanceStatusType] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE dbo.BingoInstance ADD CONSTRAINT
	FK_BingoInstance_BingoInstanceStatusType FOREIGN KEY
	(
	BingoInstanceStatusTypeId
	) REFERENCES dbo.BingoInstanceStatusType
	(
	BingoInstanceStatusTypeId
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
