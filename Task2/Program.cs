using Task2;

var service = new Service();

var tasks = Enumerable.Range(1, 10).Select(service.ProcessAsync).ToArray();
await Task.WhenAll(tasks);
