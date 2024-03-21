namespace SQRC.Mediator.Demo.Data;

    public class DataStore
    {
        private static List<Product> _products;

        public DataStore()
        {
            _products = new List<Product> 
            {
                new Product {Id = 1,Name = "Phone"},
                new Product {Id = 2,Name = "Headphones"},
                new Product {Id = 3,Name = "Keyboard"}
            };
        }



         public async Task AddProduct(Product product)
    {
        _products.Add(product);
        await Task.CompletedTask;
    }
      public async Task<IEnumerable<Product>> GetAllProducts() => await Task.FromResult( _products );


    public async Task<Product> GetProductById(int id) =>

        await Task.FromResult(_products.Single(p => p.Id == id));


     public async Task EventOccured(Product product,string evt)
    {
        _products.Single(p => p.Id == product.Id).Name = $"{product.Name} evt: {evt}";
        await Task.CompletedTask;
    }

}

