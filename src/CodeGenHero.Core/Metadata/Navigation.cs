﻿// Copyright (c) Micro Support Center, Inc. All rights reserved.

using System;

namespace CodeGenHero.Core.Metadata
{
	public class Navigation : MetadataBase, INavigation
	{
		public Type ClrType { get; set; }
		public IEntityType DeclaringEntityType { get; set; }
		public ITypeBase DeclaringType { get; set; }
		public IForeignKey ForeignKey { get; set; }
		public string Name { get; set; }
	}
}