using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace Server_TCP
{
    class ConnectionHandler
    {
        private Socket Klienti;
        private static int lidhjet = 0;
        private string eDhenaEardhur;

        private  PasswordHash pswhash = new PasswordHash();

        public ConnectionHandler(Socket klienti)
        {
            this.Klienti = klienti;
        }

        public void HandleConnection()
        {
            try
            {
                lidhjet++;
                Console.WriteLine("U pranua klienti i ri: {0} lidhje aktive", lidhjet);
                SendData(DefaultFunctions());


                while (true)
                {
                    Console.WriteLine(ReceiveData());

                    if (eDhenaEardhur.ToUpper().StartsWith("REGJISTRIMI") || eDhenaEardhur.ToUpper().StartsWith("AUTHENTIFIKIMI"))
                    {
                        int poz = eDhenaEardhur.IndexOf(" ");
                        string command = eDhenaEardhur.Substring(0, poz);
                        string sjson = eDhenaEardhur.Substring(poz + 1);

                        switch (command.ToUpper())
                        {

                            case "REGJISTRIMI":
                                SendData(Regjistrimi(sjson));
                                break;
                            case "AUTHENTIFIKIMI":
                                SendData(Authentifikimi(sjson));
                                break;
                            default:
                                SendData("Operacioini nuk eshte valid!");
                                break;
                        }
                    }

                }
                this.Klienti.Close();
                lidhjet--;
                Console.WriteLine("Klienti është shkëputur: {0} lidhje aktive", lidhjet);
            }
            catch (Exception)
            {
                lidhjet--;
                Console.WriteLine("Klienti është shkëputur: {0} lidhje aktive", lidhjet);
            }
        }

        private void SendData(string data)
        {
            this.Klienti.Send(Encoding.ASCII.GetBytes(data));
        }

        private string ReceiveData()
        {
            byte[] data = new byte[512];
            int recv = this.Klienti.Receive(data);
            string stringData = Encoding.ASCII.GetString(data, 0, recv);
            eDhenaEardhur = stringData;
            return stringData;
        }

        private string DefaultFunctions()
        {
            //string allFunctions = "\nKomandat e mundshme \n(REGJISTRIMI, AUTHENTIFIKIMI)";
            string allFunctions = "\n";
            return allFunctions;
        }

        //Metodat
        private string Regjistrimi(string sjson)
        {
            string return_value = "";
            bool UserExist = false;
            try
            {
                //Mesimdhenesi mesimdhenesi = js.Deserialize<Mesimdhenesi>(sjson);
                Mesimdhenesi mesimdhenesi = JsonConvert.DeserializeObject<Mesimdhenesi>(sjson);
                string Hashpassword = pswhash.CreateHash(mesimdhenesi.PasswordHash);
                mesimdhenesi.PasswordHash = Hashpassword;

                string path = "Mesimdhenesi.json";
                if (File.Exists(path))
                {
                    sjson = File.ReadAllText(path);
                    if (String.IsNullOrEmpty(sjson))
                    {
                        List<Mesimdhenesi> lstMesimdhenesit = new List<Mesimdhenesi>();
                        lstMesimdhenesit.Add(mesimdhenesi);
                        File.WriteAllText(path, JsonConvert.SerializeObject(lstMesimdhenesit), Encoding.UTF8);
                    }
                    else
                    {
                        List<Mesimdhenesi> lstMesimdhenesit = JsonConvert.DeserializeObject<List<Mesimdhenesi>>(sjson);
                        foreach (Mesimdhenesi item in lstMesimdhenesit)
                        {
                            if (item.userId == mesimdhenesi.userId)
                            {
                                return_value = "ERROR - Ekziston mesimdhenesi me username " + mesimdhenesi.userId;
                                UserExist = true;
                                break;
                            }
                        }
                        if (!UserExist)
                        {
                            lstMesimdhenesit.Add(mesimdhenesi);
                            File.WriteAllText(path, JsonConvert.SerializeObject(lstMesimdhenesit), Encoding.UTF8);
                            return_value = "OK - Jeni regjistruar me sukses me username " + mesimdhenesi.userId;
                        }
                    }
                }
                else
                {
                    List<Mesimdhenesi> lstMesimdhenesit = new List<Mesimdhenesi>();
                    lstMesimdhenesit.Add(mesimdhenesi);
                    File.WriteAllText(path, JsonConvert.SerializeObject(lstMesimdhenesit), Encoding.UTF8);
                    return_value = "OK - Jeni regjistruar me sukses me username " + mesimdhenesi.userId;
                }
            }
            catch (Exception ex)
            {
                return_value = ex.Message;
            }

            return return_value;
        }

        private string Authentifikimi(string sjson)
        {
            string return_value = "";

            Login login = JsonConvert.DeserializeObject<Login>(sjson);
            string password = login.PasswordHash;
            string UserId = login.userId;
            bool UserExist = false;
            string path = "Mesimdhenesi.json";
            if (File.Exists(path))
            {
                sjson = File.ReadAllText(path, Encoding.UTF8);
                List<Mesimdhenesi> lstMesimdhenesit = JsonConvert.DeserializeObject<List<Mesimdhenesi>>(sjson);

                foreach (var item in lstMesimdhenesit)
                {
                    if (item.userId == UserId)
                    {
                        UserExist = true;
                        if (pswhash.ValidatePassword(password, item.PasswordHash))
                        {
                            return_value = "OK - Jeni autentifikuar me sukses";
                        }
                        else
                        {
                            return_value = "ERROR - Passwordi eshte gabim!";
                        }
                        break;
                    }
                }
                if (!UserExist)
                {
                    return_value = "ERROR - User-i " + login.userId + " nuk ekziston!";
                }
            }
            else
            {
                return_value = "ERROR - User-i " + login.userId + " nuk ekziston!";
            }

            return return_value;
        }

    }
}
