using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrderProduct
    {
        public OrderProduct(int idOrder, int idProduct, int amount,
            float length, float width, string typeForm, int idService)
        {
            IdOrder = idOrder;
            IdProduct = idProduct;
            Amount = amount;
            Length = length;
            Width = width;
            TypeForm = typeForm;
            IdService = idService;
        }

        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public int Amount { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public string TypeForm { get; set; }
        public int IdService { get; set; }
    }
}
