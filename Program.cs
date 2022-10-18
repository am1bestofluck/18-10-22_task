
using static System.Console;

void todo(int arg)
{
    switch (arg)
    {
        case 1:
        {
            WriteLine("На входе три числа. Вернуть true если каждое из них меньше суммы двух других");
            break;
        }
       case 2:
       {
            WriteLine("Перевести инпут в двоичную систему");
            break;
       }
       case 3:
       {
        WriteLine("Вывести числа Фибонначи от 1 до n");
        break;
       }
       case 4:
       {
        WriteLine("создать копию поэлементно потому что у нас МНОГО времени =))");
        break;
       }

    }
}

bool check_if_triangle_is_possible(int side1, int side2, int side3)
{
    bool output=false;
    if (side1<side2+side3&&side2<side1+side3&&side3<side1+side2)
    {
        output=true;
    }
    return output;
}

string convert_to_binary(int inc_decimal)//?
{    
    string output=String.Empty;
    int inc_decimal_modified=inc_decimal;
    while (inc_decimal_modified>0)
    {
        output=inc_decimal_modified%2+output;//konvert?
        inc_decimal_modified=inc_decimal_modified/2;//??? целоч / с остатком %
    }
    //пока остаток от деления нацело не равен нулю: делим на два;
    //остаток от деления пишем в строку вывода;
    //строку вывода переворачиваем и отдаём...
    ///переворачиваемм....
    // char[] yep= output.ToCharArray();
    // Array.Reverse(yep);
    // output= new string(yep);
    // string[] ok = new string[output.Length];
    return output;
}

int [,] create_array_bidimentional(int lenght_w, int lenght_h,int limit_from_zero)
{
    Random content = new Random();
    int [,] output = new int[lenght_w,lenght_h];
    for (int walk_side = 0; walk_side < lenght_w; walk_side++)
    {
        for (int walk_upstairs=0; walk_upstairs<lenght_h;walk_upstairs++)
        {
            output[walk_side,walk_upstairs]=content.Next(0,limit_from_zero);
            Write($"{output[walk_side,walk_upstairs]} ");
        }  
    }
    WriteLine();
    return output;
}

int[] get_fibonacci_numbers(int limit)
{
    int[] output = new int[limit];
    output[0]=0;
    output[1]=1;
    for (int fib = 2; fib < limit; fib++)
    {
        output[fib]=output[fib-1]+output[fib-2];
    }
    return output;
    
}

int[,] copy_array_step_by_step(int[,] inc_collection)
{
    int [,] output = new int[inc_collection.GetLength(0),inc_collection.GetLength(1)];
    for (int walk_to_side = 0; walk_to_side < inc_collection.GetLength(0); walk_to_side++)
    {
        for (int walk_upstairs = 0; walk_upstairs < inc_collection.GetLength(1); walk_upstairs++)
        {
            output[walk_to_side,walk_upstairs]=inc_collection[walk_to_side,walk_upstairs];
            Write($"{output[walk_to_side,walk_upstairs]} ");
        }        
    }
    return output;
}

void task1()
{
    todo(1);
    int sidea=3,sideb=4,sidec=5;
    bool validtriangle=check_if_triangle_is_possible(sidea,sideb,sidec);
    WriteLine($"{sidea};{sideb};{sidec}___{validtriangle}");
    sidea=150;
    validtriangle=check_if_triangle_is_possible(sidea,sideb,sidec);
    WriteLine($"{sidea};{sideb};{sidec}___{validtriangle}");

}

void task2()
{
    todo(2);
    string task2_out=convert_to_binary(10);//1010
    WriteLine(task2_out);
}

void task3()
{
    todo(3);
    int[] out_t3=get_fibonacci_numbers(10);
    WriteLine(String.Join(", ",out_t3));
}

void task4()
{
    todo(4);
    int[,] client = create_array_bidimentional(10,10,20);
    int [,] clone = copy_array_step_by_step(client);
    bool check;
    check=(client==clone);
    WriteLine();
    WriteLine(check);
    //создать же тоже надо...

}

task1();

task2();

task3();//0, 1, 1, 2, 3, 5, 8, 13, 21, 34,!!! 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 

task4();