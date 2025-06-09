using Dto_Common_Enteties;

namespace IBll_Services
{
    public interface IBugabooBll
    {
        Task<List<Dto_Common_Enteties.ProductDto>> SelectAllAsync();
        Task<List<Dto_Common_Enteties.ProductDto>> SelectByCategoryAndModelAsync(int? categoryId, int? modelId);

    }
}