//Task3: По заданному номеру дня недели вывести его название

string[] weekday = new string[] {"пн", "вт", "ср", "чт", "пт", "сб", "вс"};

Console.Write("Введите номер дня недели (1 - 7): ");
string day = Console.ReadLine();

Console.WriteLine(weekday[Convert.ToInt16(day)-1]);