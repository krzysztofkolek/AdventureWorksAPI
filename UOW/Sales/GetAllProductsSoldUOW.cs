namespace AdventureWorks.UOW.Sales
{
    using System.Collections.Generic;
    using System.Linq;
    using EntityClasses.Production;
    using Main;
    using Model.Sales;
    using Repository.dbo;

    public class GetAllProductsSoldUOW : BaseUOW<GetAllProductsSoldModel>
    {
        public GetAllProductsSoldUOW(ProductRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        private ProductRepository<Product> _productRepository { get; set; }

        public override GetAllProductsSoldModel GetResult()
        {
            IList<Product> allProducts = _productRepository.GetAll();
            var model = new GetAllProductsSoldModel
            {
                Items = allProducts.Select(item => new GetAllProductsSoldItemModel
                {
                    Name = item.Name,
                    Size = item.Size,
                    StandardCost = item.StandardCost,
                    ThumbNailPhoto =
                        (item.ProductProductPhotos.FirstOrDefault() != null)
                            ? item.ProductProductPhotos.FirstOrDefault().ProductPhoto.ThumbNailPhoto
                            : new byte[0]
                }).ToList()
            };

            return model;
        }
    }
}