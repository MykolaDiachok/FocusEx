using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetFwTypeLib;
using System.Text.RegularExpressions;
using CrashReporterDotNET;
using System.Windows.Forms;
using System.Threading;

namespace FocusEx
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.ThreadException += ApplicationThreadException;

            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            //http://www.codeproject.com/Articles/14906/Open-Windows-Firewall-During-Installation
            http://blogs.msdn.com/b/securitytools/archive/2009/08/21/automating-windows-firewall-settings-with-c.aspx
            Type NetFwMgrType = Type.GetTypeFromProgID("HNetCfg.FwMgr", false);
            INetFwMgr mgr = (INetFwMgr)Activator.CreateInstance(NetFwMgrType);
            bool Firewallenabled = mgr.LocalPolicy.CurrentProfile.FirewallEnabled;
            //try
            //{
                string arg1 = "Big bumm";
                Console.WriteLine("Crash: \"" + arg1 + "\"");
                throw new Exception("this is a test");
            //}
            //  catch (Exception error) { 
                      
            //}
            Console.WriteLine("{0}", Firewallenabled);
            Console.ReadKey();
            
        }


        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            ReportCrash((Exception)unhandledExceptionEventArgs.ExceptionObject);
            Environment.Exit(0);
        }

        private static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ReportCrash(e.Exception);
        }

        private static void ReportCrash(Exception exception)
        {
            var reportCrash = new ReportCrash
            {
                ToEmail = "ndyachok@gmail.com"
            };

            reportCrash.Send(exception);
        }

    }
}
