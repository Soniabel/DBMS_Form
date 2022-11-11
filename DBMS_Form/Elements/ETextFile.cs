using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Form.Elements
{
    public class ETextFile: Element
    {
        public string path;

        public ETextFile()
        {
            path = "Empty";
        }

        public override string ToString()
        {
            return path.ToString();
        }

        public override string GetTypeName()
        {
            return "Text File";
        }

        public override void Input(string fieldName)
        {
            bool validated = false;
            while (!validated)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter file name for " + fieldName + ":",
                                                                          fieldName, "");
                if (!File.Exists("../../../textfiles/" + input))
                {
                    MessageBox.Show("This text file does not exist!");
                }
                else
                {
                    path = input;
                    validated = true;
                }
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
            path = serializable.Data1;
        }

        public override Element Clone()
        {
            ETextFile el = new ETextFile();
            el.path = path;
            return el;
        }
    }
}
