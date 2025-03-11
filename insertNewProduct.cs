using System;
using MySql.Data.MySqlClient;

namespace OOP
{
    class ManageProduct
    {
        public class InsertNewProduct
        {
            private string server = "localhost";
            private string database = "itelect";
            private string username = "root";
            private string password = "";
            private string connString;

            public InsertNewProduct()
            {
                connString = $"Server={server};Database={database};User ID={username};Password={password};";
            }
            
            public void InsertData(string productName, int productPrice, string productDescription)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        product.lineBreaker.lineBreak();
                        Console.WriteLine(@"
                                    
                                 __                                    __ __      
                                /   _  _  _  _ _|_ _ _|  |_ _   |\/|  (_ /  \|  | 
                                \__(_)| )| )(-(_|_(-(_|  |_(_)  |  |\/__)\_\/|__.");



                        string query = "INSERT INTO productlist (productName, productPrice, productDescription) VALUES (@name, @price, @description)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", productName);
                            cmd.Parameters.AddWithValue("@price", productPrice);
                            cmd.Parameters.AddWithValue("@description", productDescription);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            Console.WriteLine(rowsAffected > 0 ? @"



=======================================================================================================================
 
            |   \ __ _| |_ __ _  (_)_ _  ______ _ _| |_ ___ __| |  ____  _ __ __ ___ ______/ _|_  _| | |_  _| |
            | |) / _` |  _/ _` | | | ' \(_-/ -_| '_|  _/ -_/ _` | (_-| || / _/ _/ -_(_-(_-|  _| || | | | || |_|
            |___/\__,_|\__\__,_| |_|_||_/__\___|_|  \__\___\__,_| /__/\_,_\__\__\___/__/__|_|  \_,_|_|_|\_, (_)
                                                                                                        |__/
=======================================================================================================================" : @"

                        ___     _ _        _   _         _                 _        _      _        _ 
                        | ____ _(_| |___ __| | | |_ ___  (_)_ _  ______ _ _| |_   __| |__ _| |_ __ _| |
                        | _/ _` | | / -_/ _` | |  _/ _ \ | | ' \(_-/ -_| '_|  _| / _` / _` |  _/ _` |_|
                        |_|\__,_|_|_\___\__,_|  \__\___/ |_|_||_/__\___|_|  \__| \__,_\__,_|\__\__,_(_)");


                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}