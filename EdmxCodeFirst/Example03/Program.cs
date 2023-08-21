using System;
using System.Data;
using System.Data.SqlClient;

var connectionString = @"Server=LAPTOP-HFQMVNHN;Database=Contacts;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";

var dataTable = new DataTable();
using (var connection = new SqlConnection(connectionString))
{
    var command = connection.CreateCommand();
    command.CommandText = "SELECT * FROM CONTACTS";
    var dataAdapter = new SqlDataAdapter(command);
    dataAdapter.Fill(dataTable);
}
foreach (DataRow r in dataTable.Rows)
{
    var id = (int)r["Id"];
    var contactName = (string)r["ContactName"];
    var alias = (string)r["Alias"];
    Console.WriteLine($"[{id}] {contactName} ({alias})");
}
Console.ReadLine();
