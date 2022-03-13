using AutoMapper;
using GeekShopping.ProductApi.Data.ValueObjects;
using GeekShopping.ProductApi.Model.Context;

namespace GeekShopping.ProductApi.Repository
{
    public class ProductRepositorycs : IProductRepository
    {
        private readonly PostgresContext _context;
        private IMapper _mapper;

        public ProductRepositorycs(PostgresContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<ProductVO> Create(ProductVO vo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductVO>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductVO> FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductVO> Update(ProductVO vo)
        {
            throw new NotImplementedException();
        }
    }
}
