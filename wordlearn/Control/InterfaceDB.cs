using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wordlearn.Model;

namespace wordlearn.Control
{
    
        public static class OrtakDb
        {/// <summary>
         /// Bu kısım veritabanımızın yönetildiği yerdir.
         /// Burdaki amaç çoklu sayfalarda çoklu işlemler yapıldığı için 
         /// tek yerden veritabanını oluşturup tek yerden veritabanını kapatmaktır.
         /// Bu sayede merkezi bir yönetim sağlanmıştır. 
         /// </summary>
            public static dbwordnewEntities db = new dbwordnewEntities();
        }
   
}
