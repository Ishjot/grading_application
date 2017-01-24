using Grading_App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_App.Services
{
    public interface IDataSeedService
    {
        Tuple<ObservableCollection<Student>, Student> Seed();
    }
}
