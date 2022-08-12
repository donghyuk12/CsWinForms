using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
namespace WinFormsAppRedis
{
    class Redis
    {
        private ConnectionMultiplexer redisConnection;
        private IDatabase db;

        public Redis()
        {
        }

        public bool Init(string host, int port)
        {
            try
            {
                this.redisConnection = ConnectionMultiplexer.Connect(host + ":" + port);
                if (redisConnection.IsConnected)
                {
                    this.db = this.redisConnection.GetDatabase();
                    return true;
                }
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public string GetString(string key)
        {
            return this.db.StringGet(key);
        }
        public bool SetString(string key, string val)
        {
            return this.db.StringSet(key, val);
        }
    }
}
