using LMSWebAPI.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSWebAPI.DataAccess
{
    public class BooksManage
    {
        public static List<BOOK> GetAllBooks()
        {
            try
            {
                List<BOOK> bookList = new List<BOOK>();
                SqlConnection con = new SqlConnection();
                con = DBConnection.DBConn();
                con.Open();

                string sql = "SELECT * FROM BOOKS";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        BOOK item = new BOOK();

                        item.ID = reader.GetInt32(0);
                        item.BOOK_CODE = reader.GetString(1);
                        item.BOOK_NAME = reader.GetString(2);
                        item.BOOK_COUNT = reader.GetInt32(3);
                        bookList.Add(item);
                    }
                }
                return bookList;



            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
