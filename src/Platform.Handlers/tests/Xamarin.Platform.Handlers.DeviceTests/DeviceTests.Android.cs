﻿using Context = global::Android.Content.Context;

namespace Xamarin.Platform.Handlers.DeviceTests
{
	public partial class Platform
	{
		public static Context DefaultContext { get; set; }

		public static void Init(Context context)
		{
			DefaultContext = context;
		}
	}
}