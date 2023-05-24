/// when we run our application with UI (no matter what UI) , 
/// we run it with the "Main" Thread Or UI thread as some call it .
/// 
/// so basically when we run tasks and we didnt just fire and forget them .
/// we will return to the main thread after awaiting.
/// 
/// 
/// 


RunTask1();  // fire and forget

RunTask1().Wait();  // UI thread calls this method but we also block it and call another thread to complete task

RunTask1().ConfigureAwait(false); // if we do this the thread completeing this task will return to any thread.


RunTask2();

Console.ReadLine();




static void RunTask2()
{
    Task.Run(() =>
	{
		for (int i = 0; i < 20000; i++)
		{
			Console.WriteLine("Hello World");
		}
	});
}




static async Task RunTask1() 
{
	await Task.Run(() =>
	{
		for (int i = 0; i < 20000; i++)
		{
			Console.WriteLine("Hello World");
		}
	});
}