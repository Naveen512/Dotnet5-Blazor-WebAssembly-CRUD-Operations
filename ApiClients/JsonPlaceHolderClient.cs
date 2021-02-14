using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using dotnet5.bwasm.crud.Models;

namespace dotnet5.bwasm.crud.ApiClients
{
    public class JsonPlaceHolderClient
    {
        private HttpClient _httpClient;
        public JsonPlaceHolderClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Post>> GetAllPost()
        {
            return await _httpClient.GetFromJsonAsync<List<Post>>("/posts");
        }

        public async Task<Post> CreateOrUpdatePost(Post newPost)
        {
            #region  for-real-appliation-development
            // var response = await _httpClient.PostAsJsonAsync<Post>("/create", newPost);
            // return await response.Content.ReadFromJsonAsync<Post>();
            #endregion
            #region  dummy-implementation-for-demo
            await Task.FromResult(0);
            return newPost;
            #endregion
        }

        public async Task DeletePost(int id)
        {
            #region  for-real-application
            // await _httpClient.DeleteAsync($"delete?id={id}");
            #endregion

            #region dummy-implementation-for-demo
            await Task.FromResult(0);
            #endregion
        }
    }
}