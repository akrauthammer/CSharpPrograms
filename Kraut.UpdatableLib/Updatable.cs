using System.ComponentModel;

namespace Kraut.UpdatableLib
{
    public class Updatable
    {
        private IUpdatable appInfo;
        private BackgroundWorker bgWorker;

        public Updatable(IUpdatable appInfo)
        {
            this.appInfo = appInfo;
            this.bgWorker = new BackgroundWorker();
            //this.bgWorker.DoWork += BgWorker_DoWork;
            //this.bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
        }

        public void CheckForUpdates()
        {
            if (!this.bgWorker.IsBusy)
                this.bgWorker.RunWorkerAsync(this.appInfo);
        }
        /*
        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            IUpdatable application = (IUpdatable)e.Argument;

            if (!SharpUpdateXml.ExistsOnServer(application.UpdateXmlLocation))
                e.Cancel = true;
            else
                e.Result = SharpUpdateXml.Parse(application.UpdateXmlLocation, application.ApplicationId);
        }*/
    }
}
