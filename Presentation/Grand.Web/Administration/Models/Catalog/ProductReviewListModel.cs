﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Grand.Web.Framework;
using Grand.Web.Framework.Mvc;
using System.Collections.Generic;

namespace Grand.Admin.Models.Catalog
{
    public partial class ProductReviewListModel : BaseGrandModel
    {
        public ProductReviewListModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        [GrandResourceDisplayName("Admin.Catalog.ProductReviews.List.CreatedOnFrom")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnFrom { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.ProductReviews.List.CreatedOnTo")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnTo { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.ProductReviews.List.SearchText")]
        [AllowHtml]
        public string SearchText { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.ProductReviews.List.SearchStore")]
        public string SearchStoreId { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.ProductReviews.List.SearchProduct")]
        public string SearchProductId { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }
    }
}