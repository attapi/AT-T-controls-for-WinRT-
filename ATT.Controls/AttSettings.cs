// <copyright file="AttSettings.cs" company="AT&amp;T">
// Licensed by AT&amp;T under 'Software Development Kit Tools Agreement.' 2012
// TERMS AND CONDITIONS FOR USE, REPRODUCTION, AND DISTRIBUTION: http://developer.att.com/sdk_agreement/
// Copyright 2012 AT&amp;T Intellectual Property. All rights reserved. http://developer.att.com
// For more information contact developer.support@att.com
// </copyright>

namespace ATT.Controls
{
	/// <summary>
	/// Connection setting for AT&amp;T SDK. If you would like to use multiple controls and set the values in one place, you may use the ATTSettings static class.
	/// </summary>
	public static class AttSettings
	{
		/// <summary>
		///  Gets or sets API key.
		/// </summary>
		public static string ApiKey { get; set; }

		/// <summary>
		/// Gets or sets Secret key.
		/// </summary>
		public static string SecretKey { get; set; }
	}
}
