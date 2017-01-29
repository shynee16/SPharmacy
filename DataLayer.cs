using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;

namespace SPharmacy
{
    class DataLayer
    {
        private static StreamWriter log = null;
        private static string logFile = null;
        internal enum buttonClicked { nan, add, edit };

        private static MySqlConnection con = new MySqlConnection();
        private static MySqlCommand cmd = new MySqlCommand();
        private static MySqlDataReader rdr = null;

//current user logged in
        internal static User currentUser;
        internal static UserType currentUserType;

        internal static void createLog()
        {
            logFile = "errlog/" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            File.Create(logFile).Dispose();
            log = new StreamWriter(logFile, true);
            log.AutoFlush = true;
        }

        internal static bool Connected()
        {
            MySqlConnectionStringBuilder csb = new MySqlConnectionStringBuilder();
            csb.Database = "sjpharmacy";
            csb.UserID = "root";
            csb.Password = "";
            csb.Port = 3306;
            csb.Server = "Localhost";
            csb.SqlServerMode = true;

            con.ConnectionString = csb.ConnectionString;

            try
            {
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [DATABASE CONNECT] " + ex.Message);
                return false;
            }
        }

        internal static bool login(string username, string password)
        {
            List<User> Users = getUsers();
            List<UserType> UserTypes = getUserTypes();

            foreach (User eachUser in Users)
            {
                if (eachUser.Username == username && eachUser.Password == password)
                {
                    currentUser = eachUser;
                }
            }

            foreach (UserType eachUserType in UserTypes)
            {
                if (currentUser.UserType == eachUserType.ID)
                {
                    currentUserType = eachUserType;
                }
            }

            if (currentUser.ID == 0 && currentUserType.ID == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal static void logout()
        {
            currentUser = new User();
            currentUserType = new UserType();
            log.Close();
            StreamReader readFile = new StreamReader(logFile);
            if (readFile.ReadLine() == null)
            {
                readFile.Close();
                File.Delete(logFile);
            }
            createLog();
            frmLogin newForm = new frmLogin();
            newForm.Show();
        }

        internal static void showMessage(string caption, string message)
        {
            frmMessageBox formMessage = new frmMessageBox(caption, message);
            formMessage.ShowDialog();
        }

        internal struct User
        {
            internal int ID;
            internal string Username;
            internal string Password;
            internal int UserType;
            internal string LastName;
            internal string GivenName;
            internal string Address;
        }

        internal static List<User> getUsers()
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [users]";

            List<User> Users = new List<User>();
            User perUser = new User();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perUser.ID = Convert.ToInt32(rdr["ID"]);
                        perUser.Username = rdr["Username"].ToString();
                        perUser.Password = rdr["Password"].ToString();
                        perUser.UserType = Convert.ToInt32(rdr["UserType"]);
                        perUser.LastName = rdr["LastName"].ToString();
                        perUser.GivenName = rdr["GivenName"].ToString();
                        perUser.Address = rdr["Address"].ToString();
                        Users.Add(perUser);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [USERS SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return Users;
        }

        internal static bool insertUser(User perUser) 
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [users] ([Username], [Password], [UserType], [LastName], [GivenName], [Address]) VALUES (@username, @password, @usertype, @lastname, @givenname, @address)";
            cmd.Parameters.AddWithValue("@username", perUser.Username);
            cmd.Parameters.AddWithValue("@password", perUser.Password);
            cmd.Parameters.AddWithValue("@usertype", perUser.UserType);
            cmd.Parameters.AddWithValue("@lastname", perUser.LastName);
            cmd.Parameters.AddWithValue("@givenname", perUser.GivenName);
            cmd.Parameters.AddWithValue("@address", perUser.Address);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [USERS INSERT] " + ex.Message);
                return false;
            }
        }
    //end insert Users

    //update Users
         internal static bool updateUser(User perUser) 
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [users] SET [Username] = @username, [Password] = @password, [UserType] = @usertype, [Address] = @address, [LastName] = @lastname, [GivenName] = @givenname WHERE ID = @id";
            cmd.Parameters.AddWithValue("@username", perUser.Username);
            cmd.Parameters.AddWithValue("@password", perUser.Password);
            cmd.Parameters.AddWithValue("@usertype", perUser.UserType);
            cmd.Parameters.AddWithValue("@lastname", perUser.LastName);
            cmd.Parameters.AddWithValue("@givenname", perUser.GivenName);
            cmd.Parameters.AddWithValue("@address", perUser.Address);
            cmd.Parameters.AddWithValue("@id", perUser.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [USERS UPDATE] " + ex.Message);
                return false;
            }
        }
   //end update Users

   //delete Users
         internal static bool deleteUser(User perUser) 
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE from [users] WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", perUser.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [USERS DELETE] " + ex.Message);
                return false;
            }
        }
   //end delete Users

   //end edit Users
//end User
        


//UserType
        internal struct UserType
        {
            internal int ID;
            internal string UserTypeName;
            internal string FileMaintenance;
            internal string Transactions;
            internal string Security;
        }

    //get UserTypes
        internal static List<UserType> getUserTypes()
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [usertypes]";

            List<UserType> UserTypes = new List<UserType>();
            UserType perUserType = new UserType();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perUserType.ID = Convert.ToInt32(rdr["ID"]);
                        perUserType.UserTypeName = rdr["UserType"].ToString();
                        perUserType.FileMaintenance = rdr["FileMaintenance"].ToString();
                        perUserType.Transactions = rdr["Transactions"].ToString();
                        perUserType.Security = rdr["Security"].ToString();
                        UserTypes.Add(perUserType);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [USERTYPES SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return UserTypes;
        }
   //end get UserTypes

    //insert User Type
        internal static bool insertUserType(UserType perUserType)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [usertypes] ([UserType], [FileMaintenance], [Transactions], [Security]) VALUES (@usertype, @filemaintenance, @transactions, @security)";
            cmd.Parameters.AddWithValue("@usertype", perUserType.UserTypeName);
            cmd.Parameters.AddWithValue("@filemaintenance", perUserType.FileMaintenance);
            cmd.Parameters.AddWithValue("@transactions", perUserType.Transactions);
            cmd.Parameters.AddWithValue("security", perUserType.Security);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [USERTYPES INSERT] " + ex.Message);
                return false;
            }
        }
    //end insert User Type

    //edit User Type
        internal static bool updateUserType(UserType perUserType)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [usertypes] SET [UserType] =  @usertype, [FileMaintenance] = @filemaintenance, [Transactions] = @transactions, [Security] = @security WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@usertype", perUserType.UserTypeName);
            cmd.Parameters.AddWithValue("@filemaintenance", perUserType.FileMaintenance);
            cmd.Parameters.AddWithValue("@transactions", perUserType.Transactions);
            cmd.Parameters.AddWithValue("security", perUserType.Security);
            cmd.Parameters.AddWithValue("@id", perUserType.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [USERTYPES UPDATE] " + ex.Message);
                return false;
            }
        }
    //end edit User Type
//end usertype
         
//Category
        internal struct Category
        {
            internal int ID;
            internal string Name;
        }

    //getCategories
        internal static List<Category> getCategories()
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [categories]";

            List<Category> Categories = new List<Category>();
            Category perCategory = new Category();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perCategory.ID = Convert.ToInt32(rdr["ID"]);
                        perCategory.Name = rdr["Name"].ToString();
                        Categories.Add(perCategory);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [CATEGORIES SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return Categories;
        }
    //end getCategories

    //insert Category
        internal static bool insertCategory(Category perCategory)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [categories]([Name]) VALUES(@name)";
            cmd.Parameters.AddWithValue("@name", perCategory.Name);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [CATEGORIES INSERT] " + ex.Message);
                return false;
            }
        }
    //end insert Category
    //edit Category
        internal static bool updateCategory(Category perCategory)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [categories] SET [Name] = @name WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@name", perCategory.Name);
            cmd.Parameters.AddWithValue("@id", perCategory.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [CATEGORIES UPDATE] " + ex.Message);
                return false;
            }
        }
    //end edit Category

    //delete Category
        internal static bool deleteCategory(Category perCategory)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM [categories] WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@id", perCategory.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [CATEGORIES DELETE] " + ex.Message);
                return false;
            }
        }
//End Category


//Discount
        internal struct Discount
        {
            internal int ID;
            internal string Name;
            internal decimal Value;
        }

   //getDiscounts
        internal static List<Discount> getDiscounts()
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [discounts]";

            List<Discount> Discounts = new List<Discount>();
            Discount perDiscount = new Discount();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perDiscount.ID = Convert.ToInt32(rdr["ID"]);
                        perDiscount.Name = rdr["Name"].ToString();
                        perDiscount.Value = Convert.ToDecimal(rdr["Value"]);
                        Discounts.Add(perDiscount);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [DISCOUNTS SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return Discounts;
        }
    //end get Discount

    //insert Discount
        internal static bool insertDiscount(Discount perDiscount)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [discounts] ([Name],[Value]) VALUES (@name, @value)";
            cmd.Parameters.AddWithValue("@name", perDiscount.Name);
            cmd.Parameters.AddWithValue("@value", perDiscount.Value);

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [DISCOUNTS INSERT] " + ex.Message);
                return false;
            }
        }
    //end insert Discount

    //update Discount
        internal static bool updateDiscount(Discount perDiscount)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [discounts] SET [Name] = @name, [Value] = @value WHERE ID = @id";
            cmd.Parameters.AddWithValue("@name", perDiscount.Name);
            cmd.Parameters.AddWithValue("@value", perDiscount.Value);
            cmd.Parameters.AddWithValue("@id", perDiscount.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [DISCOUNTS UPDATE] " + ex.Message);
                return false;
            }
        }
    //end update Discount

    //delete Discount
        internal static bool deleteDiscount(Discount perDiscount)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM [discounts] WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@id", perDiscount.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [DISCOUNTS DELETE] " + ex.Message);
                return false;
            }
        }
//End Discount

//Products
        internal struct Product
        {
            internal int ID;
            internal string Code;
            internal string ProductName;
            internal string GenericName;
            internal int Subcategory;
            internal int Unit;
            internal decimal SellingPrice;
            internal decimal MarkUp;
            internal decimal Price;
            internal int ReOrderPoint;
            internal int Stocks;
            internal bool Vatable;
            internal bool Discountable;
        }
   //getProduct
        internal static List<Product> getProductsByCategory(int category, int subcategory)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            if (category != 0)
            {
                if (subcategory != 0)
                {
                    cmd.CommandText = "SELECT * FROM [products] WHERE [Subcategory] = @subcategory";
                    cmd.Parameters.AddWithValue("@subcategory", subcategory);
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM [products] JOIN [subcategories] ON [subcategories].[ID] = [products].[Subcategory] WHERE [subcategories].[Category] = @category";
                    cmd.Parameters.AddWithValue("@category", category);
                }
            }
            else
            {
                cmd.CommandText = "SELECT * FROM [products]";
            }

            List<Product> Products = new List<Product>();
            Product perProduct = new Product();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perProduct.ID = Convert.ToInt32(rdr["ID"]);
                        perProduct.Code = rdr["Code"].ToString();
                        perProduct.ProductName = rdr["ProductName"].ToString();
                        perProduct.GenericName = rdr["GenericName"].ToString();
                        perProduct.Subcategory = Convert.ToInt32(rdr["Subcategory"]);
                        perProduct.Unit = Convert.ToInt32(rdr["Unit"]);
                        perProduct.SellingPrice = Convert.ToDecimal(rdr["SellingPrice"]);
                        perProduct.MarkUp = Convert.ToDecimal(rdr["MarkUp"]);
                        perProduct.ReOrderPoint = Convert.ToInt32(rdr["ReOrderPoint"]);
                        perProduct.Price = Convert.ToDecimal(rdr["Price"]);
                        perProduct.Stocks = Convert.ToInt32(rdr["Stocks"]);
                        if (rdr["Discountable"].ToString().Equals("yes"))
                        {
                            perProduct.Discountable = true;
                        }
                        else
                        {
                            perProduct.Discountable = true;
                        }
                        if (rdr["Vatable"].ToString().Equals("yes"))
                        {
                            perProduct.Vatable = true;
                        }
                        else
                        {
                            perProduct.Vatable = true;
                        }
                        Products.Add(perProduct);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [PRODUCTSBYCATEGORY SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }

            return Products;
        }
   //end get Products by category

    //get products
        internal static List<Product> getProducts()
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [products]";

            List<Product> Products = new List<Product>();
            Product perProduct = new Product();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perProduct.ID = Convert.ToInt32(rdr["ID"]);
                        perProduct.Code = rdr["Code"].ToString();
                        perProduct.ProductName = rdr["ProductName"].ToString();
                        perProduct.GenericName = rdr["GenericName"].ToString();
                        perProduct.Subcategory = Convert.ToInt32(rdr["Subcategory"]);
                        perProduct.Unit = Convert.ToInt32(rdr["Unit"]);
                        perProduct.SellingPrice = Convert.ToDecimal(rdr["SellingPrice"]);
                        perProduct.MarkUp = Convert.ToDecimal(rdr["MarkUp"]);
                        perProduct.ReOrderPoint = Convert.ToInt32(rdr["ReOrderPoint"]);
                        perProduct.Price = Convert.ToDecimal(rdr["Price"]);
                        perProduct.Stocks = Convert.ToInt32(rdr["Stocks"]);
                        if (rdr["Discountable"].ToString().Equals("yes"))
                        {
                            perProduct.Discountable = true;
                        }
                        else
                        {
                            perProduct.Discountable = true;
                        }
                        if (rdr["Vatable"].ToString().Equals("yes"))
                        {
                            perProduct.Vatable = true;
                        }
                        else
                        {
                            perProduct.Vatable = true;
                        }
                        Products.Add(perProduct);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [PRODUCTS SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }

            return Products;
        }
        //end get Products

   //insert Product
        internal static bool insertProduct(Product perProduct)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [products] ([Code], [ProductName], [GenericName], [Subcategory], [Unit], [Price], [Vatable], [Discountable], [MarkUp], [ReOrderPoint], [Stocks], [SellingPrice]) VALUES (@code, @productname, @genericname, @subcategory, @unit, @price, @vatable, @discountable, @markup, @reorderpoint, @stocks, @sellingprice )";
            cmd.Parameters.AddWithValue("@code", perProduct.Code);
            cmd.Parameters.AddWithValue("@productname", perProduct.ProductName);
            cmd.Parameters.AddWithValue("@genericname", perProduct.GenericName);
            cmd.Parameters.AddWithValue("@subcategory", perProduct.Subcategory);
            cmd.Parameters.AddWithValue("@unit", perProduct.Unit);
            cmd.Parameters.AddWithValue("price", perProduct.Price);
            if (perProduct.Vatable)
            {
                cmd.Parameters.AddWithValue("@vatable", "yes");
            }
            else
            {
                cmd.Parameters.AddWithValue("@vatable", "no");
            }
            if (perProduct.Discountable)
            {
                cmd.Parameters.AddWithValue("@discountable", "yes");
            }
            else
            {
                cmd.Parameters.AddWithValue("@discountable", "no");
            }
            cmd.Parameters.AddWithValue("@markup", perProduct.MarkUp);
            cmd.Parameters.AddWithValue("@reorderpoint", perProduct.ReOrderPoint);
            cmd.Parameters.AddWithValue("@stocks", perProduct.Stocks);
            cmd.Parameters.AddWithValue("@sellingprice", perProduct.SellingPrice);

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [PRODUCTS INSERT] " + ex.Message);
                return false;
            }
        }
    //end insert Product

    //update Product
        internal static bool updateProduct(Product perProduct)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [products] SET [Code] = @code, [ProductName] = @productname, [GenericName] = @genericname, [Subcategory] = @subcategory, [Unit] = @unit, [Price] = @price, [Vatable] = @vatable, [Discountable] = @discountable, [MarkUp] = @markup, [ReOrderPoint] = @reorderpoint, [Stocks] = @stocks, [SellingPrice] = @sellingprice WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@id", perProduct.ID);
            cmd.Parameters.AddWithValue("@code", perProduct.Code);
            cmd.Parameters.AddWithValue("@productname", perProduct.ProductName);
            cmd.Parameters.AddWithValue("@genericname", perProduct.GenericName);
            cmd.Parameters.AddWithValue("@subcategory", perProduct.Subcategory);
            cmd.Parameters.AddWithValue("@unit", perProduct.Unit);
            cmd.Parameters.AddWithValue("@price", perProduct.Price);
            if (perProduct.Vatable)
            {
                cmd.Parameters.AddWithValue("@vatable", "yes");
            }
            else
            {
                cmd.Parameters.AddWithValue("@vatable", "no");
            }
            if (perProduct.Discountable)
            {
                cmd.Parameters.AddWithValue("@discountable", "yes");
            }
            else
            {
                cmd.Parameters.AddWithValue("@discountable", "no");
            }
            cmd.Parameters.AddWithValue("@markup", perProduct.MarkUp);
            cmd.Parameters.AddWithValue("@reorderpoint", perProduct.ReOrderPoint);
            cmd.Parameters.AddWithValue("@stocks", perProduct.Stocks);
            cmd.Parameters.AddWithValue("@sellingprice", perProduct.SellingPrice);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [PRODUCTS UPDATE] " + ex.Message);
                return false;
            }
        }
    //end update Product

    //delete Product
        internal static bool deleteProduct(Product perProduct)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM [products] WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@id", perProduct.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [PRODUCTS DELETE] " + ex.Message);
                return false;
            }
        }
//end Product


//Subcategory
        internal struct Subcategory
        {
            internal int ID;
            internal int Category;
            internal string Name;
            internal decimal MarkUp;
        }

   //get Subcategories
        internal static List<Subcategory> getSubcategories(Category Onecategory)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [subcategories] WHERE [Category] = @category";
            cmd.Parameters.AddWithValue("@category", Onecategory.ID);

            List<Subcategory> Subcategories = new List<Subcategory>();
            Subcategory perSubcategory = new Subcategory();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perSubcategory.ID = Convert.ToInt32(rdr["ID"]);
                        perSubcategory.Category = Convert.ToInt32(rdr["Category"]);
                        perSubcategory.Name = rdr["Name"].ToString();
                        perSubcategory.MarkUp = Convert.ToDecimal(rdr["MarkUp"]);
                        Subcategories.Add(perSubcategory);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [SUBCATEGORIES SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return Subcategories;
        }
    //end get Subcategories

    //insert Subcategory
        internal static bool insertSubcategory(Subcategory perSubcategory)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [subcategories] ([Name], [Category],[MarkUp]) VALUES (@name, @category, @markup)";
            cmd.Parameters.AddWithValue("@name", perSubcategory.Name);
            cmd.Parameters.AddWithValue("@category", perSubcategory.Category);
            cmd.Parameters.AddWithValue("@markup", perSubcategory.MarkUp);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [SUBCATEGORIES INSERT] " + ex.Message);
                return false;
            }
        }
    //end insert Subcategory

    //edit Subcategory
        internal static bool updateSubcategory(Subcategory perSubcategory)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [subcategories] SET [Name] = @name, [Category] = @category, [MarkUp] = @markup WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@name", perSubcategory.Name);
            cmd.Parameters.AddWithValue("@category", perSubcategory.Category);
            cmd.Parameters.AddWithValue("markup", perSubcategory.MarkUp);
            cmd.Parameters.AddWithValue("@id", perSubcategory.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [SUBCATEGORIES UPDATE] " + ex.Message);
                return false;
            }
        }
    //end edit Subcategory

    //delete Subcategory
        internal static bool deleteSubcategory(Subcategory perSubcategory)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM [subcategories] WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@id", perSubcategory.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [SUBCATEGORIES DELETE] " + ex.Message);
                return false;
            }
        }
    //end delete Subcategory
//end Subcategory


//Supplier
        internal struct Supplier
        {
            internal int ID;
            internal string Code;
            internal string Name;
            internal string TelNum;
            internal string FaxNum;
            internal string CPerson;
            internal string CNumber;
            internal string Address;
        }
    //get Supplier
        internal static List<Supplier> getSupplier()
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [suppliers]";

            List<Supplier> Suppliers = new List<Supplier>();
            Supplier perSupplier = new Supplier();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perSupplier.ID = Convert.ToInt32(rdr["ID"]);
                        perSupplier.Code = rdr["Code"].ToString();
                        perSupplier.Name = rdr["Name"].ToString();
                        perSupplier.TelNum = rdr["TelNumber"].ToString();
                        perSupplier.FaxNum = rdr["FaxNumber"].ToString();
                        perSupplier.CPerson = rdr["ContactPerson"].ToString();
                        perSupplier.CNumber = rdr["CPNumber"].ToString();
                        perSupplier.Address = rdr["Address"].ToString();
                        Suppliers.Add(perSupplier);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [SUPPLIERS SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return Suppliers;
        }
    //end get Supplier
        internal static List<Supplier> getSuppliersByProduct(Product perProduct)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [suppliers] JOIN [suppliersproducts] ON [suppliers].[ID] = [suppliersproducts].[Supplier] WHERE [suppliersproducts].[Product] = @product";
            cmd.Parameters.AddWithValue("@product", perProduct.ID);

            List<Supplier> Suppliers = new List<Supplier>();
            Supplier perSupplier = new Supplier();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perSupplier.ID = Convert.ToInt32(rdr["ID"]);
                        perSupplier.Code = rdr["Code"].ToString();
                        perSupplier.Name = rdr["Name"].ToString();
                        perSupplier.TelNum = rdr["TelNumber"].ToString();
                        perSupplier.FaxNum = rdr["FaxNumber"].ToString();
                        perSupplier.CPerson = rdr["ContactPerson"].ToString();
                        perSupplier.CNumber = rdr["CPNumber"].ToString();
                        perSupplier.Address = rdr["Address"].ToString();
                        Suppliers.Add(perSupplier);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [SUPPLIERSBYPRODUCT SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return Suppliers;
        }
    //insert Supplier
        internal static bool insertSupplier(Supplier perSupplier)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [suppliers] ([Name], [Code], [Address], [ContactPerson], [CPNumber], [TelNumber], [FaxNumber]) VALUES (@name, @code, @address, @contactperson, @cpnumber, @telnumber, @faxnumber)";
            cmd.Parameters.AddWithValue("@name", perSupplier.Name);
            cmd.Parameters.AddWithValue("@code", perSupplier.Code);
            cmd.Parameters.AddWithValue("@address", perSupplier.Address);
            cmd.Parameters.AddWithValue("@contactperson", perSupplier.CPerson);
            cmd.Parameters.AddWithValue("@cpnumber", perSupplier.CNumber);
            cmd.Parameters.AddWithValue("@telnumber", perSupplier.TelNum);
            cmd.Parameters.AddWithValue("@faxnumber", perSupplier.FaxNum);

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [SUPPLIERS INSERT] " + ex.Message);
                return false;
            }
        }
    //end insert Supplier

    //update Supplier
        internal static bool updateSupplier(Supplier perSupplier)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [suppliers] SET [Name] = @name, [Code] = @code, [Address] = @address, [ContactPerson] = @contactperson, [CPNumber] = @cpnumber, [TelNumber] = @telnumber, [FaxNumber] = @faxnumber WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@name", perSupplier.Name);
            cmd.Parameters.AddWithValue("@code", perSupplier.Code);
            cmd.Parameters.AddWithValue("@address", perSupplier.Address);
            cmd.Parameters.AddWithValue("@contactperson", perSupplier.CPerson);
            cmd.Parameters.AddWithValue("@cpnumber", perSupplier.CNumber);
            cmd.Parameters.AddWithValue("@telnumber", perSupplier.TelNum);
            cmd.Parameters.AddWithValue("@faxnumber", perSupplier.FaxNum);
            cmd.Parameters.AddWithValue("@id", perSupplier.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [SUPPLIERS UPDATE] " + ex.Message);
                return false;
            }
        }
    //end update Supplier

    //delete Supplier
        internal static bool deleteSupplier(Supplier perSupplier)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM [suppliers] WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@id", perSupplier.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [SUPPLIERS DELETE] " + ex.Message);
                return false;
            }
        }
    //delete Supplier
//end Supplier


//Expiry
        internal struct Expiration
        {
            internal int ID;
            internal int Product;
            internal string BatchNumber;
            internal DateTime Date;
        }
    //getExpiry
        internal static List<Expiration> getExpirations()
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [expiry]";

            List<Expiration> Expirations = new List<Expiration>();
            Expiration perExpiration = new Expiration();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perExpiration.ID = Convert.ToInt32(rdr["ID"]);
                        perExpiration.Product = Convert.ToInt32(rdr["Product"]);
                        perExpiration.BatchNumber = rdr["BatchNumber"].ToString();
                        perExpiration.Date = Convert.ToDateTime(rdr["ExpirationDate"]);
                        Expirations.Add(perExpiration);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [EXPIRY SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return Expirations;
        }
    //end getExpiry

   //insert Expiry
        internal static bool insertExpiry(Expiration perExpiration)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [expiry] ([Product], [BatchNumber], [ExpirationDate]) VALUES (@product, @batchnumber, @expirydate)";
            cmd.Parameters.AddWithValue("@product", perExpiration.Product);
            cmd.Parameters.AddWithValue("@batchnumber", perExpiration.BatchNumber);
            cmd.Parameters.AddWithValue("@expirydate", perExpiration.Date);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [EXPIRY INSERT] " + ex.Message);
                return false;
            }

        }

    //update Expiry
        internal static bool updateExpiry(Expiration perExpiration)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [expiry] SET [Products] = @products, [BatchNumber] = @batchnumber, [ExpirationDate] = @expirationdate";
            cmd.Parameters.AddWithValue("@products", perExpiration.Product);
            cmd.Parameters.AddWithValue("@batchnumber", perExpiration.BatchNumber);
            cmd.Parameters.AddWithValue("@expirationdate", perExpiration.Date);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [EXPIRY UPDATE] " + ex.Message);
                return false;
            }
        }
    //end update Expiry
       
    //delete Expiry

        internal static bool deleteExpiry(Expiration perExpiration)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM [expiry] WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@id", perExpiration.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [EXPIRY DELETE] " + ex.Message);
                return false;
            }
        }
    //end delete Expiry

    
//end Expiry


//Units
        internal struct Unit
        {
            internal int ID;
            internal string Name;
        }

     //getUnit
        internal static List<Unit> getUnits()
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [units]";

            List<Unit> Units = new List<Unit>();
            Unit perUnit = new Unit();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perUnit.ID = Convert.ToInt32(rdr["ID"]);
                        perUnit.Name = rdr["Name"].ToString();
                        Units.Add(perUnit);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [UNITS SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return Units;
        }
    // end get Unit

    //insert Unit
        internal static bool insertUnit(Unit perUnit)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [units] ([Name]) VALUES (@name)";
            cmd.Parameters.AddWithValue("@name", perUnit.Name);

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [UNITS INSERT] " + ex.Message);
                return false;
            }

        }
    //end insert Unit

    //update Unit
        internal static bool updateUnit(Unit perUnit)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [units] SET [Name] = @name WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@name", perUnit.Name);
            cmd.Parameters.AddWithValue("@ID", perUnit.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [UNITS UPDATE] " + ex.Message);
                return false;
            }
        }
    //end update Unit

    //delete Unit
        internal static bool deleteUnit(Unit perUnit)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM [units] WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@id", perUnit.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [UNITS DELETE] " + ex.Message);
                return false;
            }
        }
    //end delete Unit


//VAT
    //get VAT
        internal static decimal getVAT()
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [vat]";

            decimal vat = new decimal();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        vat = Convert.ToDecimal(rdr["Value"]);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [VAT SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return vat;
        }
    //end get Vat

    //update VAT
        internal static bool updateVAT(decimal vat)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [vat] set [Value] = @value";
            cmd.Parameters.AddWithValue("@value", vat);

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [VAT UPDATE] " + ex.Message);
                return false;
            }
        }
    //end update VAT
//end VAT

//Receipt Number

        internal struct ReceiptNumber
        {
            internal int ID;
            internal string Start;
            internal string End;
        }

        internal static ReceiptNumber getReceiptNumber()
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [receiptnumber]";

            ReceiptNumber perReceiptNumber = new ReceiptNumber();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perReceiptNumber.ID = Convert.ToInt32(rdr["ID"]);
                        perReceiptNumber.Start = rdr["Start"].ToString();
                        perReceiptNumber.End = rdr["End"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [RECEIPTNUMBER SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return perReceiptNumber;

        }

        //update receipt#
        internal static bool updateReceiptNumber(ReceiptNumber perReceiptNumber)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [receiptnumber] set [Start] = @start, [End] = @end";
            cmd.Parameters.AddWithValue("@start", perReceiptNumber.Start);
            cmd.Parameters.AddWithValue("@end", perReceiptNumber.End);

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [RECEIPTNUMBER UPDATE] " + ex.Message);
                return false;
            }
        }
        //end update receipt#
//end receipt number
//Purchase
        internal struct Purchase
        {
            internal int ID;
            internal String Code;
            internal DateTime Date;
            internal int Supplier;
            internal int Product;
            internal int Quantity;
        }
      
        internal static List<Purchase> getPurchase()
        {
            
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [purchase]";

            List<Purchase> Purchases = new List<Purchase>();
            Purchase perPurchase = new Purchase();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perPurchase.ID = Convert.ToInt32(rdr["ID"]);
                        perPurchase.Code = rdr["Code"].ToString();
                        perPurchase.Date = Convert.ToDateTime(rdr["DateTime"]);
                        perPurchase.Supplier = Convert.ToInt32(rdr["Supplier"]);
                        perPurchase.Product = Convert.ToInt32(rdr["Product"]);
                        perPurchase.Quantity = Convert.ToInt32(rdr["Quantity"]);
                        Purchases.Add(perPurchase);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [PURCHASE SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return Purchases;
        }
    //insert Purchase
        internal static bool insertPurchase(Purchase perPurchase)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [purchase] ([Code], [DateTime], [Supplier], [Product], [Quantity]) VALUES (@code, @date, @supplier, @product, @quantity)";
            cmd.Parameters.AddWithValue("@code", perPurchase.Code);
            cmd.Parameters.AddWithValue("@date", perPurchase.Date.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@supplier", perPurchase.Supplier);
            cmd.Parameters.AddWithValue("@product", perPurchase.Product);
            cmd.Parameters.AddWithValue("@quantity", perPurchase.Quantity);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [PURCHASE INSERT] " + ex.Message);
                return false;
            }
        }
        internal static bool deletePurchase(Purchase perPurchase)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM [purchase] WHERE [Code] = @code";
            cmd.Parameters.AddWithValue("@code", perPurchase.Code);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [PURCHASE DELETE] " + ex.Message);
                return false;
            }
        }
//end Purchase

        //Receive
        internal struct Receive
        {
            internal int ID;
            internal string PurchaseCode;
            internal DateTime Date;
            internal int Product;
            internal int Quantity;
            internal decimal Price;
        }

        internal static List<Receive> getReceive()
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [receive]";

            List<Receive> Receives = new List<Receive>();
            Receive perReceive = new Receive();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perReceive.ID = Convert.ToInt32(rdr["ID"]);
                        perReceive.PurchaseCode = rdr["PurchaseCode"].ToString();
                        perReceive.Date = Convert.ToDateTime(rdr["DateTime"]);
                        perReceive.Product = Convert.ToInt32(rdr["Product"]);
                        perReceive.Quantity = Convert.ToInt32(rdr["Quantity"]);
                        perReceive.Price = Convert.ToDecimal(rdr["Price"]);
                        Receives.Add(perReceive);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [RECEIVE SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return Receives;
        }
        //insert Receive
        internal static bool insertReceive(Receive perReceive)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [receive] ([PurchaseCode], [DateTime], [Product], [Quantity], [Price]) VALUES (@purchase, @date, @product, @quantity, @price)";
            cmd.Parameters.AddWithValue("@purchase", perReceive.PurchaseCode);
            cmd.Parameters.AddWithValue("@date", perReceive.Date.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@product", perReceive.Product);
            cmd.Parameters.AddWithValue("@quantity", perReceive.Quantity);
            cmd.Parameters.AddWithValue("@price", perReceive.Price);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [RECEIVE INSERT] " + ex.Message);
                return false;
            }
        }
        internal static bool deleteReceive(Receive perReceive)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM [receive] WHERE [PurchaseCode] = @code";
            cmd.Parameters.AddWithValue("@code", perReceive.PurchaseCode);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [RECEIVE DELETE] " + ex.Message);
                return false;
            }
        }
        //end Receive

        internal static List<Product> getProductsBySupplier(Supplier supplier)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [products] JOIN [suppliersproducts] ON [products].[ID] = [suppliersproducts].[Product] WHERE [suppliersproducts].[Supplier] = @supplier";
            cmd.Parameters.AddWithValue("@supplier", supplier.ID);

            List<Product> Products = new List<Product>();
            Product perProduct = new Product();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perProduct.ID = Convert.ToInt32(rdr["ID"]);
                        perProduct.Code = rdr["Code"].ToString();
                        perProduct.ProductName = rdr["ProductName"].ToString();
                        perProduct.GenericName = rdr["GenericName"].ToString();
                        perProduct.Subcategory = Convert.ToInt32(rdr["Subcategory"]);
                        perProduct.Unit = Convert.ToInt32(rdr["Unit"]);
                        perProduct.SellingPrice = Convert.ToDecimal(rdr["SellingPrice"]);
                        perProduct.MarkUp = Convert.ToDecimal(rdr["MarkUp"]);
                        perProduct.ReOrderPoint = Convert.ToInt32(rdr["ReOrderPoint"]);
                        perProduct.Price = Convert.ToDecimal(rdr["Price"]);
                        perProduct.Stocks = Convert.ToInt32(rdr["Stocks"]);
                        if (rdr["Discountable"].ToString().Equals("yes"))
                        {
                            perProduct.Discountable = true;
                        }
                        else
                        {
                            perProduct.Discountable = true;
                        }
                        if (rdr["Vatable"].ToString().Equals("yes"))
                        {
                            perProduct.Vatable = true;
                        }
                        else
                        {
                            perProduct.Vatable = true;
                        }
                        Products.Add(perProduct);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [PRODUCTSBYSUPPLIER SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return Products;
        }
        internal static bool insertSuppliersProducts(Supplier perSupplier, Product perProduct)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [suppliersproducts] ([Supplier], [Product]) VALUES (@supplier, @product)";
            cmd.Parameters.AddWithValue("@supplier", perSupplier.ID);
            cmd.Parameters.AddWithValue("@product", perProduct.ID);

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [SUPPLIERSPRODUCTS INSERT] " + ex.Message);
                return false;
            }
        }
        internal static bool deleteSupplierProducts(Supplier perSupplier)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM [suppliersproducts] WHERE [Supplier] = @supplier";
            cmd.Parameters.AddWithValue("@supplier", perSupplier.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [SUPPLIERSPRODUCTS DELETE] " + ex.Message);
                return false;
            }
        }

//receipts
        internal struct Receipt
        {
            internal int ID;
            internal string ReceiptNumber;
            internal DateTime DateTime;
            internal int Cashier;
            internal int Discount;
            internal decimal TotalDue;
        }
        internal static List<Receipt> getReceipts() 
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [receipts]";

            List<Receipt> Receipts = new List<Receipt>();
            Receipt perReceipt = new Receipt();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perReceipt.ID = Convert.ToInt32(rdr["ID"]);
                        perReceipt.ReceiptNumber = rdr["ReceiptNumber"].ToString();
                        perReceipt.DateTime = Convert.ToDateTime(rdr["DateTime"]);
                        perReceipt.Cashier = Convert.ToInt32(rdr["Cashier"]);
                        if (!rdr["Discount"].Equals(DBNull.Value))
                        {
                            perReceipt.Discount = Convert.ToInt32(rdr["Discount"]);
                        }
                        perReceipt.TotalDue = Convert.ToDecimal(rdr["TotalDue"]);
                        Receipts.Add(perReceipt);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [RECEIPTS SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return Receipts;
        }
        internal static bool insertReceipt(Receipt perReceipt)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            if (perReceipt.Discount != 0)
            {
                cmd.CommandText = "INSERT INTO [receipts] ([ReceiptNumber], [DateTime], [Cashier], [Discount], [TotalDue]) VALUES (@receiptnumber, @datetime, @cashier, @discount, @totaldue)";
                cmd.Parameters.AddWithValue("@discount", perReceipt.Discount);
            }
            else
            {
                cmd.CommandText = "INSERT INTO [receipts] ([ReceiptNumber], [DateTime], [Cashier], [TotalDue]) VALUES (@receiptnumber, @datetime, @cashier, @totaldue)";
            }
            cmd.Parameters.AddWithValue("@receiptnumber", perReceipt.ReceiptNumber);
            cmd.Parameters.AddWithValue("@datetime", perReceipt.DateTime.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@cashier", perReceipt.Cashier);
            cmd.Parameters.AddWithValue("@totaldue", perReceipt.TotalDue);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [RECEIPTS INSERT] " + ex.Message);
                return false;
            }
        }
        internal static bool deleteReceipt(Receipt perReceipt)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM [receipts] WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@id", perReceipt.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [RECEIPTS DELETE] " + ex.Message);
                return false;
            }
        }
//end receipts

//transactionreceipts
        internal struct TransactionReceipt
        {
            internal int ID;
            internal int Receipt;
            internal int Product;
            internal int Quantity;
        }
        internal static List<TransactionReceipt> getTransactionReceipts()
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [transactionreceipts]";

            List<TransactionReceipt> TransactionReceipts = new List<TransactionReceipt>();
            TransactionReceipt perTransactionReceipt = new TransactionReceipt();

            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        perTransactionReceipt.ID = Convert.ToInt32(rdr["ID"]);
                        perTransactionReceipt.Receipt = Convert.ToInt32(rdr["Receipt"]);
                        perTransactionReceipt.Product = Convert.ToInt32(rdr["Product"]);
                        perTransactionReceipt.Quantity = Convert.ToInt32(rdr["Quantity"]);
                        TransactionReceipts.Add(perTransactionReceipt);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [TRANSACTIONRECEIPTS SELECT] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return TransactionReceipts;
        }
        internal static bool insertTransactionReceipt(TransactionReceipt perTransactionReceipt)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [transactionreceipts] ([Receipt], [Product], [Quantity]) VALUES (@receipt, @product, @quantity)";
            cmd.Parameters.AddWithValue("@receipt", perTransactionReceipt.Receipt);
            cmd.Parameters.AddWithValue("@product", perTransactionReceipt.Product);
            cmd.Parameters.AddWithValue("@quantity", perTransactionReceipt.Quantity);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [TRANSACTIONRECEIPTS INSERT] " + ex.Message);
                return false;
            }
        }
//end transactionreceipts

        //inventory update
        internal static bool updateStock(Product perProduct)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [products] SET [Stocks] = @stocks WHERE [ID] = @id";
            cmd.Parameters.AddWithValue("@stocks", perProduct.Stocks);
            cmd.Parameters.AddWithValue("@id", perProduct.ID);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [TRANSACTIONRECEIPTS INSERT] " + ex.Message);
                return false;
            }
        }

//getMax
        internal static int getMax(String table)
        {
            int max = 0;
            cmd = new MySqlCommand();
            cmd.Connection = con;
            switch (table)
            {
                case "purchase":
                    cmd.CommandText = "SELECT MAX([Code]) FROM [purchase]";
                    break;
                case "receipts":
                    cmd.CommandText = "SELECT MAX([ReceiptNumber]) FROM [receipts]";
                    break;
                case "suppliers":
                    cmd.CommandText = "SELECT MAX([Code]) FROM [suppliers]";
                    break;
                default:
                    break;
            }
            try
            {
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                            max = Convert.ToInt32(rdr[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now.ToString() + " [GETMAX " + table + "] " + ex.Message);
            }
            finally
            {
                rdr.Close();
            }
            return max;            
        }
//end getMax
    }

}