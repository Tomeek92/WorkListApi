using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceDomain.Entities.ListOfWork
{
    public class ListOfWorkToFindJob
    {
        [Key]
        public Guid Id { get; set; }
        public string TitleWork { get; set; }
        public string DescriptionWork { get; set; }
        public string TitleDescription { get; set; }
        public string Money { get; set; }
    }
}
