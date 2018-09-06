namespace AzureFunctionsV2DI.Service
{
    public class DemoService : IDemoService
    {
        private string _testResponse;

        public DemoService(string testResponse)
        {
            _testResponse = testResponse;
        }

        public string GetResponse()
        {
            return _testResponse;
        }
    }
}
