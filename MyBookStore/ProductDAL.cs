using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore
{
	public class ProductDAL
	{

		private static string _connectionString = @"Server=DESKTOP-I43KRTU\MSSQLSERVER2019;Initial Catalog=ETrade;Integrated Security=True";
		readonly SqlConnection _connection = new SqlConnection(_connectionString);
		public List<Product> GetAll()
		{
			ConnectionControl();
			SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);
			SqlDataReader reader = command.ExecuteReader();
			DataTable dataTable = new DataTable();
			List<Product> products = new List<Product>();
			while (reader.Read())
			{
				Product product = new Product
				{
					Id = Convert.ToInt32(reader["Id"]),
					Name = reader["Name"].ToString(),
					StockAmount = Convert.ToInt32(reader["StockAmount"]),
					UnitPrice = Convert.ToInt32(reader["UnitPrice"])

				};
				products.Add(product);
			}

			reader.Close();
			_connection.Close();
			return products;

		}

		private void ConnectionControl()
		{
			if (_connection.State == ConnectionState.Closed)
			{
				_connection.Open();
			}
		}

		//public class ProductDAL
		//{
		//	public DataTable GetAll()
		//	{
		//		string connectionString = @"Server=DESKTOP-I43KRTU\MSSQLSERVER2019;Initial Catalog=ETrade;Integrated Security=True";

		//		SqlConnection connection = new SqlConnection(connectionString);

		//		if (connection.State == ConnectionState.Closed)
		//		{
		//			connection.Open();
		//		}
		//		SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);
		//		SqlDataReader reader = command.ExecuteReader();
		//		DataTable dataTable = new DataTable();
		//		dataTable.Load(reader);
		//		reader.Close();
		//		connection.Close();
		//		return dataTable;

		//	}

		public void Add(Product product)
		{
			ConnectionControl();
			SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.Products VALUES(@name,@unitPrice,@stockAmount)", _connection);
			sqlCommand.Parameters.AddWithValue("@name", product.Name);
			sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
			sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
			sqlCommand.ExecuteNonQuery();
			_connection.Close();
			
		}

		public void Update(Product product)
		{
			ConnectionControl();
			SqlCommand sqlCommand = new SqlCommand("UPDATE dbo.Products SET Name=@name,UnitPrice=@unitPrice,StockAmount=@stockAmount WHERE Id=@id", _connection);
			sqlCommand.Parameters.AddWithValue("@name", product.Name);
			sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
			sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
			sqlCommand.Parameters.AddWithValue("@id", product.Id);
			sqlCommand.ExecuteNonQuery();
			_connection.Close();

		}



		public void Delete(int id)
		{
			ConnectionControl();
			SqlCommand sqlCommand = new SqlCommand("DELETE From dbo.Products WHERE  Id=@id", _connection);
		
			sqlCommand.Parameters.AddWithValue("@id",id);
			sqlCommand.ExecuteNonQuery();
			_connection.Close();

		}
	}
	}
