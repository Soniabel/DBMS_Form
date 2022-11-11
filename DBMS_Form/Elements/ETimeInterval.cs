using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Form.Elements
{
    public class ETimeInterval : Element
    {
        public TimeSpan a;
        public TimeSpan b;

        public ETimeInterval()
        {
            a = new TimeSpan(00,00,00);
            b = new TimeSpan(01,00,00);
        }

        public override string ToString()
        {
            return string.Format("{00}-{01}", a, b);
        }

        public override string GetTypeName()
        {
            return "Time Interval";
        }

        public override void Input(string fieldName)
        {
            bool validated = false;
            while (!validated)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter start time for " + fieldName + ":",
                                                                          fieldName, "");
                try
                {
                    a = TimeSpan.Parse(input);
                    validated = true;
                }
                catch { };
            }
            validated = false;
            while (!validated)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter end time for " + fieldName + ":",
                                                                          fieldName, "");
                try
                {
                    b = TimeSpan.Parse(input);
                    if (b < a)
                        MessageBox.Show("You cannot have negative time!");
                    else
                        validated = true;
                }
                catch { };
            }
        }

        public override SerializableElement ToSerializable()
        {
            var serializable = new SerializableElement();
            serializable.Data1 = a.ToString();
            serializable.Data2 = b.ToString();
            return serializable;
        }

        public override void LoadSerializable(SerializableElement serializable)
        {
            a = TimeSpan.Parse(serializable.Data1);
            b = TimeSpan.Parse(serializable.Data2);
        }

        public override Element Clone()
        {
            ETimeInterval el = new ETimeInterval();
            el.a = a;
            el.b = b;
            return el;
        }
    }
}
