﻿using PipiShop.Data.Infrastructure;
using PipiShop.Model.Models;

namespace PipiShop.Data.Repositories
{
    public interface ITagRepository
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}