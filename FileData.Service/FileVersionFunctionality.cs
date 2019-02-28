using FileData.Service.Interfaces;
using ThirdPartyTools;

namespace FileData.Service
{
    public class FileVersionFunctionality : IFunctionalityOnFile
    {
        public string Execute(string fileName)
        {
            return new FileDetails().Version(fileName);
        }
    }
}
