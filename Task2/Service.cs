namespace Task2
{
    internal class Service
    {
        private readonly Lazy<Task<string>> _accessTokenLzy;

        public Service()
        {
            _accessTokenLzy = new Lazy<Task<string>>(GetAccessToken);
        }

        public async Task ProcessAsync(int i)
        {
            var accessToken = await _accessTokenLzy.Value;
            Console.WriteLine($"Task {i} is with lazy access token {accessToken}");
        }

        private async Task<string> GetAccessToken()
        {
            await Task.Delay(100);
            return Guid.NewGuid().ToString();
        }
    }
}
