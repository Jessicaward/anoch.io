using NUnit.Framework;
using ServiceStack.Redis;

namespace Incriminatr.Repositories
{
    [TestFixture]
    public class RepositoryTest
    {
        [Test()]
        public void TestRepository()
        {
            //arrangement
            var expected = 1;
            
            //action
            //todo: abstract this to config file.
            var host = "127.0.0.1";
            var port = 6379;
            var redisEndpoint = new RedisEndpoint(host, port);
            
            //assertion
            using (var redisClient = new RedisClient(redisEndpoint))
            {
                var result = redisClient.Increment("Name", 1);
                Assert.AreEqual(expected, result);
            }
        }
    }
}