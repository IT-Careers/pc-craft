﻿namespace AutoMapperConfiguration
{
    public static class AutoMapperExtensions
    {
        public static T To<T>(this object source)
        {
            return AutoMapperConfig.Mapper.Map<T>(source);
        }
    }
}
