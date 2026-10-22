using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client.Interfaces;

public interface IHttpService<T> where T : class
{
    Task<List<T>> Get(string resource);
    Task<T> Get(string resource, string predicate);
    Task Post(string resource, T data);
}
