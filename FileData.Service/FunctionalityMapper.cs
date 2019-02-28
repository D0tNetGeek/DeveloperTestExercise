using System;
using System.Collections.Generic;
using FileData.Service.Interfaces;

namespace FileData.Service
{
    public class FunctionalityMapper
    {
        private readonly IDictionary<string, IFunctionalityOnFile> _functionalities;

        public FunctionalityMapper()
        {
            _functionalities = new Dictionary<string, IFunctionalityOnFile>()
            {
                { "-v", new FileVersionFunctionality() },
                { "--v", new FileVersionFunctionality() },
                { "--version", new FileVersionFunctionality() },
                { "/v", new FileVersionFunctionality() },
                { "-s", new FileSizeFunctionality() },
                { "--s", new FileSizeFunctionality() },
                { "--size", new FileSizeFunctionality() },
                { "/s", new FileSizeFunctionality() },
            };
        }

        public IFunctionalityOnFile GetFunctionalityAssociatedTo(string functionality)
        {
            if (!_functionalities.TryGetValue(functionality, out var functionalityOnFile))
            {
                throw new ArgumentOutOfRangeException();
            }

            return functionalityOnFile;
        }
    }
}
