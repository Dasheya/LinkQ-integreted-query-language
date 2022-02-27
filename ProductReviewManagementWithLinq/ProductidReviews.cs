using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementWithLinq
{
    internal class ProductidReviews
    {
        public void PidAndReviews(List<ProductReview> IDReviews)
        {
            var recordedData = IDReviews.GroupBy((y, z) => (y.ProducID, z.Review)).Select(x => new { ProductID = x.Key, Reviews = x.Key });


            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "------------" + list.Review);


            }
        }
    }
}
