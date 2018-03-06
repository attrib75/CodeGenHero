// <auto-generated> - Template:ModelsBackedByDtoInterface, Version:1.0, Id:4d03f2c7-de27-4aae-a267-cad747c9606a
using System;
using System.Collections.Generic;

namespace CodeGenHero.BingoBuzz.Model.BB.Interface
{
	public partial interface IBingoInstanceContent
	{
		System.Guid BingoContentId { get; }
		System.Guid BingoInstanceContentId { get; }
		int BingoInstanceContentStatusTypeId { get; }
		System.Guid BingoInstanceId { get; }
		int Col { get; }
		System.DateTime CreatedDate { get; }
		System.Guid CreatedUserId { get; }
		bool FreeSquareIndicator { get; }
		bool IsDeleted { get; }
		int Row { get; }
		System.DateTime UpdatedDate { get; }
		System.Guid UpdatedUserId { get; }
		System.Guid UserId { get; }

		IBingoContent BingoContent { get; }
		IBingoInstance BingoInstance { get; }
		IBingoInstanceContentStatusType BingoInstanceContentStatusType { get; }
		IUser CreatedUser { get; }
		IUser UpdatedUser { get; }
		IUser User_UserId { get; }
		List<IBingoInstanceEvent> BingoInstanceEvents { get; }


	}
}
