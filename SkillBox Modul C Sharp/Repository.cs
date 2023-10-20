using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace SkillBox_Modul_C_Sharp
{
    struct Repository
    {
        private Worker[] worker;          //массив хранения данных

        private string _fileName;         //название файла с данными
        private int _id;                  //порядковый номер

        string[] title;                   //массив хранящий заголовки полей

        #region Конструкторы

        /// <summary>
        /// Констрктор
        /// </summary>
        /// <param name="fileNames">Путь к файлу с данными</param>
        public Repository(string fileNames)
        {
            this._id = 0;
            this._fileName = fileNames;                   // текущая позиция для добавления сотрудника в workers
            this.title = new string[7];     // инициализаия массива заголовков   
            this.worker = new Worker[5];    // инициализаия массива сотрудников.    | изначально предпологаем, что данных нет
        }
        #endregion

        #region Методы

        //public Worker[] GetAllWorker(Worker[] worker, string _fileName) 
        //{
        //    worker[0] = worker[ int ];
        //    // здесь происходит чтение из файла
        //    // и возврат массива считанных экземпляров
        //}

        //public Worker GetWorkerById(int id)
        //{
        //    // происходит чтение из файла, возвращается Worker
        //    // с запрашиваемым ID
        //}

        //public void DeleteWorker(int id)
        //{
        //    // считывается файл, находится нужный Worker
        //    // происходит запись в файл всех Worker,
        //    // кроме удаляемого
        //}

        public void AddWorker(string fileName) //пока что это запись работника
        {
            //if (!File.Exists(this._fileName))
            //{
            using (StreamWriter newPerson = new StreamWriter(fileName, false))
            {
                string titles = String.Format("{0},{1},{2},{3},{4},{5},{6}",
                                                title[0] = "Порядковый номер",
                                                title[1] = "Дата внесения записи",
                                                title[2] = "Фамилия Имя Отчество",
                                                title[3] = "Возраст",
                                                title[4] = "Рост",
                                                title[5] = "Дата рождения",
                                                title[6] = "Место рождения");
                //File.AppendAllText(_fileName, $"{titles}\n");
                newPerson.WriteLine(titles);
                for (int ID = 0; ID < _id; ID++)
                {
                    string worke = String.Format("{0},{1},{2},{3},{4},{5},{6}",
                                                            this.worker[ID].numID,
                                                            this.worker[ID].dataAndTime,
                                                            this.worker[ID].fullName,
                                                            this.worker[ID].age,
                                                            this.worker[ID].height,
                                                            this.worker[ID].dateOfBird,
                                                            this.worker[ID].plaseOfBird);
                    //File.AppendAllText(_fileName, $"{worke}\n");
                    newPerson.WriteLine(worke);
                }
            }
            // присваиваем worker уникальный ID,
            // дописываем нового worker в файл
        }

        ////public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        ////{
        ////    // здесь происходит чтение из файла
        ////    // фильтрация нужных записей
        ////    // и возврат массива считанных экземпляров
        ////}


        ///// <summary>
        ///// Метод добавления нового сотрудника
        ///// </summary>
        //public void InputFile() // метод ввода нового сотрудника
        //{
        //    int ID = this.NumberID();
        //    using (StreamWriter newPerson = new StreamWriter("Справочник сотрудники.csv", true, Encoding.Unicode))
        //    {
        //        char key;
        //        if (ID == 0)
        //        {
        //            TitleWorkers();
        //        }
        //        do
        //        {
        //            Console.WriteLine("Введите количество сотрудников которых вы хотите добавить");
        //            for (int i = 0; i < Convert.ToInt32(Console.ReadLine()); i++)
        //            {
        //                Worker worker = new Worker();

        //                string note = string.Empty;
        //                Console.WriteLine($"\nПорядковый номер сотрудника: \n{++ID} ");
        //                note = $"{ID}\t";
        //                string dataAndTime = DateTime.Now.ToString();
        //                Console.WriteLine($"Дата и время добавления записи {dataAndTime}");
        //                note += $"{dataAndTime}\t";
        //                Console.WriteLine("\nВведите Ф.И.О. сотрудника: ");
        //                note += $"{Console.ReadLine()}\t";
        //                Console.WriteLine("Введите возраст сотрудника: ");
        //                note += $"{Console.ReadLine()}\t";
        //                Console.WriteLine("Введите рост сотрудника: ");
        //                note += $"{Console.ReadLine()}\t";
        //                Console.WriteLine("Введите дату рождения сотрудника: ");
        //                note += $"{Console.ReadLine()}\t";
        //                Console.WriteLine("Введите место рождения сотрудника: ");
        //                note += $"{Console.ReadLine()}\t";
        //                newPerson.WriteLine(note);
        //                Console.WriteLine("Чтобы внести данные еще одного сотрудника нажмите:\"y\"");
        //                key = Console.ReadKey(true).KeyChar;
        //            }
        //        } while (char.ToLower(key) == 'y');
        //    }
        //}

        /// <summary>
        /// Метод загрузки данных
        /// </summary>
        public void Load()
        {
            if (File.Exists(_fileName))
            {
                using (StreamReader loadFile = new StreamReader(this._fileName))
                {
                    title = loadFile.ReadLine().Split(',');
                    int ID = 1;
                    while (!loadFile.EndOfStream)
                    {
                        string[] workers = loadFile.ReadLine().Split(',');

                        Add(new Worker(ID, Convert.ToDateTime(workers[1]), workers[2], Convert.ToInt32(workers[3]), Convert.ToInt32(workers[4]), workers[5], workers[6]));
                        ID++;
                    }
                }
            }
            else { Console.WriteLine("Справочник не создан, хотите добавить первого сотрудника?"); }
        }

        ///// <summary>
        ///// Метод добавления сотрудника в хранилище
        ///// </summary>
        ///// <param name="ConcreteWorker">Сотрудник</param>
        public void Add(Worker ConcreteWorker)
        {
            this.Resize(_id >= this.worker.Length);
            this.worker[this._id] = ConcreteWorker;
            ++this._id;
        }

        ///// <summary>
        ///// Метод увеличения текущего хранилища
        ///// </summary>
        ///// <param name="Flag">Условие увеличения</param>
        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.worker, this.worker.Length * 2);
            }
        }
        #endregion

        public void PrintDbToConsole()
        {
            Console.WriteLine($"{this.title[0],15} {this.title[1],15} {this.title[2],15} {this.title[3],15} {this.title[4],10} {this.title[5],10} {this.title[6],10}");

            for (int i = 0; i < _id; i++)
            {
                Console.WriteLine(this.worker[i].Print());
            }
        }
        public int Number { get { return _id; } }
    }
}