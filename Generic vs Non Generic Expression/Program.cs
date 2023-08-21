using System;
using System.Linq.Expressions;

//ref link:https://www.youtube.com/watch?v=zgFTP0vaxSI&list=PLRwVmtr-pp06SlwcsqhreZ2byuozdnPlg&index=13
//

class MainClass
{
    static void Main()
    {
        Expression<Func<int, bool>> test = i => i > 5;
        ConstantExpression c = Expression.Constant(5, typeof(int));
        Console.WriteLine(c.Type);
        Console.WriteLine(c.NodeType);
        ParameterExpression p;
        BinaryExpression b;
    }
}