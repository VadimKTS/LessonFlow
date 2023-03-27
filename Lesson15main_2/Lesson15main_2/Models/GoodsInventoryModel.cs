    namespace Lesson15main_2.Models
    {
        public class GoodsInventoryModel
	    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int QuantityIsInStock { get; set; }
		    public int QuantityActuallyInStock { get; set; }
		    public int CompareBalances { get; }

            public GoodsInventoryModel(int id, string name, int quantityIsInStock, int quantityActuallyInStock) 
            {
                Id = id;
                Name = name;
			    QuantityIsInStock = quantityIsInStock;
			    QuantityActuallyInStock = quantityActuallyInStock;
			
                if (quantityIsInStock == quantityActuallyInStock) { CompareBalances = 0; }
                else if ( quantityIsInStock > quantityActuallyInStock ) { CompareBalances = -1; }
                else { CompareBalances = 1; }
		    }
        }
    }