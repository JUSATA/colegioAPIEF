using colegioAPIEF.Models;

namespace colegioAPIEF.Services.StudentService
{
    public interface IStudentService
    {
        Task<List<Estudiante>> GetAllHeroes();
        Task<Estudiante?> GetSingleHero(int id);
        Task<List<Estudiante>> AddHero(Estudiante hero);
        Task<List<Estudiante>?> UpdateHero(int id, Estudiante request);
        Task<List<Estudiante>?> DeleteHero(int id);
    }
}