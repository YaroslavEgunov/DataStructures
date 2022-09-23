using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы, которые загружают и сохраняют данные.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Путь к файлу с сохранёнными товарами.
        /// </summary>
        private static string _itemsFileName =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Items";

        /// <summary>
        /// Путь к файлу с сохранёнными покупателями.
        /// </summary>
        private static string _customersFileName =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Customers";

        /// <summary>
        /// Проверяет наличие файла, если он отсутствует, то создает его. 
        /// </summary>
        private static void СheckFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Create);
                fileStream.Close();
            }
        }

        /// <summary>
        /// Сохраняет данные в файл.
        /// </summary>
        /// <param name="items">Путь к файлу, в который нужно сохранить данные.</param>
        public static void SaveItemsData(List<Item> items)
        {
            СheckFile(_itemsFileName);
            StreamWriter streamWriter = new StreamWriter(_itemsFileName);
            var jsonItems = JsonConvert.SerializeObject(items);
            streamWriter.Write(jsonItems);
            streamWriter.Close();
        }

        /// <summary>
        /// Сохраняет данные в файл.
        /// </summary>
        /// <param name="items">Путь к файлу, в который нужно сохранить данные.</param>
        public static void SaveCustomersData(List<Customer> customers)
        {
            СheckFile(_customersFileName);
            StreamWriter streamWriter = new StreamWriter(_customersFileName);
            var jsonCustomers = JsonConvert.SerializeObject(customers);
            streamWriter.Write(jsonCustomers);
            streamWriter.Close();
        }

        /// <summary>
        /// Загружает данные о товарах из файла.
        /// </summary>
        /// <returns>Возвращает список загруженных товаров.</returns>
        public static List<Item> LoadItemsData()
        {
            СheckFile(_itemsFileName);
            StreamReader streamReader = new StreamReader(_itemsFileName);
            var data = streamReader.ReadToEnd();
            streamReader.Close();
            var convertedData = JsonConvert.DeserializeObject<List<Item>>(data);
            return convertedData;
        }

        /// <summary>
        /// Загружает данные о покупателях из файла.
        /// </summary>
        /// <returns>Возвращает список загруженных покупателей.</returns>
        public static List<Customer> LoadCustomersData()
        {
            СheckFile(_customersFileName);
            StreamReader streamReader = new StreamReader(_customersFileName);
            var data = streamReader.ReadToEnd();
            streamReader.Close();
            var convertedData = JsonConvert.DeserializeObject<List<Customer>>(data);
            return convertedData;
        }
    }
}
