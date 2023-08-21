
using System.Data;
using System.Data.SqlClient;
var connectionString = @"Server=LAPTOP-HFQMVNHN;Database=Contacts;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";
var connection = new SqlConnection(connectionString);
var command = new SqlCommand("SELECT * FROM CONTACTS", connection);
connection.Open();
var dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
if (dataReader.HasRows)
{
    while (dataReader.Read())
    {
        var id = dataReader.GetInt32(0);
        var contactName = dataReader.GetString(1);
        var alias = dataReader.GetString(2);
        Console.WriteLine($"[{id}] {contactName} ({alias})");   
    }
}
Console.ReadLine();
