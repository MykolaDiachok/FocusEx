using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetFwTypeLib;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using NBug.Properties;
using NBug;
using System.IO;
using System.Reflection;
using SQLite.Net;


namespace FocusExHarvest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            var path = Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "db.sqlite");

            using (SQLite.Net.SQLiteConnection conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.Win32.SQLitePlatformWin32(), path))
            {
                conn.CreateTable<ForBase.CashIO>();
                conn.CreateTable<ForBase.Sales>();
            }


            AppDomain.CurrentDomain.UnhandledException += Handler.UnhandledException;
            TaskScheduler.UnobservedTaskException += Handler.UnobservedTaskException;
            //NBug.Settings.AddDestinationFromConnectionString
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


      

    }
}
