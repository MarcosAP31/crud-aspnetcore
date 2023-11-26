using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Client
    {
        public static List<Client> ClientList()
        {
            using (var db = new Context())
            {
                return db.Client.ToList();
            }
        }
        public static List<int> ClientListFilter(string filtro)
        {

            List<Client> clients = new List<Client>();
            //List<DiasLibres> diaslibres = new List<DiasLibres>();
            //Client linea = new Client();
            List<int> clients1 = new List<int>();
            using (var db = new Context())
            {
                clients = db.Client.ToList();
                if (clients1.Count == 0)
                {
                    for (int i = 0; i < clients.Count; i++)
                    {
                        if (clients[i].Name.ToLower().Contains(filtro.ToLower()))
                        {
                            clients1.Add(clients[i].ClientId);
                        }
                    }
                }
                if (clients1.Count == 0)
                {
                    for (int i = 0; i < clients.Count; i++)
                    {
                        if (clients[i].LastName.ToLower().Contains(filtro.ToLower()))
                        {
                            clients1.Add(clients[i].ClientId);
                        }
                    }
                }
                if (clients1.Count == 0)
                {
                    for (int i = 0; i < clients.Count; i++)
                    {
                        if (clients[i].Sex.ToLower().Contains(filtro.ToLower()))
                        {
                            clients1.Add(clients[i].ClientId);
                        }
                    }
                }
                if (clients1.Count == 0)
                {
                    for (int i = 0; i < clients.Count; i++)
                    {
                        if (clients[i].Department.ToLower().Contains(filtro.ToLower()))
                        {
                            clients1.Add(clients[i].ClientId);
                        }
                    }
                }
                if (clients1.Count == 0)
                {
                    for (int i = 0; i < clients.Count; i++)
                    {
                        if (clients[i].Direction.ToLower().Contains(filtro.ToLower()))
                        {
                            clients1.Add(clients[i].ClientId);
                        }
                    }
                }
                if (clients1.Count == 0)
                {
                    for (int i = 0; i < clients.Count; i++)
                    {
                        if (clients[i].Direction.ToLower().Contains(filtro.ToLower()))
                        {
                            clients1.Add(clients[i].ClientId);
                        }
                    }
                }
                return clients1;
            }
        }
        public static Client ClientById(int id)
        {
            using (var db = new Context())
            {
                return db.Client.ToList().LastOrDefault(c => c.ClientId == id);
            }
        }

        public static void CreateClient(Client oClient, byte[] image, string imageFileName)
        {
            using (var db = new Context())
            {
                oClient.ProfileImage = image;
                oClient.ImageFileName = imageFileName;
                db.Client.Add(oClient);
                db.SaveChanges();
            }
        }
        public static void UpdateClient(Client oClient, byte[] image, string imageFileName)
        {
            using (var db = new Context())
            {
                db.Client.Update(oClient);
                db.SaveChanges();
            }
        }
        public static void UpdateClientWithoutImage(Client oClient)
        {
            using (var db = new Context())
            {
                db.Client.Update(oClient);
                db.SaveChanges();
            }
        }
        public static void DeleteClient(Client oClient)
        {
            using (var db = new Context())
            {
                db.Client.Remove(oClient);
                db.SaveChanges();
            }
        }
    }
}
