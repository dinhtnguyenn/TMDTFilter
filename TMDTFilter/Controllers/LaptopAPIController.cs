﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TMDTFilter.Models;
using WebApplication6.Helpers;

namespace TMDTFilter.Controllers
{
    public class LaptopAPIController : ApiController
    {
        public IHttpActionResult Search(SearchParameters seacrhParameters)
        {
            Model1 db = new Model1();

            var searchQuery = new SearchBuilder().
            SetSearchTerm(seacrhParameters.SearchTerm).//1
            SetCompany(seacrhParameters.Company).//2
            SetScreenResolution(seacrhParameters.ScreenResolution).//3
            SetTypeName(seacrhParameters.TypeName).//4
            SetInch(seacrhParameters.Inches).//5
            SetCPU(seacrhParameters.CPU).//6
            SetSpeed(seacrhParameters.Speed).//7
            SetMemory(seacrhParameters.Memory).//8
            SetRam(seacrhParameters.Ram).//9
            SetGPU(seacrhParameters.GPU).//10
            SetOS(seacrhParameters.OS).//11
            SetPriceLow(seacrhParameters.PriceLow).//12
            SetPriceHigh(seacrhParameters.PriceHigh).//13
            SetWeight(seacrhParameters.Weight)//14
            .SetSortBy(SortCriteria.PriceHighToLow)//15
            .Build(db);
            return Ok(searchQuery);
        }
    }
}