using System.Threading.Tasks;

namespace Demo5s.Data
{
    public interface IDemo5sDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
