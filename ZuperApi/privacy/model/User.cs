using System;
using System.Collections.Generic;
using System.Linq;

namespace ZuperApi
{
	public class User
	{
		public int Id { get; private set; } 

		public List<UserCookie> Cookies { get; private set; } 

		public User(int id, List<UserCookie> cookies)
		{
			Id = id;
			Cookies = cookies;
		}

		public bool hasOptedOut() 
		{
			return (from cookie in Cookies
			        where cookie.Key == "optout"
					select cookie.Value == "1").FirstOrDefault(_ => false);
		}

	}
}

