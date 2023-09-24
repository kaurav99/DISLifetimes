﻿namespace DISLifetimes.Services
{
    public class SingletonGuidService: ISingletonGuidService
    {
        private readonly Guid Id;
        public SingletonGuidService() { Id = Guid.NewGuid(); }
        public string GetGuid() => Id.ToString();
    }
}
