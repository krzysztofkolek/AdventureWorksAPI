namespace AdventureWorks.UOW.Sales
{
    using System.Linq;
    using EntityClasses.Production;
    using Main;
    using Model.Sales;
    using Repository.dbo;

    public class GetAllProductsSoldUOW : BaseUOW<GetAllProductsSoldModel>
    {
        private ProductRepository<Product> _productRepository { get; set; }

        public GetAllProductsSoldUOW(ProductRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public override GetAllProductsSoldModel GetResult()
        {
            var allProducts = _productRepository.GetAll();
            GetAllProductsSoldModel model = new GetAllProductsSoldModel()
            {
                Items = allProducts.Select(item => new GetAllProductsSoldItemModel()
                {
                    Name = item.Name,
                    Size = item.Size,
                    StandardCost = item.StandardCost,
                    ThumbNailPhoto = (item.ProductProductPhotos.FirstOrDefault() != null) ? item.ProductProductPhotos.FirstOrDefault().ProductPhoto.ThumbNailPhoto : new byte[0]
                }).ToList()
            };

            return model;
        }
    }
}
