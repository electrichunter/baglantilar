using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Connecting_lib
{
    internal class sql_data
    {
       internal string Sqlbaglan()
        {
            // Doğru veritabanı adı ile bağlantı dizisini ayarlayın
            string connectionString = "Data Source=(local);Initial Catalog=xyzbank;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return "Bağlantı başarıyla açıldı!";
            }
        }

        public void SqlEkle(
            string isim, 
            string soyisim, 
            string telefon, 
           
            string departman, 
            string sehir, 
            string dogumTarihi, 
            string maas, 
            string mail)
        {
            try
            {
                string connectionString = "Data Source=(local);Initial Catalog=xyzbank;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Customers ( Isimler, Soyisimler, Telefon,  Departman, Sehir, DogumTarihi, Maas, Mail) VALUES (@isim, @soyisim, @telefon , @departman, @sehir, @dogumTarihi, @maas, @mail)";
                    int yeniId = 1000;
                    for (int i = 0; i < 100000000; i++)
                    {
                        yeniId++; // ID değerini artır
                    }
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", yeniId); // yeniId, belirlediğiniz ID

                        command.Parameters.AddWithValue("@isim", isim);
                        command.Parameters.AddWithValue("@soyisim", soyisim);
                        command.Parameters.AddWithValue("@telefon", telefon);
                        command.Parameters.AddWithValue("@departman", departman);
                        command.Parameters.AddWithValue("@sehir", sehir);
                        command.Parameters.AddWithValue("@dogumTarihi", dogumTarihi);
                        command.Parameters.AddWithValue("@maas", maas);
                        command.Parameters.AddWithValue("@mail", mail);

                        command.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Veri başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"SQL Error: {ex.Message}");
            }
        }
    }
}
