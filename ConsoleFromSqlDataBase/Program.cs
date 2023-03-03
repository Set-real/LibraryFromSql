using LibraryFromSql;
using System.Data;

namespace ConsoleFromSqlDataBase
{
    internal class Program
    {
        static Manager manager = new Manager();
        public enum Commands
        {
            stop,
            add,
            delete,
            update,
            show
        }
        static void Main(string[] args)
        {
            static void Update()
            {
                Console.WriteLine("Введите логин для обновления:");

                var login = Console.ReadLine();

                Console.WriteLine("Введите имя для обновления:");
                var name = Console.ReadLine();

                var count = manager.UpdateUserByLogin(login, name);

                Console.WriteLine("Строк обновлено" + count);

                manager.ShowDataUsers();
            }

            static void Add()
            {
                Console.WriteLine("Введите логин для добавления:");

                var login = Console.ReadLine();

                Console.WriteLine("Введите имя для добавления:");
                var name = Console.ReadLine();

                manager.AddUser(login, name);

                manager.ShowDataUsers();
            }

            static void Delete()
            {
                Console.WriteLine("Введите логин для удаления:");

                var count = manager.DeleteUserByLogin(Console.ReadLine());

                Console.WriteLine("Количество удаленных строк " + count);

                manager.ShowDataUsers();
            }
            Console.WriteLine("Список команд для работы консоли:");
            Console.WriteLine(Commands.stop + ": прекращение работы");
            Console.WriteLine(Commands.add + ": добавление данных");
            Console.WriteLine(Commands.delete + ": удаление данных");
            Console.WriteLine(Commands.update + ": обновление данных");
            Console.WriteLine(Commands.show + ": просмотр данных");
            Console.WriteLine();

            string command;

            do
            {
                Console.WriteLine("Введите команду:");
                command = Console.ReadLine();

                switch (command)
                {
                    case
                    nameof(Commands.add):
                        {
                            Add();
                            break;
                        }

                    case
                    nameof(Commands.delete):
                        {
                            Delete();
                            break;
                        }
                    case
                    nameof(Commands.update):
                        {
                            Update();
                            break;
                        }
                    case
                    nameof(Commands.show):
                        {
                            manager.ShowDataUsers();
                            break;
                        }
                }

                Console.WriteLine();

            }
            while (command != nameof(Commands.stop));
        }
    }
}
