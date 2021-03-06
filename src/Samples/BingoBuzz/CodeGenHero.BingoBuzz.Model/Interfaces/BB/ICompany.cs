// <auto-generated> - Template:ModelsBackedByDtoInterface, Version:1.1, Id:4d03f2c7-de27-4aae-a267-cad747c9606a
using System;
using System.Collections.Generic;

namespace CodeGenHero.BingoBuzz.Model.BB.Interface
{
	public partial interface ICompany
	{
		string Address1 { get; }
		string Address2 { get; }
		string City { get; }
		string CodeName { get; }
		System.Guid CompanyId { get; }
		System.DateTime CreatedDate { get; }
		System.Guid CreatedUserId { get; }
		bool IsDeleted { get; }
		string Name { get; }
		string State { get; }
		System.DateTime UpdatedDate { get; }
		System.Guid UpdatedUserId { get; }
		string WebsiteUrl { get; }
		string Zip { get; }

		IUser CreatedUser { get; }
		IUser UpdatedUser { get; }
		List<IMeeting> Meetings { get; }


	}
}
