﻿using ApplicationCore.DTOs;
using ApplicationCore.Models;
using AutoMapper;
using DataAccess.Entities;

namespace ApplicationCore.Mapping
{
	public class AdvertProfile : Profile
	{
		public AdvertProfile() 
		{
			CreateMap<AdvertModel, Advert>().ReverseMap(); 
			CreateMap<Advert, AdvertDto>().
				ForMember(x=>x.FirstImage,opt => opt.MapFrom(src=> src.Images.Count() > 0 ? src.Images.ElementAt(0).Url : ""));
			CreateMap<AdvertDto, Advert>()
				.ForMember(x => x.Category, opts => opts.Ignore())
				.ForMember(x=>x.City,opts=>opts.Ignore());
			CreateMap<BaseEntity, BaseEntityDto>().ReverseMap();
			CreateMap<Category, CategoryDto>().ReverseMap();
			CreateMap<City, CityDto>().ReverseMap();
			CreateMap<Image, ImageDto>().ReverseMap();
		}
	}
}