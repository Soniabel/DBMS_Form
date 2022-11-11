using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Form.Elements
{
    public abstract class Element
    {
        public abstract string GetTypeName();
        /// <summary>
        /// Show dialog window and input all values into an element
        /// </summary>
        public abstract void Input(string fieldName);
        /// <summary>
        /// Convert this element to a serializable that 
        /// can be saved and loaded from text files
        /// </summary>
        public abstract SerializableElement ToSerializable();
        /// <summary>
        /// Loads the element's values from a serializable element
        /// </summary>
        public abstract void LoadSerializable(SerializableElement serializable);
        public abstract Element Clone();

        public static Element GetElementByTypeName(string typeName)
        {
            switch (typeName)
            {
                case "Integer":
                    return new EInteger();
                case "Real":
                    return new EReal();
                case "Char":
                    return new EChar();
                case "String":
                    return new EString();
                case "Text File":
                    return new ETextFile();
                case "Integer Interval":
                    return new EIntegerInterval();
                case "Time":
                    return new ETime();
                case "Time Interval":
                    return new ETimeInterval();
                //case "Complex Integer":
                //    return new EComplexInteger();
                //case "Complex Real":
                //    return new EComplexReal();
                default:
                    return new EString();
            }
        }
        public static List<Element> GetSupportedTypes()
        {
            return new List<Element>()
            {
                new EInteger(),
                new EReal(),
                new EChar(),
                new EString(),
                new ETextFile(),
                new EIntegerInterval(),
                new ETime(),
                new ETimeInterval()
                //new EComplexInteger(),
                //new EComplexReal()
            };
        }
    }
}
