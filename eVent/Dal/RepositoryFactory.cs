using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eVent.Dal
{
    public class RepositoryFactory
    {
        public static IRepository GetRepository() => new SqlRepository();
    }
}