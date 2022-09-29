using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownhomeQuestionnaire.API.Repositories.Interface
{
    public interface IBaseRepository
    {
        string GetDataByURL(string url);
    }
}
