using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace connect
{
    internal class accesdata
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=your-access-database-file.accdb;";

        public string AccessBaglan()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                return "Bağlantı başarıyla açıldı!";
            }
        }

        public void AccessEkle(
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
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Customers (Isimler, Soyisimler, Telefon, Departman, Sehir, DogumTarihi, Maas, Mail) VALUES (@isim, @soyisim, @telefon, @departman, @sehir, @dogumTarihi, @maas, @mail)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
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
                throw new ApplicationException($"Access Hatası: {ex.Message}");
            }
        }

        public void AccessSil(int customerId)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Customers WHERE KişiID = @customerId";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
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
                throw new ApplicationException($"Access Hatası: {ex.Message}");
            }
        }

        public DataTable GetCustomerData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Customers";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Access Hatası: {ex.Message}");
            }
        }

        public void AccessUpdateCustomer(int KişiId, string newName, string newSurname, string newTelefon, string newDepart, string newSehir, string newDt, string newMaas, string newMail)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Customers SET Isimler = @newName, Soyisimler = @newSurname, Telefon = @newTelefon, Departman = @newDepart, Sehir = @newSehir, DogumTarihi = @newDt, Maas = @newMaas, Mail = @newMail WHERE KişiID = @KişiId";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KişiId", KişiId);
                        command.Parameters.AddWithValue("@newName", newName);
                        command.Parameters.AddWithValue("@newSurname", newSurname);
                        command.Parameters.AddWithValue("@newTelefon", newTelefon);
                        command.Parameters.AddWithValue("@newDepart", newDepart);
                        command.Parameters.AddWithValue("@newSehir", newSehir);
                        command.Parameters.AddWithValue("@newDt", newDt);
                        command.Parameters.AddWithValue("@newMaas", newMaas);
                        command.Parameters.AddWithValue("@newMail", newMail);

                        command.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Kayıt başarıyla güncellendi!");
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Access Hatası: {ex.Message}");
            }
        }
    }
}
  