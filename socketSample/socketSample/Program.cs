using System;
using System.Text.RegularExpressions;

using System.Net.Sockets;
namespace socketSample
{
    class Program
    {
        static void Main(string[] args)
        {
            
     
                  TcpListener sSocket = new TcpListener(8888);

                int req = 0;

                TcpClient cSocket = default(TcpClient);

            sSocket.Start();

            Console.WriteLine("Hello from Server!");

            cSocket = sSocket.AcceptTcpClient();

                Console.WriteLine("Ready for Chatting...  ");

      
                while ((true))

                {

                    try

                    {
                    //geting data from client 
                  
                     string[] operation = new string[3];
                    byte[] bytesFrom = new byte[10025];
                    NetworkStream nStream = cSocket.GetStream();
                    nStream.Read(bytesFrom, 0, (int)cSocket.ReceiveBufferSize);

                    string msgtxt = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    //split the inout to operand and operators
                    msgtxt = msgtxt.Substring(0, msgtxt.IndexOf("$"));
              
                    string[] result = Regex.Split(msgtxt, @"([*+/\-)(])|([0-9]+)");
                 
                    int res=0;

                    if (result[3] == "+")
                    {
                        res = int.Parse(result[1]) + int.Parse(result[5]);
                    }

                    else if (result[3] == "-")
                    {
                        res = int.Parse(result[1]) - int.Parse(result[5]);
                    }
                    else if (result[3] == "*")
                    {
                        res = int.Parse(result[1]) * int.Parse(result[5]);
                    }
                    else
                    {
                        res = int.Parse(result[1]) / int.Parse(result[5]);
                    }
                    Console.WriteLine("Sending the result...");

                    // send the result back to the client. 
                 
                    Console.WriteLine("Sending Response : " + res);
                    byte[] bytesToSend = System.Text.Encoding.ASCII.GetBytes(res.ToString());
                    nStream.Write(bytesToSend, 0, bytesToSend.Length);
                    Console.ReadLine();

                nStream.Flush();

                      }

                    catch (Exception ex)

                    {

                        Console.WriteLine(ex.ToString());

                    }

                }

        }



        }

    }

        
