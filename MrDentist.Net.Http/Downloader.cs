using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Net.Http
{
    public class Downloader
    {
        public async Task<Stream> DownloadAsync(Uri requestUri)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestUri))
                {
                    var a = httpClient.SendAsync(request).Result;
                    var memoryStream = new MemoryStream();
                    using (Stream contentStream = await (a).Content.ReadAsStreamAsync())
                    {
                        await contentStream.CopyToAsync(memoryStream);
                        return memoryStream;
                    }
                }
            }
        }
    }
}
