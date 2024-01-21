﻿using ASP.NET_OLX.Models;
using ASP.NET_OLX.Models.Data;
using ASP.NET_OLX.Models.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Diagnostics;


namespace ASP.NET_OLX.Controllers
{
    public class AdminController: Controller
    {
        private readonly OlxDBContext context;
        private readonly IWebHostEnvironment environment;
        private readonly IConfiguration configuration;
      

        public AdminController(OlxDBContext context, IWebHostEnvironment env, IConfiguration config)
        {
            this.environment = env;
            this.context = context;
            this.configuration = config;
        }

        public async Task<IActionResult> Index() => View(await context.Adverts.Include(x => x.Category).Include(x => x.City).ToArrayAsync());
            
        public async Task<IActionResult> ShowPartialView(int id)
        {
            var element = await context.Adverts.Include(x => x.Category).Include(x => x.City).Include(x => x.Images).FirstOrDefaultAsync(x=>x.Id == id);
            return PartialView("_ShowPartialView", element);
        }

        public async Task<IActionResult> DeleteElement(int id)
        {
            var images = context.Images.Where(x => x.AdvertId == id);
            foreach (var image in images)
                System.IO.File.Delete(Path.Combine(environment.WebRootPath, configuration["UserImgDir"], Path.GetFileName(image.Url)));
            var advert = context.Adverts.Find(id);
            context.Images.RemoveRange(images);
            context.Adverts.Remove(advert);
            await  context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
