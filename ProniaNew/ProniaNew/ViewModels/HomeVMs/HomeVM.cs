using System;
using ProniaNew.Models;

namespace ProniaNew.ViewModels.HomeVMs;

public class HomeVm
{
    public ICollection<Slider> Sliders { get; set; }
    public ICollection<Product> Products { get; set; }
}

