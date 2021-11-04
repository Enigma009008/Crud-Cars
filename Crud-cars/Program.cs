using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace Crud_cars
{



    class Program
    {
        private static ObservableCollection<Cars> Cars { get; set; }

        public static int Action { get; set; }
        static void Main(string[] args)
        {
            Cars = new ObservableCollection<Cars>();
            while (Action != 5)
            {

                ListCommand();
                Console.Write("Введите команду: ");
                Action = int.Parse(Console.ReadLine());
                switch (Action)
                {

                    case 1:
                        Cars.Add(AddCar(new Cars()));
                        Console.WriteLine("Данные успешно добавлены!");
                        break;
                    case 2:
                        Console.WriteLine("Укажите ID: ");
                        int IdEditor = int.Parse(Console.ReadLine());
                        var selectedItem = Cars.FirstOrDefault(item => item.ID == IdEditor);
                        if (selectedItem != null)
                        {
                            Cars.Add(RedictCars(selectedItem));
                            Console.WriteLine("Сохранение прошло успешно!");
                        }
                        else
                            Console.WriteLine("Такого объекта нет!");
                        break;

                    case 3:
                        Console.WriteLine("Укажите ID: ");
                        int IDRemove = int.Parse(Console.ReadLine());
                        var selectedItemRemove = Cars.FirstOrDefault(item => item.ID == IDRemove);
                        if (selectedItemRemove != null)
                        {
                            RemoveCars(selectedItemRemove);
                            Console.WriteLine("Удаление прошло успешно!");
                        }
                        else
                            Console.WriteLine("Такого объекта нет!");
                        break;

                    case 4:
                        if (Cars != null)
                        {
                            foreach (var item in Cars)
                            {
                                Console.WriteLine("ID: " + item.ID);
                                Console.WriteLine("Модель: " + item.Model);
                                Console.WriteLine("Скорость: " + item.Speed);
                                Console.WriteLine("Цена: " + item.Price);
                                Console.WriteLine("Цвет: " + item.Color);
                                Console.WriteLine("-------------------------------------");
                            }


                        }
                        break;
                    case 5:
                        break;

                }
            }

        }

        private static void ListCommand()
        {
            Console.WriteLine("Пожалуйста,укажите что вы хотите сделать?");
            Console.WriteLine("1. Добавить машину");
            Console.WriteLine("2. Редактировать ");
            Console.WriteLine("3. Удалить ");
            Console.WriteLine("4. Отобразить все машины ");
            Console.WriteLine("5. Выйти");
        }

        private static Cars AddCar(Cars cars)
        {
            Console.Write("Введите модель машины: ");
            cars.Model = Console.ReadLine();
            Console.Write("Введите скорость машины: ");
            cars.Speed = int.Parse(Console.ReadLine());
            Console.Write("Укажите цену машины: ");
            cars.Price = int.Parse(Console.ReadLine());
            Console.Write("Укажите цвет машины: ");
            cars.Color = Console.ReadLine();
            return cars;


        }


        public static Cars RedictCars(Cars cars)
        {
            Console.Write("Введите модель: ");
            cars.Model = Console.ReadLine();
            Console.Write("Введите скорость: ");
            cars.Speed = int.Parse(Console.ReadLine());
            Console.Write("Укажите стоимость: ");
            cars.Price = int.Parse(Console.ReadLine());
            Console.Write("Введите цвет: ");
            cars.Color = Console.ReadLine();
            return cars;
        }


        public static Cars RemoveCars(Cars cars)
        {
            Cars.Remove(cars);
            return cars;

        }
    }
}
