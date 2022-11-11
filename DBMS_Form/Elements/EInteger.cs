using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Form.Elements
{
    public class EInteger : Element
    {
        int value;

        public EInteger()
        {
            value = 0;
        }

        public EInteger(int val)
        {
            value = val;
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
                EInteger other = (EInteger)obj;
                return value == other.value;
            }
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public override string GetTypeName()
        {
            return "Integer";
        }

        public override void Input(string fieldName)
        {
            bool validated = false;
            while (!validated)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter integer value for " + fieldName + ":",
                                                                          fieldName, "");
                try
                {
                    value = Int32.Parse(input);
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
            value = Int32.Parse(serializable.Data1);
        }

        public override Element Clone()
        {
            EInteger el = new EInteger();
            el.value = value;
            return el;
        }
    }
}
