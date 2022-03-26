﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InventoryManagemenSystem_Ims.DTOs;
using InventoryManagemenSystem_Ims.Entities;
using InventoryManagemenSystem_Ims.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventoryManagemenSystem_Ims.Controllers
{
    public class SalesController:Controller
    {
        private readonly ISalesService _salesService;
        private readonly IItemService _itemService;
        private readonly IStockService _stockService;
        private readonly ICustomerService _customerService;
        private readonly ISalesManagerService _salesManagerService;
        private readonly ISalesItemService _salesItemService;

        public SalesController(ISalesService salesService, IItemService itemService, 
            IStockService stockService, ICustomerService customerService, ISalesManagerService salesManagerService, ISalesItemService salesItemService)
        {
            _salesService = salesService;
            _itemService = itemService;
            _stockService = stockService;
            _customerService = customerService;
            _salesManagerService = salesManagerService;
            _salesItemService = salesItemService;
        }
        
        
        [HttpGet]
        [Authorize(Roles = "SalesManager, ShopManager")]
        public async Task<IActionResult> Index()
        {
            
            return View(await _salesService.GetAllSales());
        }
        
        [HttpGet]
        [Authorize(Roles = "SalesManager")]
        public async Task<IActionResult> StartSales()
        {
            var customers = await _customerService.GetAllCustomers();
            var salesManagers = await _salesManagerService.GetAllSalesManagers();
            var items = await _itemService.GetAllItems();
            ViewData["Items"] = new SelectList(items, "Id", "ItemName");
            ViewData["Customers"] = new SelectList(customers, "Id", "CompanyName");
            ViewData["SalesManagers"] = new SelectList(salesManagers, "Id", "FirstName");
 
            return View();
            
           
        }
        
        [HttpPost]
        public async Task<IActionResult> StartSales(CreateSalesRequestModel model)
        {
             await _salesService.StartSales(model);
             return RedirectToAction("Index");

        }
        
        [HttpGet]
        [Authorize(Roles = "StockKeeper")]
        public async Task<IActionResult> ReturnGoods()
        {
            var customers = await _customerService.GetAllCustomers();
            var salesManagers = await _salesManagerService.GetAllSalesManagers();
            //var sales = await _salesService.GetAllSales();
            //ViewData["Items"] = new SelectList(items, "Id", "ItemName");
            ViewData["Customers"] = new SelectList(customers, "Id", "CompanyName");
            ViewData["SalesManagers"] = new SelectList(salesManagers, "Id", "FirstName");

            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> ReturnGoods(int salesItemId, ReturnGoodsRequestModel model)
        {
            var checkSalesItem = await _salesItemService.FindSalesItemById(salesItemId);
            var sales = await _salesService.FindSalesById(model.SalesId);

            if (sales == null)
            {
                throw new Exception("Sales not found!");
            }
            else if (checkSalesItem==null)
            {
                throw new Exception("SalesItem not found!");
            }

            await _salesService.ReturnGoods(salesItemId, model);
            return RedirectToAction("Index");
        }
       
    }
}