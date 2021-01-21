using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Employee_Management_Alpha_1._0
{
    public class Stock
    {


        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;");//sql connector
        private Item stock;
        private StockSales stockSales;
        private List<StockRequestInfo> stockRequestInfos;
        private List<Item> newStocks;
        private List<StockSales> newSales;
        private List<Item> DepoStock;

        public Stock()
        {
            this.newStocks = new List<Item>();
            this.newSales = new List<StockSales>();
            this.stockRequestInfos = new List<StockRequestInfo>();
            this.DepoStock = new List<Item>();
        }




        public Item GetItemsById(int id)
        {


            if (GetAllItems().Count > 0)//For cycle runs into an error if list is empty, so we check it here and skip the cycle if it's empty
            {
                for (int i = 0; i < GetAllItems().Count; i++)
                {
                    if (GetAllItems()[i].Id == id)
                    {
                        return GetAllItems()[i];
                    }
                }
            }
            return null;
        }

        public Item GetDepoItemsById(int id)
        {


            if (GetAllDepoStock().Count > 0)//For cycle runs into an error if list is empty, so we check it here and skip the cycle if it's empty
            {
                for (int i = 0; i < GetAllDepoStock().Count; i++)
                {
                    if (GetAllDepoStock()[i].Id == id)
                    {
                        return GetAllDepoStock()[i];
                    }
                }
            }
            return null;
        }


        public StockRequestInfo GetRequestByID(int id)
        {
            if (GetAllRequests().Count > 0)
            {
                for(int i = 0; i < GetAllRequests().Count; i++)
                {
                    if(GetAllRequests()[i].ID == id)
                    {
                        return GetAllRequests()[i];
                    }
                }
            }
            return null;
        }



        public List<StockRequestInfo> GetAllRequests()
        {
            stockRequestInfos.Clear();
            string sql = "SELECT * FROM stockrequests";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                stockRequestInfos.Add(new StockRequestInfo(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2])));
            }
            if (stockRequestInfos.Count() >= 1)
            {
                conn.Close();
                return stockRequestInfos;
            }
            else
            {
                conn.Close();
                return null;
            }
        }

        public List<StockSales> GetAllSales()
        {
            newSales.Clear();
            string sql = "SELECT * FROM `stock_purchases` WHERE Sales > 1 ORDER BY Sales DESC";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                newSales.Add(new StockSales(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1])));

            }
            if (newSales.Count() >= 1)
            {
                conn.Close();
                return newSales;
            }
            else
            {
                conn.Close();
                return null;
            }
        }

        public List<Item> SearchItemStock(string s)
        {
            newStocks.Clear();
            string sql = "SELECT * FROM itemstock WHERE Name LIKE '%" + s + "%'";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                newStocks.Add(new Item(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2]), Convert.ToDouble(dr[3]), Convert.ToString(dr[4])));

            }
            if (newStocks.Count() >= 1)
            {
                conn.Close();
                return newStocks;
            }
            else
            {
                conn.Close();
                return null;
            }
        }

        public List<Item> SearchDepoStock(string s)
        {
            newStocks.Clear();
            string sql = "SELECT * FROM depostock WHERE Name LIKE '%" + s + "%'";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                newStocks.Add(new Item(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2]), Convert.ToDouble(dr[3]), Convert.ToString(dr[4])));

            }
            if (newStocks.Count() >= 1)
            {
                conn.Close();
                return newStocks;
            }
            else
            {
                conn.Close();
                return null;
            }
        }

        public List<Item> GetAllDepoStock()
        {
            DepoStock.Clear();
            string sql = "SELECT * FROM depostock";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DepoStock.Add(new Item(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2]), Convert.ToDouble(dr[3]), Convert.ToString(dr[4])));

            }
            if (DepoStock.Count() >= 1)
            {
                conn.Close();
                return DepoStock;
            }
            else
            {
                conn.Close();
                return null;
            }
        }

        public List<Item> GetAllDepoStockWithLowQuantity()
        {
            DepoStock.Clear();
            string sql = "SELECT * FROM depostock WHERE Quantity < 15 ORDER BY Quantity DESC";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DepoStock.Add(new Item(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2]), Convert.ToDouble(dr[3]), Convert.ToString(dr[4])));

            }
            if (DepoStock.Count() >= 1)
            {
                conn.Close();
                return DepoStock;
            }
            else
            {
                conn.Close();
                return null;
            }
        }

        public List<Item> GetAllItems()
        {
            newStocks.Clear();
            string sql = "SELECT * FROM itemstock";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                newStocks.Add(new Item(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2]), Convert.ToDouble(dr[3]), Convert.ToString(dr[4])));
            }
            if (newStocks.Count() >= 1)

            {
                conn.Close();

                return newStocks;
            }
            else
            {
                conn.Close();

                return null;
            }
        }

        public void RemoveItembyId(string id)
        {
            string sql = $"DELETE FROM `itemstock` WHERE `itemstock`.`ID` = {id};";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void RemoveRequestById(int id)
        {
            string sql = $"DELETE FROM `stockrequests` WHERE `stockrequests`.`ID` = {id};";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }


        public void RemoveDepoItembyId(string id)
        {
            string sql = $"DELETE FROM `depostock` WHERE `itemstock`.`ID` = {id};";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }


        public void BuyItem(string id, int quantity, int amount) // at this point, it only decreases the quantity of the item
        {
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand($"UPDATE `depostock` SET `Quantity` = '{quantity + amount}' WHERE ID = {id}", connection);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void AcceptStockRequest(string id, int quantity, int amount)
        {
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand($"UPDATE `itemstock` SET `Quantity` = '{quantity + amount}' WHERE ID = {id}", connection);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void AddStockRequest(int id, string name, int amount)
        {
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO stockrequests (ID, Name, Amount) VALUES (@ID, @Name, @Amount) ON DUPLICATE KEY UPDATE `Amount` = `Amount` + @Amount", connection);
                    //MessageBox.Show(cmd.CommandText);

                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }


        public void AddItem(string name, int quantity, double pricePerUnit, string category)
        {
            this.stock = new Item(name, quantity, pricePerUnit, category); //instantiate a new object of type employee
            this.newStocks.Add(stock); //add it to list of type employee
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Data entered succesfully.");
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO itemstock (Name, Quantity, PricePerUnit, Category) VALUES (@Name, @Quantity, @PricePerUnit, @Category)", connection);
                    //cmd.Parameters.AddWithValue("@employeeID", Convert.ToInt32(tbEmployeeID.Text));

                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@PricePerUnit", pricePerUnit);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void AddDepoItem(string name, int quantity, double pricePerUnit, string category)
        {
            this.stock = new Item(name, quantity, pricePerUnit, category); //instantiate a new object of type employee
            this.newStocks.Add(stock); //add it to list of type employee
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Data entered succesfully.");
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO depostock (Name, Quantity, PricePerUnit, Category) VALUES (@Name, @Quantity, @PricePerUnit, @Category)", connection);
                    //cmd.Parameters.AddWithValue("@employeeID", Convert.ToInt32(tbEmployeeID.Text));

                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Quantity", 0);
                    cmd.Parameters.AddWithValue("@PricePerUnit", pricePerUnit);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void AddItemToDepo(string name, int quantity, double pricePerUnit, string category)
        {
            this.stock = new Item(name, quantity, pricePerUnit, category); //instantiate a new object
            this.DepoStock.Add(stock); //add it to list
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Data entered succesfully.");
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO depostock (Name, Quantity, PricePerUnit, Category) VALUES (@Name, @Quantity, @PricePerUnit, @Category)", connection);

                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@PricePerUnit", pricePerUnit);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public int GetQuantityFromDepo(int id)
        {
            string quantity;

            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);

            connection.Open();
            if (connection.State == ConnectionState.Open)
            {

                MySqlCommand cmd = new MySqlCommand($"SELECT Quantity FROM `depostock` WHERE ID = {id}", connection);

                var dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    quantity = dr.GetString(0);


                    //MySqlCommand cmd = new MySqlCommand($"UPDATE `itemstock` SET `Sales` = '{sales + quantity}' WHERE ID = {id}", connection);

                    dr.Close();
                    connection.Close();
                    return Convert.ToInt32(quantity);

                }
                else
                {
                    return 0;
                }

            }
            else
            {
                return 0;
            }
        }

        public string GetQuantity(int id)
        {
            string quantity;

            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);

            connection.Open();
            if (connection.State == ConnectionState.Open)
            {

                MySqlCommand cmd = new MySqlCommand($"SELECT Sales FROM `stock_purchases` WHERE ID = {id}", connection);

                var dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    quantity = dr.GetString(0);


                    //MySqlCommand cmd = new MySqlCommand($"UPDATE `itemstock` SET `Sales` = '{sales + quantity}' WHERE ID = {id}", connection);

                    dr.Close();
                    connection.Close();
                    return quantity;

                }
                else
                {
                    return "0";
                }

            }
            else
            {
                return "0";
            }
        }

        public string GetSales(int id)
        {
            string quantity;

            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);

            connection.Open();
            if (connection.State == ConnectionState.Open)
            {

                MySqlCommand cmd = new MySqlCommand($"SELECT Sales FROM `stock_purchases` WHERE ID = {id}", connection);

                var dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    dr.Read();
                    quantity = dr.GetString(0);

                    
                    //MySqlCommand cmd = new MySqlCommand($"UPDATE `itemstock` SET `Sales` = '{sales + quantity}' WHERE ID = {id}", connection);

                    dr.Close();
                    connection.Close();
                    return quantity;

                }
                else
                {
                    return "0";
                }

            }
            else
            {
                return "0";
            }
        }

        public void AddSale(int id, int sales, int quantity)
        {
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                   
                    MySqlCommand cmd = new MySqlCommand($"UPDATE `stock_purchases` SET `Sales` = '{sales + quantity}' WHERE ID = {id}", connection);
                   

                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void ChangeItem(string id, string name, int quantity, double pricePerUnit, string category)
        {
            this.stock = new Item(name, quantity, pricePerUnit, category); //instantiate a new object of type employee
            this.newStocks.Add(stock); //add it to list of type employee
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Data entered succesfully.");
                    //MySqlCommand cmd = new MySqlCommand($"UPDATE `itemstock` SET `Name` = '{name}', `Quantity` = '{quantity}' WHERE ID = {id}", connection);
                    MySqlCommand cmd = new MySqlCommand($"UPDATE `itemstock` SET `Name` = '{name}', `Quantity` = '{quantity}', `PricePerUnit` = '{pricePerUnit}', `Category` = '{category}' WHERE ID = {id}", connection);
                    //, `DOB`, `BSN`, `Position`, `WorkingHours`, `PhoneNr`, `Address`, `Email`, `EmergencyC`, `EmergencyR`, `EmergencyNr`, `Certifications`, `Languages`, `ContractType`, `ContractDuration`
                    //cmd.Parameters.AddWithValue("@employeeID", Convert.ToInt32(tbEmployeeID.Text));

                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void UpdateStockWithNoQuantity(string id, string name, int quantity, double pricePerUnit, string category)
        {
            this.stock = new Item(name, quantity, pricePerUnit, category); //instantiate a new object of type employee
            this.newStocks.Add(stock); //add it to list of type employee
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand($"UPDATE `itemstock` SET `Name` = '{name}', `PricePerUnit` = '{pricePerUnit}', `Category` = '{category}' WHERE ID = {id}", connection);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void UpdateDepoStockWithNoQuantity(string id, string name, int quantity, double pricePerUnit, string category)
        {
            this.stock = new Item(name, quantity, pricePerUnit, category); //instantiate a new object of type employee
            this.newStocks.Add(stock); //add it to list of type employee
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Data entered succesfully.");
                    //MySqlCommand cmd = new MySqlCommand($"UPDATE `itemstock` SET `Name` = '{name}', `Quantity` = '{quantity}' WHERE ID = {id}", connection);
                    MySqlCommand cmd = new MySqlCommand($"UPDATE `depostock` SET `Name` = '{name}', `PricePerUnit` = '{pricePerUnit}', `Category` = '{category}' WHERE ID = {id}", connection);
                    //, `DOB`, `BSN`, `Position`, `WorkingHours`, `PhoneNr`, `Address`, `Email`, `EmergencyC`, `EmergencyR`, `EmergencyNr`, `Certifications`, `Languages`, `ContractType`, `ContractDuration`
                    //cmd.Parameters.AddWithValue("@employeeID", Convert.ToInt32(tbEmployeeID.Text));

                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void ChangeDepoItem(string id, string name, int quantity, double pricePerUnit, string category)
        {
            this.stock = new Item(name, quantity, pricePerUnit, category); //instantiate a new object of type employee
            this.newStocks.Add(stock); //add it to list of type employee
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand($"UPDATE `depostock` SET `Name` = '{name}', `Quantity` = '{quantity}', `PricePerUnit` = '{pricePerUnit}', `Category` = '{category}' WHERE ID = {id}", connection);

                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }



    }
}

