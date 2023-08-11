
using SingletonDemo;

Parallel.Invoke(
    () => CreateInstance(),
    () => CreateInstance(),
    () => CreateInstance()
    //() => CreateInstance2()  
    );

static void CreateInstance()
{
    
    var instance = Class1.Instance;
    Console.ReadLine();
}

/*static void CreateInstance2()
{
    Thread.Sleep(500);
    var instance = Class1.Instance;
    Console.ReadLine();
}*/

