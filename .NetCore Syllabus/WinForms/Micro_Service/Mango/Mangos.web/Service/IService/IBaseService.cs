

using Mangos.web.Models;


namespace Mangos.web.Service.IService
{
    public interface IBaseService
    {
      Task<ResponseDto>? SendAsync(RequestDto responseDto);
    }
}
