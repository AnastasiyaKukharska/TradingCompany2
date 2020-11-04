﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL.Interfaces;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL.Concrete
{
    public class BasketDal : IBasketDal
    {
        private string connectionString;

        public BasketDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public BasketDTO CreateBasket(BasketDTO basket)
        {
            var x = DateTime.Now;
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "insert into Basket (UserID,BookID,StatusID,Title,Author,Price,Amount,Date) output INSERTED.BasketID values (@userID,@bookID,@statusID,@title,@author,@price,@amount,@date)";
                comm.Parameters.Clear();
                //comm.Parameters.AddWithValue("@basketID", basket.BasketID);
                comm.Parameters.AddWithValue("@title", basket.Title);
                comm.Parameters.AddWithValue("@userID", basket.UserID);
                comm.Parameters.AddWithValue("@statusID", basket.StatusID);
                comm.Parameters.AddWithValue("@bookID", basket.BookID);
                comm.Parameters.AddWithValue("@author", basket.Author);
                comm.Parameters.AddWithValue("@price", basket.Price);
                comm.Parameters.AddWithValue("@amount", basket.Amount);
                comm.Parameters.AddWithValue("@date", basket.Date);
                conn.Open();

                basket.BasketID = Convert.ToInt32(comm.ExecuteScalar());
                return basket;
            }
        }

        public void DeleteBasket(int id)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "delete from Basket where BasketID = @id";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@id", id);
                conn.Open();

                comm.ExecuteNonQuery();
            }
        }

        public List<BasketDTO> GetAllBaskets()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "select * from Basket";
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                List<BasketDTO> baskets = new List<BasketDTO>();
                while (reader.Read())
                {
                    baskets.Add(new BasketDTO
                    {
                        BasketID = (int)reader["BasketID"],
                        UserID = (int)reader["UserID"],
                        StatusID = (int)reader["StatusID"],
                        BookID = (int)reader["BookID"],
                        Title = reader["Title"].ToString(),
                        Author = reader["Author"].ToString(),
                        Amount = (int)reader["Amount"],
                        Price = (decimal)reader["Price"],
                        Date = (DateTime)reader["Date"],

                    });
                }

                return baskets;
            }
        }

        public void GetBasketById(int id)
        {

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "select * from Basket where UserId=id";
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Author"]}\t{reader["Title"]}\t{reader["Price"]}\t{reader["Amount"]}\t{reader["Date"]}");
                }
            }
        }
        //при оплаті покупки, або замовленні доставки змінює статус замовлення

        public void  UpdateBasket(int id,int Sid)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                conn.Open();
                comm.CommandText = "update Baket set StatusID = @newStatusId where BasketID = id";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@newStatusID", Sid);
            }
        }
        string connStr = ConfigurationManager.ConnectionStrings["IMDB"].ConnectionString;
        //int ID;
        public int UD(string username)
        {
            
            using (SqlConnection conn = new SqlConnection(this.connStr))
            using (SqlCommand comm = conn.CreateCommand())
            {
                conn.Open();
                comm.CommandText = $"select * from Users where Login='{username}'  " ;
                SqlDataReader reader = comm.ExecuteReader();


                    UserDTO users = new UserDTO();

                    users.UserID = (int)reader["UserID"];

                conn.Close();
                return users.UserID;
            }
            
        }
        public void AddBook(string t, int id)
        {
            BasketDal dal2 = new BasketDal(ConfigurationManager.ConnectionStrings["IMDB"].ConnectionString);
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand comm = conn.CreateCommand())
            {
                conn.Open();
                comm.CommandText = $"select * from Books where Title = '{t}'";
                SqlDataReader reader = comm.ExecuteReader();

                BooksDTO Book = new BooksDTO();
                while (reader.Read())
                {


                    Book.BookID = (int)reader["BookID"];
                    Book.Author = reader["Autor"].ToString();
                    Book.Price = (Decimal)reader["Price"];


                }
                conn.Close();
                BasketDTO m = new BasketDTO
                {
                    Title = t,
                    UserID = id,
                    BookID = Book.BookID,
                    StatusID = 3,
                    Author = Book.Author,
                    Price = Book.Price,
                    Amount = 1,
                    Date = DateTime.Now
                };

                m = dal2.CreateBasket(m);
            }
        }
    }
}
