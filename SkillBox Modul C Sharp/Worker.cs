using System;
using System.IO;
using System.Text;

namespace SkillBox_Modul_C_Sharp
{
    struct Worker
    {
        #region Методы
        public string Print()
        {
            return $"{this.numID,10} {this.dataAndTime,25} {this.fullName,15} {this.age,15} {this.height,15} {this.dateOfBird,12} {this.plaseOfBird,10}" ;
        }


        #endregion

        #region Конструкторы

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="numID">        Порядковый номер                    </param>
        /// <param name="dataAndTime">  Дата и время добавления записи      </param>
        /// <param name="fullName">     ФИО                                 </param>
        /// <param name="age">          Возраст                             </param>
        /// <param name="height">       Рост                                </param>
        /// <param name="dateOfBird">   Дата рождения                       </param>
        /// <param name="plaseOfBird">  Место рождения                      </param>
        public Worker(int numID, DateTime dataAndTime, string fullName, int age, int height, string dateOfBird, string plaseOfBird)
        {
            this.numID = numID;
            this.dataAndTime = dataAndTime;
            this.fullName = fullName;
            this.age = age;
            this.height = height;
            this.dateOfBird = dateOfBird;
            this.plaseOfBird = plaseOfBird;
        }

        #endregion

        #region Свойства

        #endregion

        #region Поля

        /// <summary>
        /// Поле "Порядковый номер (ID)"
        /// </summary>
        public int numID;

        /// <summary>
        /// Поле "Дата и время добавления записи"
        /// </summary>
        public DateTime dataAndTime;

        /// <summary>
        /// Поле "Ф.И.О."
        /// </summary>
        public string fullName;

        /// <summary>
        /// Поле "Возраст"
        /// </summary>
        public int age;

        /// <summary>
        /// Поле "Рост"
        /// </summary>
        public int height;

        /// <summary>
        /// Поле "Дата рождения"
        /// </summary>
        public string dateOfBird;

        /// <summary>
        /// Поле "Место рождения"
        /// </summary>
        public string plaseOfBird;
        #endregion
    }
}
