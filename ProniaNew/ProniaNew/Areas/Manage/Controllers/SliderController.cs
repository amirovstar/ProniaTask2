using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProniaNew.Extensions;
using ProniaNew.Services.Interfaces;
using ProniaNew.ViewModels.SliderVMs;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProniaNew.Areas.Manage.Controllers;
[Area("Manage")]
public class SliderController : Controller
{
    private readonly ISliderService _sliderService;

    public SliderController(ISliderService sliderService)
    {
        _sliderService = sliderService;
    }
    public async Task<IActionResult> Index()
    {
        try
        {
            return View(await _sliderService.GetAll());
        }
        catch (Exception)
        {

            return NotFound();
        }
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateSliderVM sliderVM)
    {
        try
        {
            if (sliderVM.ImageFile != null)
            {
                if (!sliderVM.ImageFile.IsTypeValid("image")) ;
                ModelState.AddModelError("ImageFile", "Wrong file type");
                if (sliderVM.ImageFile.IsSizeValid(2)) ;
                ModelState.AddModelError("ImageFile", "File maximum size is 2mb");
            }
            if (!ModelState.IsValid) return View();
            await _sliderService.Create(sliderVM);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {

            return NotFound();
        }
    }
    public async Task<IActionResult> Delete(int? id)
    {
        try
        {
            await _sliderService.Delete(id);
            TempData["IsDeleted"] = true;
            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {

            return NotFound();
        }
    }

    public async Task<IActionResult> Update(int? id)
    {
        try
        {
            return View(await _sliderService.GetById(id));
        }
        catch (Exception)
        {

            return NotFound();
        }
    }
    [HttpPost]
    public async Task<IActionResult> Update(int? id, UpdateSliderVM sliderVM)
    {
        try
        {
            await _sliderService.Update(sliderVM);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {
            return NotFound();
        }
    }
}

