using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Form.Elements
{
    public class EChar: Element
    {
        public char value;

        public EChar()
        {
            value = '#';
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
                EChar other = (EChar)obj;
                return value == other.value;
            }
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public override string GetTypeName()
        {
            return "Char";
        }

        public override void Input(string fieldName)
        {
            bool validated = false;
            while (!validated)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter character for " + fieldName + ":",
                                                                          fieldName, "");
                try
                {
                    value = Char.Parse(input);
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
            value = serializable.Data1.ToCharArray()[0];
        }

        public override Element Clone()
        {
            EChar el = new EChar();
            el.value = value;
            return el;
        }
    }
}
