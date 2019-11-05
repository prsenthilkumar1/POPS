using POPS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace POPS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            POPSViewModel popsViewModel = new POPSViewModel();
            HttpResponseMessage responseMessage;

            popsViewModel.supplierViewModelList = new List<SupplierViewModel>();
            popsViewModel.itemViewModelList = new List<ItemViewModel>();
            popsViewModel.poMasterViewModel = new List<POMasterViewModel>();
            popsViewModel.poDetailViewModel = new List<PODetailViewModel>();

            responseMessage = POPSClient.webApiClient.GetAsync("SupplierAPI").Result;
            popsViewModel.supplierViewModelList = responseMessage.Content.ReadAsAsync<List<SupplierViewModel>>().Result;

            responseMessage = POPSClient.webApiClient.GetAsync("ItemAPI").Result;
            popsViewModel.itemViewModelList = responseMessage.Content.ReadAsAsync<List<ItemViewModel>>().Result;

            responseMessage = POPSClient.webApiClient.GetAsync("POMasterAPI").Result;
            popsViewModel.poMasterViewModel = responseMessage.Content.ReadAsAsync<List<POMasterViewModel>>().Result;

            responseMessage = POPSClient.webApiClient.GetAsync("PODetailAPI").Result;
            popsViewModel.poDetailViewModel = responseMessage.Content.ReadAsAsync<List<PODetailViewModel>>().Result;

            return View(popsViewModel);
        }

        public ActionResult CreateSupplier()
        {
            return View("SupplierCreate");
        }

        [HttpPost]
        public ActionResult SaveSupplier(SupplierViewModel supplierViewModel)
        {
            HttpResponseMessage responseMessage = POPSClient.webApiClient.PostAsJsonAsync("SupplierAPI", supplierViewModel).Result;
            return RedirectToAction("Index");
        }

        public ActionResult UpdateSupplier(SupplierViewModel supplierViewModel)
        {
            HttpResponseMessage responseMessage = POPSClient.webApiClient.PutAsJsonAsync("SupplierAPI/" + supplierViewModel, supplierViewModel).Result;
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSupplier(SupplierViewModel supplierViewModel)
        {
            HttpResponseMessage responseMessage = POPSClient.webApiClient.DeleteAsync("SupplierAPI/" + supplierViewModel).Result;
            return RedirectToAction("Index");
        }


        public ActionResult CreateItem()
        {
            return View("NewItem");
        }

        [HttpPost]
        public ActionResult SaveItem(ItemViewModel itemViewModel)
        {
            HttpResponseMessage responseMessage = POPSClient.webApiClient.PostAsJsonAsync("ItemAPI", itemViewModel).Result;
            return RedirectToAction("Index");
        }

        public ActionResult UpdateItem(ItemViewModel itemViewModel)
        {
            HttpResponseMessage responseMessage = POPSClient.webApiClient.PutAsJsonAsync("ItemAPI/" + itemViewModel, itemViewModel).Result;
            return RedirectToAction("Index");
        }

        public ActionResult DeleteItem(ItemViewModel itemViewModel)
        {
            HttpResponseMessage responseMessage = POPSClient.webApiClient.DeleteAsync("ItemAPI/" + itemViewModel).Result;
            return RedirectToAction("Index");
        }

        public ActionResult CreatePOMaster()
        {
            return View("NewPOMaster");
        }

        [HttpPost]
        public ActionResult SavePOMaster(POMasterViewModel poMasterViewModel)
        {
            HttpResponseMessage responseMessage = POPSClient.webApiClient.PostAsJsonAsync("POMasterAPI", poMasterViewModel).Result;
            return RedirectToAction("Index");
        }

        public ActionResult UpdatePOMaster(POMasterViewModel poMasterViewModel)
        {
            HttpResponseMessage responseMessage = POPSClient.webApiClient.PutAsJsonAsync("POMasterAPI/" + poMasterViewModel, poMasterViewModel).Result;
            return RedirectToAction("Index");
        }

        public ActionResult DeletePOMaster(POMasterViewModel poMasterViewModel)
        {
            HttpResponseMessage responseMessage = POPSClient.webApiClient.DeleteAsync("POMasterAPI/" + poMasterViewModel).Result;
            return RedirectToAction("Index");
        }

        public ActionResult CreatePODetail()
        {
            return View("NewPODetail");
        }

        [HttpPost]
        public ActionResult SavePODetail(PODetailViewModel poDetailViewModel)
        {
            HttpResponseMessage responseMessage = POPSClient.webApiClient.PostAsJsonAsync("PODetailAPI", poDetailViewModel).Result;
            return RedirectToAction("Index");
        }

        public ActionResult UpdatePODetail(PODetailViewModel poDetailViewModel)
        {
            HttpResponseMessage responseMessage = POPSClient.webApiClient.PutAsJsonAsync("PODetailAPI/" + poDetailViewModel, poDetailViewModel).Result;
            return RedirectToAction("Index");
        }

        public ActionResult DeletePODetail(PODetailViewModel poDetailViewModel)
        {
            HttpResponseMessage responseMessage = POPSClient.webApiClient.DeleteAsync("PODetailAPI/" + poDetailViewModel).Result;
            return RedirectToAction("Index");
        }

    }
}