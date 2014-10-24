﻿using System;

namespace Xenon
{
	public class XenonTestOptions
	{
		private Action<bool, string> _assertMethod;
		public int WaitForSeconds { get; set; } = 5;

		public Action<bool, string> AssertMethod
		{
			get
			{
				if ( _assertMethod == null )
					throw new Exception( "You must set an AssertMethod" );
				return _assertMethod;
			}
			set { _assertMethod = value; }
		}
	}
}