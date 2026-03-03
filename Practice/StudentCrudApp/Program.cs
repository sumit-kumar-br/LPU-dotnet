using System;
using Microsoft.Data.SqlClient;

string connectionString = "Server=localhost\\sqlexpress;Database=DemoDB;Trusted_Connection=True;TrustServerCertificate=True;";

while (true)
{
    Console.WriteLine("\n===== Student Management System =====");
    Console.WriteLine("1. Insert Student");
    Console.WriteLine("2. View Students");
    Console.WriteLine("3. Update Student");
    Console.WriteLine("4. Delete Student");
    Console.WriteLine("5. Exit");
    Console.Write("Enter choice: ");

    if(!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Invalid Input!!");
        continue;   
    }

    switch (choice)
    {
        case 1:
            InsertStudent(connectionString);
            break;
        case 2:
            ViewStudents(connectionString);
            break;
        case 3:
            UpdateStudent(connectionString);
            break;
        case 4:
            DeleteStudent(connectionString);
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
}

static void InsertStudent(string cs)
{
    Console.Write("Enter student name: ");
    string name = Console.ReadLine();

    Console.Write("Enter Email: ");
    string email = Console.ReadLine();

    using SqlConnection con = new SqlConnection(cs);
    string query = "insert into Students (Name, Email) values (@Name, @Email)";
    SqlCommand cmd = new SqlCommand(query, con);

    cmd.Parameters.AddWithValue("@Name", name);
    cmd.Parameters.AddWithValue("@Email",email);

    con.Open();
    cmd.ExecuteNonQuery();

    Console.WriteLine("Student inserted successfully");
}

static void ViewStudents(string cs)
{
    using SqlConnection con = new SqlConnection(cs);
    string query = "select * from Students";
    SqlCommand cmd = new SqlCommand(query, con);

    con.Open();
    using SqlDataReader reader = cmd.ExecuteReader();

    Console.WriteLine("\nID | Name | Email");
    Console.WriteLine("---------------------");

    while (reader.Read())
    {
        Console.WriteLine($"{reader["Id"]}  |  {reader["Name"]}  | {reader["Email"]}");
    }

}

static void UpdateStudent(string cs)
{
    Console.Write("Enter Student Id to Update: ");
    if (!int.TryParse(Console.ReadLine(), out int id))
    {
        Console.WriteLine("Invalid Id!");
        return;
    }
    
    Console.Write("Enter new name: ");
    string name = Console.ReadLine();

    Console.Write("Enter new Email: ");
    string email = Console.ReadLine();

    using SqlConnection con = new SqlConnection(cs);
    string query = "update Students set Name=@Name, Email=@Email where Id=@Id";
    SqlCommand cmd = new SqlCommand(query, con);

    cmd.Parameters.AddWithValue("@Name", name);
    cmd.Parameters.AddWithValue("@Email", email);
    cmd.Parameters.AddWithValue("@Id",id);

    con.Open();
    int rows = cmd.ExecuteNonQuery();

    Console.WriteLine(rows > 0 ? "Updated Successfully!" : "Student Not Found!");

}


static void DeleteStudent(string cs)
{
    Console.Write("Enter the student Id to delete: ");
    if(!int.TryParse(Console.ReadLine(), out int id))
    {
        Console.WriteLine("Invalid Id!");
        return;
    }

    using SqlConnection con = new SqlConnection(cs);
    string query = "delete from Students where Id=@Id";
    SqlCommand cmd = new SqlCommand(query, con);

    cmd.Parameters.AddWithValue("@Id",id);

    con.Open();
    int rows = cmd.ExecuteNonQuery();

    Console.WriteLine(rows > 0 ? "Deleted successfully!" : "Student not found!");
}