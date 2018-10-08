﻿using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace {{MyCompanyName}}.{{MyProjectName}}.EntityFrameworkCore
{
    [ConnectionStringName("{{MyProjectName}}")]
    public interface I{{MyProjectName}}DbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}