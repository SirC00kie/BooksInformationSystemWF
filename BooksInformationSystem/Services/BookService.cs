using BooksInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksInformationSystem.Services
{
    public class BookService
    {
        private const string PATH_DIRECTORY_EXPERIMENT = "..\\..\\..\\Results";

        public static List<Book> Books = new ();

        public void Save(string fileName)
        {
            var directory = Directory.CreateDirectory(PATH_DIRECTORY_EXPERIMENT);
            XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));

            using (FileStream fs = new FileStream($"{fileName}.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Books);
            }
        }

        public bool Load(string fileName)
        {
            Books.Clear();
            XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                try
                {
                    Books = (List<Book>)formatter.Deserialize(fs);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

    }
}
