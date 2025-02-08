using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyHub.Persistence.SqlServer.Context;

internal class ArmyHubDbContext : DbContext
{
    public ArmyHubDbContext(DbContextOptions<ArmyHubDbContext> options) : base(options)
    { }
}
