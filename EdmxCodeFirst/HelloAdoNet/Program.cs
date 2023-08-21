using System.Data.SqlClient;

// object đảm nhiệm việc kết nối

var connection = new SqlConnection
{
    // chuỗi ký tự chứa tham số phục vụ kết nối
    ConnectionString = @"Server=LAPTOP-HFQMVNHN;Database=Contacts;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true"
};
// object đảm nhiệm việc thực thi truy vấn

var command = new SqlCommand()
{
    Connection = connection,
    CommandText = "SELECT COUNT(*) FROM CONTACTS"
};

// thử mở kết nối
connection.Open();
// thực thi truy vấn và lấy kết quả
var res = (int)command.ExecuteScalar();
// đóng kết nối
connection.Close();
Console.WriteLine($"{res} contacts found in the database");
Console.ReadLine();
