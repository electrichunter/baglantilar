    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FireSharp;
    using FireSharp.Config;
    using FireSharp.Response;
    using FireSharp.Interfaces;
    using Newtonsoft.Json;
    using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace connect
    {




        internal class frebasedata
        {
        
        public string adı {  get; set; }
        public string soyadı { get; set; }
        public string telefonu { get; set; }
        public string departmanı { get; set; }
        public string şehri { get; set; }
        public string dogumyılı { get; set; }
        public string maaş { get; set; }
        public string mail { get; set; }

        IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "XK23WfqzLMpj4tDFqg0t5zwvZZFKFPHP2dUsqvL6",
            BasePath = "https://console.firebase.google.com/u/0/project/xyzbank-2e8fa/database/xyzbank-2e8fa-default-rtdb/data/~2F"
        };

        IFirebaseClient client;

        
        public void FirebaseData()
        {
        
        }

       
    }




}

