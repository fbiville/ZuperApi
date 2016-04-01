using System;

namespace ZuperApi
{
	public struct UserCookie
	{

		public string Key { get; private set; }

		public string Value { get; private set; }

		public UserCookie(string key, string value): this() {
			Key = key;
			Value = value;
		}
	}

}

