using ErrorSort;

var random = new Random();
var names = Enum.GetNames<ErrorList>();
var erroEnum = (ErrorList)random.Next(names.Length);

try
{
    switch (erroEnum)
    {
        case ErrorList.DivideByZeroException:
            var a1 = 1;
            var b1 = 2;
            b1 -= 2;
            Console.WriteLine(a1/b1);
            break;
        case ErrorList.IndexOutOfRangeException:
        {
            var charList = new char[1];
            Console.WriteLine(charList[2]);
            break;
        }
        case ErrorList.OverflowException:
            checked
            {
                var a2 = 2;
                Console.WriteLine(int.MaxValue * a2);
            }
            break;
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}