using System.Diagnostics;
using System.ServiceProcess;

namespace ServerServiceApp
{
    public partial class ServerService : ServiceBase
    {
        Starter starter = new Starter();

        public ServerService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            starter.Start();
        }

        protected override void OnStop()
        {
            starter.Stop();
            Debugger.Break(); //TODO Remove in production
        }
    }
}
