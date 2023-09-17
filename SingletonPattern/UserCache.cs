using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class UserCache
    {
        private static readonly int UserNumberLimit = 10;
        private static int ActualyUserCount;
        private static readonly List<UserCache> InitializedUserCaches = new(UserNumberLimit);

        private UserCache()
        {
        }

        public string UserName { get; set; }

        public object AllowedModules { get; set; }

        public object AllowedGroups { get; set; }

        public static UserCache Instance(string userName)
        {
            if (InitializedUserCaches.Exists(userCache => userCache.UserName == userName))
                return InitializedUserCaches.First(userCache => userCache.UserName == userName);

            if (ActualyUserCount == UserNumberLimit)
                throw new Exception("The number of chaches is limeted for users");

            var newUserCache = new UserCache { UserName = userName };
            InitializedUserCaches.Add(newUserCache);
            ActualyUserCount++;

            return newUserCache;
        }
    }
}
