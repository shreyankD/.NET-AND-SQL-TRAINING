using System;

using System.Runtime.Remoting;

using System.Runtime.Remoting.Channels;

using System.Runtime.Remoting.Channels.Tcp;

using Assignment_7_Remote;



namespace Assigment_7_Server
{
    public class Server

    {

        public static void Main()

        {

            TcpChannel channel = new TcpChannel(8080);

            ChannelServices.RegisterChannel(channel, false);



            RemotingConfiguration.RegisterWellKnownServiceType(

                typeof(YourRemoteObject),

                "RemoteObject",

                WellKnownObjectMode.Singleton);



            Console.WriteLine("Server is ready...");

            Console.ReadLine();

        }

    }

}
