using System;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Assignment_7_Remote;

namespace Assignment_7_Windows
{
    
    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)

        {

            TcpChannel channel = new TcpChannel();

            ChannelServices.RegisterChannel(channel, false);



            YourRemoteObject remoteObject =

                (YourRemoteObject)Activator.GetObject(

                    typeof(YourRemoteObject),

                    "tcp://localhost:8080/RemoteObject");



            string result = remoteObject.HelloWorld();

            label1.Text = result;

        }

    }
}

