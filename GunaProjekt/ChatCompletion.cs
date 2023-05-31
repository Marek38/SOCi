using System;
using System.Threading.Tasks;

namespace GunaProjekt
{
    internal class ChatCompletion
    {
        private OpenAIApi api;

        public ChatCompletion(OpenAIApi api)
        {
            this.api = api;
        }

        internal Task<string> SendUserMessage(string userInput)
        {
            throw new NotImplementedException();
        }
    }
}