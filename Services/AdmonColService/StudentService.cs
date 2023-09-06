
namespace colegioAPIEF.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly Data.DataContext _context;

        public StudentService(Data.DataContext context)
        {
            _context = context;
        }

        public async Task<List<Estudiante>> AddHero(Estudiante hero)
        {
            _context.Students.Add(hero);
            await _context.SaveChangesAsync(); 
            return await _context.Students.ToListAsync();
        }

        public async Task<List<Estudiante>?> DeleteHero(int id)
        {
            var hero = await _context.Students.FindAsync(id);
            if (hero is null)
                return null;

            _context.Students.Remove(hero);
            await _context.SaveChangesAsync();

            return await _context.Students.ToListAsync();
        }

        public async Task<List<Estudiante>> GetAllHeroes()
        {
            var heroes = await _context.Students.ToListAsync();
            return heroes;
        }

        public async Task<Estudiante?> GetSingleHero(int id)
        {
            var hero = await _context.Students.FindAsync(id);
            if (hero is null)
                return null;

            return hero;
        }

        public async Task<List<Estudiante>?> UpdateHero(int id, Estudiante request)
        {
            var hero = await _context.Students.FindAsync(id);
            if (hero is null)
                return null;

            hero.Address = request.Address;
            hero.age = request.age;
            hero.StudentName = request.StudentName;
            await _context.SaveChangesAsync();

            return await _context.Students.ToListAsync();
        }



        //Task<Estudiante?> IStudentService.GetSingleHero(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}