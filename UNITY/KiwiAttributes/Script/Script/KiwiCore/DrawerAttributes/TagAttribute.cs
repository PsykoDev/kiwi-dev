﻿using System;

namespace KiwiAttributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class TagAttribute : DrawerAttribute
	{
	}
}