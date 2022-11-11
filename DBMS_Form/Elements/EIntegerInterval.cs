using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Form.Elements
{
    public class EIntegerInterval: Element
    {
        public int a;
        public int b;

        public EIntegerInterval()
        {
            a = 0;
            b = 1;
        }

        public override string ToString()
        {
            return string.Format("[{0};{1}]", a, b);
        }

        public override string GetTypeName()
        {
            return "Integer Interval";
        }

        public override void Input(string fieldName)
        {
            bool validated = false;
            while (!validated)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter lower bound for " + fieldName + ":",
                                                                          fieldName, "");
                try
                {
                    a = Int32.Parse(input);
                    validated = true;
                }
                catch { };
            }
            validated = false;
            while (!validated)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter upper bound for " + fieldName + ":",
                                                                          fieldName, "");
                try
                {
                    b = Int32.Parse(input);
                    if (b < a)
                        MessageBox.Show("Upper bound must be higher than lower!");
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
            a = Int32.Parse(serializable.Data1);
            b = Int32.Parse(serializable.Data2);
        }

        public override Element Clone()
        {
            EIntegerInterval el = new EIntegerInterval();
            el.a = a;
            el.b = b;
            return el;
        }
    }
}
