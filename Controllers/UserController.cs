using ASP.NET_OLX.Models;
using ASP.NET_OLX.Models.Data;
using ASP.NET_OLX.Models.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics;

namespace ASP.NET_OLX.Controllers
{
    public class UserController(OlxDBContext context) : Controller
    {
        private readonly OlxDBContext context = context;

        private const string imageDirPath = "UsersAdvertsImages";

        private async Task<string> saveImage(IFormFile file,IWebHostEnvironment env)
        {
            string filePath = Path.Combine(env.WebRootPath, imageDirPath, file.FileName);
            using (Stream fileStream = new FileStream(filePath, FileMode.Create))
            {
               await  file.CopyToAsync(fileStream);
            }
            var location = new Uri($"{Request.Scheme}://{Request.Host}/{imageDirPath}/{file.FileName}");
            return location.AbsoluteUri;
        }

        public async Task<IActionResult> Index()
        {
           await context.Images.LoadAsync();
           var data = context.Adverts.Include(x=>x.Category)
                                                   .Include(x=>x.City)
                                                   .Include(x=>x.AdvertImages).ToArray();
            return View(data);
        }

        public IActionResult AddAdvert()
        {
             ViewBag.Categories = context.Categories.Select(x => x.Name).ToArray();
             ViewBag.Cities = context.Cities.Select(x => x.Name).ToArray();
             return View();
        }

       
        [HttpPost]
        public async Task<IActionResult> Create(AdvertCreationModel saleAd, [FromServices] IWebHostEnvironment env)
        {
            var newAd = new Advert
            {
                Date = DateTime.Now,
                Description = saleAd.Description,
                SellerName = saleAd.SellerName,
                IsNew = saleAd.IsNew,
                CategoryId = context.Categories.FirstOrDefault(x => x.Name == saleAd.Category).Id,
                CityId = context.Cities.FirstOrDefault(x => x.Name == saleAd.City).Id,
                Price = saleAd.Price,
                Title = saleAd.Title
            };

            foreach (var item in saleAd.Images)
            {
                context.AdvertImages.Add(new AdvertImage () { Image = new() { Url = await saveImage(item,env) }, Advert = newAd });
            }
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}