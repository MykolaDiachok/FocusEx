using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NetFwTypeLib;

namespace FocusEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://www.codeproject.com/Articles/14906/Open-Windows-Firewall-During-Installation
            http://blogs.msdn.com/b/securitytools/archive/2009/08/21/automating-windows-firewall-settings-with-c.aspx
            Type NetFwMgrType = Type.GetTypeFromProgID("HNetCfg.FwMgr", false);
            INetFwMgr mgr = (INetFwMgr)Activator.CreateInstance(NetFwMgrType);
            bool Firewallenabled = mgr.LocalPolicy.CurrentProfile.FirewallEnabled;
            Console.WriteLine("{0}", Firewallenabled);
            Console.ReadKey();
        }
    }
}
