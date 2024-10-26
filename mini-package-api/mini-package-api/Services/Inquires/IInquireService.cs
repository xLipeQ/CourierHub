using mini_package_api.Models;
using mini_package_api.Models.Requests;
using mini_package_api.Models.Requests.Paging;
using mini_package_api.Models.Responses.InquireWithOfferResponse;

namespace mini_package_api.Services.Inquires
{
    public interface IInquireService
    {

        Inquire FindById(int id);

        Task<Inquire> AddInquire(InquireRequest inquire);

        Task<InquireWithOfferResponse> GetInquires(PagingRequest pagingRequest);
        Task<int> GetClientInquireCount(int clientId);
    }
}
