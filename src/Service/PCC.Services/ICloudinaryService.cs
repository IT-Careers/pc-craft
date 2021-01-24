using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace PCC.Services
{
    public interface ICloudinaryService
    {
        Task<string> UploadImage(IFormFile formFile);
    }
}
