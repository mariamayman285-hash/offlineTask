using offlineTask.data.DbContexts;

namespace offlineTask.Models
{
    public class TaskitemBL
    {
        TaskItemDbContext context = new TaskItemDbContext();
        
        public List<Taskitem> GetAll()
        {
            return context.Taskitems.ToList();
        }

        public Taskitem GetById(int id)
        {
            return context.Taskitems.FirstOrDefault(t=>t.Id==id);
        }
         
    }
}
