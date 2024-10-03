using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchYourWallet.Infra.Context
{
    public class ConnectionContextFb
    {
        public IFirebaseConfig fc = new FirebaseConfig()
        {
            AuthSecret = "KCJLfv4BPrD3fcGrq0gkD9tJAlLx5u7WHJdNATFx",
            BasePath = "https://watchyourwallet-af657-default-rtdb.firebaseio.com"
        };

        public IFirebaseClient client;
        public ConnectionContextFb()
        {
            try
            {
                client = new FireSharp.FirebaseClient(fc);
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao conectar com o banco");
            }
        }
    }
}
