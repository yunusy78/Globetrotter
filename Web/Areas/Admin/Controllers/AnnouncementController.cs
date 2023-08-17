using AutoMapper;
using Business.Abstract;
using DTO.DTOs.AnnouncementDTOs;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class AnnouncementController : Controller
{
    private readonly IAnnouncementService _announcementService;
    private readonly IMapper _mapper;
    
    public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
    {
        _announcementService = announcementService;
        _mapper = mapper;
    }
    // GET
    public IActionResult Index()
    {
        var model =_mapper.Map<List<AnnouncementListDto>>(_announcementService.GetAll());
        
        return View(model);
    }
    
    
    
    public IActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    
    public IActionResult Add(AnnouncementAddDTO model)
    {
        if (ModelState.IsValid)
        {
            _announcementService.Add(_mapper.Map<Announcement>(model));
            return RedirectToAction("Index");
        }
        return View(model);
    }
    
    public IActionResult Update(Guid id)
    {
        var model = _mapper.Map<AnnouncementUpdateDto>(_announcementService.GetById(id));
        return View(model);
    }
    
    [HttpPost]
    public IActionResult Update(AnnouncementUpdateDto model)
    {
        if (ModelState.IsValid)
        {
          var announcement=  _announcementService.GetById(model.Id);
            _announcementService.Update(new Announcement()
                {
                    Id = model.Id,
                    Title = model.Title,
                    Content = model.Content,
                    CreatedAt = announcement.CreatedAt,
                }
            
            );
            
           // _announcementService.Update(_mapper.Map<Announcement>(model));
            return RedirectToAction("Index");
        }
        return View(model);
    }
    
    public IActionResult Delete(Guid id)
    {
        _announcementService.Delete(new Announcement{Id = id});
        return RedirectToAction("Index");
    }
   
}