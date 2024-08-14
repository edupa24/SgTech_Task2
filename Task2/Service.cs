namespace Task2
{
    internal class Service
    {
        private string _accessToken;

        public async Task ProcessAsync(int i)
        {
            _accessToken ??= await GetAccessToken();
            
            Console.WriteLine($"Process {i} with AccessToken {_accessToken}");
        }

        private async Task<string> GetAccessToken()
        {
            await Task.Delay(100);
            return Guid.NewGuid().ToString();
        }
    }
}
