using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POPS.ViewModel
{
    public class POPSViewModel
    {
        public List<SupplierViewModel> supplierViewModelList { get; set; }
        public List<ItemViewModel> itemViewModelList { get; set; }
        public List<POMasterViewModel> poMasterViewModel { get; set; }
        public List<PODetailViewModel> poDetailViewModel { get; set; }

    }
}