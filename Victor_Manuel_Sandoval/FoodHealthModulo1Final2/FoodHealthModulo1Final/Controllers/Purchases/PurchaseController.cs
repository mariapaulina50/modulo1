using FoodHealthModulo1Final.Context;
using FoodHealthModulo1Final.Models.Orders;
using FoodHealthModulo1Final.Models.Packages;
using FoodHealthModulo1Final.Models.Profiles;
using FoodHealthModulo1Final.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodHealthModulo1Final.Controllers.Purchases
{
    public class PurchaseController : Controller
    {
        FoodHealthModulo1FinalContext db = new FoodHealthModulo1FinalContext();
        // GET: Purchase
        // GET: del customer
        public ActionResult NewPackage()
        {
            var purchaseView = new PurchaseView();
            purchaseView.Customer = new Customer();
            purchaseView.PackagePurchase1 = new List<PackagePurchase>();
            Session["purchaseView"] = purchaseView;


            var list = db.Customers.ToList();
            list.Add(new Customer { CustomerId = 0, FirstName = "[Seleccione un Cliente]" });
            list = list.OrderBy(C => C.FullName).ToList();
            ViewBag.CustomerId = new SelectList(list, "CustomerId", "FullName");

            return View(purchaseView);
        }

        [HttpPost]
        public ActionResult NewPackage(PurchaseView purchaseView)
        {
            purchaseView = Session["PurchaseView"] as PurchaseView;
            var customerId = int.Parse(Request["CustomerId"]);
            if(customerId == 0)
            {
                var list = db.Customers.ToList();
                list.Add(new Customer { CustomerId = 0, FirstName = "[Seleccione un Cliente]" });
                list = list.OrderBy(C => C.FullName).ToList();
                ViewBag.CustomerId = new SelectList(list, "CustomerId", "FullName");
                ViewBag.Error = "Debe Seleccionar un Cliente";
                return View(purchaseView);
            }

            var customer = db.Customers.Find(customerId);
            if(customer == null)
            {
                var listC = db.Customers.ToList();
                listC.Add(new Customer { CustomerId = 0, FirstName = "[Seleccione un Cliente]" });
                listC = listC.OrderBy(C => C.FullName).ToList();
                ViewBag.CustomerId = new SelectList(listC, "CustomerId", "FullName");
                ViewBag.Error = "El cliente no existe";
                return View(purchaseView);
            }

            if(purchaseView.PackagePurchase1.Count == 0)
            {
                var listC = db.Customers.ToList();
                listC.Add(new Customer { CustomerId = 0, FirstName = "[Seleccione un Cliente]" });
                listC = listC.OrderBy(C => C.FullName).ToList();
                ViewBag.CustomerId = new SelectList(listC, "CustomerId", "FullName");
                return View(purchaseView);
            }

            var order = new Order
            {
                CustomerId = customerId,
                DateOrder = DateTime.Now,
                OrderStatus = OrderStatus.Create
            };

            db.Orders.Add(order);
            db.SaveChanges();

            var orderId = db.Orders.ToList().Select(o => o.OrderID).Max();

            foreach (var item in purchaseView.PackagePurchase1)
            {
                var orderDetail = new OrderDetail
                {
                    PackageID = item.PackageID,
                    Description = item.Description,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    OrderID = orderId
                };
                db.OrderDetails.Add(orderDetail);
                db.SaveChanges();
            }

            ViewBag.Message = string.Format("Orden {0}, Guardada Correctamente", orderId);

            var listS = db.Customers.ToList();
            listS.Add(new Customer { CustomerId = 0, FirstName = "[Seleccione un Cliente]" });
            listS = listS.OrderBy(C => C.FullName).ToList();
            ViewBag.CustomerId = new SelectList(listS, "CustomerId", "FullName");

            purchaseView = new PurchaseView();
            purchaseView.Customer = new Customer();
            purchaseView.PackagePurchase1 = new List<PackagePurchase>();
            Session["purchaseView"] = purchaseView;


            return View(purchaseView);
        }

        // GET: Packages
        public ActionResult AddPackage()
        {
            var list = db.Packages.ToList();
            list.Add(new PackagePurchase { PackageID = 0, Description = "[Seleccione un Paquete]" });
            list = list.OrderBy(C => C.Description).ToList();
            ViewBag.PackageID = new SelectList(list, "PackageID", "Description");
            return View();
        }

        [HttpPost]
        public ActionResult AddPackage(PackagePurchase packagePurchase)
        {
            var purchaseView = Session["purchaseView"] as PurchaseView;
            var packageid = int.Parse(Request["PackageID"]);

            if (packageid == 0)
            {
                var list = db.Packages.ToList();
                list.Add(new PackagePurchase { PackageID = 0, Description = "[Seleccione un Paquete]" });
                list = list.OrderBy(C => C.Description).ToList();
                ViewBag.PackageID = new SelectList(list, "PackageID", "Description");
                ViewBag.Error = "Seleccione un Alimento";

            }
            //Validar existencia de producto

            var package = db.Packages.Find(packageid);

            if (package == null)
            {
                var list = db.Packages.ToList();
                list.Add(new PackagePurchase { PackageID = 0, Description = "[Seleccione un Paquete]" });
                list = list.OrderBy(C => C.Description).ToList();
                ViewBag.PackageID = new SelectList(list, "PackageID", "Description");
                ViewBag.Error = "Paquete no Existe";
                return View(packagePurchase);
            }

            //Adicionar el producto a la orden
            packagePurchase = purchaseView.PackagePurchase1.Find(p => p.PackageID == packageid);

            if (packagePurchase == null)
            {

                packagePurchase = new PackagePurchase
                {
                    Description = package.Description,
                    PackageID = package.PackageID,
                    Quantity = float.Parse(Request["Quantity"]),

                };

                purchaseView.PackagePurchase1.Add(packagePurchase);
            }
            else
            {
                packagePurchase.Quantity += float.Parse(Request["Quantity"]);
            }

            var listC = db.Customers.ToList();
            listC.Add(new Customer { CustomerId = 0, FirstName = "[Seleccione un Cliente]" });
            listC = listC.OrderBy(C => C.FullName).ToList();
            ViewBag.CustomerId = new SelectList(listC, "CustomerId", "FullName");

            return View("NewPackage", purchaseView);

        }

    }
}