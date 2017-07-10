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
    public delegate void
        OwinApplication(IDictionary<string, object> env,
        Action<string, IDictionary<string, IList<string>>, IEnumerable<object>> respond,
        Action<Exception> error);

    class HttpHandler
    {
        public static void Run()
        {
            var server = new DotNetServer();
            var pipe = server.Start();
            String passKey = "071mVGZ9h2d4Va";
            server.Host((env, respond, error) =>
                {
                    var path = env["Owin.RequestUri"] as string;
                    var urlParts = path.Substring(1).Split(new[] { '/' }, 15);
                  
 
                    if (urlParts.Length >= 1)
                    {
                        if (urlParts[0] == "status")
                        {
                            Log.Info("Received a url request - " + urlParts[0]);

                            respond(
                                    "200 OK",
                                    new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                    new object[] { Encoding.ASCII.GetBytes("Online") }
                                    );
                            return;
                        }
                        else if(urlParts[0] == "validate")
                        {
                            try
                            {
                            
                            String remKey = urlParts[1];
                            if (File.Exists("License.key"))
                            {
                             
                            if (presets.authorise(remKey,passKey) == true)
                            {
                                respond(
                                    "200 OK",
                                    new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                    new object[] { Encoding.ASCII.GetBytes("authorised") }
                                    );
                                Log.Info("authorised");
                            }
                            else
                            {
                                respond(
                                    "200 OK",
                                    new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                    new object[] { Encoding.ASCII.GetBytes("bad key") }
                                    );
                                Log.Info("bad key");
                            }
                            }
                                else
                            {
                                respond(
                                    "200 OK",
                                    new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                    new object[] { Encoding.ASCII.GetBytes("License.key file not found or damaged.") }
                                    );
                                Log.Error("License.key file not found or damaged.");
                            }
                                }
                            
                            catch (Exception e) {
                                respond(
                                    "200 OK",
                                    new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                    new object[] { Encoding.ASCII.GetBytes("bad request") }
                                    );
                                Log.Info("bad request");
                                Console.WriteLine(e);
                            }
                            
                        }
                        else if (urlParts[0] == "about")
                        {
                            respond(
                                    "200 OK",
                                    new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                    new object[] { Encoding.ASCII.GetBytes(presets.getVersion()) }
                                    );
                        }
                        else if (urlParts[0] == "start")
                        {
                            string remKey = urlParts[1];
                            string layerStart = urlParts[2];
                            if(presets.authorise(remKey, passKey) == true)
                            { 
                            Log.Info("Calling preset.start() for - " + layerStart);//calling
                            if (presets.run(layerStart) == true)
                            {

                                respond(
                                   "200 OK",
                                   new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                   new object[] { Encoding.ASCII.GetBytes("success") }

                                   );
                                Log.Info("Returned success");
                            }
                            else
                            {
                                respond(
                                   "200 OK",
                                   new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                   new object[] { Encoding.ASCII.GetBytes("error") }
                                   );
                                Log.Info("Returned error");
                            }
                            
                         }
                            else
                            {
                                respond(
                                   "200 OK",
                                   new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                   new object[] { Encoding.ASCII.GetBytes("authorisation error") }
                                   );
                                Log.Info("authorisation error");
                            }
                      }
                        else if (urlParts[0] == "stop")
                        {
                            string remKey = urlParts[1];
                            string layerStop = urlParts[2];
                            if (presets.authorise(remKey, passKey) == true)
                            {
                                Log.Info("Calling preset.start() for - " + layerStop);//calling
                                if (presets.run(layerStop) == true)
                                {

                                    respond(
                                       "200 OK",
                                       new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                       new object[] { Encoding.ASCII.GetBytes("success") }

                                       );
                                    Log.Info("Returned success");
                                }
                                else
                                {
                                    respond(
                                       "200 OK",
                                       new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                       new object[] { Encoding.ASCII.GetBytes("error") }
                                       );
                                    Log.Info("Returned error");
                                }

                            }
                            else
                            {
                                respond(
                                   "200 OK",
                                   new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                   new object[] { Encoding.ASCII.GetBytes("authorisation error") }
                                   );
                                Log.Info("authorisation error");
                            }
                        }
                        else if (urlParts[0] == "new")
                        {
                            string remKey = urlParts[1];
                            if (presets.authorise(remKey, passKey))
                            {
                                Log.Info("calling presets.createLayer()");
                                string NAME = urlParts[2];
                                string SERVERIP = urlParts[3];
                                string SERVERRCON = urlParts[4];//rcon port
                                string SERVERPASS = urlParts[5];
                                string LAYERUSER = urlParts[6];
                                string LAYERPASS = urlParts[7];
                                string LAYERPORT = urlParts[8];
                                string LAYERGAME = urlParts[9];
                                string LAYERINITIALS = urlParts[10];
                                Log.Info("Variables assigned");
                                presets.createLayer(NAME,SERVERIP,SERVERRCON,SERVERPASS,LAYERUSER,LAYERPASS,LAYERPORT,LAYERGAME,LAYERINITIALS);
                                Log.Info("presets.createLayer() called");
                                respond(
                                   "200 OK",
                                   new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                   new object[] { Encoding.ASCII.GetBytes("done") }
                                   );
                                
                            }
                            else
                            {
                                respond(
                                   "200 OK",
                                   new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                   new object[] { Encoding.ASCII.GetBytes("authorisation error") }
                                   );
                                Log.Info("authorisation error");
                            }
                        }
                        else if (urlParts[0] == "layerinfo")
                        {

                        }
                        else
                        {
                            respond(
                                        "200 OK",
                                        new Dictionary<string, IList<string>>() 
                                {
                                    { "Content-Type",  new string[] { "text/plain" } }
                                },
                                        new object[] { Encoding.ASCII.GetBytes("You are not authorised to dance here.") }
                                        );
                        }
//break



                    }
                    
                }
            );
        }

   
        
        
    }
    }

                       

        