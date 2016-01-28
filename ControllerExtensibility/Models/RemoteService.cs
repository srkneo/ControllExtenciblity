using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;

namespace ControllerExtensibility.Models
{
    public class RemoteService
    {
        public string GetRemoteData()
        {
            Thread.Sleep(5000);
            return "Hello from the otherside of the world";
        }

        public async Task<string> GetRemoteDataAsync()
        {
            return await Task<string>.Factory.StartNew(() => {
                Thread.Sleep(5000);
                return "Hello from the otherside of the world";
            });
        }
    }
}