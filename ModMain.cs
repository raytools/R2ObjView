using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Ray2Mod;

namespace R2ObjView
{
    public class ModMain : IMod
    {
        internal RemoteInterface Remote;

        public void Run(RemoteInterface remoteInterface)
        {
            Remote = remoteInterface;

            Thread uiThread = new Thread(StartFrame);
            uiThread.SetApartmentState(ApartmentState.STA);
            uiThread.Start();
        }

        private void StartFrame()
        {
            IconManager.InitIcons();

            //Application.VisualStyleState = VisualStyleState.NoneEnabled;
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }
    }
}