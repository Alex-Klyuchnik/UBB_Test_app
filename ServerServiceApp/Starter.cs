using ServerServiceApp.TCP_Server;

namespace ServerServiceApp
{
    class Starter
    {
        private volatile bool isRunning;

        public void Start ()
        {
            isRunning = true;
            ConnectionEstablisher connection = new ConnectionEstablisher();
            while (isRunning)
            {
                connection.Listen();
            }
        }

        public void Stop ()
        {
            isRunning = false;
        }
    }
}
