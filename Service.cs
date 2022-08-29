using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public static class Service
    {
        public static void SomeMethod()
        {
            int[] arr = new int[] { 10, 20, 50 };
            try
            {
                int result = arr[4];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! Вы обратились к элементу за пределами массива!");
                Console.WriteLine("Системное сообщение: {0}", ex.Message);
                Console.WriteLine("Метод: {0}", ex.TargetSite);
                Console.WriteLine("Класс: {0}", ex.TargetSite.DeclaringType);
                Console.WriteLine("Сборка: {0}", ex.Source);
            }
            finally //данный блок не является обязательным
            {
                Console.WriteLine("Finaly-блок");
            }
            Console.WriteLine("Программа продолжила выполнение");
        }
    }
}