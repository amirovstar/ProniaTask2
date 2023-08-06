using System;
using ProniaNew.Models;
using ProniaNew.ViewModels.SliderVMs;

namespace ProniaNew.Services.Interfaces;

public interface ISliderService
{
    Task Create(CreateSliderVM sliderVM);
    Task Update(UpdateSliderVM sliderVM);
    Task Delete(int? id);
    Task<ICollection<Slider>> GetAll();
    Task<Slider> GetById(int? id);
}

