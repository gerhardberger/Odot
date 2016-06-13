﻿using System;
namespace Odot
{
	public static class TimeSpanExtension
	{
		public static string ToReadableString(this TimeSpan span)
		{
			string formatted = string.Format("{0}{1}{2}{3}",
				span.Duration().Days > 0 ? string.Format("{0:0}d, ", span.Days) : string.Empty,
				span.Duration().Hours > 0 ? string.Format("{0:0}h, ", span.Hours) : string.Empty,
				span.Duration().Minutes > 0 ? string.Format("{0:0}m, ", span.Minutes) : string.Empty,
				span.Duration().Seconds > 0 ? string.Format("{0:0}s", span.Seconds) : string.Empty);

			if (formatted.EndsWith(" ")) formatted = formatted.Substring(0, formatted.Length - 2);

			if (string.IsNullOrEmpty(formatted)) formatted = "0s";

			return formatted;
		}
	}
}

