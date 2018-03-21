using BO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAL
{
    public class SerializerRepository<T> : IRepository<T> where T : IIdentifiable
    {
        private readonly string path;
        private readonly XmlSerializer xmlSerializer;
        private bool fileExist;
        private List<T> elements;

        public SerializerRepository()
        {
            path = Path.GetTempPath() + @"\" + typeof(T).Name + ".xml";
            fileExist = File.Exists(path);
            xmlSerializer = new XmlSerializer(typeof(List<T>));
        }

        public List<T> GetAll()
        {
            if (elements != null)
                return elements;

            if (!fileExist)
                return new List<T>();

            using (var sr = new StreamReader(path))
            {
                elements = xmlSerializer.Deserialize(sr) as List<T>;
            }
            return elements;
        }

        public void Insert(T element)
        {
            var elements = GetAll();
            element.Id = elements.Any() ? elements.Max(e => e.Id) + 1 : 1;

            elements.Add(element);
            Save(elements);
        }

        private void Save(List<T> elements)
        {
            using (var sw = new StreamWriter(path))
            {
                xmlSerializer.Serialize(sw, elements);
            }
        }

        public T GetById(int id)
        {
            return GetAll().SingleOrDefault(g => g.Id == id);
        }

        public void Update(T element)
        {
            var elements = GetAll();
            var elementDb = GetById(element.Id);
            if (elementDb != null)
            {
                elements.Remove(elementDb);
                elements.Add(element);
                Save(elements);
            }
        }

        //public void Update(T element)
        //{
        //    var elements = GetAll();
        //    for (int i = 0; i < elements.Count; i++)
        //    {
        //        if (elements[i].Id == element.Id)
        //        {
        //            elements[i] = element;
        //            Save(elements);
        //            return;
        //        }
        //    }
        //}

        public void Delete(int id)
        {
            var elements = GetAll();
            var elementDb = GetById(id);
            elements.Remove(elementDb);
            Save(elements);
        }
    }
}
