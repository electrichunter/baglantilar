using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
using MySql.Data;
using MySql.Data.MySqlClient;

namespace connect
{
 internal class mysqldata
   {
       // MySQL bağlantı dizesi
       string connectionString = "Server=localhost;Database=xyzbank;Uid=root;Pwd=password;"; // Bağlantı bilgilerinizi buraya girin

       // Veritabanına bağlanma ve bağlantıyı açma
       public string MySqlBaglan()
       {
           try
           {
               using (MySqlConnection connection = new MySqlConnection(connectionString))
               {
                   connection.Open();
                   return "Bağlantı başarıyla açıldı!";
               }
           }
           catch (Exception ex)
           {
               throw new ApplicationException($"MySQL Bağlantı Hatası: {ex.Message}");
           }
       }

       // Veritabanına yeni müşteri ekleme
       public void MySqlEkle(
           string isim,
           string soyisim,
           string telefon,
           string departman,
           string sehir,
           DateTime dogumTarihi,
           decimal maas,
           string mail)
       {
           try
           {
               using (MySqlConnection connection = new MySqlConnection(connectionString))
               {
                   connection.Open();

                   string query = "INSERT INTO Customers (Isimler, Soyisimler, Telefon, Departman, Sehir, DogumTarihi, Maas, Mail) VALUES (@isim, @soyisim, @telefon, @departman, @sehir, @dogumTarihi, @maas, @mail)";

                   using (MySqlCommand command = new MySqlCommand(query, connection))
                   {
                       command.Parameters.AddWithValue("@isim", isim);
                       command.Parameters.AddWithValue("@soyisim", soyisim);
                       command.Parameters.AddWithValue("@telefon", telefon);
                       command.Parameters.AddWithValue("@departman", departman);
                       command.Parameters.AddWithValue("@sehir", sehir);
                       command.Parameters.AddWithValue("@dogumTarihi", dogumTarihi);
                       command.Parameters.AddWithValue("@maas", maas);
                       command.Parameters.AddWithValue("@mail", mail);

                       command.ExecuteNonQuery(); // Komutu çalıştır
                   }
               }

               Console.WriteLine("Veri başarıyla eklendi!");
           }
           catch (Exception ex)
           {
               throw new ApplicationException($"MySQL Hatası: {ex.Message}");
           }
       }

       // Belirli bir müşteri kaydını silme
       public void MySqlSil(int customerId)
       {
           try
           {
               using (MySqlConnection connection = new MySqlConnection(connectionString))
               {
                   connection.Open();

                   string query = "DELETE FROM Customers WHERE KişiID = @customerId";

                   using (MySqlCommand command = new MySqlCommand(query, connection))
                   {
                       command.Parameters.AddWithValue("@customerId", customerId);

                       int rowsAffected = command.ExecuteNonQuery();

                       if (rowsAffected > 0)
                       {
                           Console.WriteLine("Kayıt başarıyla silindi.");
                       }
                       else
                       {
                           Console.WriteLine("Silinecek kayıt bulunamadı.");
                       }
                   }
               }
           }
           catch (Exception ex)
           {
               throw new ApplicationException($"MySQL Hatası: {ex.Message}");
           }
       }

       // Veritabanındaki müşteri verilerini getirme
       public DataTable GetCustomerData()
       {
           try
           {
               using (MySqlConnection connection = new MySqlConnection(connectionString))
               {
                   connection.Open();
                   string query = "SELECT * FROM Customers";

                   MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                   DataTable dataTable = new DataTable();
                   adapter.Fill(dataTable);

                   return dataTable;
               }
           }
           catch (Exception ex)
           {
               throw yeni ApplicationException($"MySQL Hatası: {ex.Message}");
           }
       }

       // Belirli bir müşteriyi güncelleme
       public void MySqlUpdateCustomer(int customerId, string newName, string newSurname, string newTelefon, string newDepartman, string newSehir, DateTime newDogumTarihi, decimal newMaas, string newMail)
       {
           try
           {
               using (MySqlConnection connection = new MySqlConnection(connectionString))
               {
                   connection.Open();

                   string query = "UPDATE Customers SET Isimler = @newName, Soyisimler = @newSurname, Telefon = @newTelefon, Departman = @newDepartman, Sehir = @newSehir, DogumTarihi = @newDogumTarihi, Maas = @newMaas, Mail = @newMail WHERE KişiID = @customerId";

                   using (MySqlCommand command = new MySqlCommand(query, connection))
                   {
                       command.Parameters.AddWithValue("@customerId", customerId);
                       command.Parameters.AddWithValue("@newName", newName);
                       command.Parameters.AddWithValue("@newSurname", newSurname);
                       command.Parameters.AddWithValue("@newTelefon", newTelefon);
                       command.Parameters.AddWithValue("@newDepartman", newDepartman);
                       command.Parameters.AddWithValue("@newSehir", newSehir);
                       command.Parameters.AddWithValue("@newDogumTarihi", newDogumTarihi);
                       command.Parameters.AddWithValue("@newMaas", newMaas);
                       command.Parameters.AddWithValue("@newMail", newMail);

                       command.ExecuteNonQuery();
                   }
               }
           }
           catch (Exception ex)
           {
               throw new ApplicationException($"MySQL Hatası: {ex.Message}");
           }
       }
   }
}





   }
}*/