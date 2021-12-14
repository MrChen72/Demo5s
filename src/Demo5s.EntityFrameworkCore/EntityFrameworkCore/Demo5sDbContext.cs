using Demo5s.Goods;
using Demo5s.RBAC;
using Demo5s.Reptile;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Demo5s.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class Demo5sDbContext : 
        AbpDbContext<Demo5sDbContext>,
        IIdentityDbContext,
        ITenantManagementDbContext
    {
        /* Add DbSet properties for your Aggregate Roots / Entities here. */
        
        #region Entities from the modules
        
        /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
         * and replaced them for this DbContext. This allows you to perform JOIN
         * queries for the entities of these modules over the repositories easily. You
         * typically don't need that for other modules. But, if you need, you can
         * implement the DbContext interface of the needed module and use ReplaceDbContext
         * attribute just like IIdentityDbContext and ITenantManagementDbContext.
         *
         * More info: Replacing a DbContext of a module ensures that the related module
         * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
         */
        
        //Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }
        
        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

        #endregion

        #region Goods
        public virtual DbSet<GoodsModel> GoodsModel { get; set; }
        public virtual DbSet<BrandModel> BrandModel { get; set; }
        public virtual DbSet<ClassifyModel> ClassifyModel { get; set; }
        public virtual DbSet<PictureModel> PictureModel { get; set; }
        public virtual DbSet<SpecModel> SpecModel { get; set; }
        public virtual DbSet<OrdersModel> OrdersModel { get; set; }
        public virtual DbSet<CityModel> CityModel { get; set; }
        #endregion

        #region RBAC
        public virtual DbSet<UserModel> UserModel { get; set; }
        public virtual DbSet<RoleModel> RoleModel { get; set; }
        public virtual DbSet<PowerModel> PowerModel { get; set; }
        public virtual DbSet<UserRoleModel> UserRoleModel { get; set; }        
        public virtual DbSet<RolePowerModel> RolePowerModel { get; set; }
        #endregion
        //爬虫表
        public virtual DbSet<ReptileModel> ReptileModel { get; set; }

        public Demo5sDbContext(DbContextOptions<Demo5sDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            #region Goods
            builder.Entity<GoodsModel>(b => b.ToTable("tb_GoodsModel"));
            builder.Entity<BrandModel>(b => b.ToTable("tb_BrandModel"));
            builder.Entity<ClassifyModel>(b => b.ToTable("tb_ClassifyModel"));
            builder.Entity<PictureModel>(b => b.ToTable("tb_PictureModel"));
            builder.Entity<SpecModel>(b => b.ToTable("tb_SpecModel"));
            builder.Entity<OrdersModel>(b => b.ToTable("tb_OrdersModel"));
            builder.Entity<CityModel>(b => b.ToTable("tb_CityModel"));
            #endregion


            #region RBAC
            builder.Entity<UserModel>(b => b.ToTable("tb_UserModel"));
            builder.Entity<RoleModel>(b => b.ToTable("tb_RoleModel"));
            builder.Entity<PowerModel>(b => b.ToTable("tb_PowerModel"));
            builder.Entity<UserRoleModel>(b => b.ToTable("tb_UserRoleModel"));
            builder.Entity<RolePowerModel>(b => b.ToTable("tb_RolePowerModel"));
            #endregion
            
            //爬虫
            builder.Entity<ReptileModel>(b => b.ToTable("tb_ReptileModel"));

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(Demo5sConsts.DbTablePrefix + "YourEntities", Demo5sConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

        }
    }
}
