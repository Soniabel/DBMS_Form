using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Form.Elements
{
    public class EString: Element
    {
        public string value;

        public EString()
        {
            value = "Empty";
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
                EString other = (EString)obj;
                return value == other.value;
            }
        }

        public EString(string val)
        {
            value = val;
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public override string GetTypeName()
        {
            return "String";
        }

        public override void Input(string fieldName)
        {
            bool validated = false;
            while (!validated)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter string value for " + fieldName + ":",
                                                                          fieldName, "");
                try
                {
                    value = input;
                    validated = true;
                }
                catch { };
            }
        }

        public override SerializableElement ToSerializable()
        {
            var serializable = new SerializableElement();
            serializable.Data1 = this.ToString();
            return serializable;
        }

        public override void LoadSerializable(SerializableElement serializable)
        {
            value = serializable.Data1;
        }

        public override Element Clone()
        {
            EString el = new EString();
            el.value = value;
            return el;
        }
    }
}
