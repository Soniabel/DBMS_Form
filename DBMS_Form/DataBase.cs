using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Form
{
    public class DataBase
    {
        public string name;
        public string saveFilename;
        public List<DBTable> tables;

        public DataBase()
        {
            name = "Nice-Database";
            saveFilename = null;
            tables = new List<DBTable>();
        }

        public DataBase(string dbName)
        {
            name = dbName;
            saveFilename = null;
            tables = new List<DBTable>();
        }

        public string GetName()
        {
            return name;
        }

        public string GetSaveFilename()
        {
            return saveFilename;
        }

        public void AddTable(DBTable table)
        {
            tables.Add(table);
        }

        public DBTable GetTable(int index)
        {
            return tables.ElementAt(index);
        }

        public void DeleteTable(int index)
        {
            tables.RemoveAt(index);
        }

        /// <summary>
        /// Get list of table descriptions
        /// </summary>
        public List<string> GetTableDescList()
        {
            List<string> tlist = new List<string>();
            foreach (DBTable table in tables)
            {
                tlist.Add(table.GetDescription());
            }
            return tlist;
        }

        public void SaveToJSON(string path)
        {
            saveFilename = path;
            Serialize();
            var serializer = new JavaScriptSerializer();
            string serializedResult = serializer.Serialize(this);
            System.IO.File.WriteAllText(path, serializedResult);
        }

        public void LoadFromJSON(string path)
        {
            string serializedDB = System.IO.File.ReadAllText(path);
            var serializer = new JavaScriptSerializer();
            // Load file DB into a new object
            DataBase file_DB = serializer.Deserialize<DataBase>(serializedDB);
            name = file_DB.GetName();
            saveFilename = path;
            // Copy the new DB's tables
            tables = file_DB.DeserializeTables();
        }

        private void Serialize()
        {
            foreach (DBTable table in tables)
                table.Serialize();
        }

        private List<DBTable> DeserializeTables()
        {
            foreach (DBTable table in tables)
                table.Deserialize();
            return tables;
        }
    }
}
