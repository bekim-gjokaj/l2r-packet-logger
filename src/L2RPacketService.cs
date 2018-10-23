using Kamael.Packets.Factory;
using PacketDotNet;
using SharpPcap;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Kamael.Packets
{
    /// <summary>
    ///
    /// </summary>
    public class L2RPacketService
    {
        public static ICaptureDevice Device { get; set; }

        // A few variable used throughout the program
        /// <summary>
        /// The encryption key
        /// </summary>
        public static byte[] EncryptionKey = { 0xA7, 0x84, 0x20, 0xD0, 0xC9, 0x78, 0xB3, 0x9A };

        /// <summary>
        /// The filter
        /// </summary>
        public static string filter = "port 12000 and len > 60";

        /// <summary>
        /// The read timeout milliseconds
        /// </summary>
        public static int readTimeoutMilliseconds = 1000;

        /// <summary>
        /// The default device
        /// </summary>
        public static int defaultDevice = 3;

        /// <summary>
        /// Parses the packet.
        /// </summary>
        /// <param name="packetReader">The packet reader.</param>
        /// <returns></returns>
        ///

        public L2RPacketService()
        {
        }

        public L2RPacketService(ICaptureDevice device)
        {
            Device = device;
        }

        public static void Start(ICaptureDevice device)
        {
            try
            {
                Device = device;

                // Open the device for capturing
                device.Open(DeviceMode.Promiscuous, L2RPacketService.readTimeoutMilliseconds);

                //filter to capture only packets from L2R that have data
                //string filter = "src port 12000 and len > 60";
                device.Filter = L2RPacketService.filter;

                Console.WriteLine
                    ("\n-- The following filter will be applied: \"{0}\"",
                    L2RPacketService.filter);
                Console.WriteLine
                    ("-- Listening on {0} {1}. \n\n Hit 'Enter' to stop...\n\n",
                                  device.Name, device.Description);

                // Start the capturing process
                device.StartCapture();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
        }

        public async Task StartAsync(ICaptureDevice device)
        {
            try
            {
                // Open the device for capturing
                device.Open(DeviceMode.Promiscuous, L2RPacketService.readTimeoutMilliseconds);

                //filter to capture only packets from L2R that have data
                //string filter = "src port 12000 and len > 60";
                device.Filter = L2RPacketService.filter;

                Console.WriteLine
                    ("\n-- The following filter will be applied: \"{0}\"",
                    L2RPacketService.filter);
                Console.WriteLine
                    ("-- Listening on {0} {1}. \n\n Hit 'Enter' to stop...\n\n",
                                  device.Name, device.Description);

                // Start the capturing process
                device.StartCapture();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static IL2RPacket ParsePacket(L2RPacket packetReader)
        {
            try
            {
                ushort packetId = (ushort)(packetReader.ReadUInt16() - 1);
                Console.WriteLine("-Packet ID: " + packetId + "\r");

                PacketFactory factory = new ConcretePacketFactory();
                IL2RPacket pckt = factory.GetPacket(packetId, packetReader);
                return pckt;
                
                //var director = new PacketDirector();
                //var packet = director.Construct();
                //packet.Parts.ForEach((part) => Console.WriteLine(part));

                // Change the following for different Servers. INT/JAP/KOR/SEA
                //HandlerINT.TypePacket(packetReader, packetId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Parse Packet Error: \r\n" + ex.ToString());
                return packetReader;
            }
        }

        /// <summary>
        /// Initializations the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        public static int Initialization(string[] args)
        {
            int delData = 0;

            // Sets optional values based on what arguement is used.
            for (int i = 0; i < args.Length; i++)
            {
                string value = args[i];
                Console.WriteLine(value.Substring(0, 1));
                if (value.Substring(0, 1) != "-")
                {
                    value = "h";
                }
                else
                {
                    value = value.Substring(1, 1).ToLower();
                }
                switch (value)
                {
                    case "f":
                        i++;
                        filter = args[i];
                        break;

                    case "t":
                        i++;
                        readTimeoutMilliseconds = Convert.ToInt32(args[i]);
                        break;

                    case "i":
                        i++;
                        defaultDevice = Convert.ToInt32(args[i]);
                        break;

                    case "d":
                        delData = 0;
                        break;

                    case "h":
                        Help();
                        break;

                    default:
                        Console.WriteLine("Incorrect arguement used when lauching program. /n/n");
                        Help();
                        break;
                }
            }

            // Creates folders if they do not exist yet.
            if (!Directory.Exists(@"Output\"))
            {
                Directory.CreateDirectory(@"Output\");
            }

            // Deletes old record files if it exists.
            if (delData == 1)
            {
                foreach (string item in Directory.GetFiles(@"Output\", "*.csv"))
                {
                    File.Delete(item);
                }

                foreach (string item in Directory.GetFiles(@"Output\", "*.txt"))
                {
                    File.Delete(item);
                }
            }
            /* Retrieve the device list */
            CaptureDeviceList devices = CaptureDeviceList.Instance;

            // Returns error if no devices found.
            // If only one device found uses that device.
            if (devices.Count < 1)
            {
                Console.WriteLine("No device found on this machine");
                // Exits the program.
                ExitProgram();
            }
            else if (devices.Count == 1)
            {
                defaultDevice = 0;
            }

            if (defaultDevice < 0)
            {
                defaultDevice = 0;
                // Lists each of the devices that can be captured
                // and then has you select the device you want to use.
                Console.WriteLine("The following devices are available on this machine:");
                Console.WriteLine("----------------------------------------------------\n");
                foreach (ICaptureDevice dev in devices)
                {
                    Console.WriteLine("{0}) {1} {2}", defaultDevice, dev.Name, dev.Description);
                    defaultDevice++;
                }
                Console.Write("\n-- Please choose a device to capture: ");
                defaultDevice = 0;
            }
            return defaultDevice;
        }

        /// <summary>
        /// Prints the time, length, src ip, src port, dst ip and dst port
        /// for each packet recieved then writes payload data to a file.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CaptureEventArgs"/> instance containing the event data.</param>
        public static void PacketCapturer(object sender, CaptureEventArgs e)
        {
            try
            {
                DateTime time = e.Packet.Timeval.Date;
                int len = e.Packet.Data.Length;
                IL2RPacket l2rPacket = null;

                Packet packet = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

                TcpPacket tcpPacket = (PacketDotNet.TcpPacket)packet.Extract(typeof(PacketDotNet.TcpPacket));
                if (tcpPacket != null)
                {
                    IPPacket ipPacket = (IPPacket)tcpPacket.ParentPacket;
                    System.Net.IPAddress srcIp = ipPacket.SourceAddress;
                    System.Net.IPAddress dstIp = ipPacket.DestinationAddress;
                    int srcPort = tcpPacket.SourcePort;
                    int dstPort = tcpPacket.DestinationPort;
                    byte[] payloadData = tcpPacket.PayloadData;

                    Console.WriteLine("{0}:{1}:{2}.{3}\tLen={4}\t{5}:{6} -> {7}:{8}",
                    time.Hour, time.Minute, time.Second, time.Millisecond, len,
                    srcIp, srcPort, dstIp, dstPort);

                    // Decrypt and process incoming packets
                    if (srcPort == 12000)
                    {
                        l2rPacket = GetPacket(payloadData);

                        //if (l2rPacket is PacketClanMemberKillNotify)
                        //{
                        //    .Go().GetAwaiter().OnCompleted(() =>
                        //     {
                        //         Console.WriteLine("finished");
                        //     });
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Parser Error: \r\n" + ex.InnerException);
            }
        }

        /// <summary>
        /// The incoming buffer
        /// </summary>
        public static System.Collections.Generic.List<byte> _incomingBuffer = new System.Collections.Generic.List<byte>();

        /// <summary>
        /// Appends the incoming data.
        /// </summary>
        /// <param name="payloadData">The payload data.</param>
        public static IL2RPacket GetPacket(byte[] payloadData)
        {
            try
            {
                IL2RPacket packet = null;
                _incomingBuffer.AddRange(payloadData);

                // If the buffer contains any complete packets, process them
                while (_incomingBuffer.Count >= 2)
                {
                    ushort packetLength = BitConverter.ToUInt16(_incomingBuffer.GetRange(0, 2).ToArray(), 0);
                    if (_incomingBuffer.Count >= packetLength)
                    {
                        byte spacer = _incomingBuffer[2]; // skip 1 byte

                        byte[] packetData = _incomingBuffer.GetRange(3, packetLength - 3).ToArray();
                        _incomingBuffer.RemoveRange(0, packetLength);

                        DecryptPacket(packetData);
                        return ParsePacket(new L2RPacket(packetData));
                        
                    }
                    else
                    {
                        break;
                    }
                }

                return packet;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incoming Data Error: \r\n" + ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// Decrypts the packet.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public static void DecryptPacket(byte[] packet)
        {
            for (int i = 0; i < packet.Length; i++)
            {
                packet[i] = (byte)(packet[i] ^ EncryptionKey[i % EncryptionKey.Length]);
            }
        }

        /// <summary>
        /// Helps this instance.
        /// </summary>
        public static void Help()
        {
            Console.WriteLine("\nHelp\n");
            Console.WriteLine("Correct usage: L2RPacketReader.exe -(option) (value)");
            Console.WriteLine("\nStandalone Options\n");
            Console.WriteLine("-h: Displays this document.");
            Console.WriteLine("-d: Saves Data files between executions.");
            Console.WriteLine("\nOptions That Require Values\n");
            Console.WriteLine("-i #: Sets which device to listen for packets to capture.");
            Console.WriteLine("-f \"filter\": Sets a custom filter for the packets using winPCap's filtering.");
            Console.WriteLine("               default filter value is \"port 12000 and len > 60\"");
            Console.WriteLine("-t #: Sets a custom timeout value. Default value is 1000.\n\n");
            ExitProgram();
        }

        /// <summary>
        /// Exits the program.
        /// </summary>
        public static void ExitProgram()
        {
            Environment.Exit(0);
        }

        public static void InitializeDevice()
        {
            /* Retrieve the device list  part of initialization*/
            CaptureDeviceList devices = CaptureDeviceList.Instance;

            ICaptureDevice device = CaptureDeviceList.Instance[Globals.deviceInterface];

            //Register our handler function to the 'packet arrival' event
            device.OnPacketArrival +=
                    new PacketArrivalEventHandler(L2RPacketService.PacketCapturer);

            // Open the device for capturing
            device.Open(DeviceMode.Promiscuous, L2RPacketService.readTimeoutMilliseconds);

            //filter to capture only packets from L2R that have data
            //string filter = "src port 12000 and len > 60";
            device.Filter = L2RPacketService.filter;

            Device = device;
        }
    }
}