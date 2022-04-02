using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NurseCallMvc
{
    using Microsoft.AspNet.SignalR;
    using NurseCallMvcs.Models;
    using SignalRChat;
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    public class UDPListener
    {
        private readonly IHubContext< ChatHub> _hub;
        public UDPListener(IHubContext< ChatHub> _hub)
        {
            this._hub = _hub;
        }
        public void StartListener(  string ip, int port)
        {
            Task.Run(async () => {
                string ipAddress = ip;
                IPAddress address = IPAddress.Parse(ipAddress);
                UdpClient listener = new UdpClient(port);
                IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, port);
                try
                {
                    while (true)
                    
                    {
                       
                        byte[] bytes = listener.Receive(ref groupEP);
                        Console.WriteLine("Waiting for broadcast");
                        Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytes.Length));
                        
                        try
                        {
                            var message = PacketHelper.GetMessage(new Packet(bytes));
                           // if (message !=null)
                             //   await _hub.Clients.All.SendAsync("ReceiveMessage",  message.callType,message.isRoom,message.roomNumber);

                        }
                        catch (Exception ex) {  Console.WriteLine(ex.Message); }
                    }
                }
                catch (SocketException e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    listener.Close();
                }
            
            });
        }

        
    }


}
