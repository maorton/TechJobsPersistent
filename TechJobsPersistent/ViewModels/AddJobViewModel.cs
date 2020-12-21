using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel : Controller
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public int EmployerId { get; set; }
        public List<Skill> Skills { get; set; }

        public AddJobViewModel(List<Employer> possibleEmployers, List<Skill> possibleSkills)
        {
            Employers = new List<SelectListItem>();
            Skills = possibleSkills;
            foreach (var employer in possibleEmployers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }

        public AddJobViewModel()
        {
        }
    }
}
