using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Form.Elements
{
    public class ETime : Element
    {
        TimeSpan value;

        public ETime()
        {
            value = new TimeSpan(0,0,0);
        }

        public ETime(TimeSpan val)
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
                ETime other = (ETime)obj;
                return value == other.value;
            }
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public override string GetTypeName()
        {
            return "Time";
        }

        public override void Input(string fieldName)
        {
            bool validated = false;
            while (!validated)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter time value for " + fieldName + ":",
                                                                          fieldName, "");
                try
                {
                    value = TimeSpan.Parse(input);
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
            value = TimeSpan.Parse(serializable.Data1);
        }

        public override Element Clone()
        {
            ETime el = new ETime();
            el.value = value;
            return el;
        }
    }

}
