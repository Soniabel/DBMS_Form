using DBMS_Form.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Form
{
    public class DBRow
    {
        List<Element> items;
        public List<SerializableElement> serializables;

        public DBRow()
        {
            items = new List<Element>();
            serializables = new List<SerializableElement>();
        }

        /// <summary>
        /// Returns true if all items in a row have the same content
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
                DBRow other = (DBRow)obj;
                var ritems = other.GetElements();
                if (items.Count != ritems.Count)
                    return false;
                // Check that all element have the same values
                for (int i = 0; i < items.Count; i++)
                    if (!items[i].Equals(ritems[i]))
                        return false;
                // All checks passed, rows are equal
                return true;
            }
        }

        public void AddElement(Element el)
        {
            items.Add(el);
        }

        public List<Element> GetElements()
        {
            return items;
        }

        public Element GetElement(int index)
        {
            return items[index];
        }

        public void InputElement(DBField field)
        {
            string typeName = field.GetTypeName();
            string fieldName = field.GetName();
            Element newElement;
            newElement = Element.GetElementByTypeName(typeName);
            newElement.Input(fieldName);
            items.Add(newElement);
        }

        public List<string> GetTextRepresentation()
        {
            List<string> representation = new List<string>();
            foreach (Element el in items)
                representation.Add(el.ToString());
            return representation;
        }

        /// <summary>
        /// Fill in the list of serializables so the object can be saved to JSON
        /// </summary>
        public void Serialize()
        {
            serializables = new List<SerializableElement>();
            foreach (Element el in items)
                serializables.Add(el.ToSerializable());
        }

        public void Deserialize(List<DBField> fields)
        {
            items = new List<Element>();
            for (int i = 0; i < fields.Count; i++)
            {
                string typeName = fields[i].GetTypeName();
                var el = Element.GetElementByTypeName(typeName);
                el.LoadSerializable(serializables[i]);
                items.Add(el);
            }
        }
    }
}
