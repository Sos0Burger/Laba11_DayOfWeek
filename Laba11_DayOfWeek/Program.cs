internal class Program
{
    static int dayNumber = 0;
    private static void Main(string[] args)
    {
        DayOfWeek dof = () =>
        {

            Program.dayNumber++;
            switch (Program.dayNumber)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 7:
                    return "Воскресенье";
                default:
                    Program.dayNumber = 1;
                    return "Понедельник";
            }
        };
        for (int i = 0; i < 14; i++)
        {
            Console.WriteLine(dof());
        }

    }
}
delegate string DayOfWeek();