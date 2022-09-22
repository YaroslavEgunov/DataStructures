using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит метод, отвечающий за создание уникальных идентификаторов.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Уникальный индетификатор. 
        /// </summary>
        private static int _id = 1;

        /// <summary>
        /// Создаёт уникальный идентификатор.
        /// </summary>
        /// <returns>Возвращает уникальный идентификатор.</returns>
        public static int GetNextId()
        {
            return _id++;
        }
    }
}
