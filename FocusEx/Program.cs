using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrittercismSDK;
using NetFwTypeLib;
using System.Text.RegularExpressions;

namespace FocusEx
{
    class Program
    {
#pragma warning disable 67
        public new event UnhandledExceptionEventHandler UnhandledException;
#pragma warning restore
        static void Main(string[] args)
        {

            Crittercism.Init("d92782186fca43a2907ad24de7b82e9c00555300");
            //http://www.codeproject.com/Articles/14906/Open-Windows-Firewall-During-Installation
            http://blogs.msdn.com/b/securitytools/archive/2009/08/21/automating-windows-firewall-settings-with-c.aspx
            Type NetFwMgrType = Type.GetTypeFromProgID("HNetCfg.FwMgr", false);
            INetFwMgr mgr = (INetFwMgr)Activator.CreateInstance(NetFwMgrType);
            bool Firewallenabled = mgr.LocalPolicy.CurrentProfile.FirewallEnabled;
            //try
            //{
            string arg1 = "Big bumm";
            Console.WriteLine("Crash: \"" + arg1 + "\"");
            ThrowException(arg1);
            //}
            //  catch (Exception error) { 
            //          Crittercism.LogHandledException(error);
            //}
            Console.WriteLine("{0}", Firewallenabled);
            Console.ReadKey();
            Crittercism.Shutdown();
        }
    }
}
