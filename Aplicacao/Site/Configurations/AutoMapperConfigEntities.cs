﻿using AutoMapper;

namespace Site.Configurations
{
	public class AutoMapperConfigEntities
	{
		public static MapperConfiguration RegisterMappings()
		{
			return new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new MappingModels());
			});
		}
	}
}
