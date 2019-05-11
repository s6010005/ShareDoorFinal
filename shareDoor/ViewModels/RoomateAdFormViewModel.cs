using shareDoor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shareDoor.ViewModels
{
    public class RoomateAdFormViewModel
    {
        public ApplicationUser User { get; set; }
        public List<State> States { get; set;}
        public List<Area> Areas { get; set; }
        public int StateId { get; set; }
        public int AreaId { get; set; }
        public string Smoker { get; set; }
        public string Pets { get; set; }
        public string Gender { get; set; }
        public int RendCost { get; set; }
        public string Description { get; set; }

        public RoomateAdFormViewModel()
        {
            States = new List<State>();
            Areas = new List<Area>();
        }
    }
}