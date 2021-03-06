﻿// Copyright (c) Micro Support Center, Inc. All rights reserved.

using System;

namespace CodeGenHero.Core.Metadata
{
	public class Property : MetadataBase, IProperty
	{
		public Type ClrType { get; set; }

		public IEntityType DeclaringEntityType { get; set; }
		public ITypeBase DeclaringType { get; set; }

		public bool IsConcurrencyToken { get; set; }
		public bool IsNullable { get; set; }
		public string Name { get; set; }
	}
}