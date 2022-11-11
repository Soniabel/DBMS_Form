using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Form
{
    public class DBField
    {
        public string name;
        public string typeName;

        public DBField()
        {
            name = "Field-Name";
            typeName = "Undefined Type";
        }

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                DBField other = (DBField)obj;
                return name.Equals(other.GetName()) && typeName.Equals(other.GetTypeName());
            }
        }

        public DBField(string _name, string _typeName)
        {
            name = _name;
            typeName = _typeName;
        }

        public string GetName()
        {
            return name;
        }

        public string GetTypeName()
        {
            return typeName;
        }

        /// <summary>
        /// Returns field description in the form of "name: type"
        /// </summary>
        public string GetDescription()
        {
            return name + ": " + typeName;
        }

        public DBField Clone()
        {
            return new DBField(name, typeName);
        }
    }
}
