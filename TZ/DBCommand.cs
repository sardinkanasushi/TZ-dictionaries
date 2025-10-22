using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using System.Data.Entity.Core.Objects;
using System.Data;
using System.Collections;

namespace TZ
{
    internal class DBCommand : DbContext
    {
        private static string dBSource;
        public delegate void SimpleEvent(string source);
        private static event SimpleEvent SourceChanged;
        private static bool CreateDictionaryTable()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={dBSource};Version=3;"))
                {
                    connection.Open();
                    using (SQLiteCommand commandCreate = new SQLiteCommand("CREATE TABLE DICT (" +
                        "DICT_ID INTEGER PRIMARY KEY NOT NULL UNIQUE, " +
                        "PARENT_ID INTEGER, " +
                        "NAME TEXT (255)  NOT NULL, " +
                        "CODE TEXT (255)  NOT NULL, " +
                        "DESCRIPTION TEXT (255)  NOT NULL);", connection))
                    {
                        commandCreate.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception) { Console.WriteLine("dictionary creating eror"); }
            return false;
        }
        private static bool CreateItemTable()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={dBSource};Version=3;"))
                {
                    connection.Open();
                    using (SQLiteCommand commandCreate = new SQLiteCommand("CREATE TABLE DICT_ITEM (" +
                        "ITEM_ID INTEGER PRIMARY KEY NOT NULL UNIQUE, " +
                        "DICT_ID INTEGER REFERENCES DICT (DICT_ID) NOT NULL," +
                        "CODE TEXT (255) NOT NULL," +
                        "NAME TEXT (255) NOT NULL);", connection))
                    {
                        commandCreate.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception) { Console.WriteLine("item creating eror"); }
            return false;
        }
        public static void SelectDBFile(string source)
        {
            dBSource = source;
            SourceChanged.Invoke(dBSource);
        }
        public static bool CreateDBFile(string directory)
        {
            try
            {
                using (File.Create(directory+= @".sqlite"))
                {
                    SelectDBFile(directory);
                }
                CreateDictionaryTable();
                CreateItemTable();
                return true;
            }
            catch(Exception) { Console.WriteLine("file creating eror"); }
            return false;
        }
        public static List<Dictionary> GetDictionaries()
        {
            try
            {
                List<Dictionary> tempDictionaries = new List<Dictionary>();
                using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={dBSource};Version=3;"))
                {
                    connection.Open();
                    using (SQLiteCommand commandSelect = new SQLiteCommand("SELECT DICT_ID, PARENT_ID, NAME, CODE, DESCRIPTION FROM DICT;", connection))
                    {
                        using (SQLiteDataReader reader = commandSelect.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Dictionary tempDictionary = new Dictionary();
                                int? tempParantId = null;
                                if (int.TryParse(reader.GetValue(1).ToString(), out int value)) tempParantId = value;
                                tempDictionaries.Add(new Dictionary()
                                {
                                    Id = reader.GetInt32(0),
                                    ParantId = tempParantId,
                                    Name = reader.GetString(2),
                                    Code = reader.GetString(3),
                                    Description = reader.GetValue(4).ToString()
                                });
                            }
                            reader.Close();
                        }
                    }
                    connection.Close();
                }
                return tempDictionaries;
            }
            catch (Exception ex) { Console.WriteLine("reading eror " + ex); }
            return null;
        }
        public static List<Item> GetItems(int? dictionaryId)
        {
            try
            {
                List<Item> tempItems = new List<Item>();
                using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={dBSource};Version=3;"))
                {
                    connection.Open();
                    string request;
                    if (dictionaryId == null) request = $"SELECT * FROM DICT_ITEM;";
                    else request = $"SELECT * FROM DICT_ITEM WHERE DICT_ID = {dictionaryId};";

                    using (SQLiteCommand commandSelect = new SQLiteCommand(request, connection))
                    {
                        using (SQLiteDataReader reader = commandSelect.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tempItems.Add(new Item()
                                {
                                    Id = reader.GetInt32(0),
                                    DictionaryId = reader.GetInt32(1),
                                    Code = reader.GetString(2),
                                    Name = reader.GetString(3),
                                });
                            }
                            reader.Close();
                        }
                    }
                    connection.Close();
                }
                return tempItems;
            }
            catch (Exception ex) { Console.WriteLine("reading eror " + ex); }
            return null;
        }
        public static bool AddDictionary(Dictionary dictionary)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={dBSource};Version=3;"))
                {
                    connection.Open();

                    string dictionaryParentId = "NULL";
                    if (dictionary.ParantId != null) dictionaryParentId = dictionary.ParantId.ToString();

                    string request = $"INSERT INTO DICT (PARENT_ID, NAME, CODE, DESCRIPTION) values (" +
                              $@"{dictionaryParentId},@name, @code, @description)";

                    using (SQLiteCommand commandAdd = new SQLiteCommand(request, connection))
                    {
                        commandAdd.Parameters.Add("@name", DbType.String, 255);
                        commandAdd.Parameters.Add("@code", DbType.String, 255);
                        commandAdd.Parameters.Add("@description", DbType.String, 2000);

                        commandAdd.Parameters["@name"].Value = dictionary.Name;
                        commandAdd.Parameters["@code"].Value = dictionary.Code;
                        commandAdd.Parameters["@description"].Value = dictionary.Description;

                        commandAdd.ExecuteNonQuery();
                        Console.WriteLine("добавлено успешно");
                    }
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine("reading eror " + ex); }
            return false;
        }
        public static bool DeleteDictionary(List<Dictionary> dictionaryToDelete)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={dBSource};Version=3;"))
                {
                    connection.Open();
                    foreach (Dictionary dictionary in dictionaryToDelete)
                    {
                        using (SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM DICT_ITEM WHERE DICT_ID = {dictionary.Id}", connection))
                        {
                            commandDelete.ExecuteNonQuery();
                            Console.WriteLine("items удалено успешно");
                        }
                        using (SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM DICT WHERE DICT_ID = {dictionary.Id}", connection))
                        {
                            commandDelete.ExecuteNonQuery();
                            Console.WriteLine("dictionary удалено успешно");
                        }
                    }
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine("reading eror " + ex); }
            return false;
        }
        public static bool UpdateDictionary(Dictionary dictionary)
        {
           try
            {
                using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={dBSource};Version=3;"))
                {
                    string parentID = "NULL";
                    if(dictionary.ParantId != null) parentID = dictionary.ParantId.ToString();

                    Console.WriteLine("data sourse is correct");
                    connection.Open();
                    string request = $"UPDATE DICT SET " +
                        $"PARENT_ID = {parentID}, " +
                        $@"NAME = @name, " +
                        $@"CODE = @code, " +
                        $@"DESCRIPTION = @description " +
                        $"WHERE DICT_ID = {dictionary.Id};";
                    using (SQLiteCommand commandAdd = new SQLiteCommand(request, connection))
                    {
                        commandAdd.Parameters.Add("@name", DbType.String, 255);
                        commandAdd.Parameters.Add("@code", DbType.String, 255);
                        commandAdd.Parameters.Add("@description", DbType.String, 2000);

                        commandAdd.Parameters["@name"].Value = dictionary.Name;
                        commandAdd.Parameters["@code"].Value = dictionary.Code;
                        commandAdd.Parameters["@description"].Value = dictionary.Description;
                        
                        commandAdd.ExecuteNonQuery();
                        Console.WriteLine("изменено успешно");
                    }
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine("reading eror " + ex); }
            return false;
        }
        public static bool UpdateItem(Item item)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={dBSource};Version=3;"))
                {
                    connection.Open();
                    string request = $"UPDATE DICT_ITEM SET " +
                        $@"DICT_ID = {item.DictionaryId}, " +
                        $@"NAME = @name, " +
                        $@"CODE = @code " +
                        $"WHERE ITEM_ID = {item.Id};";
                    using (SQLiteCommand commandAdd = new SQLiteCommand(request, connection))
                    {
                        commandAdd.Parameters.Add("@name", DbType.String, 255);
                        commandAdd.Parameters.Add("@code", DbType.String, 255);

                        commandAdd.Parameters["@name"].Value = item.Name;
                        commandAdd.Parameters["@code"].Value = item.Code;

                        commandAdd.ExecuteNonQuery();
                        Console.WriteLine("изменено успешно");
                    }
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine("reading eror " + ex); }
            return false;
        }
        public static bool AddItem(Item item)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={dBSource};Version=3;"))
                {
                    connection.Open();

                    string request = $"INSERT INTO DICT_ITEM (DICT_ID, CODE, NAME) values (" +
                              $@"{item.DictionaryId}, " +
                              $@"@code, " +
                              $@"@name)";
                    using (SQLiteCommand commandAdd = new SQLiteCommand(request, connection))
                    {
                        commandAdd.Parameters.Add("@name", DbType.String, 255);
                        commandAdd.Parameters.Add("@code", DbType.String, 255);

                        commandAdd.Parameters["@name"].Value = item.Name;
                        commandAdd.Parameters["@code"].Value = item.Code;

                        commandAdd.ExecuteNonQuery();
                        Console.WriteLine("добавлено успешно");
                    }
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine("reading eror " + ex); }
            return false;
        }
        public static bool DeleteItem(List<Item> itemsToDelete)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={dBSource};Version=3;"))
                {
                    connection.Open();
                    foreach (Item item in itemsToDelete)
                    {
                        using (SQLiteCommand command = new SQLiteCommand($"DELETE FROM DICT_ITEM WHERE ITEM_ID = {item.Id}", connection))
                        {
                            command.ExecuteNonQuery();
                            Console.WriteLine("удалено успешно");
                        }
                    }
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine("reading eror " + ex); }
            return false;
        }
        public static void AddListnerSourceChanged(SimpleEvent listner)
        {
            SourceChanged += listner;
        }
        public static void RemoveListnerSourceChanged(SimpleEvent listner)
        {
            SourceChanged -= listner;
        }
        public static List<Dictionary> CascadeDeleteDictionariesPrediction(List<Dictionary> dictionariesToDelete)
        {
            List<Dictionary> allDictionaries = GetDictionaries();
            List<Dictionary> childDictionariseToDelete = new List<Dictionary>();
            foreach (Dictionary dictionary in dictionariesToDelete)
            {
                FindChild(dictionary, allDictionaries, dictionary.Id.Value, childDictionariseToDelete);
            }
            return childDictionariseToDelete;
        }
        private static void FindChild(Dictionary parentDictionary, List<Dictionary> allDictionaries, int baseId, List<Dictionary> childDictionariseToDelete)
        {
            childDictionariseToDelete.Add(parentDictionary);
            foreach (Dictionary dictionary in allDictionaries)
            {
                if (dictionary.ParantId == parentDictionary.Id && dictionary.Id != baseId)
                {
                    FindChild(dictionary, allDictionaries, baseId, childDictionariseToDelete);
                    break;
                }
            }
            
        }
    }
}
