using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Contractors.Models;
using System.Configuration;

namespace Contractors.Repositories
{
    public class ContractorsRepository : IContractorsRepository
    {
        string CS = ConfigurationManager.ConnectionStrings["DBName"].ConnectionString;
        public List<Contractor> GetAll()
        {
            List<Contractor> contractors = new List<Contractor>();
            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * From Contractors";
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    contractors.Add(new Contractor()
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Name = reader["Name"].ToString(),
                        Country = reader["Country"].ToString(),
                        City = reader["City"].ToString(),
                        Street = reader["Street"].ToString(),
                        HouseNumber = int.Parse(reader["HouseNumber"].ToString()),
                        PostalCode = int.Parse(reader["PostalCode"].ToString()),
                        Email = reader["Email"].ToString(),
                        PhoneNumber = int.Parse(reader["PhoneNumber"].ToString()),
                        NIP = int.Parse(reader["NIP"].ToString()),
                        AccountNumber = reader["AccountNumber"].ToString()
                    });
                }
                return contractors;
            }
        }
        public Contractor Details(int id)
        {
            Contractor contractor = new Contractor();
            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select Id,Name,Country,City,Street,HouseNumber,PostalCode,Email,PhoneNumber,NIP,AccountNumber FROM Contractors where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                contractor.Id = int.Parse(reader["Id"].ToString());
                contractor.Name = reader["Name"].ToString();
                contractor.Country = reader["Country"].ToString();
                contractor.City = reader["City"].ToString();
                contractor.Street = reader["Street"].ToString();
                contractor.HouseNumber = int.Parse(reader["HouseNumber"].ToString());
                contractor.PostalCode = int.Parse(reader["PostalCode"].ToString());
                contractor.Email = reader["Email"].ToString();
                contractor.PhoneNumber = int.Parse(reader["PhoneNumber"].ToString());
                contractor.NIP = int.Parse(reader["NIP"].ToString());
                contractor.AccountNumber = reader["AccountNumber"].ToString();
                return contractor;
            }

        }
        public Contractor Edit(Contractor contractor, int id)
        {
            using (SqlConnection conn = new SqlConnection(CS))
            {
                String query = "UPDATE Contractors SET Name=@Name,Country=@Country,City=@City,Street=@Street,HouseNumber=@HouseNumber,PostalCode=@PostalCode,Email=@Email,PhoneNumber=@PhoneNumber,NIP=@NIP,AccountNumber=@AccountNumber WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", contractor.Id);
                    cmd.Parameters.AddWithValue("@Name", contractor.Name);
                    cmd.Parameters.AddWithValue("@Country", contractor.Country);
                    cmd.Parameters.AddWithValue("@City", contractor.City);
                    cmd.Parameters.AddWithValue("@Street", contractor.Street);
                    cmd.Parameters.AddWithValue("@HouseNumber", contractor.HouseNumber);
                    cmd.Parameters.AddWithValue("@PostalCode", contractor.PostalCode);
                    cmd.Parameters.AddWithValue("@Email", contractor.Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", contractor.PhoneNumber);
                    cmd.Parameters.AddWithValue("@NIP", contractor.NIP);
                    cmd.Parameters.AddWithValue("@AccountNumber", contractor.AccountNumber);
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    
                }
                return contractor;
            }
        }
        public void Delete(Contractor contractor,int id)
        {
            //Contractor contractorToDelete = new Contractor();
            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Delete From Contractors where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                
            }
            
        }
        public void Create(Contractor contractor)
        {
            using (SqlConnection conn = new SqlConnection(CS))
            {
                conn.Open();
                string query = "Insert Into Contractors(Name,Country,City,Street,HouseNumber,PostalCode,Email,PhoneNumber,NIP,AccountNumber) values(@Name,@Country,@City,@Street,@HouseNumber,@PostalCode,@Email,@PhoneNumber,@NIP,@AccountNumber)";
                SqlCommand cmd = new SqlCommand(query, conn);

                
                cmd.Parameters.AddWithValue("@Name", contractor.Name);
                cmd.Parameters.AddWithValue("@Country", contractor.Country);
                cmd.Parameters.AddWithValue("@City", contractor.City);
                cmd.Parameters.AddWithValue("@Street", contractor.Street);
                cmd.Parameters.AddWithValue("@HouseNumber", contractor.HouseNumber);
                cmd.Parameters.AddWithValue("@PostalCode", contractor.PostalCode);
                cmd.Parameters.AddWithValue("@Email", contractor.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", contractor.PhoneNumber);
                cmd.Parameters.AddWithValue("@NIP", contractor.NIP);
                cmd.Parameters.AddWithValue("@AccountNumber", contractor.AccountNumber);
                cmd.ExecuteNonQuery();
                
            }
        }
    }
}