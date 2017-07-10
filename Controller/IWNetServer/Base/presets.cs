using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using Kayak;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Linq;
using Controller.@class.Hash;


namespace LayerNETserver
{
    class presets
    {
        
        
        public static bool authorise(string remKey, string passKey)
        {
            try
            {
                String iniVector = "@1B2c3D4e5F6g7H8";
                Controller.@class.Hash.RijndaelEnhanced hasher = new RijndaelEnhanced(passKey, iniVector);
                String key = File.ReadAllText("License.key");
                if (remKey == hasher.Decrypt(key))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                return false;
            }
        }
        public static bool run(string layerStart)
        {
            //code to start.
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName =  layerStart;
            if (System.IO.File.Exists(layerStart) == true)
            {
                //file exists, we can proceed to run the server!
                Log.Info("Starting process for " + layerStart);
                Process.Start(startinfo).WaitForExit();
                Log.Info("started");
                return true;
               
            }
            else
            {
                return false;
            }
        }
        public static string getVersion()
        {
            return File.ReadAllText("./data/about.server");
        }
        public static void createLayer(string svName,string svIp,string svRport, string svRpass, string admUser, string admPass, string lyrPort, string lyrGame, string lyrInitials)//one of the most important part of code
        {
            
            #region Preset variables
            //preset variables
            string NAME = svName;
            string SERVERIP = svIp;
            string SERVERRCON = svRport;
            string SERVERPASS = svRpass;
            string LAYERUSER = admUser;
            string LAYERPASS = admPass;
            string LAYERPORT = lyrPort;
            string LAYERDIRECTORY = "procon_" + lyrGame.ToLower() + "_" + lyrInitials.ToLower();
            string STARTUPNAME = "startup_" + lyrGame.ToLower() + "_" + lyrInitials.ToLower()+".bat";
            string SHUTDOWNNAME = "shutdown_" + lyrGame.ToLower() + "_" + lyrInitials.ToLower()+".bat";
            string SVCFGNAME = SERVERIP + "_" + SERVERRCON + ".cfg";
            #endregion
            #region Presets
            //Presets
            string accountsPreset = File.ReadAllText("./presets/accounts.preset");
            string proconPreset = File.ReadAllText("./presets/procon.preset");
            string serverPreset = File.ReadAllText("./presets/server.preset");
            string startupPreset = File.ReadAllText("./presets/startup.preset");
            string shutdownPreset = File.ReadAllText("./presets/shutdown.preset");
            #endregion
            #region Replacing 'accounts' preset
            string accounts = accountsPreset.Replace("[LAYERUSER]", LAYERUSER);
            accounts = accounts.Replace("[LAYERPASS]", LAYERPASS);
            #endregion
            #region Replacing 'procon' preset
            string procon = proconPreset.Replace("[SERVERIP]", SERVERIP);
            procon = procon.Replace("[SERVERRCON]", SERVERRCON);
            procon = procon.Replace("[SERVERPASS]", SERVERPASS);
            procon = procon.Replace("[NAME]", NAME);
            #endregion
            #region Replacing 'server' preset
            string server = serverPreset.Replace("[LAYERUSER]", LAYERUSER);
            server = server.Replace("[LAYERPORT]", LAYERPORT);
            #endregion
            #region Replacing 'startup' preset
            string startup = startupPreset.Replace("[LAYERDIRECTORY]", LAYERDIRECTORY);
            #endregion
            #region Replacing 'shutdown' preset
            string shutdown = shutdownPreset.Replace("[LAYERDIRECTORY]", LAYERDIRECTORY);
            #endregion
            #region here follows the real code that matters
                        //create a Directory for the layer
                        if (Directory.Exists(LAYERDIRECTORY) == true) { Directory.Delete(LAYERDIRECTORY); }
                        Directory.CreateDirectory(LAYERDIRECTORY);
                        //unzip the files.zip
                        unzip("./files/files.zip", "./" + LAYERDIRECTORY + "/");
                        //Lets write the accounts.cfg
                        writeFile("./" + LAYERDIRECTORY + "/Configs/accounts.cfg", accounts);
                        //Lets write the procon.cfg
                        writeFile("./" + LAYERDIRECTORY + "/Configs/procon.cfg", procon);
                        //Lets write the server.cfg
                        writeFile("./" + LAYERDIRECTORY + "/Configs/" + SVCFGNAME, server);
                        //Lets write the startup script and make it executable
                        writeFile(STARTUPNAME, startup);
                        chmodrx(STARTUPNAME);
                        //Lets write the shutdown script and make it executable
                        writeFile(SHUTDOWNNAME, shutdown);
                        //chmodrx(SHUTDOWNNAME);
            #endregion

        }
        public static void writeFile(string filename, string data)
        {
            if (File.Exists(filename) == true)
            {
                File.Delete(filename);
            }
            File.WriteAllText(filename, data);
        }
        public static void unzip(string path, string path2)
        {
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = "unzip";
            startinfo.Arguments = path + " -d " + path2;
            Process.Start(startinfo).WaitForExit();

        }
        public static void chmodrx(string filename){
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = "chmod";
            startinfo.Arguments = "+rx " + filename;
            Process.Start(startinfo).WaitForExit();
            //startinfo.FileName = "dos2unix";
            //startinfo.Arguments = filename;
            //Process.Start(startinfo).WaitForExit(); //we switched to Windows!!!!!
        }
    }
}