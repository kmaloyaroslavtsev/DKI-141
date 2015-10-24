using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    /// <summary>
    ///     Базовый класс всех карт
    /// </summary>
    public abstract  class Card
    {
        /// <summary>
        ///      Название карты
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Стоимость карты
        /// </summary>
        public int Cost { get; set; }

    }
}
