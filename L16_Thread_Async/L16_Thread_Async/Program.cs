
//Console.WriteLine("App started");

//for (int i = 0; i < 100; i++)
//{
//    new Thread(() =>
//    {
//        int id = Environment.CurrentManagedThreadId;
//        Console.WriteLine(id + " has started");
//        Thread.Sleep(2000);
//        Console.WriteLine(id + " has finished");

//    }).Start();
//}

//Console.WriteLine("App finished");

//Console.ReadLine();


//new Thread(() =>
//{
//    while(true) Console.WriteLine("Thread #1");
//}).Start();

//new Thread(() =>
//{
//    while (true) Console.WriteLine("Thread #2");
//}).Start();

//var t = new Thread(() =>
//{
//    Console.WriteLine("start");
//    Thread.Sleep(2000);
//    Console.WriteLine("finish");
//});

//Console.WriteLine("app start");

//t.IsBackground = true;

//t.Start();

//Console.WriteLine("app middle");

//t.Join();

//Console.WriteLine("app finish");

//Console.ReadKey();


//while (true)
//{
//    //new Thread(() => Console.WriteLine(
//    //        Environment.CurrentManagedThreadId)
//    //    ).Start();

//    ThreadPool.QueueUserWorkItem((state) =>
//    {
//        Console.WriteLine(Environment.CurrentManagedThreadId);
//    });
//}


//ThreadPool.GetAvailableThreads(out int num, out int num1);
//Console.WriteLine(num);
//Console.WriteLine(num1);


//Console.WriteLine("start");

//ThreadPool.QueueUserWorkItem((state) =>
//    {
//        Console.WriteLine("start download");

//        _ = new HttpClient().GetAsync("https://youtube.com").Result;

//        Console.WriteLine("finish download");
//    });

//Console.WriteLine("finish");

//Console.ReadKey();


Console.WriteLine("start");
await Async();
Console.WriteLine("finish");

Console.ReadKey();

async Task Async()
{
    Console.WriteLine("async start");
    await Task.Delay(1000);
    Console.WriteLine("async finish");
}