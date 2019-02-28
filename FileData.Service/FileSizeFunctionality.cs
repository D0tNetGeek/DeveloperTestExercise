using FileData.Service.Interfaces;
using ThirdPartyTools;

namespace FileData.Service
{
    public class FileSizeFunctionality : IFunctionalityOnFile
    {
        public string Execute(string fileName)
        {
            return new FileDetails().Size(fileName).ToString();
        }
    }
}
