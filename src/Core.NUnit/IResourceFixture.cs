using System;
using System.Collections.Generic;
using System.Text;

namespace Squadron
{
    public interface IResourceFixture<T> where T : ISquadronAsyncLifetime
    {
    }
}