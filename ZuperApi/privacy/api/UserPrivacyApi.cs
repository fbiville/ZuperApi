using System;

namespace ZuperApi
{
	public class UserPrivacyApi: Nancy.NancyModule
	{
		public UserPrivacyApi()
		{
			Get["/"] = _ => "Hello World!";
		}
	}
}

