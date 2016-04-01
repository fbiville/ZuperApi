using System;

namespace ZuperApi
{
	public interface UserCookieRepository
	{
		List<UserCookie> findAllByUserId(int userId);
	}
}

