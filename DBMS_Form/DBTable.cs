using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Form
{
    public class DBTable
    {
        public string name;
        public List<DBField> fields;
        public List<DBRow> rows;

        public DBTable()
        {
            name = "Nice-Table";
            fields = new List<DBField>();
            rows = new List<DBRow>();
        }

        public DBTable(string tableName)
        {
            name = tableName;
            fields = new List<DBField>();
            rows = new List<DBRow>();
        }

        /// <summary>
        /// Returns true if the contents of two tables are the same
        /// ! even if the names of two tables differ !
        /// </summary>
        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                DBTable other = (DBTable)obj;
                var rfields = other.GetFields();
                var rrows = other.GetRows();
                // Check for equal table size
                if (fields.Count != rfields.Count ||
                    rows.Count != rrows.Count)
                    return false;
                // Check for same fields and rows
                for (int i = 0; i < fields.Count; i++)
                    if (!fields[i].Equals(rfields[i]))
                        return false;
                for (int i = 0; i < rows.Count; i++)
                    if (!rows[i].Equals(rrows[i]))
                        return false;
                // All checks passed, tables are equal
                return true;
            }
        }

        public void AddField(string fname, string ftype)
        {
            fields.Add(new DBField(fname, ftype));
        }

        public void AddField(DBField field)
        {
            fields.Add(field);
        }

        /// <summary>
        /// Prompts user to enter all elements to form a DBRow. Returns this DBRow
        /// </summary>
        public DBRow InputRow()
        {
            DBRow new_row = new DBRow();
            foreach (DBField field in fields)
            {
                new_row.InputElement(field);
            }
            return new_row;
        }

        public void AddRow(DBRow row)
        {
            rows.Add(row);
        }

        public void ReplaceRow(DBRow row, int index)
        {
            rows[index] = row;
        }

        public void DeleteRow(int index)
        {
            rows.RemoveAt(index);
        }

        public void DeleteField(int index)
        {
            fields.RemoveAt(index);
        }

        public List<DBField> GetFields()
        {
            return fields;
        }

        public List<DBRow> GetRows()
        {
            return rows;
        }

        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Returns table description in the following format
        /// "Name: (field1: type, field2:type)"
        /// </summary>
        public string GetDescription()
        {
            List<string> flist = GetFieldListWithTypes();
            return name + ": (" + string.Join(", ", flist) + ")";
        }

        public List<string> GetFieldListWithTypes()
        {
            List<string> flist = new List<string>();
            foreach (DBField field in fields)
            {
                flist.Add(field.GetDescription());
            }
            return flist;
        }

        public List<string> GetFieldList()
        {
            List<string> flist = new List<string>();
            foreach (DBField field in fields)
            {
                flist.Add(field.GetName());
            }
            return flist;
        }

        /// <summary>
        /// Gets string representation of a table, to be shown in DataGridViews
        /// </summary>
        public List<List<string>> GetTextRepresentation()
        {
            List<List<string>> representation = new List<List<string>>();
            foreach (DBRow row in rows)
            {
                List<string> repr_row = row.GetTextRepresentation();
                representation.Add(repr_row);
            }
            return representation;
        }

        public void Serialize()
        {
            foreach (DBRow row in rows)
                row.Serialize();
        }

        public void Deserialize()
        {
            foreach (DBRow row in rows)
                row.Deserialize(fields);
        }

        public DBTable Search(string value, string typeName)
        {
            DBTable resultTable = new DBTable();
            // Add same fields (Warning: no copy constructor!)
            resultTable.fields = fields;
            foreach (DBRow row in rows)
            {
                bool found = false;
                for (int i = 0; i < fields.Count; i++)
                    // check if any field of a proper type includes value
                    if (fields[i].GetTypeName().Equals(typeName))
                        if (row.GetElement(i).ToString().IndexOf(value) != -1)
                        {
                            found = true;
                            break;
                        }
                if (found)
                    resultTable.AddRow(row);
            }
            return resultTable;
        }
    
    }
}
