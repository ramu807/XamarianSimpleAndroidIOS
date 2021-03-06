﻿using Restaurant.Abstractions.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Abstractions.ViewModels
{
   public interface ISettingsViewModel
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string Picture { get; set; }
        decimal Price { get; set; }
        CategoryDto CategoryDto { get; set; }
        string Currency { get; set; }
        bool IsFavorite { get; set; }
    }
}
