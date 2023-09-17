using SingletonPattern;

try
{
    UserCache.Instance("sysadmin");
    UserCache.Instance("admin");
    UserCache.Instance("master");
    UserCache.Instance("sysadmin");
    UserCache.Instance("sysadmin");
    UserCache.Instance("testUser1");
    UserCache.Instance("testUser2");
    UserCache.Instance("testUser3");
    UserCache.Instance("testUser4");
    UserCache.Instance("testUser5");
    UserCache.Instance("testUser6");
    UserCache.Instance("testUser7");
    UserCache.Instance("sysadmin"); // user cache exists
    UserCache.Instance("sysadmin"); //user cache exists
    UserCache.Instance("testUser8"); //limited user cache
}
catch (Exception exeption)
{
    Console.WriteLine(exeption.Message);
}