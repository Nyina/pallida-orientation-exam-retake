using Webshop;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Webshop.Models;

namespace WebshopTest
{
    public class WebshopEndpointTests
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public WebshopEndpointTests()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task SummaryManagementTest()
        {
            var response = await Client.GetAsync("/warehouse/summary?itemname=Green+Fox+Jumper&size=s&amount=3");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"itemname\":\"Green Fox Jumper\", \"manufacturer\":\"Gucci\", \"category\":\"sweaters\", \"size\":\"s\", \"quantity\":3, \"sub-total price\":240}", responseJson);
        }

        [Fact]
        public async Task QueryManagementTest()
        {
            var response = await Client.GetAsync("/warehouse/query?price=50&type=lower");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"result\":\"ok\",\"clothes\":[{\"Id\":16,\"ItemName\":\"Strecth Steamed Pencil Skirt\",\"Manufacturer\":\"Calvin Klein\",\"Category\":\"skirts\",\"Size\":\"s\",\"Price\":39},{\"Id\":18,\"ItemName\":\"Strecth Steamed Pencil Skirt\",\"Manufacturer\":\"Calvin Klein\",\"Category\":\"skirts\",\"Size\":\"m\",\"Price\":39}]}", responseJson);
        }
    }
}
