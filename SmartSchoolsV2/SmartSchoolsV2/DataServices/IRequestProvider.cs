﻿using System.Threading.Tasks;

namespace SmartSchoolsV2.DataServices
{
    public interface IRequestProvider
    {
        Task<bool> CheckConnection(string uri);
        Task<TResult> GetAsync<TResult>(string uri);

        Task<TResult> PostAsync<TResult>(string uri, TResult data);

        Task<TResult> PostAsync<TRequest, TResult>(string uri, TRequest data);

        Task<TResult> PutAsync<TResult>(string uri, TResult data);

        Task<TResult> PutAsync<TRequest, TResult>(string uri, TRequest data);
    }
}
