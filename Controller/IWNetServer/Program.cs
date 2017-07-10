using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace LayerNETserver
{
    public class Program
    {
        static void Main(string[] args)
        {
            Log.Initialize("LayerNet.log", LogLevel.All,true);
            
            Log.Info("Layer Web API starting...");
            Log.Info("Author - Pavitra Behre");
            Log.Info("Based on NTA's IWNET server code.");
            Console.Title = "|Layer Control Web API|";
            HttpHandler.Run(); //starting our HTTP handler on port 13000
            Log.Info("HTTP handler running on port 13000");
            while (true)
            {
                try
                {
                    Log.Info("Keeping webAPI alive! at " + DateTime.UtcNow + " UTC");
                    
                }
                catch (Exception e) { Log.Error(e.ToString()); }

                Thread.Sleep(10000); //Every 10 seconds
            }
        }
    }
}