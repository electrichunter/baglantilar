    using System;
    using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
using System.Windows.Forms;

namespace connect
{
    internal class sqldata
    {
        string connectionString = "Data Source=(local);Initial Catalog=xyzbank;Integrated Security=True";
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



        public void Sqlsil(int customerId)
        {
            try
            {
                // Veritabanı bağlantı dizesi
                string connectionString = "Data Source=(local);Initial Catalog=xyzbank;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Müşteriyi benzersiz ID ile silme sorgusu
                    string query = "DELETE FROM Customers WHERE KişiID = @customerId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreyi ekle
                        command.Parameters.AddWithValue("@customerId", customerId);

                        // Sorguyu çalıştır
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
                throw new ApplicationException($"SQL Hatası: {ex.Message}");
            }
        }








        public DataTable GetCustomerData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu tanımla
                    string query = "SELECT * FROM Customers";

                    // SqlDataAdapter ile DataTable'ı doldur
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"SQL Error: {ex.Message}");
            }
        }

        /*
        public void DeğişiklikleriKaydet()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanında bekleyen değişiklik olup olmadığını kontrol edin
                    using (SqlCommand command = new SqlCommand("SELECT @@TRANCOUNT()", connection))
                    {
                        int tranCount = (int)command.ExecuteScalar();

                        if (tranCount > 0)
                        {
                            // İşlemi tamamlayın
                            using (SqlCommand commitCommand = new SqlCommand("COMMIT TRANSACTION", connection))
                            {
                                commitCommand.ExecuteNonQuery();
                            }

                            Console.WriteLine("Değişiklikler başarıyla kaydedildi!");
                        }
                        else
                        {
                            Console.WriteLine("Bekleyen değişiklik bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Veritabanı Hatası: {ex.Message}");
            }
        }
    
        
        */

        public void SqlUpdateCustomer(int KişiId, string newName, string newSurname, string newTelfon, string newDepart, string newSehir, string newDt, string newMaas, string newMail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Customers SET Isimler = @newName, Soyisimler = @newSurname, Telefon = @newTelfon, Departman = @newDepart, Sehir = @newSehir, DogumTarihi = @newDt, Maas = @newMaas, Mail = @newMail WHERE KişiID = @KişiId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KişiId", KişiId);
                    command.Parameters.AddWithValue("@newName", newName);
                    command.Parameters.AddWithValue("@newSurname", newSurname);
                    command.Parameters.AddWithValue("@newTelfon", newTelfon);
                    command.Parameters.AddWithValue("@newDepart", newDepart);
                    command.Parameters.AddWithValue("@newSehir", newSehir);
                    command.Parameters.AddWithValue("@newDt", newDt);
                    command.Parameters.AddWithValue("@newMaas", newMaas);
                    command.Parameters.AddWithValue("@newMail", newMail);

                    command.ExecuteNonQuery(); // SQL komutunu çalıştır
                }
            }
        }
    }
}



    

    
