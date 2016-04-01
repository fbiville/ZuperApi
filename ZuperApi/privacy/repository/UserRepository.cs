using System;

namespace ZuperApi
{
	public interface UserRepository
	{
		User findOneByUserId(int userId);
	}
}

