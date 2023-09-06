
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using colegioAPIEF.Services.StudentService;
using colegioAPIEF.Models;

namespace colegioAPIEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly IStudentService _superHeroService;

        public EstudiantesController(IStudentService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Estudiante>>> GetAllHeroes()
        {
            return await _superHeroService.GetAllHeroes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Estudiante>> GetSingleHero(int id)
        {
            var result = await _superHeroService.GetSingleHero(id);
            if (result is null)
                return NotFound("Hero not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Estudiante>>> AddHero(Estudiante hero)
        {
            var result = await _superHeroService.AddHero(hero);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Estudiante>>> UpdateHero(int id, Estudiante request)
        {
            var result = await _superHeroService.UpdateHero(id, request);
            if (result is null)
                return NotFound("Hero not found.");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Estudiante>>> DeleteHero(int id)
        {
            var result = await _superHeroService.DeleteHero(id);
            if (result is null)
                return NotFound("Hero not found.");

            return Ok(result);
        }
    }
}