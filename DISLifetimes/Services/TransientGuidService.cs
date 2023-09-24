﻿namespace DISLifetimes.Services
{
    public class TransientGuidService: ITransientGuidService
    {
        private readonly Guid Id;
        public TransientGuidService() { Id = Guid.NewGuid(); }
        public string GetGuid() => Id.ToString();
    }
}
