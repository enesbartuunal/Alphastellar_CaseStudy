using Alphastellar.Business.Implementations;
using Alphastellar.Business.Services;
using Alphastellar.Common;
using Alphastellar.DataAccess.Entites.Concrete;
using Alphastellar.Model.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alphastellar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly CarService _carService;
        private readonly BusService _busService;
        private readonly BoatService _boatService;
        public MainController(CarService carService, BusService busService, BoatService boatService)
        {
            _busService = busService;
            _carService = carService;
            _boatService = boatService;
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<IActionResult> GetCars()
        {
            try
            {
                var carsList = await _carService.Get();
                return Ok(carsList.Data);
            }
            catch (Exception e)
            {

                return BadRequest(new Result<IActionResult>(false, ResultConstant.RecordNotFound));
            }

        }
        [HttpGet]
        [Route("/[controller]/[action]/{id}")]
        public async Task<IActionResult> GetCarsByColor(string color)
        {
            try
            {
                var carsList = await _carService.Get(x => x.color == color);
                return Ok(carsList.Data);
            }
            catch (Exception e)
            {

                return BadRequest(new Result<IActionResult>(false, ResultConstant.RecordNotFound));
            }

        }
        [HttpGet]
        [Route("/[controller]/[action]/{id}")]
        public async Task<IActionResult> GetBoatsByColor(string color)
        {
            try
            {
                var boatsList = await _boatService.Get(x => x.color == color);
                return Ok(boatsList.Data);
            }
            catch (Exception e)
            {

                return BadRequest(new Result<IActionResult>(false, ResultConstant.RecordNotFound));
            }

        }
        [HttpGet]
        [Route("/[controller]/[action]/{id}")]
        public async Task<IActionResult> GetBusesByColor(string color)
        {
            try
            {
                var busesList = await _busService.Get(x => x.color == color);
                return Ok(busesList.Data);
            }
            catch (Exception e)
            {

                return BadRequest(new Result<IActionResult>(false, ResultConstant.RecordNotFound));
            }

        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> ChooseHeadLightsOption(int? id, [FromBody] bool headlights)
        {

            var model = new CarDto() { CarID = (int)id, headlights = headlights };
            var dataResponce = await _carService.Update(model);
            if (dataResponce.IsSuccess)
                return Ok(new Result<IActionResult>(true, ResultConstant.RecordUpdateSuccessfully));
            else
                return BadRequest(new Result<IActionResult>(false, ResultConstant.RecordUpdateNotSuccessfully));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
                return BadRequest(new Result<IActionResult>(false, ResultConstant.RecordNotFound));
            var data = await _carService.Delete((int)id);
            if (data.IsSuccess)
                return Ok(new Result<IActionResult>(true, ResultConstant.RecordRemoveSuccessfully));
            else
                return BadRequest(new Result<IActionResult>(false, ResultConstant.RecordRemoveNotSuccessfully));
        }
    }
}
