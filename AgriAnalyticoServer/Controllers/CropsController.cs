using System;
using AgriAnalyticoServer.Contracts;
using AgriAnalyticoServer.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgriAnalyticoServer.Controllers
{
    [Route("api/[controller]")]
    public class CropsController : Controller
    {

        private readonly IRepositoryWrapper _repository;

        public CropsController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllCrops()
        {
            try
            {
                var crops = _repository.Crop.GetCrops();
                return Ok(crops);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

//        [HttpGet("{id}", Name = "CropById")]
//        public IActionResult GetCropById(Guid id)
//        {
//            try
//            {
//                var crop = _repository.Crop.GetCropById(id);
//
//                if (crop is null)
//                    return NotFound();
//
//                return Ok(crop);
//            }
//            catch (Exception ex)
//            {
//                return StatusCode(500, "Internal Server Error");
//            }
//        }

        [HttpGet("{name}", Name = "CropByName")]
        public IActionResult GetCropByName(string name)
        {
            try
            {
                var crop = _repository.Crop.GetCropByName(name);
                if (crop is null)
                    return NotFound();

                return Ok(crop);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPost]
        public IActionResult AddNewCrop([FromBody]Crop crop)
        {
            try
            {
                if (crop is null)
                    return BadRequest("Crop object is null");

                if (!ModelState.IsValid)
                    return BadRequest("Invalid Model Object");

                _repository.Crop.AddNewCrop(crop);

                //return CreatedAtRoute("CropByName", new {name = crop.Name}, crop);
                return CreatedAtRoute("CropByName", new { name = crop.Name}, crop);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
