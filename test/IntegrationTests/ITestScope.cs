using System;

namespace SnowMaker.IntegrationTests
{
    public interface ITestScope : IDisposable
    {
        string IdScopeName { get; }
        string ReadCurrentPersistedValue();
    }
}