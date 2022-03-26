﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using InventoryManagemenSystem_Ims.DTOs;
using InventoryManagemenSystem_Ims.Entities;
using InventoryManagemenSystem_Ims.Interfaces.Repositories;
using InventoryManagemenSystem_Ims.Interfaces.Services;

namespace InventoryManagemenSystem_Ims.Implementations.Services
{
    public class SalesService:ISalesService
    {
        private readonly ISalesRepository _salesRepository;
        private readonly IItemRepository _itemRepository;
        private readonly IStockService _stockService;
        private readonly IStockRepository _stockRepository;
        private readonly IReturnGoodsRepository _returnGoodsRepository;


        public SalesService(ISalesRepository salesRepository, IItemRepository itemRepository, IStockService stockService, IStockRepository stockRepository, IReturnGoodsRepository returnGoodsRepository)
        {
            _salesRepository = salesRepository;
            _itemRepository = itemRepository;
            _stockService = stockService;
            _stockRepository = stockRepository;
            _returnGoodsRepository = returnGoodsRepository;
        }
      

        public async Task<BaseResponse<SalesDto>> FindSalesById(int id)
        {
            var sales = await _salesRepository.FindSalesById(id);
            if (sales==null)
            {
                return new BaseResponse<SalesDto>
                {
                    Message = "Sales requested cannot e found"
                };
            }

            return new BaseResponse<SalesDto>
            {
                Message = "Sales retrieved",
                Status = true,
                Data = new SalesDto
                {

                    
                    Description = sales.Description,
                    CustomerId = sales.CustomerId,
                    PricePerUnit = sales.PricePerUnit,
                    Quantity = sales.Quantity,
                    TotalPrice = sales.PricePerUnit * sales.Quantity,
                    Id = sales.Id,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow
                }
            };
        }

        public async Task<Sales> UpdateSales(UpdateSalesRequestModel model)
        {
            var sales = await _salesRepository.FindSalesById(model.SalesId);
            var checkSalesItem = await _salesRepository.FindSalesItemById(model.SalesItemId);
            

            if (checkSalesItem==null)
            {
                return null;
            }

            sales.ItemId = model.ItemId;
            sales.Id = model.SalesId;
            sales.PricePerUnit = model.PricePerUnit;
            checkSalesItem.TotalPrice = sales.PricePerUnit * sales.Quantity;
            await _salesRepository.UpdateSales(model.SalesId, sales);
            await _salesRepository.UpdateSalesItem(model.SalesItemId, checkSalesItem);
            return sales;
        }

        public async Task<bool> DeleteSales(int id, int stockItemId)
        {
            var stockItem = await _stockService.GetStockItemById(stockItemId);
            var sales = await _salesRepository.FindSalesById(id);

            if (sales == null)
            {
                throw new Exception("Sales not found!");
            }


            var newStockItem = new UpdateStockItemRequestModel
            {
                StockItemId = stockItemId,
                Quantity = sales.Quantity + stockItem.Quantity,
                ItemId = stockItem.ItemId,
                PricePerUnit = stockItem.PricePerUnit,
                StockId = stockItem.StockId,

            };

            await _stockService.UpdateItemInStock(stockItemId, newStockItem);
            await _salesRepository.DeleteSales(sales.Id);
            return true;
        }

        public async Task<BaseResponse<bool>> ExistsById(int id)
        {
            await _salesRepository.ExistsById(id);
            return new BaseResponse<bool>
            {
                Message = "Request successful",
                Status = true
            };
        }

        public async Task<IEnumerable<Sales>> GetAllSales()
        {
            return await _salesRepository.GetAllSales();
            
        }

         public async Task<Sales> StartSales(CreateSalesRequestModel model)
               {
                    var checkStockItem = await _stockRepository.GetStockItemsByItemId(model.StockItemId);
                    
                    var sales = new Sales
                    {
                        ItemId = checkStockItem.ItemId,
                        Item = checkStockItem.Item,
                        CustomerId = model.CustomerId,
                        SalesManagerId = model.SalesManagerId,
                        DateCreated = DateTime.UtcNow,
                        PricePerUnit = model.PricePerUnit,
                        Quantity = model.Quantity
        
                    };
                        var pricePerUnit = sales.PricePerUnit;
                        var quantity = sales.Quantity;
                        var salesItem = new SalesItem
                        {
                           
                            SalesId = sales.Id,
                            Sales = sales,
                            DateCreated = DateTime.UtcNow,
        
                        };
                        
                        salesItem.TotalPrice += pricePerUnit * quantity;
                        sales.SalesItems.Add(salesItem);
                        checkStockItem.Quantity = checkStockItem.Quantity - sales.Quantity;
                        
                    await _stockRepository.UpdateStockItem(model.StockItemId, checkStockItem);
                    await _salesRepository.CreateSales(sales);

                    return sales;
               }

        public async Task<Sales> Create(Sales sales)
        {
            await _salesRepository.CreateSales(sales);
            return sales;
        }

        public async Task<BaseResponse<IList<SalesDto>>> GetSalesItemByDate(DateTime date)
        {
            var checkSalesDate= await _salesRepository.GetSalesItemByDate(date);
            if (checkSalesDate==null)
            {
                return new BaseResponse<IList<SalesDto>>
                {
                    Message = "Sales date requested cannot be found",
                    Status = false
                };
            }

            return new BaseResponse<IList<SalesDto>>
            {
                Message = "Data fetched successfully",
                Status = true,
                Data = checkSalesDate.Select(sales => new SalesDto
                {
                    
                    Description = sales.Description,
                    Id = sales.Id,
                    CustomerId = sales.CustomerId,
                    SalesManagerId = sales.SalesManagerId,
                    DateCreated = DateTime.UtcNow,
                   Quantity = sales.Quantity,
                   PricePerUnit = sales.PricePerUnit,
                   TotalPrice = sales.Quantity * sales.PricePerUnit

                }).ToList()
            };

        }

        public async Task<BaseResponse<decimal>> GetGrandTotalOfAllSales()
        {
           var grandTotalSales= await _salesRepository.GetGrandTotalOfAllSales();

           return new BaseResponse<decimal>
           {
               Message = "Grand total sales fetched!",
               Status = true,
               Data = grandTotalSales
           };
        }

        public async Task<BaseResponse<ReturnGoodsDto>> ReturnGoods(int salesItemId, ReturnGoodsRequestModel model)
        {
            var checkSalesItem = await _salesRepository.FindSalesItemById(salesItemId);
            var sales = await _salesRepository.FindSalesById(model.SalesId);
            if (checkSalesItem==null)
            {
                return new BaseResponse<ReturnGoodsDto>
                {
                    Message = "SalesItem not found!",
                    Status = false
                };
            }
            
            if (DateTime.UtcNow > checkSalesItem.DateCreated.AddDays(7))
            {
                return new BaseResponse<ReturnGoodsDto>
                {
                    Message = "The time interval for returning goods has elapsed",
                    Status = false
                };
            }
            else if (DateTime.UtcNow <= checkSalesItem.DateCreated.AddDays(7))
            {
                var returnGoods = new ReturnGoods
                {
                    CustomerId = model.CustomerId,
                    Description = model.Description,
                    QuantityReturned = model.QuantityReturned,
                    SalesItemId = model.SalesItemId,
                    SalesManagerId = model.SalesManagerId,
                    ReturnType = model.ReturnType,
                    DateCreated = DateTime.UtcNow

                };
                sales.Quantity = sales.Quantity - returnGoods.QuantityReturned;
                checkSalesItem.TotalPrice = sales.Quantity * sales.PricePerUnit;
                
                await _salesRepository.UpdateSales(sales.Id, sales);
                await _salesRepository.UpdateSalesItem(salesItemId, checkSalesItem);
                await _returnGoodsRepository.ReturnGoods(returnGoods);


            }
            return new BaseResponse<ReturnGoodsDto>
            {
                Message = "Goods successfully returned",
                Status = true
            };
        }
    }
}